//using Innova.Core.Models;
//using Innova.Core.Services;
//using MailKit.Net.Smtp;
//using MimeKit;
//using Microsoft.Extensions.Options;

//public class EmailService : IEmailService
//{
//	private readonly EmailSettings _emailSettings;

//	public EmailService(IOptions<EmailSettings> emailSettings)
//	{
//		_emailSettings = emailSettings.Value;
//	}

//	// دالة إرسال رمز PIN عبر البريد الإلكتروني
//	public async Task SendPinEmailAsync(string email, int pinCode)
//	{
//		var message = new MimeMessage();
//		message.From.Add(new MailboxAddress("Innova", _emailSettings.From)); // إستخدام From من الإعدادات
//		message.To.Add(new MailboxAddress("", email));
//		message.Subject = "Your PIN Code";

//		message.Body = new TextPart("plain")
//		{
//			Text = $"Your PIN code is: {pinCode}"
//		};

//		using (var client = new SmtpClient())
//		{
//			await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, true); // إستخدام SmtpServer و Port من الإعدادات
//			await client.AuthenticateAsync(_emailSettings.Username, _emailSettings.Password); // إستخدام Username و Password من الإعدادات
//			await client.SendAsync(message);
//			await client.DisconnectAsync(true);
//		}
//	}

//	// دالة إرسال رابط إعادة تعيين كلمة المرور عبر البريد الإلكتروني
//	public async Task SendResetPasswordEmailAsync(string email, string resetLink)
//	{
//		var message = new MimeMessage();
//		message.From.Add(new MailboxAddress("Innova", _emailSettings.From)); // إستخدام From من الإعدادات
//		message.To.Add(new MailboxAddress("", email));
//		message.Subject = "Password Reset Request";

//		message.Body = new TextPart("plain")
//		{
//			Text = $"To reset your password, click the following link: {resetLink}"
//		};

//		using (var client = new SmtpClient())
//		{
//			await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, true); // إستخدام SmtpServer و Port من الإعدادات
//			await client.AuthenticateAsync(_emailSettings.Username, _emailSettings.Password); // إستخدام Username و Password من الإعدادات
//			await client.SendAsync(message);
//			await client.DisconnectAsync(true);
//		}
//	}
//}

using Innova.Core.Models;
using Innova.Core.Services;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Microsoft.Extensions.Options;

public class EmailService : IEmailService
{
	private readonly EmailSettings _emailSettings;

	public EmailService(IOptions<EmailSettings> emailSettings)
	{
		_emailSettings = emailSettings.Value;
	}

	// دالة إرسال رمز PIN عبر البريد الإلكتروني
	public async Task SendPinEmailAsync(string email, int pinCode)
	{
		var message = new MimeMessage();
		message.From.Add(new MailboxAddress("Innova", _emailSettings.From));
		message.To.Add(new MailboxAddress("", email));
		message.Subject = "Your PIN Code";

		message.Body = new TextPart("plain")
		{
			Text = $"Your PIN code is: {pinCode}"
		};

		using (var client = new SmtpClient())
		{
			try
			{
				// الاتصال باستخدام StartTls
				await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);

				// مصادقة الحساب
				await client.AuthenticateAsync(_emailSettings.Username, _emailSettings.Password);

				// إرسال الرسالة
				await client.SendAsync(message);

				// قطع الاتصال
				await client.DisconnectAsync(true);
			}
			catch (Exception ex)
			{
				// تسجيل الأخطاء أو إعادة إرسال الخطأ للمستخدم
				throw new InvalidOperationException($"Failed to send email: {ex.Message}", ex);
			}
		}
	}

	// دالة إرسال رابط إعادة تعيين كلمة المرور عبر البريد الإلكتروني
	public async Task SendResetPasswordEmailAsync(string email, string resetLink)
	{
		var message = new MimeMessage();
		message.From.Add(new MailboxAddress("Innova", _emailSettings.From));
		message.To.Add(new MailboxAddress("", email));
		message.Subject = "Password Reset Request";

		message.Body = new TextPart("plain")
		{
			Text = $"To reset your password, click the following link: {resetLink}"
		};

		using (var client = new SmtpClient())
		{
			try
			{
				// الاتصال باستخدام StartTls
				await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);

				// مصادقة الحساب
				await client.AuthenticateAsync(_emailSettings.Username, _emailSettings.Password);

				// إرسال الرسالة
				await client.SendAsync(message);

				// قطع الاتصال
				await client.DisconnectAsync(true);
			}
			catch (Exception ex)
			{
				// تسجيل الأخطاء أو إعادة إرسال الخطأ للمستخدم
				throw new InvalidOperationException($"Failed to send email: {ex.Message}", ex);
			}
		}
	}
}

