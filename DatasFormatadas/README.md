## <h2 align="center">:calendar: DatasFormatadas - C#</h2>
Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que listará algumas datas importante da área da técnologia, escolhar 5 datas ou utilize os sugeridos nos requisitos.

<p align="center">
  <img src="https://img.shields.io/static/v1?label=.Net&message=framework&color=blue&style=for-the-badge&logo=.Net"/>  
  <img src="https://img.shields.io/static/v1?label=CSharp&message=language&color=blue&style=for-the-badge&logo=CSharp"/>  
  <img src="http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=GREEN&style=for-the-badge"/>
</p>

## :bookmark: Requisitos:
<h3> Quando o usuário abrir a aplicação deve ser solicitado qual o formato de data ele deseja visualizar. Deve ser disponibilizada as formatações abaixo: </h3>

1 - Utilizar minha configuração de sistema: 08/01/2021 20:48:13 (Este item deve apenas converter a data para string, deixar que o sistema use o formato dele)
2 - Formato simples: 08-01-21
3 - Formato longo sexta-feira, 8 de janeiro de 2021
4 - Formato longo personalizado 08-01-2021 08:48:13
5 - Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT

Após seleção correta de uma opção exiba um segundo menu com as seguintes opções (ou use outras de sua escolha): 

1 - ENIAC 
2 - RFC1 
3 - Alan Turing

Ao escolher uma das opções o sistema deverá exibir para o usuário um cabeçalho com a data do evento e um texto com a descrição do evento. Abaixo você encontra as datas e textos dos eventos sugeridos acima:

(ENIAC) - 15 de agosto de 1946 No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.

(RFC1) - 17 de abril de 1969 Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.

(Alan Turing) - 23 de junho de 1912 Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o "pai da informática" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.

## :books: Funcionalidades
* <b>Formatar Data</b>: Esta funcionalidade permite a formatação das datas baseado na escolha do usuário.
* <b>Datas Especiais</b>: Esta funcionalidade apresenta um registro de data especial contida em um array.

## :rocket: Rodando o projeto
* Para rodar o repositório é necessário clonar o mesmo para a sua pasta de preferência;
* Ter o ambiente com a instalação do Dotnet mais recente. Para baixar a versão mais atual do Dotnet acesse o link: https://dotnet.microsoft.com/download
* Após a instalação podemos verificar se o dotnet foi instalado com sucesso verificando sua versão com o comando: dotnet --version (deve ser executado no PowerShell ou CMD)
* Acessar a pasta do projeto via CMD/PowerShell, onde foi clonado o repositório, e execute os comandos na sequência que é demonstrada abaixo.
  
1° - dotnet build: Compila um projeto e todas as suas dependências.

2° - dotnet run: Executa o código-fonte sem qualquer comando de compilação ou inicialização explícito.

Existem diversos outros comandos, vale a pena a leitura da coumentação, a qual pode ser encontrada em: https://docs.microsoft.com/pt-br/dotnet/core/tools/

## :handshake: Colaboradores
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/viniciusgdfurtado">
        <img src="https://avatars.githubusercontent.com/u/82420738?v=4" width="100px;" alt="Foto de Vinicius Furtado no GitHub"/><br>
        <sub>
          <b>viniciusgdfurtado</b>
        </sub>
      </a>
    </td>
  </tr>
</table>
