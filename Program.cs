using System.Diagnostics;

Console.WriteLine("Hello, World!");

// array => lista
// tupla => struct => struct record
// array: comprimento fixo, homogêneo e é contíguo na memória
// []: array (arranjo, vetor)
int[] idades = new int[5];
// Memória RAM
// [0,0,0,_,_,.......,_,0] = 160bits
// 0-31,32-63,64-95,96-...
Console.WriteLine(idades.Length); // 5
Console.WriteLine(idades[0]);
idades[0] = 49;
idades[1] = 25;

// homogêneo (mesmo tipo)
double[] notas = [7.5, 10, 6]; // array literal

foreach (var nota in notas) Console.WriteLine(nota);

for (var i = 0; i < notas.Length; i++)
{
    Console.WriteLine(notas[i]);
}

// Tupla (tuple)
// int[] avaliacoes = [7, 2];
(int, int) avaliacao = (7, 2);

Console.WriteLine(avaliacao.Item1); // 7
Console.WriteLine(avaliacao.Item2); // 2
// tamanho fixo
(double primeiroBi, double segundoBi) frequencia = (79.0, 98.0);

Console.WriteLine(frequencia.segundoBi);
// heterogênea, poucos atributos, não é posicional
(string nome, int matricula) aluno = ("Lizandro", 202582832);

Console.WriteLine
    ($"Nome: {aluno.nome}, Matricula: {aluno.matricula}");

// Lista (list), homogênea, tamanho variável (crescer)
// Parâmetro de Tipo
List<decimal> depositos1 = new List<decimal>();
var depositos2 = new List<decimal>();
List<decimal> depositos3 = new();
List<decimal> depositos4 = [];
// indexada, tamanho variável, homogênea, ordenada
Console.WriteLine(depositos4.Count); // 0
depositos4.Add(234.2M);
depositos4.Add(733);
Console.WriteLine(depositos4[0]); // 234.2
depositos4.RemoveAt(0);
// depositos4.Clear();

depositos4.Add(1823);
depositos4.Add(54);
depositos4.Add(893);
depositos4.Add(234);

foreach (var d in depositos4)
{
    Console.WriteLine($"Depósito de {d:0.00}");
}

var resultado = Estatistica.Amplitude(depositos4);
// posicional
Console.WriteLine($"Mínimo: {resultado[0]}");
Console.WriteLine($"Máximo: {resultado[1]}");
Console.WriteLine($"Amplitude: {resultado[2]}");

var resultado2 = Estatistica.AmplitudeV2(depositos4);
// posicional
Console.WriteLine($"Mínimo: {resultado2.Minimo}");
Console.WriteLine($"Máximo: {resultado2.Maximo}");
Console.WriteLine($"Amplitude: {resultado2.Amplitude}");

Dispersão resultado3 = Estatistica.AmplitudeV3(depositos4);
// posicional
Console.WriteLine($"Mínimo: {resultado3.Mínimo}");
Console.WriteLine($"Máximo: {resultado3.Máximo}");
Console.WriteLine($"Amplitude: {resultado3.Amplitude}");

Console.WriteLine(resultado3);

/*
var a1 = new Altura { Centimetros = 172 };
var a2 = new Altura { Centimetros = 187 };
var a3 = new Altura { Centimetros = 172 };

Console.WriteLine(a1 == a2);
Console.WriteLine(a1 == a3);

struct Altura
{
    public int Centimetros;
}
*/
