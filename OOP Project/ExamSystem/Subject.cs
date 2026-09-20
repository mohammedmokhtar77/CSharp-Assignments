namespace ExamSystem;

/// <summary>
/// Represents a subject that can have an associated exam.
/// </summary>
public class Subject
{
    /// <summary>
    /// Gets or sets the unique identifier of the subject.
    /// </summary>
    public int SubjectId { get; set; }

    /// <summary>
    /// Gets or sets the name of the subject.
    /// </summary>
    public string SubjectName { get; set; }

    /// <summary>
    /// Gets or sets the exam associated with the subject.
    /// </summary>
    public Exam Exam { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Subject"/> class.
    /// </summary>
    /// <param name="subjectId">The unique identifier of the subject.</param>
    /// <param name="subjectName">The name of the subject.</param>
    public Subject(int subjectId, string subjectName)
    {
        SubjectId = subjectId;
        SubjectName = subjectName;
    }

    /// <summary>
    /// Associates an exam with the current subject.
    /// </summary>
    /// <param name="exam">The exam to associate with the subject.</param>
    public void CreateExam(Exam exam)
    {
        Exam = exam;
    }
}