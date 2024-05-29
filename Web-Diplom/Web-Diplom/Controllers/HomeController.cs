using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Web_Diplom.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace Web_Diplom.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		[HttpPost]
		public IActionResult SendEmail(AppointmentFormViewModel model, string page)
		{
			if (ModelState.IsValid)
			{
				try
				{
					string senderEmail = "";// почта отправки
					string senderPassword = "";//
					string receiverEmail = "";//куда отправлять
					string subject = "Заявка на услугу: " + model.Service;
					string body = $"Имя: {model.Name}\nНомер телефона: {model.PhoneNumber}\nДата: {model.Date}\nВремя: {model.Time}\nСообщение: {model.Message}";

					MailMessage mail = new MailMessage();
					SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

					mail.From = new MailAddress(senderEmail);
					mail.To.Add(receiverEmail);
					mail.Subject = subject;
					mail.Body = body;

					smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
					smtpClient.EnableSsl = true;

					smtpClient.Send(mail);

					TempData["SuccessMessage"] = "Сообщение успешно отправлено";

					if (page == "Contact")
					{
						return RedirectToAction("Contact");
					}
					else
					{
						return RedirectToAction("Index");
					}
				}
				catch (Exception ex)
				{
					TempData["ErrorMessage"] = "Ошибка при отправке сообщения: " + ex.ToString();
					if (page == "Contact")
					{
						return RedirectToAction("Contact");
					}
					else
					{
						return RedirectToAction("Index");
					}
				}
			}

			if (page == "Contact")
			{
				return View("Contact", model);
			}
			else
			{
				return View("Index", model);
			}
		}


		[HttpGet]
		public IActionResult Index()
		{
			var model = new AppointmentFormViewModel();
			return View(model);
		}

		public IActionResult Services()
		{
            List<ServiceModel> services = GetServicesFromDatabase();

            return View(services);
        }

		public IActionResult Team()
		{
			return View();
		}

		public IActionResult Project() 
		{ 
			return View(); 
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

        public List<ServiceModel> GetServicesFromDatabase()
        {
            List<ServiceModel> services = new List<ServiceModel>();


			// Подключение к базе данных
            using (SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=CarRepair;integrated security=True; "))
            {
                connection.Open();

                // Создание SQL-запроса
                string query = "SELECT [Title],[Price] FROM [CarRepair].[dbo].[Specialisation]";

                // Создание команды
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Выполнение запроса и получение данных
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
							// Создание экземпляра ServiceModel и заполнение данными из результата запроса
							ServiceModel service = new ServiceModel();
							service.Name = reader.GetString(0);
							service.Price = reader.GetDecimal(1);

                            // Добавление экземпляра ServiceModel в список services
                            services.Add(service);
                        }
                    }
                }
            }

            return services;
        }
    }
}
