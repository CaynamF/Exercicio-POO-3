using Atividade_3;

// Atividade 1

Veiculo carro1 = new Carro()
{
    Marca = "Toyota",
    Modelo = "Corolla",
    QuantidadePortas = 4
};

Veiculo moto1 = new Motocicleta()
{
    Marca = "Honda",
    Modelo = "CB 500F",
    Cilindradas = 471
};

carro1.ExibirInformacoes();
moto1.ExibirInformacoes();

// Atividade 2

ProdutoDigital produto1 = new Ebook()
{
    Nome = "Harry Potter e a Pedra Filosofal",
    Preco = 49,
    QuantidadePaginas = 264
};

ProdutoDigital produto2 = new CursoOnline()
{
    Nome = "C#",
    Preco = 250,
    CargaHoraria = 200
};

produto1.ExibirInformacoes();
produto2.ExibirInformacoes();
