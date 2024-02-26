using SistemaEstacionamento.Model;

//encoding de caracteres para UTF-8 para exibir as acentuações
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + 
                  "Digite o preço inicial do estacionamento: R$ ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor do preço por hora de estacionamento R$: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

//Instanciando a classe estaciomanento, e passando os parâmetrod recebidos
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

//Realiza o loop do meu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a opção");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículo");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3" :
            estacionamento.ListarVeiculo();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("Precione uma tecla para continuar");
        Console.ReadLine();        
    }

}

Console.WriteLine("Obrigado por utilizar o nosso Sistema");
Console.WriteLine("Encerrando o programa.");