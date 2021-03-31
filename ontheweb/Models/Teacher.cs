namespace ontheweb.Models
{
    public class Teacher
    {
        private string _name;
        private uint _id;
        private uint _classId;
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public uint Id
        {
            get => _id;
            set => _id = value;
        }

        public uint ClassId
        {
            get => _classId;
            set => _classId = value;
        }
        
        public Teacher(string name, uint id, uint classId)
        {
            _name = name;
            _id = id;
            _classId = classId;
        }
    }
}