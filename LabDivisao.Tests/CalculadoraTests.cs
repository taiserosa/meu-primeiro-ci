namespace LabDivisao.Tests;

using LabDivisao.App;

public class CalculadoraTests
{
    [Fact]
    public void Dividir_DeveRetornarOResultadoDaDivisao_QuandoReceberDoisNumeros()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Dividir(10, 2);

        // Assert
        Assert.Equal(5, resultado);
    }
}
