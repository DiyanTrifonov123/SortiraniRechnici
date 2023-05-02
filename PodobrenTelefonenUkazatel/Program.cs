using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodobrenTelefonenUkazatel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        phoneBook.Add(input[1], input[2]); break;

                    case "S":
                        if (phoneBook.ContainsKey(input[1]))
                        {
                            string phone = phoneBook[input[1]];
                            Console.WriteLine($"{input[1]} -> {phone}");
                        }
                        else
                        {
                            Console.WriteLine($"Контактът {input[1]} не съществува!");
                        }
                        break;
                    case "ListAll":
                        Console.WriteLine($"В указателя има {phoneBook.Count} записани. \nСписък по азбучен ред: ");
                        foreach (var item in phoneBook.Keys)
                        {
                            Console.WriteLine($"{item} -> {phoneBook[item]}");
                        }
                        break;

                    default:
                        break;
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
