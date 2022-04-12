using System;

namespace lista_oito_logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat, choose, age;
            string name;

            do
            {
                Console.Write("Entre com qual exercício deseja verificar: "); choose = int.Parse(Console.ReadLine());

                switch(choose) 
                {
                    case 1:

                        Console.Write("Entre com seu nome: "); name = Console.ReadLine();
                        Console.Write("Entre com sua idade: "); age = int.Parse(Console.ReadLine());

                        Mensagem(name, age);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Deseja fazer algum outro exercício: "+
                "1 - Sim "+
                "2 - Não ")

            } while (repeat != 2);
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
        public static float Media(params int[] values)
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
        public static int Repetition(int[] values = new int[10], int num)
        {
            int count = 0; // Variável do método

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
        public static int LePositivos(int num1, int num2, int num3, int num4, int num5)
        {
            // Vetores do método
            int[] numbers = new int[] { num1, num2, num3, num4, num5};
            int[] sumNums = new int[numbers.Length];

            // For para percorrer os vetores e realizar a somatoria
            for (int i = 0; i < numbers.Length; i++)
            {
                sumNums[i] = Somatorio(numbers[i]);
            }

            return sumNums; // Retorno do método
        }

        public static int Somatorio(int num)
        {
            int sum = 0; // Váriavel do método que será retornado

            // For para realizar a soma dos valores de num e inferiores
            for(int i = num; i >= 1; i--)
            {
                sum += i;
            }

            return sum; // Retorno do método
        }

        // Método para a sétima questão
        public static int 
    }
}
 