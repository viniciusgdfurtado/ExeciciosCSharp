using System.Runtime.CompilerServices;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();            
        }

    static void Sum(){
        Console.Write("Digite o primeiro valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x1);

        Console.Write("Digite o segundo valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x2);

        Console.Write($"O resultado da sua Soma ({x1} + {x2}) é: {x1 + x2}");        
        Console.WriteLine("\n=================================");  
        Menu();
    }

    static void Subtract(){
        Console.Write("Digite o primeiro valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x1);

        Console.Write("Digite o segundo valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x2);

        Console.Write($"O resultado da sua Subtração ({x1} - {x2}) é: {x1 - x2}");            
        Console.WriteLine("\n=================================");  
        Menu();
    }

    static void Multiply(){
        Console.Write("Digite o primeiro valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x1);

        Console.Write("Digite o segundo valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x2);

        Console.Write($"O resultado da sua Multiplicação ({x1} * {x2}) é: {x1 * x2}");          
        Console.WriteLine("\n=================================");  
        Menu(); 
    }

    static void Division(){
        Console.Write("Digite o primeiro valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x1);

        Console.Write("Digite o segundo valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x2);

        if (x2 == 0) {
            Console.WriteLine("Não é possível realizar a divisão por 0");                    
        }
        else
        {
            Console.Write($"O resultado da sua Dividisão ({x1} / {x2}) é: {x1 / x2}");                
        }    
        Console.WriteLine("\n=================================");  
        Menu();
    }

    static void Modulo(){
        Console.Write("Digite o primeiro valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x1);

        Console.Write("Digite o segundo valor: ");
        decimal.TryParse(Console.ReadLine(), out decimal x2);

        if (x2 == 0) {
            Console.WriteLine("Não é possível realizar o módulo por 0");                    
        }
        else
        {
            Console.Write($"O resultado do Resto da sua Dividisão ({x1} % {x2}) é: {x1 % x2}");                
        }  
        Console.WriteLine("\n=================================");  
        Menu();
    }    

    static void Pow(){
        Console.Write("Digite o primeiro valor: ");
        long.TryParse(Console.ReadLine(), out long x1);

        Console.Write("Digite o segundo valor: ");
        long.TryParse(Console.ReadLine(), out long x2);        
        
        if (x2 == 0) {
            Console.WriteLine("Não é possível realizar o módulo por 0");                    
        }
        else
        {
            Console.Write($"O resultado da sua Exponenciação ({x1} ^ {x2}) é: {Math.Pow(x1, x2)}");                
        }    
        Console.WriteLine("\n=================================");
        Menu();       
    }

        public static void Menu()
        {               
            Console.WriteLine("\n============ Menu ============");                  
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("=================================");
            Console.Write("Selecione uma Opção: ");
            int.TryParse(Console.ReadLine(), out int opcao);

            if (opcao.Equals(0)){
                return;
            }

            switch (opcao)
            {
                case 1: 
                    Sum();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Modulo();
                    break;                
                case 6:
                    
                    break;
                default: return;
            }
        }
    }

}

