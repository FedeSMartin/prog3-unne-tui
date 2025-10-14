namespace practica10sep.Core
{
    public class Caja : Paquete
    {
 
        public Caja(double volumen, double peso, double distancia, double costoKm) 
            :base(volumen,peso,distancia,costoKm)
        {
            
        }

        public override double CalculoEnvio()
        {
            double costoEnvio = Distancia * costoPorKM;

            return costoEnvio;
        }
    }
}
