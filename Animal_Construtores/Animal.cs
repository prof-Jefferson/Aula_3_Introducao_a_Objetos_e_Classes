public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Este animal faz um som.");
    }
}
