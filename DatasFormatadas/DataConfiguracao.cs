using System;
using System.Globalization;
class DataConfiguracao
{
    private int OpcaoFormatacao;
    private string ValorDataFormatada;    

    public void MenuInicial()
    {
        Console.WriteLine("=========================================================");
        Console.WriteLine("1 - Utilizar minha configuração de sistema.");
        Console.WriteLine("2 - Formato simples.");
        Console.WriteLine("3 - Formato longo.");
        Console.WriteLine("4 - Formato longo personalizado.");
        Console.WriteLine("5 - Formato RFC1123 pattern.");
        Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out int formato);
        DefineFormatacao(formato);
        Console.WriteLine("=========================================================");
    }

    public void MenuDatasEspeciais()
    {
        string[] DatasEspeciais = new string[3];
        DatasEspeciais[0] = "(ENIAC) - 15 de agosto de 1946 No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.";
        DatasEspeciais[1] = "(RFC1) - 17 de abril de 1969 Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.";
        DatasEspeciais[2] = "(Alan Turing) - 23 de junho de 1912 Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o 'pai da informática' por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.";
        
        Console.WriteLine("=========================================================");
        Console.WriteLine("1- ENIA.C");
        Console.WriteLine("2- RFC1.");
        Console.WriteLine("3- Alan Turing.");
        Console.Write("Escolha: ");
        int.TryParse(Console.ReadLine(), out int indicedata);
        Console.WriteLine("=========================================================");

        switch (indicedata)
        {
            case 1: 
                {
                    Console.WriteLine($"Data Especial: {DatasEspeciais[0]}");
                    break;
                }
            case 2: 
                {
                    Console.WriteLine($"Data Especial: {DatasEspeciais[1]}");
                    break;
                }
            case 3: 
                {
                    Console.WriteLine($"Data Especial: {DatasEspeciais[2]}");
                    break;
                }
            default:
                {
                    Console.WriteLine($"Data Especial selecionada é inválida.");
                    break;
                }
        }        
        
        Console.WriteLine("=========================================================");
    }   

    public void DefineFormatacao(int formato)
    {
        OpcaoFormatacao = formato;
    }

    public void FormataData()
    {
        DateTime data = new DateTime();
        data = DateTime.Now;

        switch (this.OpcaoFormatacao)
        {
            case 1:
                {
                    ValorDataFormatada = data.ToString();
                    break;
                }
            case 2:
                {
                    ValorDataFormatada = String.Format("{0:dd-MM-yy}", data);
                    break;
                }
            case 3:
                {
                    ValorDataFormatada = data.ToLongDateString();
                    break;
                }
            case 4:
                {
                    ValorDataFormatada = String.Format("{0:dd-MM-yyyy HH:mm:ss}", data);
                    break;
                }
            case 5:
                {
                    ValorDataFormatada = DateTime.UtcNow.ToString(CultureInfo.CreateSpecificCulture("pt-BR"));
                    break;
                }
            default:
                {
                    throw new Exception("Formatação não definida, escolha uma opção válida.");
                }
        }

        Console.WriteLine($"Data Formatada: {ValorDataFormatada}");
        Console.WriteLine("=========================================================");
        MenuDatasEspeciais();
    }

}