namespace dare.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get; set; }
        private string IMEI {get; set; }
        private int Memoria {get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }

        public string GetModelo()
        {
            return Modelo;
        }

        public string GetIMEI()
        {
            return IMEI;
        }

        public int GetMemoria()
        {
            return Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}