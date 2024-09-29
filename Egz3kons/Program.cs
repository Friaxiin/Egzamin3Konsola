namespace Egz3kons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods method = new Methods();
            Console.WriteLine("Podaj pesel");

            string pesel = Console.ReadLine();

            if (pesel.Length != 11)
            {
                Console.WriteLine("Podano niepoprawny pesel");
            }
            else
            {
                method.CheckSex(pesel);
                Console.WriteLine("Zgodność sumy kontrolnej:" + method.ControlNumberCheck(pesel));
            } 
        }
    }
}
