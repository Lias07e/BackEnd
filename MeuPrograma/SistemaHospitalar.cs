class SistemaHospitalar
{
    static void Main()
    {
        bool executado = true;

        while(executado){
        Console.WriteLine("===== Sistema de Triagem Hospitalar =====");
        Console.WriteLine("Digite 1 para : Nova triagem  ");
        Console.WriteLine("Digite 2 para Sair ");

        int escolha = int.Parse(Console.ReadLine()!);


         if (escolha == 1)
        {
            Console.WriteLine("Qual seu nome");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Qual a temperatura corporal");
            double temp = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Dificuldade para respirar ( S /N)");
            string resp = Console.ReadLine()!;

             if(resp.ToUpper() == "S")
            {
                Console.WriteLine("Emergencia ,cor VERMELHA");

            }

            else if( temp >= 38.5 || idade >= 65)
            {
                Console.WriteLine("Urgencia, cor AMARELA");

            }
            else {
                Console.WriteLine("Pouco Urgente , cor VERDE");

            }
            Console.WriteLine("==============================");
            Console.WriteLine("===== Resultado da Triagem =====");
            Console.WriteLine($"nome do paciente : {nome}");
            Console.WriteLine($"idade do paciente : {idade}");
            Console.WriteLine($"temperatura do paciente : {temp}");
            Console.WriteLine($" dificuldade para respirar : {resp}");

            Console.WriteLine("===== Triagem concluída!=====");
        }  

       else if(escolha == 2)
        {
            executado = false;
            Console.WriteLine("Obriago pela consulta ");
        }

                else
                {
                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                }

                  Console.WriteLine("Programa encerrado");

    }
    
}
}