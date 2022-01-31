using static System.Console;

class Aula2
{
    static void Main ()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Loui";
        p1.Idade = 22;
        p1.EnderecoPessoa = new Endereco()
        {
            Logradouro = "Rua Santo Antonio ",
            Numero = 881,
            CEP =" 8888-888",
            Cidade = "Curitiba"
        };

        WriteLine("Fim");
    }
}

