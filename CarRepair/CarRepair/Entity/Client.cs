namespace CarRepair
{
    //Частичный класс Client
    //В этом файле находится только переопределение метода ToString()
    public partial class Client
    {
        public override string ToString()
        {
            return FirstName + " " + Name + " " +SecondName;
        }
    }
}
