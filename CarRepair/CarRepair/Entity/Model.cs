namespace CarRepair
{
    public partial class Model
    {
        //Частичный класс Models
        //В этом файле находится только переопределение метода ToString()
        public override string ToString()
        {
            return Brand + " | " + Title + " | " + Year.Year;
        }
    }
}
