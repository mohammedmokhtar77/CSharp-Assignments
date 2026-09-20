namespace ExamSystem;

public class MCQQuestion : Question
{
    public MCQQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
        : base(header, body, mark, answerList, rightAnswer)
    {
    }
    
    public override void DisplayQuestion()
    {
        Console.WriteLine(Header);
        Console.WriteLine(Body);

        Console.WriteLine();

        foreach (Answer answer in AnswerList)
        {
            Console.WriteLine(answer);
        }
    }
}