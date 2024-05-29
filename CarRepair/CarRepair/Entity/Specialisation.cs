namespace CarRepair
{
	public partial class Specialisation
	{
		//Частичный класс Specialisation
		//В этом файле находится только переопределение метода ToString()
		public override string ToString()
		{
			return Department + " | " + Title;
		}
	}
}
