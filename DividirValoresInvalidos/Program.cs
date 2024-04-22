

static double DividirNumero(int numerador, int denominador)
{
    if (numerador < 0 || denominador < 0)
    {
        throw new ArgumentException("Un numero es negativo.");
    }

    if (denominador == 0)
    {
        throw new DivideByZeroException("El denominador no puede ser cero.");
    }

    return numerador / denominador;
}



try
{
    Console.WriteLine($"Resultado: {DividirNumero(20, 10)}");
    Console.WriteLine($"Resultado: {DividirNumero(-20, 5)}");

}
catch (ArgumentException ex)
{

    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}