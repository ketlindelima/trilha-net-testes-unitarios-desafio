// Seção de testes

using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista validater = new ValidacoesLista();

var lista = new List<int> { 5, 7, 8, 9 };
var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

var result = validater.MultiplicarNumerosLista(lista, 2);
foreach (var item in result)
{
    Console.WriteLine(item);
}