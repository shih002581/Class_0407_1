namespace Class_0407_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1234, "咚咚紐", 98);
            Console.WriteLine(s.GetName());
            Console.WriteLine(s.Info());
        }
    }
}
