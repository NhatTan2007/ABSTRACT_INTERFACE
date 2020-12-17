using System;
using System.Collections;

namespace NEWS_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourChoice;
            bool checkInput = false;
            Hashtable newsList = new Hashtable();
            string title;
            DateTime publishDate;
            string author;
            string content;

            while (true)
            {
                Menu();
                do
                {
                    Console.Write("Please select one option frome above: ");
                    checkInput = int.TryParse(Console.ReadLine(), out yourChoice);
                } while (!checkInput || yourChoice <= 0 || yourChoice > 4);

                switch (yourChoice)
                {
                    case 1:
                        Console.Write("Title: ");
                        title = Console.ReadLine();
                        do
                        {
                            Console.Write("Date publish: ");
                            checkInput = DateTime.TryParse(Console.ReadLine(), out publishDate);
                        } while (!checkInput);
                        Console.Write("Author is: ");
                        author = Console.ReadLine();
                        author = FormatName(author);
                        Console.Write("Content: ");
                        content = Console.ReadLine();

                        News latestNew = new News(title: title, publishDate: publishDate, author: author, content: content);
                        Console.WriteLine($"Please enter 3 rates of news: {title}: ");
                        int count = 0;
                        do
                        {
                            Console.Write($"Rate {count + 1}: ");
                            checkInput = int.TryParse(Console.ReadLine(), out latestNew.RateList[count]);
                            if(checkInput && latestNew.RateList[count] >= 0 && latestNew.RateList[count] <= 5) count++;
                        } while (count <= 2);
                        
                        newsList.Add(latestNew.Id, latestNew);
                        break;
                    case 2:
                        foreach (DictionaryEntry item in newsList)
                        {
                            Console.WriteLine(((News)item.Value).Display());
                        }
                        break;
                    case 3:
                        foreach (DictionaryEntry item in newsList)
                        {
                            ((News)item.Value).CalculateAverageRate();
                            Console.WriteLine(((News)item.Value).Display());
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("NEWS MANAGEMENT SYSTEM\n");
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average rate");
            Console.WriteLine("4. Exit");
        }

        static string FormatName(string nameInput)
        {
            //Remove space;
            while (nameInput.IndexOf("  ") != -1)
            {
                nameInput = nameInput.Replace("  ", " ");
            }
            //make Upercase first char each word.
            nameInput = nameInput.ToLower();
            string[] nameSplitArray = nameInput.Split(" ");
            for (int i = 0; i < nameSplitArray.Length; i++)
            {
                char[] stringSplitToChar = nameSplitArray[i].ToCharArray();
                stringSplitToChar[0] = Char.ToUpper(stringSplitToChar[0]);
                nameSplitArray[i] = new string(stringSplitToChar);
            }
            nameInput = String.Join(" ", nameSplitArray);
            return nameInput;
        }
    }
}
