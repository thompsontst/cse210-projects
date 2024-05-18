namespace week04_demo
{
   public class PictureBook: Book
   {
  private string _illustrator = "";
public PictureBook ()
{
  _illustrator = "Unseen";
}
  public string GetIllustrator()
{
    return _illustrator;
}
public void SetIllustrator (string Illustrator)
{
_illustrator = Illustrator;
}

 public string GetPictureBookInfo ()
  {
    return $"{_title} by {_author}, illustarted by {_illustrator}";
  }

   }
   }
  
