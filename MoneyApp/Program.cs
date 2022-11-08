namespace MoneyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Nickel n = new Nickel();
            Console.WriteLine(n.About());
            Console.WriteLine(n.GetMintFromMark());
        }
    }
}