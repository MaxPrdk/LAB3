namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 4);
            Console.WriteLine($"�����: {rectangle.Area}");
            Console.WriteLine($"��������: {rectangle.Perimeter}");
        }
    }
}