namespace ExamSystem;
/// <summary>
///  Represents an answer associated with an exam question.
/// </summary>
public class Answer
{
    public int AnswerId { get; set; }

    public string AnswerText { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Answer"/> class.
    /// </summary>
    /// <param name="answerId">The unique identifier of the answer.</param>
    /// <param name="answerText">The text of the answer.</param>
    public Answer(int answerId , string answerText)
    {
        AnswerId = answerId;
        AnswerText = answerText;
    }
    /// <summary>
    /// Returns a string representation of the answer.
    /// </summary>
    /// <returns>
    /// A string containing the answer ID and answer text.
    /// </returns>
    public override string ToString()
    {
        return $"{AnswerId}- {AnswerText}";;
    }
}