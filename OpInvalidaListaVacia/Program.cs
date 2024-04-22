using OpInvalidaListaVacia.Clases;

ManejadorLista listaObj = new ManejadorLista();

try
{

    listaObj.InsertarElemento(20);
    listaObj.InsertarElemento(100);
    listaObj.InsertarElemento(55);
    listaObj.InsertarElemento(79);


    listaObj.EliminarElemento();
    listaObj.EliminarElemento();
    listaObj.EliminarElemento();
    listaObj.EliminarElemento();
    listaObj.EliminarElemento();

}
catch (InvalidOperationException ex)
{
	Console.WriteLine(ex.Message);
}




