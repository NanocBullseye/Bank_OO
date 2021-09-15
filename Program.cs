using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client eduardo = new Client("Joao", 1234, 890, 333.33);
            Client thulio = new Client("Jonas", 1234, 900, 3333333.33);
            Client cana = new Client("Josias", 1234, 999, 3333333333333333333.33);

            Console.WriteLine("O titular da conta é: " + eduardo.titular);
            Console.WriteLine("O titular da conta é: " + thulio.titular);
            Console.WriteLine("O titular da conte é: " + cana.titular);
        }
    }
}
