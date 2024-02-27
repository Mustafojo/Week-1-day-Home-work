using Dapper;
using Npgsql;
public class BookServices
{
    private string _connectionstring = 
    "Server=localhost;Port=5432;Database=EducationDb;User Id = postgres;Password=2007";

    public List<Book> GetBooks()
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        var result = connection.Query<Book>("select * from book").ToList();
        return result;
    }

    public void AddBook(Book book)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("insert into book (name,author) values (@name,@author)",book);
    }

    public void UpdateBook(Book book)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("update book set name = @name,author = @author where id = @id",book);
    }

    public void DeleteBook(int id)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("delete from book where id = @id",new { Id = @id });
    }
}