using System;

namespace Practice_with_multidimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] books =
            {
                {"Александр Пушкин","Михаил Лермонтов","Сергей Есенин"},
                {"Роберт Мартин","Джеси Шелл","Сергей Тепляков"},
                {"Стивен Кинг","Говард Лавкрафт","Брем Стокер"}
            };

            const string CommandSearchBookIJ = "1";
            const string CommandSearchBookAuthor = "2";
            const string CommandExit = "3";

            string userInput;


            bool isOpen = true;
            while( isOpen )
            {
                Console.SetCursorPosition(0,20);
                Console.WriteLine("Весь список авторов:");
                for(int i = 0; i < books.GetLength(0); i++)
                {
                    for(int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i,j] +" | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("1 - узнать имя автора по индексу книги.");
                Console.WriteLine("2 - найти книгу по автору.");
                Console.WriteLine("3 - выход");
                Console.WriteLine("Введите команду меню:");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSearchBookIJ:
                        int line, column;
                        Console.WriteLine("Введите номер полки:");
                        line = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("Введите номер столбца:");
                        column = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine($"Это автор - {books[line,column]}");
                        break;
                    case CommandSearchBookAuthor:
                        bool authorIsFound = false;
                        Console.WriteLine("Введите автора:");
                        string author = Console.ReadLine();
                        for(int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0;j < books.GetLength(1);j++)
                            {
                                if (books[i,j].ToLower() == author.ToLower())
                                {
                                    Console.WriteLine($"Автор {books[i, j]} находится по адресу полка: {i + 1}, столбец {j + 1}.");
                                }
                            }
                        }
                        if (authorIsFound)
                        {
                            Console.WriteLine("Такого автора нет.");
                        }
                        break;
                    case CommandExit:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Не верная команда");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
