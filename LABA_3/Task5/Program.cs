using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Category { get; set; }

}

class HomeLibrary
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public Book GetBook(int index)
    {
        if (index >= 0 && index < books.Count)
        {
            return books[index];
        }

        return null;
    }


   

    public List<Book> FindBooksByTitle(string title)
    {
        return books.Where(b => b.Title.Equals(title)).ToList();
    }

    public List<Book> FindBooksByAuthor(string author)
    {
        return books.Where(b => b.Author.Equals(author)).ToList();
    }

    public List<Book> FindBooksByYear(int year)
    {
        return books.Where(b => b.Year == year).ToList();
    }

    public List<Book> FindBooksByCategory(string category)
    {
        return books.Where(b => b.Category.Equals(category)).ToList();
    }

    public void DisplayAllBooks()
    {
        Console.WriteLine("Список всех книг в библиотеке:");
        foreach (var book in books)
        {
            Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год издания: {book.Year}, Категория: {book.Category}");
        }
    }
}

class Program
{
    static void Main()
    {
        HomeLibrary library = new HomeLibrary();

        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Поиск книги");
            Console.WriteLine("4. Вывести список всех книг");
            Console.WriteLine("5. Выход");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите название книги:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Введите автора книги:");
                    string author = Console.ReadLine();
                    Console.WriteLine("Введите год издания книги:");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите категорию книги:");
                    string category = Console.ReadLine();

                    Book newBook = new Book {Title = title, Author = author, Year = year, Category = category };
                    library.AddBook(newBook);
                    break;

                case 2:
                    Console.WriteLine("Введите название книги, которую хотите удалить:");
                    string titleToRemove = Console.ReadLine();
                    Book bookToRemove = library.FindBooksByTitle(titleToRemove).FirstOrDefault();
                    if (bookToRemove != null)
                    {
                        library.RemoveBook(bookToRemove);
                        Console.WriteLine($"Книга {titleToRemove} удалена из библиотеки.");
                    }
                    else
                    {
                        Console.WriteLine("Книга не найдена.");
                    }
                    break;



                    break;

                case 3:
                    Console.WriteLine("Выберите по какому признаку искать книгу:");
                    Console.WriteLine("1. По автору");
                    Console.WriteLine("2. По году издания");
                    Console.WriteLine("3. По категории");
                    int searchChoice = int.Parse(Console.ReadLine());

                    switch (searchChoice)
                    {
                        case 1:
                            Console.WriteLine("Введите автора для поиска:");
                            string authorSearch = Console.ReadLine();
                            List<Book> booksByAuthor = library.FindBooksByAuthor(authorSearch);
                            foreach (var book in booksByAuthor)
                            {
                                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год издания: {book.Year}, Категория: {book.Category}");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Введите год издания для поиска:");
                            int yearSearch = int.Parse(Console.ReadLine());
                            List<Book> booksByYear = library.FindBooksByYear(yearSearch);
                            foreach (var book in booksByYear)
                            {
                                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год издания: {book.Year}, Категория: {book.Category}");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Введите категорию для поиска:");
                            string categorySearch = Console.ReadLine();
                            List<Book> booksByCategory = library.FindBooksByCategory(categorySearch);
                            foreach (var book in booksByCategory)
                            {
                                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год издания: {book.Year}, Категория: {book.Category}");
                            }
                            break;

                        default:
                            Console.WriteLine("Неверный выбор для поиска. Пожалуйста, выберите существующий признак.");
                            break;
                    }
                    break;

                case 4:
                    library.DisplayAllBooks();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Неверный выбор операции. Пожалуйста, выберите существующую операцию.");
                    break;
            }
        }
    }
}