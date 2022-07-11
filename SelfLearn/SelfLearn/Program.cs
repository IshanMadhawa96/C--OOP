namespace SelfLearn
{
    class Program
    {
        static void Main(string[] args)
        {
           Person p1 = new Person();
           
            p1.name = "Ishan";
            p1.age = 25;
            //p1.Height = 6;
            //p1.Weight = 75;

            //using default constructer
            Console.WriteLine(p1.name);
            //p1.PrintPersonInfor();
            //using parameterized constructer
            Person p2 = new Person("Ish",26,6,75,7500);
            p2.PrintPersonInfor();
        }
    }
}