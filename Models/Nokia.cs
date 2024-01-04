namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado com sucesso no seu Nokia");
        }

        public override void Ligar()
        {
            Console.WriteLine($"O Nokia do modelo {Modelo} está fazendo uma ligação...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine($"O {Modelo} está recebendo uma ligação...");
        }
    }
}