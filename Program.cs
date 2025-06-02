Console.Clear();

int contador = 0;
int numero;
int resultado;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine()!);

while (contador <= 10)
{
    resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado}");
    contador++;
}
