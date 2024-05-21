namespace week04_demo {
public class MathAssignment : Assignment
{
protected string _textBookSection;
protected string _problems;
public MathAssignment(string studentName, string topic, string textBookSection, string MathProblems): base(studentName,topic)
{
    _textBookSection = textBookSection;
    _problems = MathProblems;
}
public string GetHomeWorkList()
{
    return $"{_studentName} - {_topic}\n {_textBookSection}";
}
}
}
