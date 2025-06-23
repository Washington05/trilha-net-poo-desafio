namespace DesafioPOO.Models
{
    // Implementado"
    public class Nokia : Smartphone
    {
      public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo no Nokia");
            Console.WriteLine($"Nome do aplicativo: {nomeApp}");
        }
    }
}