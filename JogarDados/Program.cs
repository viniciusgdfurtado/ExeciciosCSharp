using System.Collections;
using System.Reflection.Metadata;

namespace JogarDados
{
    class Jogador{
        public string Nome { get; set; }
        public int Pontuacao { get; set; } 
        public int ValorRodada { get; set; }          
    }

    class Partida{
        public int qtdJogadores = 2; 
        public int qtdRodadas = 3;
        public int qtdFacesDados = 6;
    }
    
    class Program{                        
        static void Main(string[] args){        
            IniciarJogo(new Partida());
        }   

        static int RolarDados(int qtdFaces){
            Random random = new Random();            
            return random.Next(1, qtdFaces++);
        }

        static void IniciarJogo(Partida partida){
            Console.WriteLine("=============================== Jogar Dados ===============================");
            List<Jogador> jogadores = new List<Jogador>();
            for (int i = 0; i < partida.qtdJogadores; i++)
            {
               Jogador jogador = new Jogador();
               Console.Write($"Digite o nome do Jogador {i + 1}: ");               
               jogador.Nome = Console.ReadLine();
               jogadores.Add(jogador);
            }
            Console.WriteLine("");

            for (int i = 0; i < partida.qtdRodadas; i++)
            {
                Jogador maiorValor = new Jogador();
                maiorValor.ValorRodada = 0;
                bool Empatada = false;
                
                Console.WriteLine($"================================= Rodada {i+1} =================================");
                foreach (Jogador jogador in jogadores)
                {
                    jogador.ValorRodada = RolarDados(partida.qtdFacesDados);   

                    if (maiorValor.ValorRodada == jogador.ValorRodada){
                        Empatada = true;
                        Console.WriteLine($"Rodada Empatada com valor: {maiorValor.ValorRodada}");
                        Console.WriteLine("Pressione Enter para a Próxima rodada.");
                        Console.ReadLine();                         
                        continue;   
                    }

                    if (maiorValor.ValorRodada < jogador.ValorRodada){
                        maiorValor = jogador;
                    }                        

                }    

                if (!Empatada) {
                    maiorValor.Pontuacao++;
                    Console.WriteLine($"Vencedor da rodada foi {maiorValor.Nome} com valor: {maiorValor.ValorRodada}.");                               
                    Console.WriteLine("Pressione Enter para a Próxima rodada.");
                    Console.ReadLine();     
                }
            }

            Jogador vencedor = new Jogador();
            bool partidaEmpatada = false;

            foreach (Jogador jogador in jogadores)
            {                  
                if (vencedor.Pontuacao < jogador.Pontuacao){
                    vencedor = jogador;
                } 
                else if (vencedor.Pontuacao == jogador.Pontuacao){
                    partidaEmpatada = true;
                }

            }    
            
            Console.WriteLine("=============================== Resultado da Partida =======================");
            if (!partidaEmpatada) {                
                Console.WriteLine($"Vencedor da partida foi {vencedor.Nome} com pontuação de: {vencedor.Pontuacao}.");                                                               
            }   
            else{
                Console.WriteLine($"A partida foi encerrada em empate.");                                                               
            }
            Console.WriteLine("============================================================================");
            return;
        }

    
    }

}