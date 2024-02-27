var bookser = new BookServices();

while (true)
{
    System.Console.WriteLine("c = Create");
    System.Console.WriteLine("r = Read");
    System.Console.WriteLine("u = Update");
    System.Console.WriteLine("d = Delete");
    System.Console.WriteLine("e = Exit");
    
    string command = Console.ReadLine();

    if(command == "c")
    {
        var book = new Book();
        System.Console.Write("Enter book Name : ");
        book.Name = Console.ReadLine();
        System.Console.Write("Enter book Author : ");
        book.Author = Console.ReadLine();
        System.Console.WriteLine("Book successfully created ! ");
        bookser.AddBook(book);
    }

    if(command == "r")
    {
        foreach (var item in bookser.GetBooks())
        {
            System.Console.WriteLine("Id : " + item.Id);
            System.Console.WriteLine("Name : " + item.Name);
            System.Console.WriteLine("Author : " + item.Author);
        }
    }

    if(command == "u")
    {
        var updatedbook = new Book();
        System.Console.WriteLine("Enter Id for updating ! ");
        updatedbook.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter book Name : ");
        updatedbook.Name = Console.ReadLine();
        System.Console.Write("Enter book Author : ");
        updatedbook.Author = Console.ReadLine();
        bookser.UpdateBook(updatedbook);
        System.Console.WriteLine("Book successfully updated ! ");
    }

    if(command == "d")
    {
        System.Console.WriteLine("For deleting book show Id");
        bookser.DeleteBook(Convert.ToInt32(Console.ReadLine()));
        System.Console.WriteLine("Book deleted successfully");
    }

    if(command == "e")
    {
        break;
    }
}