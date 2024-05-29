namespace CarRepair
{
    //Частичный класс Employee
    //В этом файле находится только переопределение метода ToString()
    public partial class Employee
    {
        public override string ToString()
        {
            return FirstName + " " + Name + " " + SecondName;
        }
    }
}
