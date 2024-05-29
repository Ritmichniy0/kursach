using System;

namespace Web_Diplom.Models
{
	public class EmailModel
	{
		public string Service { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public string Message { get; set; }
	}
}
