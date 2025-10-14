namespace practica10sep.Core
{
    public class Sobre
    {
        public double Volumen { get; }
        public double Peso { get; }
        public int Distancia { get; }

        public double costoPorKM = 150;
            
        public Sobre(double volumen, double peso, int distancia)
        {
            Volumen = volumen;
            Peso = peso;
            Distancia = distancia;
        }

        public double CalculoEnvio()
        {
            double costoEnvio = Distancia * costoPorKM;

            return costoEnvio;
        }

    }
}
