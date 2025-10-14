namespace practica10sep.Core.Tests
{
    public class sobreTest
    {
        [Fact]
        public void CalcularCostoEnvio_Volumen75Peso100Distancia10_Resultado1500()
        {
            var sobreChico = new Sobre(75, 100, 10, 150);

            Assert.Equal(1500, sobreChico.CalculoEnvio());

        }
    }
}
