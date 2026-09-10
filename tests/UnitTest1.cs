using BhaskaraApp;

namespace BhaskaraApp.test
{
    public class UnitTest1
    {
        // TESTES DO MÉTODO TemRaizesReais()

        [Fact]
        public void TemRaizesReais_DeltaPositivo_DeveRetornarTrue()
        {
            var bhaskara = new Bhaskara(1, -3, 2);

            Assert.True(bhaskara.TemRaizesReais());
        }

        [Fact]
        public void TemRaizesReais_DeltaZero_DeveRetornarTrue()
        {
            var bhaskara = new Bhaskara(1, -4, 4);

            Assert.True(bhaskara.TemRaizesReais());
        }

        [Fact]
        public void TemRaizesReais_DeltaNegativo_DeveRetornarFalse()
        {
            var bhaskara = new Bhaskara(1, 2, 5);

            Assert.False(bhaskara.TemRaizesReais());
        }


        // TESTES DO MÉTODO CalcularRaizes()

        [Fact]
        public void CalcularRaizes_DuasRaizesDiferentes_DeveRetornar2e1()
        {
            var bhaskara = new Bhaskara(1, -3, 2);

            var (x1, x2) = bhaskara.CalcularRaizes();

            Assert.Equal(2, x1);
            Assert.Equal(1, x2);
        }

        [Fact]
        public void CalcularRaizes_DeltaZero_DeveRetornarDuasRaizesIguais()
        {
            var bhaskara = new Bhaskara(1, -4, 4);

            var (x1, x2) = bhaskara.CalcularRaizes();

            Assert.Equal(2, x1);
            Assert.Equal(2, x2);
        }

        [Fact]
        public void CalcularRaizes_DeltaNegativo_DeveRetornarNulo()
        {
            var bhaskara = new Bhaskara(1, 2, 5);

            var (x1, x2) = bhaskara.CalcularRaizes();

            Assert.Null(x1);
            Assert.Null(x2);
        }
    }
}
