namespace PersonApi.Models
{
    public struct Student
    {
        //Fields
        private string name;
        private int age;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string PrintStudentDetails()
        {
            return $"Name: {name}  Age: {age}";
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
