namespace ExamSystem;

/// <summary>
/// Represents a practical exam.
/// A practical exam displays the questions and answers,
/// then shows the correct answers after the exam is finished.
/// </summary>
public class PracticalExam : Exam
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PracticalExam"/> class.
    /// </summary>
    /// <param name="time">The duration of the exam in minutes.</param>
    /// <param name="numberOfQuestions">The number of questions in the exam.</param>
    /// <param name="questions">The questions included in the exam.</param>
    /// <param name="subject">The subject associated with the exam.</param>
    public PracticalExam(int time, int numberOfQuestions, Question[] questions, Subject subject)
        : base(time, numberOfQuestions, questions, subject)
    {
    }

    /// <summary>
    /// Displays the practical exam, including its questions and available answers,
    /// followed by the correct answers.
    /// </summary>
    public override void ShowExam()
    {
        Console.WriteLine("PRACTICAL EXAM");
        Console.WriteLine($"Subject: {Subject.SubjectName}");
        Console.WriteLine($"Time: {Time} Minutes");
        Console.WriteLine();

        foreach (Question question in Questions)
        {
            Console.WriteLine(question);

            foreach (Answer answer in question.AnswerList)
            {
                Console.WriteLine(answer);
            }

            Console.WriteLine();
        }

        Console.WriteLine("RIGHT ANSWERS");

        foreach (Question question in Questions)
        {
            Console.WriteLine($"{question.Header}: {question.RightAnswer}");
        }
    }
}