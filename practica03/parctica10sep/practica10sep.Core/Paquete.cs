namespace practica10sep.Core
{
    public abstract class Paquete
    {
        protected double Volumen { get; }
        protected double Peso { get; }
        protected double Distancia { get; }

        protected double costoPorKM;
            
        public Paquete(double volumen, double peso, double distancia, double costoKm)
        {
            Volumen = volumen;
            Peso = peso;
            Distancia = distancia;
            costoPorKM = costoKm;
        }

        public abstract double CalculoEnvio();

    }
}
