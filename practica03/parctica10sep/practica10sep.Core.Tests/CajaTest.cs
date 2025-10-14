namespace practica10sep.Core.Tests
{
    public class CajaTest
    {
        [Fact]
        public void CalcularCostoEnvio_Volumen1500Peso850Distancia30_Resultado1500()
        {
            var cajaChica = new Caja(1500, 850, 90, 150);

            Assert.Equal(7500, cajaChica.CalculoEnvio());

        }
    }
}
