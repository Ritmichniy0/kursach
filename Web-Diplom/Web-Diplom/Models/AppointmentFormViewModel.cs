using System.ComponentModel.DataAnnotations;
using System;

namespace Web_Diplom.Models
{
	public class AppointmentFormViewModel
	{
		[Required(ErrorMessage = "Пожалуйста, выберите услугу")]
		public string Service { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите ваше имя")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Пожалуйста, введите ваш номер телефона")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Введите дату")]
		[Display(Name = "Дата")]
		[DataType(DataType.Date)]
		[CustomDate(ErrorMessage = "Выберите сегодняшнюю или будущую дату")]
		public DateTime? Date { get; set; }


		[DataType(DataType.Time)]
		[Required(ErrorMessage = "Пожалуйста, укажите время")]
		[DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
		public string Time { get; set; }

		public string Message { get; set; }
	}
}
