namespace UspechMobile.Models
{
    internal interface IAssessedAssignment
    {
        int IDAssignment { get; set; }
        int IDStudent { get; set; }
        int Grade { get; set; }
        string StudentFIO { get; set; }
    }
}