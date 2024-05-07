namespace Practice10._1.Services
{
    public class SchoolService
    {
        private ApplicationDbContext _context;
        public SchoolService(ApplicationDbContext context) 
        {
            _context = context;
        }
        internal async void Add(object sourse)
        {

        }
        internal IEnumerable<Student> GetStudents() =>
            _context.Students.AsEnumerable();

        internal IEnumerable<Teacher> GetTeachers() =>
            _context.Teachers.AsEnumerable();
        internal IEnumerable<Group> GetGroups() =>
            _context.Groups.AsEnumerable();

        internal async void UpdateStudents(Guid Id, Student newData)
        {

        }
        internal async void UpdateTeachers(Guid Id, Teacher newData)
        {

        }
        internal async void UpdateGroups(Guid Id, Group newData)
        {

        }
        internal void DeleteTeacher(Guid Id)
        {

        }
        internal void DeleteStudent(Guid Id)
        {

        }
        internal void DeleteGroup(Guid Id)
        {

        }
    }
}
