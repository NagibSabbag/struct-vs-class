using System;
using System.Diagnostics;
using StructProject;
using ClassProject;

// Teste com struct
PontoStruct p1 = new PontoStruct(3, 4);
PontoStruct p2 = new PontoStruct(6, 8);
Console.WriteLine($"Distância entre pontos (struct): {p1.Distancia(p2)}");

// Teste com class
PontoClass c1 = new PontoClass(3, 4);
PontoClass c2 = new PontoClass(6, 8);
Console.WriteLine($"Distância entre pontos (class): {c1.Distancia(c2)}");

// Comparação de performance
Stopwatch sw = new Stopwatch();
int tamanho = 1000000;

// Struct Test
sw.Start();
PontoStruct[] pontosStruct = new PontoStruct[tamanho];
for (int i = 0; i < tamanho; i++)
{
   pontosStruct[i] = new PontoStruct(i, i);
}
sw.Stop();
Console.WriteLine($"Tempo com struct: {sw.ElapsedMilliseconds} ms");

// Class Test
sw.Restart();
PontoClass[] pontosClass = new PontoClass[tamanho];
for (int i = 0; i < tamanho; i++)
{
   pontosClass[i] = new PontoClass(i, i);
}
sw.Stop();
Console.WriteLine($"Tempo com class: {sw.ElapsedMilliseconds} ms");