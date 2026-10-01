using Xunit;
using Assert = NUnit.Framework.Assert;

namespace ExamSystem.Tests;

public class QuestionComparisonTests
{
     [Fact]
    public void CompareTo_ShouldReturnLessThanZero_WhenCurrentMarkIsSmaller()
    {
        // Arrange
        Answer answer = new Answer(1, "C#");

        Question question1 = new MCQQuestion(
            "Q1",
            "Question 1",
            5,
            new[] { answer },
            answer);

        Question question2 = new MCQQuestion(
            "Q2",
            "Question 2",
            10,
            new[] { answer },
            answer);

        // Act
        int result = question1.CompareTo(question2);

        // Assert
        Assert.Equals(-1, Math.Sign(result));    }


    [Fact]
    public void CompareTo_ShouldReturnZero_WhenMarksAreEqual()
    {
        // Arrange
        Answer answer = new Answer(1, "C#");

        Question question1 = new MCQQuestion(
            "Q1",
            "Question 1",
            5,
            new[] { answer },
            answer);

        Question question2 = new MCQQuestion(
            "Q2",
            "Question 2",
            5,
            new[] { answer },
            answer);

        // Act
        int result = question1.CompareTo(question2);

        // Assert
        Assert.Equals(0, result);
    }


    [Fact]
    public void CompareTo_ShouldReturnGreaterThanZero_WhenCurrentMarkIsGreater()
    {
        // Arrange
        Answer answer = new Answer(1, "C#");

        Question question1 = new MCQQuestion(
            "Q1",
            "Question 1",
            10,
            new[] { answer },
            answer);

        Question question2 = new MCQQuestion(
            "Q2",
            "Question 2",
            5,
            new[] { answer },
            answer);

        // Act
        int result = question1.CompareTo(question2);

        // Assert
        Assert.Equals(1, Math.Sign(result));    }


    [Fact]
    public void CompareTo_ShouldReturnOne_WhenOtherQuestionIsNull()
    {
        // Arrange
        Answer answer = new Answer(1, "C#");

        Question question = new MCQQuestion(
            "Q1",
            "Question",
            5,
            new[] { answer },
            answer);

        // Act
        int result = question.CompareTo(null);

        // Assert
        Assert.Equals(1, result);
    }
}