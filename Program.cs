using System;

namespace lista_oito_logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat, choose;

            Console.WriteLine("----------------------------------------------------------------------\n");
            Console.WriteLine("                       Lista de Exercícios "); 
            Console.WriteLine("----------------------------------------------------------------------\n");

            do
            {
                Console.WriteLine("----------------------------------------------------------------------\n");
                Console.Write("Entre com qual exercício deseja verificar: "); choose = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------------\n");

                switch(choose) 
                {
                    case 1:
                        string name;
                        int age;

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #1\n");

                        Console.Write("Entre com seu nome: "); name = Console.ReadLine();
                        Console.Write("Entre com sua idade: "); age = int.Parse(Console.ReadLine());

                        Message(name, age);

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    case 2:
                        string secondName, lastName, fullName;

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #2\n");

                        Console.Write("Entre com seu nome: "); name = Console.ReadLine();
                        Console.Write("Entre com seu nome: "); secondName = Console.ReadLine();
                        Console.Write("Entre com seu nome: "); lastName = Console.ReadLine();

                        fullName = FullName(name, secondName, lastName);

                        Console.WriteLine($"O seu nome completo é {fullName}");

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    case 3:
                        int password;
                        bool passwordConfirmed;

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #3\n");

                        Console.Write("Informe a senha: "); password = int.Parse(Console.ReadLine());
                        passwordConfirmed = PasswordVerified(password);
                        Console.WriteLine();

                        if(passwordConfirmed == true)
                        {
                            Console.WriteLine("Acesso Concedido!");
                        }
                        else
                        {
                            Console.WriteLine("Acesso Negado!");
                        }

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    case 4:
                        int arrayLength, value;
                        int[] array;
                        float media;

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #4\n");

                        Console.Write("Informe uma quantidade de valores: "); arrayLength = int.Parse(Console.ReadLine());
                        array = new int[arrayLength];

                        for (int i = 0; i < arrayLength; i++)
                        {
                            Console.WriteLine("Informe um valor: ");
                            array[i] = int.Parse(Console.ReadLine());
                        }

                        media = Media(array);

                        Console.WriteLine($"A média dos números informados é de {media.ToString("F2")}");

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    case 5:
                        int num, retorno;

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #5\n");

                        Console.Write("Informe qual número entre 1 à 10 que deseja verificar quantas vezes será repetido: "); num = int.Parse(Console.ReadLine());

                        retorno = Repetition(num);

                        Console.WriteLine($"O número repete um total de {retorno} vezes.");

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    case 6:
                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #6\n");

                        Console.Write("Informe um número para que sua soma seja retornada: "); num = int.Parse(Console.ReadLine());
                        retorno = Somatorio(num);

                        if (retorno == 0)
                        {
                            Console.WriteLine("Desculpe porém o número informado é negativo.");
                        }
                        else
                        {
                            Console.WriteLine($"A soma desse número é {retorno}");
                        }

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    case 7:
                        

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #7\n");

                        Triple();

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    case 8:
                        int birthDayYear;
                        string permission;

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        Console.WriteLine("Questão #8\n");

                        Console.Write("Entre com seu ano de nascimento: "); birthDayYear = int.Parse(Console.ReadLine());

                        permission = Confirm(birthDayYear);

                        Console.WriteLine($"{permission}.");

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                    default:
                        Console.WriteLine("----------------------------------------------------------------------\n");

                        Console.WriteLine("Questão não existente!");

                        Console.WriteLine("----------------------------------------------------------------------\n");
                        break;
                }

                Console.WriteLine("----------------------------------------------------------------------\n");
                // Condiconal de Repetição
                Console.WriteLine("Deseja fazer algum outro exercício: "+
                "1 - Sim "+
                "2 - Não ");
                repeat = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------------\n");

            } while (repeat != 2);

            Console.WriteLine("----------------------------------------------------------------------\n");

            Console.WriteLine("Fim do Programa.");

            Console.WriteLine("----------------------------------------------------------------------");
        }

        // Método para a primeira questão
        public static void Message(string name, int age)
        {
            Console.WriteLine($"Meu nome é {name} e minha idade é {age}");
        }

        // Método para a segunda questão
        public static string FullName(string name, string lastName, string secondLastName)
        {
            return $"{name} {lastName} {secondLastName}";
        }

        // Método para a terceira questão
        public static bool PasswordVerified(int password)
        {
            // Senha númerica padrão criada exclusivamente para este exercício
            if (password == 1234)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }

        // Método para a quarta questão 
        public static float Media(int[] values)
        {
            // Variáveis do método
            float media;
            int sum = 0; 

            // Percorre o vetor e soma os valores
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            media = sum / values.Length; // Cálculo para encontrar a média

            return media;
        }

        // Método para a quinta questão
        public static int Repetition(int num)
        {
            // Variáveis e vetores do método
            Random rand = new Random();
            int[] values = new int[10]; 
            int count = 0;

            // For para adicionar os valores ao vetor
            for(int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(1, 10);
            }

            // For para percorrer o vetor e verificar quantas vezes num repete
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == num)
                {
                    count++; // Acréscimo do count
                }
            }

            return count;
        }

        // Métodos para a sexta questão
        public static int LePositivos(int num)
        {
            // Verifica se o número informado é positivo
            if(num > 0)
            {
                return Somatorio(num);
            }
            else
            {
                return 0;
            }
        }

        public static int Somatorio(int num)
        {
            int sum = 0; // Váriavel do método que será retornado
            int otherNum = LePositivos(num); // Chamado do método para verificar se o npumero passsado é positivo

            // For para realizar a soma dos valores de num e inferiores
            for(int i = otherNum; i >= 1; i--)
            {
                sum += i;
            }

            return sum; // Retorno do método
        }

        // Método para a sétima questão
        // Pelas próprias orientações do professor a questão foi alterada de forma que fica mais simplificada
        public static void Triple()
        {
            Random rand = new Random();
            // Vetores do Método
            int[] tripleNumbers = new int[10];
            int[] nums = new int[10];

            // For para percorrer vetor e atribuir seu valores
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1,10);
            }

            // For para adicionar valores no vetor criado
            for(int i = 0; i < tripleNumbers.Length; i++)
            {
                tripleNumbers[i] = nums[i] * 3;
            }

            foreach (int i in tripleNumbers)
            {
                Console.WriteLine(tripleNumbers[i]); // impressão do vetor gerado pelo método
            } 
        }

        // Método para a oitava questão
        public static string Confirm(int birthdayYear)
        {
            DateTime date = DateTime.Now; // Pega a data atual

            // Verifica se a idade é maior que 18
            if((date.Year - birthdayYear) >= 18)
            {
                return "Permissão Concedida"; // Retorno caso verdadeiro
            }
            else
            {
                return "Sem Permissão"; // Retorno caso falso
            }
        }
    }
}
 