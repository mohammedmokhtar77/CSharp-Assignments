namespace ExamSystem;

/// <summary>
/// Represents the base class for all types of exam questions.
/// </summary>
public abstract class Question : ICloneable, IComparable<Question>
{
    public string Header { get; set; }

    public string Body { get; set; }
    
    public int Mark { get; set; }
    
    public Answer[] AnswerList { get; set; }
    
    public Answer RightAnswer { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Question"/> class.
    /// </summary>
    /// <param name="header">The header or title of the question.</param>
    /// <param name="body">The body or text of the question.</param>
    /// <param name="mark">The mark assigned to the question.</param>
    /// <param name="answerList">The available answers for the question.</param>
    /// <param name="rightAnswer">The correct answer for the question.</param>
    protected Question(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
    {
        Header = header;
        Body = body;
        Mark = mark;
        AnswerList = answerList;
        RightAnswer = rightAnswer;
    }

    /// <summary>
    /// Displays the question and its available answers.
    /// </summary>
    public abstract void DisplayQuestion();

    /// <summary>
    /// Creates a shallow copy of the current question object.
    /// </summary>
    /// <returns>
    /// A shallow copy of the current <see cref="Question"/> object.
    /// </returns>
    public virtual object Clone()
    {
        return MemberwiseClone();
    }

    /// <summary>
    /// Compares the current question with another question based on its mark.
    /// </summary>
    /// <param name="other">
    /// The question to compare with the current question.
    /// </param>
    /// <returns>
    /// A value less than zero if the current question has a smaller mark,
    /// zero if both questions have the same mark,
    /// or a value greater than zero if the current question has a larger mark.
    /// </returns>
    public int CompareTo(Question? other)
    {
        if (other == null)
            return 1;

        return Mark.CompareTo(other.Mark);
    }

    /// <summary>
    /// Returns a string representation of the current question.
    /// </summary>
    /// <returns>
    /// A string containing the question header and body.
    /// </returns>
    public override string ToString()
    {
        return $"{Header}: {Body}";
    }
}