namespace Innova.Apis.DTO_s
{
	public class CompleteRegisterDto
	{
		public int PinCode { get; set; }
		public string Email { get; set; }
		public string Token { get; set; }
		public string? PreferredLanguage { get; set; } = string.Empty;
		public string? TimeZone { get; set; } = string.Empty;
		public DateTime AppointmentDate { get; set; }
		public int Age { get; set; }
		public string? PaymentMethod { get; set; } = string.Empty;
	}
}
