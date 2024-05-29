using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Diplom.Models
{
	public class CustomDateAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (value is DateTime date)
			{
				return date >= DateTime.Today;
			}
			return false;
		}
	}
}