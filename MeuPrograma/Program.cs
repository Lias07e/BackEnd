using System;

class Program
{
   
    static void main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite seu CPF :");
        string cpf = Console.ReadLine()!;

        Console.WriteLine("Qual seu sexo: M/F ");
        string sexo = Console.ReadLine()!;

        Console.WriteLine("===== Detalhes de medicamentos =====");
        Console.WriteLine(" Dipirona - 3 vezes ao dia");
        Console.WriteLine(" Simeticona - 3 vezes ao dia");
        Console.WriteLine(" Gelo - após as refeições");

        Console.WriteLine("===== Detalhes do paciente =====");
        Console.WriteLine($" Nome do paciente : {nome}");
        Console.WriteLine($" CPF do paciente :{cpf}");
        Console.WriteLine($" Sexo do paciente : {sexo}");
        Console.WriteLine(" data : 13/08/2029");

    }
}

       


 /*Exibe uma mensagem na tela
        Console.WriteLine("Olá! Qual é o seu nome?");

        // Lê o nome digitado pelo usuário
        string nome = Console.ReadLine();

        // Exibe uma mensagem personalizada
        
        Console.WriteLine($"Prazer em te conhecer, {nome}!");*/
