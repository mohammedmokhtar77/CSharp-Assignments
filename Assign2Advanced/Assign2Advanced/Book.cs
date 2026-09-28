namespace Assign2Advanced;

public class Book
{
    public string ISBN { get; set; }

    public string Title { get; set; }

    public string[] Authors { get; set; }

    public DateTime PublicationDate { get; set; }

    public decimal Price { get; set; }

    public Book(string ISBN, string Title, string[] Authors, DateTime PublicationDate, decimal Price)
    {
        this.ISBN = ISBN;
        this.Title = Title;
        this.Authors = Authors;
        this.PublicationDate = PublicationDate;
        this.Price = Price;
    }

    public override string ToString()
    {
        return $"ISBN: {ISBN} :: " +
               $"Title: {Title} :: " +
               $"Authors: {string.Join(", ", Authors)} :: " +
               $"Publication Date: {PublicationDate} :: " +
               $"Price: {Price}";
    }
}