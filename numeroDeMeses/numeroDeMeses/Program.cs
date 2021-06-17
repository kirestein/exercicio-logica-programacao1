using System;

namespace numeroDeMeses
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDeDias = 0, diasDoMes = 30, n = 0;
            

            do
            {
                Console.WriteLine("Digite o número de meses que deseja calcular a quantidade de dias: ");
                string numerosDeMeses = Console.ReadLine();
                n = Convert.ToInt32(numerosDeMeses);
                totalDeDias = diasDoMes * n;

                Console.WriteLine("O número de dias de " + n + " meses é: " + totalDeDias);

            } while (n > 0);
    }
    }
}
