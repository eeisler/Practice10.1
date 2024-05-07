namespace Practice10._1
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string ?FIO { get; set; }
        public List<Group>? groups { get; set; }
    }
}
