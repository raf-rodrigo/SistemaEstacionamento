namespace SistemaEstacionamento.Model;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar: ");
        string placaVeiculo = Console.ReadLine();
        veiculos.Add(placaVeiculo);
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover: ");
        string placaVeiculo = Console.ReadLine();

        if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper()))
        {
            Console.WriteLine("Digite o números de horas que o carro ficou estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = precoInicial + precoPorHora * horas;

            veiculos.Remove(placaVeiculo);
            Console.WriteLine($"Foi dado baixa no carro placa {placaVeiculo}, e o preço total é de R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, veículo não encontrado. Confira se digitou a placa corretamente.");
        }
    }

    public void ListarVeiculo()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são: ");
            foreach (var VARIABLE in veiculos)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
    
    
}