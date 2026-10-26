namespace LabDivisao.App;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o dividendo: ");
        var dividendo = decimal.Parse(Console.ReadLine()!);

        Console.Write("Digite o divisor: ");
        var divisor = decimal.Parse(Console.ReadLine()!);

        var calculadora = new Calculadora();
        var resultado = calculadora.Dividir(dividendo, divisor);

        Console.WriteLine($"Resultado: {resultado}");
    }
}