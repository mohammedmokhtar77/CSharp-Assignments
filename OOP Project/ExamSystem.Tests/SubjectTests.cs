using Xunit;
using Assert = NUnit.Framework.Assert;

namespace ExamSystem.Tests;

public class SubjectTests
{
    [Fact]
    public void CreateExam_ShouldAssociateExamWithSubject()
    {
        // Arrange
        Subject subject = new Subject(
            1,
            "C# Programming");

        Answer answer = new Answer(1, "C#");

        Question question = new MCQQuestion(
            "Q1",
            "Which language is used with .NET?",
            5,
            new[] { answer },
            answer);

        Question[] questions =
        {
            question
        };

        Exam exam = new FinalExam(
            60,
            questions.Length,
            questions,
            subject);

        // Act
        subject.CreateExam(exam);

        // Assert
        Assert.Equals(true, ReferenceEquals(exam, subject.Exam));    }
}