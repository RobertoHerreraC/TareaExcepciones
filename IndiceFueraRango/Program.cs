using IndiceFueraRango.Clases;

int[] numeros = { 20, 15, 62, 55 };

Arreglo arregloObj = new Arreglo(numeros);

try
{
	Console.WriteLine($"Indice: 1 valor: {arregloObj.ObtenerElemento(1)}");
    Console.WriteLine($"Indice: 3 valor: {arregloObj.ObtenerElemento(3)}");
    Console.WriteLine($"Indice: 10 valor: {arregloObj.ObtenerElemento(10)}");
}
catch (IndexOutOfRangeException ex)
{

	Console.WriteLine(ex.Message);
}