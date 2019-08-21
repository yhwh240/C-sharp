using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Lesson08ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{

			//const string fileName = @"test.txt";
			//const string testMessage = "Hello, world! ¤";

			//byte[] messageAnsiBytes = Encoding.ASCII.GetBytes(testMessage);

			//FileStream testFileStream = File.Open(
			//	fileName,
			//	FileMode.OpenOrCreate,
			//	FileAccess.Write,
			//	FileShare.None);


			//testFileStream.Seek(0, SeekOrigin.End);
			//testFileStream.Write(messageAnsiBytes);
			//testFileStream.Flush();
			//testFileStream.Close();


			//List<int> intList = new List<int>
			//{
			//	10,
			//	20,
			//	30,
			//	40
			//};

			//Console.WriteLine(string.Join(", ", intList));


			//Самостоятельная работа

			//double a = 0;
			//string inputValue = string.Empty;
			//const string endWord = "stop";


			//List<double> doubleList = new List<double>();

			////Считывыние данных
			//Console.WriteLine("Please, enter numbers, if you finish, write 'stop' ");

			//while (true)
			//{
			//	inputValue = Console.ReadLine();

			//	if (inputValue == endWord)
			//	{
			//		break;
			//	}

			//	try
			//	{
			//		a = double.Parse(inputValue);
			//	}
			//	catch (System.FormatException e)
			//	{
			//		Console.WriteLine("Error format");
			//		throw;
			//	}

			//	doubleList.Add(a);

			//}

			////Расчёт
			//double summOfValues = 0;
			//double averageValue = 0;

			//foreach (double value in doubleList)
			//{
			//	summOfValues += value;


			//}
			//averageValue = summOfValues / doubleList.Count;


			//Console.WriteLine("List: " + string.Join(" |", doubleList));
			//Console.WriteLine("Sum ({0}) / Count ({1}) = Average {2}", summOfValues, doubleList.Count, averageValue);


			//Dictionary

			//Dictionary<int, string> countries = new Dictionary<int, string>(5);
			//countries.Add(1, "Russia");
			//countries.Add(2, "Great Britain");
			//countries.Add(3, "USA");
			//countries.Add(4, "France");
			//countries.Add(5, "China");

			//foreach (KeyValuePair<int, string> keyValue in countries)
			//{
			//	Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
			//}


			//Console.WriteLine();


			//Dictionary<string, string> countries2 = new Dictionary<string, string>(5);
			//countries2.Add("ru", "Russia");
			//countries2.Add("gb", "Great Britain");
			//countries2.Add("us", "USA");
			//countries2.Add("fr", "France");
			//countries2.Add("ch", "China");

			//foreach (KeyValuePair<string, string> keyValues in countries2)
			//{
			//	Console.WriteLine($"{keyValues.Key} - {keyValues.Value}");
			//}


			//Самостоятельная Стэк

			const string stopWord = "exit";
			const string addStack = "wash";
			const string outStack = "dry";
			string input = string.Empty;
			int i = 0;

			var plates = new Stack<string>();

			
			do{
				input = Console.ReadLine();

				if (input == addStack)
				{
					plates.Push("plate" + i);
					i++;
					Console.WriteLine($"{plates.Peek()} has washed");
				}
				else if(input == outStack)
				{
					if (plates.Count > 0)
					{
						Console.WriteLine("{0} has dried", plates.Pop());
					}
					else
					{
						Console.WriteLine("Stack is empty");
						continue;
					}
				}
			}while (input != stopWord);






			Console.ReadKey();
		}
	}
}
