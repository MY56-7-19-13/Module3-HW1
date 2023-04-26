using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Starter
    {
        public void Run()
        {
            List<string> books = new List<string>
            {
                "Fahrenheit 451", "Introduction to Algorithms", "Code Complete: A Practical Handbook of Software Construction",
                "Design Patterns: Elements of Reusable Object-Oriented Software", "The Pragmatic Programmer"
            };
            MyCollection myCollection = new MyCollection(books);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine(" ------------------");
                Console.WriteLine("|*National Library*|");
                Console.WriteLine(" ------------------");
                Console.WriteLine();
                Console.WriteLine("Catalogue:");
                Console.WriteLine(new string('-', 25));
                if (books.Count == 0)
                {
                    Console.WriteLine("No item in library");
                }
                else
                {
                    foreach (var item in myCollection)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.WriteLine(new string('-', 25));
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("-----");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. AddRange collection");
                Console.WriteLine("3. Remove book(by title)");
                Console.WriteLine("4. Remove book(by number)");
                Console.WriteLine("5. Sort books");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Now you can add some book in our list!");
                        Console.Write("Enter the name book: ");
                        string? nameOfBooks = Console.ReadLine();
                        books.Add(nameOfBooks);
                        Console.WriteLine("Item added to the list");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("If you take point `2`, you can enter two books in list");
                        List<string> moreBooks = new List<string>();
                        Console.Write("Enter the name book: ");
                        string? moreBooksName1 = Console.ReadLine();
                        moreBooks.Add(moreBooksName1);
                        Console.Write("Please one more: ");
                        string? moreBooksName2 = Console.ReadLine();
                        moreBooks.Add(moreBooksName2);
                        books.AddRange(moreBooks);
                        Console.WriteLine("Items added to the list");
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("In this option you can remove book by title");
                        if (books.Count == 0)
                        {
                            Console.WriteLine("But no item in the list");
                        }
                        else
                        {
                            Console.Write("So, please enter the title you want to remove: ");
                            string? titleForRemove = Console.ReadLine();
                            if (books.Contains(titleForRemove))
                            {
                                books.Remove(titleForRemove);
                                Console.WriteLine($"Book `{titleForRemove}` removed from the list");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("No title in list!");
                            }
                        }

                        break;
                    case "4":
                        if (books.Count == 0)
                        {
                            Console.WriteLine("No item in the list");
                        }
                        else
                        {
                            Console.WriteLine("In this option you can remove book by number of position in list");
                            Console.Write("Enter the number of book to remove: ");
                            int numberToRemove = Convert.ToInt32(Console.ReadLine()) - 1;
                            if (numberToRemove >= 0 && numberToRemove <= books.Count)
                            {
                                string itemToRemove = books[numberToRemove];
                                books.RemoveAt(numberToRemove);
                                Console.WriteLine($"Item `{itemToRemove}` removed from the list");
                                Console.Write("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Invalid item number!");
                            }
                        }

                        break;
                    case "5":
                        Console.WriteLine("In this option you can sort your list");
                        Console.WriteLine("After this, look on");
                        Console.WriteLine("It`ll be a magic");
                        Console.Write("For doing this press any key...");
                        Console.ReadKey();
                        books.Sort();
                        Console.Clear();
                        break;
                    case "6":
                        isRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
