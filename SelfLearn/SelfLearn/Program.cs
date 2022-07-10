namespace SelfLearn
{
    class Program
    {
        static void Main(string[] args)
        {
           Person p1 = new Person();
           Person p2 = new Person();
            p1.name = "Ishan";
            p1.age = 25;
            p1.Height = 6;
            p1.Weight = 75;
            Console.WriteLine(p1.Weight);
            p1.PrintPersonInfor();
        }
    }
}