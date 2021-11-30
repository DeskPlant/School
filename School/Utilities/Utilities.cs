using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Utilities
{
	public static class Utilities
	{
		public static int ReadCommand()
		{
			string str = Console.ReadLine();
			Console.WriteLine();

			return int.TryParse(str, out int command) ? command : -1;
		}

		public static Guid ReadGuid()
		{
			Guid id;
			bool succeded;

			do
			{
				string format = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
				Console.WriteLine($"Give an ID in the following format: {format}");

				succeded = Guid.TryParse(Console.ReadLine(), out id);
			}
			while (!succeded);

			return id;
		}

		public static DateTime ReadDate(string format = "yyyy/MM/dd HH:mm:ss")
		{
			DateTime dateTime;
			bool succeded;

			do
			{
				Console.WriteLine($"Give the date and time in the following format: {format}");
				string dateString = Console.ReadLine();
				succeded = DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
			}
			while (!succeded);

			return dateTime;
		}

		public static double ReadDouble()
		{
			double amount;
			bool succeded;

			do
			{
				Console.WriteLine("Enter the value");
				succeded = double.TryParse(Console.ReadLine(), out amount);
			}
			while (!succeded);

			return amount;
		}

		public static string ReadString(string hint)
		{
			Console.WriteLine(hint);
			string name = Console.ReadLine();
			return name;
		}

		public static string ReadString(string hint, IEnumerable<string> validStrings)
		{
			string name;
			do
			{
				Console.WriteLine(hint);
				Console.WriteLine($"Read string must be from collection: {string.Join(", ", validStrings)}");
				name = Console.ReadLine();
			}
			while (!validStrings.Contains(name));

			return name;
		}

		public static T ReadEnum<T>() // T is a generic type class
		{
			string transactionType;

			string[] list = System.Enum.GetNames(typeof(T)); // gets the names of all the the Transaction types (inc and outgo)

			string enumNames = string.Join(" or ", list);

			do
			{
				Console.WriteLine($"Is your {typeof(T).Name} {enumNames}?"); // basically using {} instead of +
				transactionType = Console.ReadLine();
			}
			while (!list.Contains(transactionType));

			return (T)Enum.Parse(typeof(T), transactionType);
		}
	}
}