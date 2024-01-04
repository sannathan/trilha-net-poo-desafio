namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public abstract void Ligar();
        
        public abstract void ReceberLigacao();
        
        public abstract void InstalarAplicativo(string nomeApp);
    }
}