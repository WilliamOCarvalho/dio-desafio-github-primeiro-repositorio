using static System.Console;

public class program 
{
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O Valor da variavel a é {a}");

    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
 
    public static void Main()
    {
      Pessoa p1 = new Pessoa();
      p1.Nome = "William";
      p1.Idade = 32;
      p1.Documento = "1234";

      TrocarNome(p1, "José");

      WriteLine($"O novo nome é :{p1.Nome}");

    }

}

