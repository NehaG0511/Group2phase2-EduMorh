public class Course  //course specification
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public string CourseImage { get; set; }
    public decimal CoursePrice { get; set; }

    public List<CourseRegistration> CourseRegistrations { get; set; }
}
