using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
	public class Exercises
	{
		// The first four exercises can be procedures if you wish
		// Please add appropriate calling code to Program.cs


		// Add tests as well as calling code for the exercises where you use functions

		// 1: Arrays
		// Create an array of doubles each of which holds three coordinates
		// Print these to the screen
		public static void ArrayExcericises()
		{
            double[,] Array = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };
			Console.WriteLine(String.Join("",Array.Cast<int>()));

		}

        // 2: Byte Arrays
        // i) Create an array of bytes that represents the word hello. Convert this to a string and output the result.
        // ii) Convert the word hello both in Chinese and in English to bytes. Output the byte array. 
		public static void ByteArrays()
		{
			string Input = "hello";
			string ChineseHello = "你好";
			byte[] ChineseByteArray=Encoding.UTF32.GetBytes(ChineseHello);
            byte[] ByteArray = Encoding.ASCII.GetBytes(Input);
			Console.WriteLine(string.Join("",ByteArray));
			Console.WriteLine(string.Join("", ChineseByteArray));
		}



		// 3: Temperatures
		// Populate a list of doubles to represent daily temperatures over two weeks
		// Calculate and output the min, max and average temperatures over the time period
		// Sort the list in ascending order and print it out

		public static void Temperatures()
		{
			List<Double> Temperatures = new List<Double>();
			for (int i = 0; i <= 14; i++)
			{
				Console.WriteLine("What is the current temperature looking like(In Celcius)?");
				double temperature = Convert.ToDouble(Console.ReadLine());
				Temperatures.Add(temperature);
			}
			Temperatures.Sort();
			double SumTotal=Temperatures.Sum();
			// Sorts the list from smallest to largest order
			Console.WriteLine($"The maximum temperature was {Temperatures[0]}");
			Console.WriteLine($"The minimum temperature was {Temperatures[Temperatures.Count-1]}");
			Console.WriteLine($"The average temperature was {SumTotal / Temperatures.Count}");
		}

		// 4: Students
		// Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
		// Print the names of the oldest and youngest students
		// Print out how many students were born after 2010
		// Create a new list of strings with the full names of all the students and print this out     

		public static void Students()
		{
            List<(string firstname, string surname, DateTime Birthdate)> Studentdata = new List<(string firstname, string surname, DateTime Birthdate)>();
			string input = "End";
			while (input != "End")
			{
                Console.WriteLine("Input Firstname (Type End to exit)");
                string firstname = Console.ReadLine();
                Console.WriteLine("Input Surname(Type End to exit)");
                string surname = Console.ReadLine();
                Console.WriteLine("Input Date Of Birth(Type End to exit)");
                DateTime Birthdate = Convert.ToDateTime(Console.ReadLine());
                Studentdata.Add((firstname, surname, Birthdate));
            }
			

        }

        // 5: Pig Latin
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        // Leave punctuation marks untouched.
        // The cat sat on the mat. => heTay atcay noay hetay atmay.
        public static string PigLatin(string input)
		{
            var words = input.Split(' ');
            var StringBuilder = new StringBuilder();

            foreach (var word in words)
            {
                var firstChar = word[0];
                if (char.IsPunctuation(firstChar))
                    StringBuilder.Append(firstChar + " ");
                else
                    StringBuilder.Append(word.Remove(0, 1) + firstChar + "ay ");
            }
            return StringBuilder.ToString();
        }
			
			

		// 6. Mexican wave
		//  1.  The input string will always be lower case but maybe empty.
		//  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
		// Example
		// Wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
		public static List<string> Wave(string input)
		{
			throw new NotImplementedException();
		}

		// 7. Anagram
		// Given a word and a list of words return the number of words that are anagrams of the others
		// Anagram("star", ["rats", "arts", "arc"]) => 2
		public static int Anagram(string input, string[] possibleAnagrams)
		{
			throw new NotImplementedException();
		}

		// 8. Variable Name helper
		public enum VariableNameType
		{
			CamelCase,
			PascalCase,
			SnakeCase
		}
		// Return the string in either camelCase, PascalCase or snake_case depending on the user choice
		public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
		{
			throw new NotImplementedException();
		}

		// 9. Binary search
		// The function should take a sorted list. You can sort it in the calling code using default sort.
		// Use a binary search to find the requested value (write this yourself)
		// It should return the index of the value found or -1 if it isn't found
		public static int BinarySearch(List<decimal> values)
		{
			throw new NotImplementedException();
		}
	}
}
