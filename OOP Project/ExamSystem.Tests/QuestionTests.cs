using Xunit;
using Assert = NUnit.Framework.Assert;

namespace ExamSystem.Tests;

public class QuestionTests
{
    [Fact]
    public void MCQQuestion_ShouldStoreCorrectData()
    {
        // Arrange
        Answer answer1 = new Answer(1, "C#");
        Answer answer2 = new Answer(2, "Java");

        Answer[] answers =
        {
            answer1,
            answer2
        };

        // Act
        Question question = new MCQQuestion(
            "Q1",
            "Which language is used with .NET?",
            5,
            answers,
            answer1);

        // Assert
        Assert.Equals("Q1", question.Header);
        Assert.Equals("Which language is used with .NET?", question.Body);
        Assert.Equals(5, question.Mark);
        Assert.Equals(2, question.AnswerList.Length);
        Assert.Equals(answer1, question.RightAnswer);
    }


    [Fact]
    public void TrueFalseQuestion_ShouldStoreCorrectData()
    {
        // Arrange
        Answer trueAnswer = new Answer(1, "True");
        Answer falseAnswer = new Answer(2, "False");

        Answer[] answers =
        {
            trueAnswer,
            falseAnswer
        };

        // Act
        Question question = new TrueFalseQuestion(
            "Q1",
            "C# is an OOP language.",
            5,
            answers,
            trueAnswer);

        // Assert
        Assert.Equals("Q1", question.Header);
        Assert.Equals(5, question.Mark);
        Assert.Equals(trueAnswer, question.RightAnswer);
    }


    [Fact]
    public void ToString_ShouldReturnHeaderAndBody()
    {
        // Arrange
        Answer answer = new Answer(1, "C#");

        Question question = new MCQQuestion(
            "Q1",
            "Which language is used with .NET?",
            5,
            new[] { answer },
            answer);

        // Act
        string result = question.ToString();

        // Assert
        Assert.Equals(
            "Q1: Which language is used with .NET?",
            result);
    }
}