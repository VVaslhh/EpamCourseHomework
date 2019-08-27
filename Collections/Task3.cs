using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
   public class Task3
    {

        private readonly List<string> strList = new List<string>();
        private readonly List<string> newList = new List<string>();

        public string CreateRandomElementOfList(int strLength = 4)
        {
            Random rand = new Random();

            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder str = new StringBuilder();

            for (int j = 0; j < strLength; j++)
            {
                str.Append(characters[rand.Next(characters.Length)]);
            }
            return str.ToString();
        }

        public List<string> CreateList(int numberOfElements = 100)
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                string s = CreateRandomElementOfList();
                strList.Add(s);
            }
            Console.WriteLine($"The length of list before transformation = {strList.Count}");

            return strList;

        }

        public List<string> ModifyList()
        {
            for (int i = 0; i < strList.Count; i++)
            {
                if (!newList.Contains(strList[i]) && !strList[i].StartsWith("Z"))
                {
                    newList.Add(strList[i]);
                }
            }
            newList.Sort((a, b) => -1 * a.CompareTo(b));

            Console.WriteLine($"The length of list after transformation = {newList.Count}");
            return newList;
        }

        public void DisplayPage(List<string> str, int pageNumber, int itemsInPage = 5)
        {
            int pagesCount = str.Count / itemsInPage;
            if (pageNumber < 0 || pageNumber > pagesCount)
            {
                throw new ArgumentOutOfRangeException($"List have only {pagesCount} pages");
            }
                int startIndex = pageNumber * itemsInPage;
            int endIndex = startIndex + 5;
            for (int i = startIndex; i < endIndex; i++)
            {
                Console.WriteLine($"{i + 1}. {str[i]}");
               
            }
        }

        public void Display(List<string> st)
        {
            int i = 0;
            foreach (var s in st)
            {
                i++;
                Console.WriteLine($"{i} Name: {s}");
            }
            Console.WriteLine("\n");

        }
    }
}
