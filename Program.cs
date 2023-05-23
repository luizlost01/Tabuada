using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira Qual Tabuada Deseja Que Seja Exibida");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Mostrando agora a tabuada do Número {num}");
        tabuada(num);



        static void tabuada(int tab){
            for (int i = 0; i <= 10; i++)
            {
                int result = tab * i;
                Console.WriteLine($"{tab} x {i} = {result}");
            }
            Console.ReadLine();
        }


    }


}