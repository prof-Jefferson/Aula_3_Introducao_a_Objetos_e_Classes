namespace SRC;

class Program
{
    static void Main(string[] args)
    {
        Animal meuGato = new Gato("Whiskers", 3);
        meuGato.ExibirInformacoes(); // Nome: Whiskers, Idade: 3
        meuGato.EmitirSom(); // Miau!

        Animal meuCachorro = new Cachorro("Rex", 5);
        meuCachorro.ExibirInformacoes(); // Nome: Rex, Idade: 5
        meuCachorro.EmitirSom(); // Au au!
    }
}
