namespace Soma_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            inicia();                        
        }

        static void Somar(List<decimal> lista){
            decimal soma = 0;
            foreach (var numero in lista)
            {
                soma += numero;    
            }
            Console.WriteLine($"O Total das somas dos valores é: {soma}.");
        }

        static void Media(List<decimal> lista){
            decimal media = 0; 
            foreach (var numero in lista)
            {
                media += numero;    
            }           
            media = media / lista.Count();
            Console.WriteLine($"O Total da média dos valores é: {media}.");
        }

        static void inicia(){
            Console.WriteLine("=============================================================="); 
            Console.Write("Informe a quantidade de números a serem informados: ");
            int.TryParse(Console.ReadLine(), out int qtdNumeros);

            if (qtdNumeros < 3 || qtdNumeros > 10){
                Console.WriteLine("A Quantidade de números deve estar entre 3 e 10.");  
                return;      
            }

            List<decimal> numeros = new List<decimal>();
            for (int i = 0; i < qtdNumeros; i++)
            {
                Console.Write($"Informe o número {i + 1}: "); 
                decimal.TryParse(Console.ReadLine(), out decimal numero);
                numeros.Add(numero);
            }
            
            Console.WriteLine("==============================================================");
            Somar(numeros);
            Media(numeros);
            Console.WriteLine("=============================================================="); 
        }

    }

}