
public class Assessment //course assessment
{
    public int AssessmentId { get; set; }
    public int CourseId { get; set; }
    public string AssessmentName { get; set; }
    public string AssessmentDescription { get; set; }
    public List<Question> Questions { get; set; }
}

public class Question
{
    public int QuestionId { get; set; }
    public int AssessmentId { get; set; }
    public string QuestionText { get; set; }
    public List<Answer> Answers { get; set; }
}

public class Answer
{
    public int AnswerId { get; set; }
    public int QuestionId { get; set; }
    public string AnswerText { get; set; }
    public bool IsCorrect { get; set; }
}
