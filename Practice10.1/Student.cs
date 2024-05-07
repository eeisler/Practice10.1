namespace Practice10._1
{
    public class Student
    {
        public Guid Id { get; set; }
        public string ?FIO { get; set; }
        public string ?Group { get; set; }
        public List<Group> ?group { get; set; }
    }
}
