using TDD_semana05;

namespace CalculadoraTddTeste
{
    public class TesteCalculadora                   //Criada Classe TEsteCalculadora
    {
        //ADICAO
        [Fact]
        public void TestarAdicaoInt()               //Criado método para testar Adicão
        {
            int resultado = Calculadora.Adicao(5, 5);               //variável Resultado recebe a chamada de metodo Adição da classe Calculadora

            int esperado = 10;              //variável Esperado recebe do usuário o valor que deve aparecer no resultado

            Assert.Equal(esperado, resultado);              //Comparamos se o valor Esperado é igual ao Resultado
        }

        [Fact]
        public void TestarAdicaoDouble()
        {
            double resultado = Calculadora.Adicao(0.5, 0.5);

            double esperado = 1;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarAdicaoFloat()
        {
            float resultado = Calculadora.Adicao(5.6f, 5.6f);

            float esperado = 11.2f;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarAdicaoDecimal()
        {
            decimal resultado = Calculadora.Adicao(4.7M, 4.7M);

            decimal esperado = 9.4M;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarAdicaoLong()
        {
            long resultado = Calculadora.Adicao(30001L, 30009L);

            long esperado = 60010;

            Assert.Equal(esperado, resultado);
        }
        

        
        //SUBTRAÇÂO
        [Fact]
        public void TestarSubtracaoInt() 
        {
            int resultado = Calculadora.Subtracao(15, 5);

            int esperado = 10;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarSubtracaoDouble()
        {
            double resultado = Calculadora.Subtracao(0.9, 0.2);

            double esperado = 0.7;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarSubtracaoFloat()
        {
            float resultado = Calculadora.Subtracao(15.55F, 7.05F);

            float esperado = 8.5F;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarSubtracaoDecimal()
        {
            decimal resultado = Calculadora.Subtracao(11.599M, 5.590M);

            decimal esperado = 6.009M;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarSubtracaoLong()
        {
            long resultado = Calculadora.Subtracao(56789L, 54321L);

            long esperado = 2468L;

            Assert.Equal(esperado, resultado);
        }




        //MULTIPLICACAO
        [Fact]
        public void TestarMultiplicacaoInt()              //Criado método para testar Multiplicação
        {
            int resultado = Calculadora.Multiplicacao(5, 5);

            int esperado = 25;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarMultiplicacaoDouble()
        {
            double resultado = Calculadora.Multiplicacao(4.5, 4.5);

            double esperado = 20.25;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarMultiplicacaoFloat()
        {
            float resultado = Calculadora.Multiplicacao(0.9F, 0.5F);

            float esperado = 0.45F;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarMultiplicacaoDecimal()
        {
            decimal resultado = Calculadora.Multiplicacao(5.608M, 10.5M);

            decimal esperado = 58.884M;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarMultiplicacaoLong()
        {
            long resultado = Calculadora.Multiplicacao(9999999L, 9563L);

            long esperado = 95629990437L;

            Assert.Equal(esperado, resultado);
        }




        //DIVISAO
        [Fact]
        public void TestarDivisaoInt()              //Criado método para testar Divisão
        {
            int resultado = Calculadora.Divisao(515, 5);

            int esperado = 103;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarDivisaoDouble()
        {
            double resultado = Calculadora.Divisao(50, 5);

            double esperado = 10;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarDivisaoFloat()
        {
            float resultado = Calculadora.Divisao(3.003F, 3F);

            float esperado = 1.001F;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarDivisaoDecimal()
        {
            decimal resultado = Calculadora.Divisao(5628.908M, 2.2M);

            decimal esperado = 2558.5945454545454545454545455M;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TestarDivisaoLong()
        {
            long resultado = Calculadora.Divisao(8461328479413266L, 8L);

            long esperado = 1057666059926658L;

            Assert.Equal(esperado, resultado);
        }


        [Fact]
        public void TestarMetodoNumeroPrimo()
        {
            bool result = ValidadorDeNumeros.ENumeroPrimo(5);

            Assert.True(result);
        }

        [Fact]
        public void TestarMetodoParOuImpar()
        {
            bool result = ValidadorDeNumeros.ParOuImpar(10);

            Assert.True(result);
        }

        [Fact]
        public void TestarNetodoDivisivelPor()
        {
            bool result = ValidadorDeNumeros.DivisivelPor(9, 3);

            Assert.True(result);
        }
    }
}