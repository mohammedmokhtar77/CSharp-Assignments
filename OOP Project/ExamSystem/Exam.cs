namespace ExamSystem;

/// <summary>
/// Represents the base class for all types of exams.
/// Defines the common properties and behavior shared by exams.
/// </summary>
public abstract class Exam
{
    public int Time { get; set; }
    
    public int NumberOfQuestions { get; set; }
    
    public Question[] Questions { get; set; }
    
    public Subject Subject { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Exam"/> class.
    /// The constructor is protected because <see cref="Exam"/> is an abstract class
    /// and is intended to be initialized through its derived classes.
    /// </summary>
    /// <param name="time">The duration of the exam in minutes.</param>
    /// <param name="numberOfQuestions">The number of questions in the exam.</param>
    /// <param name="questions">The questions included in the exam.</param>
    /// <param name="subject">The subject associated with the exam.</param>
    protected Exam(int time, int numberOfQuestions, Question[] questions, Subject subject)
    {
        Time = time;
        NumberOfQuestions = numberOfQuestions;
        Questions = questions;
        Subject = subject;
    }

    /// <summary>
    /// Displays the exam.
    /// The implementation is provided by each derived exam type.
    /// </summary>
    public abstract void ShowExam();
}