using System.Net;
using System.Security.Cryptography;

namespace week04_demo
{
   public class Book
   {
  protected string _author = "";
  protected string _title = "";
public Book()
{
  _author = "Annonymous";
  _title = "Unknown";

}
  public string GetAuthor ()
  {
    return _author;
  }
  public void SetAuthor(string author)
  {
    _author = author;
  }
  public string GetTitle()
  {
    return _title;
  }
  public void SetTitle(string title)
  {
    _title = title;
  }
  public string GetBookInfo ()
  {
    return $"{_title} by {_author}";
  }

   }
  
}