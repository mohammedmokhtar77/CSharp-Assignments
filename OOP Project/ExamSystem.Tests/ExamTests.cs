using Xunit;
using Assert = NUnit.Framework.Assert;

namespace ExamSystem.Tests;

public class ExamTests
{
    [Fact]
    public void FinalExam_ShouldBeCreatedCorrectly()
    {
        // Arrange
        Subject subject = new Subject(1, "C#");

        Answer answer = new Answer(1, "C#");

        Question question = new MCQQuestion(
            "Q1",
            "Question",
            5,
            new[] { answer },
            answer);

        Question[] questions =
        {
            question
        };

        // Act
        Exam exam = new FinalExam(
            60,
            questions.Length,
            questions,
            subject);

        // Assert
        Assert.Equals(typeof(FinalExam), exam.GetType());
        Assert.Equals(60, exam.Time);
        Assert.Equals(1, exam.NumberOfQuestions);
        Assert.Equals(true, ReferenceEquals(subject, exam.Subject));
        Assert.Equals(1, exam.Questions.Length);
    }


    [Fact]
    public void PracticalExam_ShouldBeCreatedCorrectly()
    {
        // Arrange
        Subject subject = new Subject(1, "C#");

        Answer answer = new Answer(1, "C#");

        Question question = new MCQQuestion(
            "Q1",
            "Question",
            5,
            new[] { answer },
            answer);

        Question[] questions =
        {
            question
        };

        // Act
        Exam exam = new PracticalExam(
            60,
            questions.Length,
            questions,
            subject);

        // Assert
        Assert.Equals(typeof(PracticalExam), exam.GetType());
        Assert.Equals(60, exam.Time);
        Assert.Equals(1, exam.NumberOfQuestions);
        Assert.Equals(true, ReferenceEquals(subject, exam.Subject));
        Assert.Equals(1, exam.Questions.Length);
    }
}