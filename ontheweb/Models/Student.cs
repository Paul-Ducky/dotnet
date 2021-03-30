namespace ontheweb.Models
{
    public class Student
    {
        public uint Id;
        public string Name;
        public uint ClassId;

        public Student(uint id, string name, uint classId)
        {
            Id = id;
            Name = name;
            ClassId = classId;
        }
    }
}