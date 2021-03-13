using System;

namespace VelMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            string ent1, ent2;
             int media, tempo, metros;
        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------- VELOCIDADE MÉDIA ----------");
            Console.ResetColor(); 

            Console.Write("Digite os metros percorridos: ");
            ent1 = Console.ReadLine();
            Console.Write("Digite o tempo percorrido em segundos: ");
            ent2 = Console.ReadLine();

            metros = Convert.ToInt32(ent1);
            tempo = Convert.ToInt16(ent2);

            media = metros / tempo;
            
            Console.WriteLine();
            Console.WriteLine($"A velocidade média é {media} m/s");


       }
    }
}
