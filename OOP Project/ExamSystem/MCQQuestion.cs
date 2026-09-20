namespace ExamSystem;

/// <summary>
/// Represents a multiple-choice question where the user selects one answer.
/// </summary>
public class MCQQuestion : Question
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MCQQuestion"/> class.
    /// </summary>
    /// <param name="header">The header or title of the question.</param>
    /// <param name="body">The body or text of the question.</param>
    /// <param name="mark">The mark assigned to the question.</param>
    /// <param name="answerList">The available answers for the question.</param>
    /// <param name="rightAnswer">The correct answer for the question.</param>
    public MCQQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
        : base(header, body, mark, answerList, rightAnswer)
    {
    }

    /// <summary>
    /// Displays the question and all available answers.
    /// </summary>
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