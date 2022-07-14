namespace SelfLearn
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Student student = new Student();
            student.name = "Aravinda";
            student.age = 25;
            student.Weight = 75;
            student.Height = 6;
            student.Salary = 25000;
            student.studentID = 785648;
            student.uniName = "No University";
            Console.WriteLine("From Perent Class");
            student.PrintPersonInfor();
            Console.WriteLine("From Student Class");
            student.Study();
           

        }
    }
}