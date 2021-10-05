using System;

namespace Homework1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Podaj swoje imie: ");
			string name = Console.ReadLine();

			Console.Write("Podaj rok urodzenia: ");
			int year = GetYear();

			Console.Write("Podaj miesiąc urodzenia: ");
			int month = GetMonth();

			Console.Write("Podaj dzień urodzenia: ");
			int day = GetDay(year, month);

			Console.Write("Podaj miejsce urodzenia: ");
			string birthplace = Console.ReadLine();

			DateTime birthDate = new DateTime(year, month, day);

			int age = (DateTime.Now.DayOfYear > birthDate.DayOfYear) ? (DateTime.Now.Year - year) : (DateTime.Now.Year - year - 1);

			Console.WriteLine($"\nCześć {name}, urodziłeś się w {birthplace} i masz {age} lat.");

			Console.ReadLine();
		}

		private static int GetYear()
		{
			int year;
			while (!int.TryParse(Console.ReadLine(), out year) || year < 1850 || year > DateTime.Now.Year)
				ErrorMessage();
			return year;
		}

		private static int GetMonth()
		{
			int month;
			while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
				ErrorMessage();
			return month;
		}

		private static int GetDay(int year, int month)
		{
			int day;
			while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > DateTime.DaysInMonth(year, month))
				ErrorMessage();
			return day;
		}

		private static void ErrorMessage()
		{
			Console.Write("Error! Nieprawidłowe dane! Wpisz jeszcze raz: ");
		}
	}
}
