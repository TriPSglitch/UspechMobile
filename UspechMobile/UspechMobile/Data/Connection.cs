using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using UspechMobile.DBModels;

namespace UspechMobile.Data
{
    public class Connection
    {
        public readonly SQLiteAsyncConnection db;

        public Connection(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);

            db.CreateTableAsync<Roles>().Wait();
            db.CreateTableAsync<Persons>().Wait();
            db.CreateTableAsync<Users>().Wait();
            db.CreateTableAsync<Courses>().Wait();
            db.CreateTableAsync<UserCourses>().Wait();
            db.CreateTableAsync<Schedule>().Wait();
            db.CreateTableAsync<Categories>().Wait();
            db.CreateTableAsync<CourseCategories>().Wait();
            db.CreateTableAsync<Lectures>().Wait();
            db.CreateTableAsync<LectureImages>().Wait();
            db.CreateTableAsync<LectureFiles>().Wait();
            db.CreateTableAsync<Exercises>().Wait();
            db.CreateTableAsync<ExerciseComments>().Wait();
            db.CreateTableAsync<ExerciseFiles>().Wait();
            db.CreateTableAsync<AnswersExercise>().Wait();
            db.CreateTableAsync<AnswerExerciseFiles>().Wait();
            db.CreateTableAsync<Tests>().Wait();
            db.CreateTableAsync<TestComments>().Wait();
            db.CreateTableAsync<StudentTestGrade>().Wait();
            db.CreateTableAsync<Types>().Wait();
            db.CreateTableAsync<Questions>().Wait();
            db.CreateTableAsync<QuestionAnswerOptions>().Wait();
            db.CreateTableAsync<AnswersQuestion>().Wait();
        }

        #region получение всего списка
        public Task<List<Persons>> GetPersons()
        {
            return db.Table<Persons>().ToListAsync();
        }

        public Task<List<Users>> GetUsers()
        {
            return db.Table<Users>().ToListAsync();
        }

        public Task<List<Courses>> GetCourses()
        {
            return db.Table<Courses>().ToListAsync();
        }

        public Task<List<Schedule>> GetSchedules()
        {
            return db.Table<Schedule>().ToListAsync();
        }

        public Task<List<Categories>> GetCategories()
        {
            return db.Table<Categories>().ToListAsync();
        }

        public Task<List<Lectures>> GetLectures()
        {
            return db.Table<Lectures>().ToListAsync();
        }

        public Task<List<Exercises>> GetExercises()
        {
            return db.Table<Exercises>().ToListAsync();
        }

        public Task<List<ExerciseComments>> GetExerciseComments()
        {
            return db.Table<ExerciseComments>().ToListAsync();
        }

        public Task<List<AnswersExercise>> GetAnswersExercises()
        {
            return db.Table<AnswersExercise>().ToListAsync();
        }

        public Task<List<Tests>> GetTests()
        {
            return db.Table<Tests>().ToListAsync();
        }

        public Task<List<TestComments>> GetTestComments()
        {
            return db.Table<TestComments>().ToListAsync();
        }

        public Task<List<StudentTestGrade>> GetStudentTestGrades()
        {
            return db.Table<StudentTestGrade>().ToListAsync();
        }
        public Task<List<QuestionAnswerOptions>> GetQuestionAnswerOptions()
        {
            return db.Table<QuestionAnswerOptions>().ToListAsync();
        }

        public Task<List<AnswersQuestion>> GetAnswersQuestions()
        {
            return db.Table<AnswersQuestion>().ToListAsync();
        }
        #endregion

        #region получение одного объекта
        public Task<Persons> GetPerson(int id)
        {
            return db.Table<Persons>().Where(item  => item.ID == id).FirstOrDefaultAsync();
        }

        //public Task<Users> GetUser(int id)
        //{
        //    return db.Table<Users>().ToListAsync();
        //}

        //public Task<Chats> GetChat(int id)
        //{
        //    return db.Table<Chats>().ToListAsync();
        //}

        //public Task<Courses> GetCourse(int id)
        //{
        //    return db.Table<Courses>().ToListAsync();
        //}

        //public Task<Categories> GetCategory(int id)
        //{
        //    return db.Table<Categories>().ToListAsync();
        //}

        //public Task<Lectures> GetLecture(int id)
        //{
        //    return db.Table<Lectures>().ToListAsync();
        //}

        //public Task<Exercises> GetExercise(int id)
        //{
        //    return db.Table<Exercises>().ToListAsync();
        //}

        //public Task<AnswersExercise> GetAnswerExercise(int id)
        //{
        //    return db.Table<AnswersExercise>().ToListAsync();
        //}

        //public Task<Tests> GetTest(int id)
        //{
        //    return db.Table<Tests>().ToListAsync();
        //}

        //public Task<QuestionAnswerOptions> GetQuestionAnswerOption(int id)
        //{
        //    return db.Table<QuestionAnswerOptions>().ToListAsync();
        //}

        //public Task<AnswersQuestion> GetAnswersQuestion(int id)
        //{
        //    return db.Table<AnswersQuestion>().ToListAsync();
        //}
        #endregion
    }
}