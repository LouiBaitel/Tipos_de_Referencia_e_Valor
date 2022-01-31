
using static System.Console;
public class Program
{
    static void Demo6()
    {
        
        int[] numeros = new int[] {0, 2, 4, 6, 8};
        WriteLine($"Digite o numero que deseja encontrar");

        var numero  = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        
        if (idxEncontrado >= 0)
        {
            WriteLine($"O numero digitado está na posição {idxEncontrado} ");
        }
        else{
            WriteLine("O número digitado não foi encontrado..");
        }
        
    }
    static void Demo5()
    {
        int[] pares = new int[] {0, 2, 4, 6, 8};

        MudarParaImpar(pares);

        WriteLine($"Os impares {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Loui";

        TrocarNome(nome, "Nico");
        WriteLine($"O novo nome é {nome} ");
    }

    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Idade = 22,
            Nome = "Antonio",
            Documento = "1234"
        };

        var p2 = p1;

        p1 = TrocarNome (p1, "João");

        WriteLine($@"
            O nome da pessoa 1 é: {p1.Nome}
            O nome da pessoa 2 é: {p2.Nome}
        ");
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Loui";
        p1.Idade = 22;
        p1.Documento = "666";

        Pessoa p2 = p1.Clone();
       
        TrocarNome(p1, "Nico");

        //Utilizar o @ permite que o espaçamento incluido seja printado
        WriteLine($@"
        O nome da pessoa 1 é: {p1.Nome}
        O nome da pessoa 2 é: {p2.Nome}
        ");
    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variável é {a}"); //Como o system.console foi usado no inicio, pode-se abreviar
    }
    static int Adicionar20(int x)
    {
        return x = x + 20;
    }

    static void TrocarNome (Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }

    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
            return i;
        }
        return -1;
    }

    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if (item.Equals(pessoa))
            {
                return true;
            }
        }
        return false;
    }
    public static void Main ()
    {
        List<StructPessoa> pessoas = new List<StructPessoa>()
        {
            new StructPessoa(){Nome = "Loui"},
            new StructPessoa(){Nome = "Nico"},
            new StructPessoa(){Nome = "Alexia"},
            new StructPessoa(){Nome = "Daniel"},
            new StructPessoa(){Nome = "Barbara"},
            new StructPessoa(){Nome = "Kelvin"},
            new StructPessoa(){Nome = "Belinha"}
        };

        WriteLine("Digite a pessoa que deseja encontrar");

        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if(encontrado)
        {
            WriteLine("Pessoa Localizada!");
        }
        else{
            WriteLine("Pessoa não localizada :/");
        }


    }
}