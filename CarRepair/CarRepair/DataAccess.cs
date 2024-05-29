using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepair
{
    class DataAccess
    {
        //Контекст данных EntityFramework
        static CarRepairEntities context;

        //Статический конструктор, срабатывает всегда первым при обращении к классу. 
        //В нем происходит инициализация контекста
        static DataAccess()
        {
            context = new CarRepairEntities();
        }

        //Возвращает список отделов
        public static List<Role> GetRole()
        {
            return context.Role.ToList();
        }

        //Возвращает список отделов
        public static List<Department> GetDepartments()
        {
            return context.Department.ToList();
        }

        //Метод возвращает коллекцию марок автомобилей
        public static List<Model> GetMarks()
        {
            //Сортируем по возрастанию по названию
            return context.Model.OrderBy(x => x.Title).ToList();
        }

        //Метод возвращает список всех клиентов
        public static List<Client> GetClients()
        {
            return context.Client.ToList();
        }

        //Метод получает список всех сотрудников, отсортированных по имени
        public static List<Employee> GetEmployees()
        {
            return context.Employee.OrderBy(x => x.Name).ToList();
        }

        public static List<Employee> GetEmployee(Employee employee)
		{
			return context.Employee.Where(x => x.ID_Employee == employee.ID_Employee).ToList();
		}

		//Метод получает список автомобилей для определенного клиента
		public static List<Car> GetCars(Client client)
        {
            //Обращаемся к контексту данных и с помощью метода where производим поиск нужных автомобилей
            return context.Car.Where(x => x.Client_ID == client.ID_Client).ToList();
        }

        //Получаем все ремонты отсортированные по дате начала ремонта
        public static List<Repair> GetRepairs()
        {
            return context.Repair.OrderBy(x => x.DateRepairBegin).ToList();
        }

		public static List<DetailRepair> GetRepairs(Employee employee)
		{

			return context.DetailRepair.Where(x => x.Employee.ID_Employee == employee.ID_Employee).ToList();
		}

		public static List<Specialisation> GetSpecialisation(Department depart)
        {
            //Производим поиск с помощью where и возвращаем список сотрдников
            return context.Specialisation.Where(x => x.Department_ID == depart.ID_Department).ToList();
        }

        //Получаем список всех сотрудников из определенного отдела
        public static object GetEmployees(Specialisation specialisation)
        {
            //Производим поиск с помощью where и возвращаем список сотрдников
            return context.Employee.Where(x => x.Specialisation_ID == specialisation.ID_Specialisation).ToList();
        }

        //Получаем ремонты для определнного клиента(для отчета)
        public static List<Repair> GetRepairs(Client client)
        {
            return context.Repair.Where(x => x.Car.Client_ID == client.ID_Client).ToList();
        }

        //Возвращает список всех авто
        public static List<Car> GetAllCars()
        {
            return context.Car.ToList();
        }

        //Возвращает ремонты для конкретного авто  (для отчета)
        public static List<Repair> GetRepairs(Car car)
        {
            return context.Repair.Where(x => x.Car_ID == car.ID_Car).ToList();
        }

		public static List<Detail> GetDetail()
		{
			return context.Detail.ToList();
		}

		public static List<DetailRepair> GetRepairsPeople(Employee employee, DateTime start, DateTime end)
        {
            return context.DetailRepair.Where(x => x.Employee_ID == employee.ID_Employee && x.Repair.DateRepairBegin >= start && x.Repair.DateRepairEnd <= end ).ToList();
        }

		public static List<DetailRepair> GetRepairsPeople(Employee employee, DateTime start)
		{
			return context.DetailRepair.Where(x => x.Employee_ID == employee.ID_Employee && x.Repair.DateRepairBegin >= start && x.Repair.DateRepairEnd == null).ToList();
		}

		public static List<DetailRepair> GetRepairsPeopls(DateTime start, DateTime end)
        {
            return context.DetailRepair.Where(x => x.Repair.DateRepairEnd >= start && x.Repair.DateRepairEnd <= end).ToList();
        }

        //Получить ремонты за заданный период  (для отчета)
        public static List<Repair> GetRepairs(DateTime start, DateTime end)
        {
            //Устанавливаем дату конца +23 часа и 59 м и 59 сек
            //т.к. в метод передаем только дату и если пользователь выберет 2 одинаоквые даты
            //например 22.06.2017 00:00:00, то дата конца станет 22.06.2017 23:59:59
            //и тогда мы получим ремонты за конкретные сутки
            var end_ = end.AddHours(23).AddMinutes(59).AddSeconds(59);
            return context.Repair.Where(x => x.DateRepairBegin >= start && x.DateRepairBegin <= end_).ToList();
        }

        public static List<Repair> GetRepairsEnd(DateTime start, DateTime end)
        {
            //Устанавливаем дату конца +23 часа и 59 м и 59 сек
            //т.к. в метод передаем только дату и если пользователь выберет 2 одинаоквые даты
            //например 22.06.2017 00:00:00, то дата конца станет 22.06.2017 23:59:59
            //и тогда мы получим ремонты за конкретные сутки
            var end_ = end.AddHours(23).AddMinutes(59).AddSeconds(59);
            return context.Repair.Where(x => x.DateRepairEnd >= start && x.DateRepairEnd <= end_).ToList();
        }

		public static List<Brand> GetBrand()
		{
			return context.Brand.ToList();
		}

		public static List<Color> GetColor()
		{
			return context.Color.ToList();
		}

		//Добавляет новый отдел в БД
		public static void AddNewDepartment(string department)
        {
            //Создаем новый объект типа Department и при создании заполняем поля
            Department d = new Department()
            {
                Title = department
            };
            //В контексте добавляем отдел к колекции отделов
            context.Department.Add(d);
            //Сохраняем изменения
            context.SaveChanges();
        }

        //добавить новую модель
        public static void AddNewModel(Brand brand, string model, DateTime dateTime)
        {
            //Создаем объект типа Модель
            Model mod = new Model()
            {
                Brand = brand,
                Title = model,
                Year = dateTime.Date
            };
            //Добавляем к контексту в коллекцию моделей
            context.Model.Add(mod);
            //Сохраняем изменения
            context.SaveChanges();
        }

		public static void AddNewBrand(string brand)
		{
			Brand newBrand = new Brand()
			{
				Title = brand
			};
			context.Brand.Add(newBrand);
			context.SaveChanges();
		}

		//Метод добавляет нового клиента
		public static void AddNewClient(string clientFirstName, string clientName, string clientSecondName, string clientPhone, string clientEmail)
        {
            //Создаем клиента и заполняем поля
            Client cl = new Client()
            {
                FirstName = clientFirstName,
                Name = clientName,
                SecondName= clientSecondName,
                Phone = clientPhone,
                Email = clientEmail
            };
            //Добавляем в коллекцию клиентов контекста и сохраняем изменения
            context.Client.Add(cl);
            context.SaveChanges();
        }

        //Метод для добавления нового сотрудника
        public static void AddNewEmployee(Specialisation specialisation, Role roleitem, string firstName, string name, string secondName, string phone, string email, string login, string password)
        {
            //Создаем объект типа employee
            Employee emp = new Employee()
            {
                Specialisation = specialisation,
                Role = roleitem,
                FirstName = firstName,
                Name = name,
                SecondName = secondName,
                Phone = phone,
                Email = email,
                Login = login,
                Password = password
            };
            //Заполняем данными, добавляем в контекст и сохраняем изменения
            context.Employee.Add(emp);
            context.SaveChanges();
        }

        //Метод для добавления нового автомобиля
        public static void AddNewCar(Client client, Model mark, Color color, string gosNum, string VIM)
        {
            //Создаем автомобиль и заполняем данными
            Car car = new Car()
            {
                Model = mark,
                Color = color,
                VIN = VIM,
                Number = gosNum
            };
            //Добавляем в список авто контекста данных и сохраняем изменения
            client.Car.Add(car);
            context.SaveChanges();
        }

		public static void AddNewSpecialisatio(Department department, string title, decimal value)
		{
            Specialisation specialisation = new Specialisation()
            {
                Department = department,
                Title = title,
                Price = value
            };
            context.Specialisation.Add(specialisation);
            context.SaveChanges();
		}

		public static void AddNewDetail(string title, decimal price)
		{
            Detail detail = new Detail()
            {
                Title = title,
                Price = price
            };
            context.Detail.Add(detail);
            context.SaveChanges();
		}

        //Метод для добавления нового ремонта, имеет возвращаемый тип Repair, чтобы вернуть Обьект ремонта, который мы только что добавили
        public static Repair AddNewRepair(Car car, DateTime dateTime, decimal totalPrice)
        {
            //Создаем ремонт
            Repair repair = new Repair()
            {
                Car = car,
                DateRepairBegin = dateTime,
                TotalPrice = totalPrice
            };
            //Получаем объект из БД, который мы только что добавили
            var x = context.Repair.Add(repair);
            //Сохраняем изменения
            context.SaveChanges();
            return x; //Возвращаем объект типа Repair
        }

        //Метод добавляет новую деталь к ремонту
        public static void AddNewDetailRepair(DetailRepair item, Repair repair)
        {
            //Метод принимает объект типа Repair и к нему добавляет детали типа DetailRepair
            repair.DetailRepair.Add(item);
            context.SaveChanges(); //Сохр. изменения
        }

        //Обновляем название отдела
        public static void UpdateDepartment(Department item, string departTitle)
        {
            //Изменяем название
            item.Title = departTitle;
            //Сохраняем изменения
            context.SaveChanges();
        }

		//Метод обновляет клиента. Получаем клиента, меняем поля на необх. и сохраняем изменения
		public static void UpdateClient(Client item, string clientFirstName, string clientName, string clientSecondName, string clientPhone, string clientEmail)
        {
            item.FirstName = clientFirstName;
            item.Name = clientName;
            item.SecondName = clientSecondName;
            item.Phone = clientPhone;
            item.Email = clientEmail;
            context.SaveChanges();
        }

        //Метод для обновления инофрмации о сотруднике
        public static void UpdateEmployee(Employee item, Specialisation specialisation, Role roleitem, string firstName, string name, string secondName, string phone, string email, string login, string password)
        {
            //Меняем поля и сохраняем изменения контекста
            item.Specialisation = specialisation;
            item.Role = roleitem;
            item.FirstName = firstName;
            item.Name = name;
            item.SecondName = secondName;
            item.Phone = phone;
            item.Email = email;
            item.Login = login;
            item.Password = password;

            context.SaveChanges();
        }

        //Метод для обновления автомобилей
        public static void UpdateCar(Car item, Model avto, Color color, string gosNum, string VIN)
        {
            //Меняем поля 
            item.Model = avto;
            item.Number = gosNum;
            item.Color = color;
            item.VIN = VIN;
            //Сохраняем изменения в контексте
            context.SaveChanges();
        }

		public static void UpdateDetail(Detail item, string title, decimal price)
		{
			item.Title = title;
            item.Price = price;
            context.SaveChanges();
		}

		public static void UpdateSpecialisatio(Specialisation item, string title, decimal value)
		{
            item.Title = title;
            item.Price = value;
            context.SaveChanges();
		}

        //Метод для обновления данных о ремонте
        public static void UpdateRepair(Repair repair, Car car, decimal totalPrice)
        {
            //Меняем нужные поля и сохраняем изменения
            repair.TotalPrice = totalPrice;
            repair.Car = car;

            context.SaveChanges();
        }

        //Метод обновляет марку
        public static void EditModel(Model item, Brand brand, string modelTitle, DateTime dateTime)
        {
            item.Brand = brand;
            item.Title = modelTitle;
            item.Year = dateTime.Date;
            context.SaveChanges();
        }

		public static void EditBrand(Brand item, string brandText)
		{
			item.Title = brandText;
			context.SaveChanges();
		}

		//Установить ремонт как выполненный
		public static void SetRepairIsDone(Repair item)
        {
            //Ремонт выполнен, если у него есть дата окончания работ. По этому просто устанавливаем ему текушую дату и время
            item.DateRepairEnd = DateTime.Now;
            context.SaveChanges(); // сохра изменения
        }

        //Метод очищает все детали ремонта
        public static void ClearDetailsRepair(Repair repair)
        {
            //Производим поиск всех деталей для конкретного ремонта
            var list = context.DetailRepair.Where(x => x.Repair_ID == repair.ID_Repair).ToList();
            //В цикле удаляем их из контекста и сохраняем изменения
            foreach (var item in list)
            {
                context.DetailRepair.Remove(item);
            }
            context.SaveChanges();
        }

        //Метод для удаления авто
        internal static void DeleteCar(Car item)
        {
            //Удаляем, сохраняем изменения
            context.Car.Remove(item);
            context.SaveChanges();
        }

        internal static void DeleteModels(Model item)
        {
            //Удаляем, сохраняем изменения
            context.Model.Remove(item);
            context.SaveChanges();
        }

        internal static void DeleteRepair(Repair selected)
        {
            context.Repair.Remove(selected);
            context.SaveChanges();
        }

		internal static void DeleteBrand(Brand item)
		{
			context.Brand.Remove(item);
            context.SaveChanges();
		}

        public static void DeleteEmployee(Employee selected)
        {
            selected.Password = null;
            selected.Login = null;
            var idrole = context.Role.SingleOrDefault(x => x.TypeRole == "Не активный");
            selected.Role_ID = idrole.ID_Role;

            context.SaveChanges();
        }
	}
}