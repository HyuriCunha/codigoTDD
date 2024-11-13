using MeusTalentos;

namespace MeusTalentosTeste;

public class UnitTest1
{

    public Calculadora construirClasse()
    {
        string data = "02/02/2000";
        Calculadora calc = new Calculadora(data);
        return calc;
    }



    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }


    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(9, 5, 4)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }


    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }


    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(40, 5, 8)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }


    [Fact]
    public void TesteDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3, 0)
        );
    }


    [Fact]
    public void TesteHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(2, 2);
        calc.somar(3, 2);
        calc.somar(4, 2);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}