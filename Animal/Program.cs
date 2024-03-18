class Program
{
    static void Main(string[] args)
    {
        Animal animalGenerico = new Animal();
        animalGenerico.ExibirInformacoes(); // Saída: Eu sou um animal.
        animalGenerico.EmitirSom(); // Saída: Este animal faz um som.

        Gato meuGato = new Gato();
        meuGato.ExibirInformacoes(); // Saída: Eu sou um animal.
        meuGato.EmitirSom(); // Saída: Miau!

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.ExibirInformacoes(); // Saída: Eu sou um animal.
        meuCachorro.EmitirSom(); // Saída: Au au!
    }
}
