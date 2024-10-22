namespace StructIndexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt numbers= new ListInt (0);
            numbers.Add(6);
            numbers.AddRange(1,2,3,4,5,8);
            numbers.Add(7);
            Console.WriteLine(numbers.Contains(6));
            //numbers.RemoveRange(8);
            Console.WriteLine("Numbers: " + numbers.ToString());
            numbers.Sum();

           

        }
    }
}
