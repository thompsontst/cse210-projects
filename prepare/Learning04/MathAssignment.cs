namespace week04_demo {
public class MathAssignment : Assignment
{
protected string _textBookSection;
public MathAssignment(string studentName, string topic, string textBookSection): base(studentName,topic)
{
    _textBookSection = textBookSection;
}
public string GetHomeWorkList()
{
    return $"{_studentName} - {_topic}\n {_textBookSection}";
}
}
}
