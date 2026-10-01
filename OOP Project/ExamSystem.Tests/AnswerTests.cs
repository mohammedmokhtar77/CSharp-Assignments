using Xunit;
using Assert = NUnit.Framework.Assert;

namespace ExamSystem.Tests;

public class AnswerTests
{
    [Fact]
    public void ToString_ShouldReturnAnswerIdAndAnswerText()
    {
        // Arrange
        Answer answer = new Answer(1, "C#");

        // Act
        string result = answer.ToString();

        // Assert
        Assert.Equals("1- C#", result);
    }
}