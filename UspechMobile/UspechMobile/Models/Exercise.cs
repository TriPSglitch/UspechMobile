using System.Threading.Tasks;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class Exercise : IAssessedAssignment
    {
        private int idAssignment;
        private int idStudent;
        private int grade;
        private string studentFIO;

        public int IDAssignment { get => idAssignment; set => idAssignment = value; }
        public int IDStudent { get => idStudent; set => idStudent = value; }
        public int Grade { get => grade; set => grade = value; }
        public string StudentFIO { get => studentFIO; set => studentFIO = value; }

        public Exercise(AnswersExercise assignment)
        {
            this.IDAssignment = assignment.IDExercise;
            this.IDStudent = assignment.IDStudent;
            this.Grade = assignment.Grade;
            Task.Run(() => this.GetData()).Wait();
        }

        public Exercise() { }

        private async void GetData()
        {
            Persons student = await App.Connection.db.Table<Persons>().Where(item => item.ID == this.IDStudent).FirstOrDefaultAsync();
            this.studentFIO = student.Firstname + " " + student.Lastname.Substring(0, 1) + " " + student.Middlename.Substring(0, 1);
        }
    }
}