using static System.Console;

Numero a = new Numero(2);
Numero b = new Numero(2);

if ( a.N == b.N ) // com ( a == b ) estariamos comparando somente as referência, e não os valores
{
    WriteLine($"a e b são iguais");
}
else
{
    WriteLine ($"a e b são diferentes");
}

class Numero
{
    public int N { get; set; }

    public Numero(int n)
    {
        N = n;
    }
}