namespace DesafioFundamentos.Models
{
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

        // Método para adicionar um veículo
        public void AdicionarVeiculo()
        {
            // Solicita a placa ao usuário e adiciona à lista de veículos
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();  // Armazena a placa
            veiculos.Add(placa);  
            // Adiciona a placa à lista
            Console.WriteLine($"Veículo com placa {placa} adicionado.");
        }

        // Método para remover um veículo
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();  // Armazena a placa digitada

            // Verifica se o veículo está estacionado
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());  // Armazena o tempo de permanência

                // Calcula o valor total: precoInicial + precoPorHora * horas
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Remove o veículo da lista
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        // Método para listar os veículos
        public void ListarVeiculos()
        {
            // Verifica se há veículos estacionados
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                // Exibe todos os veículos na lista
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
