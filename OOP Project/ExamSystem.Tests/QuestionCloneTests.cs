using Xunit;
using Assert = NUnit.Framework.Assert;

namespace ExamSystem.Tests;

public class QuestionCloneTests
{
    [Fact]
    public void Clone_ShouldCreateDifferentQuestionObject()
    {
        // Arrange
        Answer answer = new Answer(1, "C#");

        Question original = new MCQQuestion(
            "Q1",
            "Which language is used with .NET?",
            5,
            new[] { answer },
            answer);

        // Act
        Question clone = (Question)original.Clone();

        // Assert
        Assert.Equals(false, ReferenceEquals(original, clone));
        Assert.Equals(original.Header, clone.Header);
        Assert.Equals(original.Body, clone.Body);
        Assert.Equals(original.Mark, clone.Mark);
    }
}