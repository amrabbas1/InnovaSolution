using Innova.Apis.DTO_s;
using Innova.Core.Models;
using Innova.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
	private readonly UserManager<User> _userManager;
	private readonly IEmailService _emailService;
	private readonly ITokenService _tokenService;
	private readonly IDistributedCache _cache;
	private readonly ILogger<AccountController> _logger;
	private readonly SignInManager<User> _signInManager;

	public AccountController(
		UserManager<User> userManager,
		IEmailService emailService,
		ITokenService tokenService,
		IDistributedCache cache,
		ILogger<AccountController> logger , SignInManager<User> signInManager) 
	{
		_userManager = userManager;
		_emailService = emailService;
		_tokenService = tokenService;
		_cache = cache;
		_logger = logger; 
	    _signInManager = signInManager;
	}

	[HttpPost("Register")]
	public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
	{
		var user = new User()
		{
			Name = registerDto.StudentName, 
			Email = registerDto.Email,
			PhoneNumber = registerDto.PhoneNumber,
			UserName = registerDto.Email.Split('@')[0],
			Age = registerDto.Age, 
			PreferredLanguage = registerDto.PreferredLanguage, 
			TimeZone = registerDto.TimeZone, 
			AppointmentDate = registerDto.AppointmentDate, 
			PaymentMethod = registerDto.PaymentMethod 
		};

		var result = await _userManager.CreateAsync(user, registerDto.Password);
		if (!result.Succeeded) return BadRequest(result.Errors);

	
		var pinCode = new Random().Next(1000, 9999);
		await _cache.SetStringAsync(user.Email, pinCode.ToString(), new DistributedCacheEntryOptions
		{
			AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
		});

		
		await _emailService.SendPinEmailAsync(user.Email, pinCode);

		
		var token = await _tokenService.GenerateToken(user);

		
		var returnedUser = new UserDto()
		{
			Name = registerDto.StudentName,
			Email = registerDto.Email,
			Token = token,
			PinCode = pinCode 
		};

		return Ok(returnedUser);
	}


	[HttpPost("Login")]
	public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
	{
		var user = await _userManager.FindByEmailAsync(loginDto.Email);
		if (user == null) return Unauthorized("Invalid email or password.");

		var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
		if (!result.Succeeded) return Unauthorized("Invalid email or password.");

		
		var token = await _tokenService.GenerateToken(user);

		// إنشاء الـ UserDto مع البيانات
		var returnedUser = new UserDto()
		{
			Name = user.Name,
			Email = user.Email,
			Token = token
		};

		return Ok(returnedUser);
	}

	[HttpPost("ForgetPassword")]
	public async Task<IActionResult> ForgetPassword(ForgetPasswordDto forgetPasswordDto)
	{
		var user = await _userManager.FindByEmailAsync(forgetPasswordDto.Email);
		if (user == null)
			return NotFound("User not found.");

		var token = await _userManager.GeneratePasswordResetTokenAsync(user);
		var resetLink = $"https://yourapp.com/reset-password?email={user.Email}&token={token}";

		await _emailService.SendResetPasswordEmailAsync(user.Email, resetLink);
		return Ok("Reset password email sent.");
	}

	[HttpPost("ResetPassword")]
	public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
	{
		var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
		if (user == null)
			return NotFound("User not found.");

		var result = await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.NewPassword);
		if (!result.Succeeded)
			return BadRequest(result.Errors);

		return Ok("Password reset successful.");
	}

	[HttpPost("RequestPin")]
	public async Task<IActionResult> RequestPin([FromBody] RequestPinDto requestPinDto)
	{
		var user = await _userManager.FindByEmailAsync(requestPinDto.Email);
		if (user == null)
		{
			return NotFound("User not found.");
		}

		// توليد PIN عشوائي
		var pinCode = new Random().Next(1000, 9999);

		// تخزين الـ PIN في الـ Cache لمدة 5 دقائق
		await _cache.SetStringAsync(user.Email, pinCode.ToString(), new DistributedCacheEntryOptions
		{
			AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
		});

		// إرسال الـ PIN عبر الإيميل
		await _emailService.SendPinEmailAsync(user.Email, pinCode);

		return Ok("PIN has been sent to your email.");
	}




	[HttpPost("LoginWithPin")]
	public async Task<ActionResult<UserDto>> LoginWithPin(LoginWithPinDto loginWithPinDto)
	{
		// أول حاجة لازم تحقق إذا كان عنده PIN صالح في الـ Cache.
		var storedPin = await _cache.GetStringAsync(loginWithPinDto.Email);

		if (storedPin == null)
		{
			// لو مفيش PIN في الـ Cache أو انتهت مدته، هنبعت له PIN جديد.

			// أول حاجة هنبعت له PIN جديد
			var newPinCode = new Random().Next(1000, 9999);

			// تخزين الـ PIN في الـ Cache لمدة 5 دقائق
			await _cache.SetStringAsync(loginWithPinDto.Email, newPinCode.ToString(), new DistributedCacheEntryOptions
			{
				AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
			});

			// إرسال الـ PIN على الإيميل
			await _emailService.SendPinEmailAsync(loginWithPinDto.Email, newPinCode);

			return BadRequest("PIN has expired or not found. A new PIN has been sent to your email.");
		}

		// التحقق من صحة الـ PIN المدخل
		if (storedPin != loginWithPinDto.PinCode.ToString())
		{
			return BadRequest("Invalid PIN.");
		}

		// لو الـ PIN صحيح، البحث عن المستخدم
		var user = await _userManager.FindByEmailAsync(loginWithPinDto.Email);
		if (user == null)
		{
			return BadRequest("User not found.");
		}

		// توليد التوكين
		var token = await _tokenService.GenerateToken(user);

		// إرجاع الـ UserDto مع التوكين
		var returnedUser = new UserDto()
		{
			Name = user.UserName,
			Email = user.Email,
			Token = token
		};

		return Ok(returnedUser);
	}


}
