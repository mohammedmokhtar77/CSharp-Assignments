namespace ExamSystem;

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject(1, "C#");

        Answer answer1 = new Answer(1, "C#");
        Answer answer2 = new Answer(2, "Java");
        Answer answer3 = new Answer(3, "Python");
        Answer answer4 = new Answer(4, "C++");

        Answer[] answers = { answer1, answer2, answer3, answer4 };

        Question question = new MCQQuestion("Q1", 
            "Which language is used to build .NET applications?", 
            60, answers, answer1);

        Question[] questions = { question };
        // Dynamic Binding (Late Binding) ===> CLR At Runtime
        Exam exam = new FinalExam(60, questions.Length, questions, subject);
        subject.CreateExam(exam);
        exam.ShowExam();
    }
}