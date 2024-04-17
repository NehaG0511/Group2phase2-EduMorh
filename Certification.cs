public class Certification
{
    public int CertificationId { get; set; }
    public int AssessmentId { get; set; }
    public string CertificationName { get; set; }
    public string CertificationDescription { get; set; }
    public DateTime CertificationDate { get; set; }

    public Assessment Assessment { get; set; }
}