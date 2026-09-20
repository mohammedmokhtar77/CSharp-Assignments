namespace ExamSystem;

/// <summary>
/// Represents a final exam.
/// A final exam displays the questions, available answers,
/// correct answers, and the grades assigned to the questions.
/// </summary>
public class FinalExam : Exam
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FinalExam"/> class.
    /// </summary>
    /// <param name="time">The duration of the exam in minutes.</param>
    /// <param name="numberOfQuestions">The number of questions in the exam.</param>
    /// <param name="questions">The questions included in the exam.</param>
    /// <param name="subject">The subject associated with the exam.</param>
    public FinalExam(int time, int numberOfQuestions, Question[] questions, Subject subject)
        : base(time, numberOfQuestions, questions, subject)
    {
    }

    /// <summary>
    /// Displays the final exam, including its questions,
    /// available answers, correct answers, and total grade.
    /// </summary>
    public override void ShowExam()
    {
        int totalGrade = 0;

        Console.WriteLine("FINAL EXAM");
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

            Console.WriteLine($"Right Answer: {question.RightAnswer}");
            Console.WriteLine($"Mark: {question.Mark}");

            totalGrade += question.Mark;
        }

        Console.WriteLine($"Total Grade: {totalGrade}");
    }
}