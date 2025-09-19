namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower();
            flower.Name = "BlackMagic";
            flower.Type = "Rose";
            flower.Cost = 50;
            flower.Hight = 80;

            Console.WriteLine($"Your flower has the following parameters: name - {flower.Name}, type - {flower.Type}, {flower.Cost}, {flower.Hight}");

            Console.WriteLine();
            Console.WriteLine($"_Updating data for flower_");
            Console.WriteLine();

            flower.EditFlower();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"_New flower information_ ");
            Console.WriteLine();
            Console.WriteLine();

            flower.GetFlowerInfo();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(flower.AnalysHight());
        }
    }
}
