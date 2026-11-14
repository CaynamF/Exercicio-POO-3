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

// Atividade-3

JogoDigital jogoDigital = new JogoDigital("Minecraft","PC");
JogoFisico jogoFisico = new JogoFisico("God of War", "PlayStation 5");

jogoDigital.ExibirInformacoes();
jogoFisico.ExibirInformacoes();

// Atividade-4

Notificacao generico = new();
Notificacao email = new NotificacaoEmail();
Notificacao sms = new NotificacaoSMS();
Notificacao push = new NotificacaoPush();

generico.Enviar();
email.Enviar();
sms.Enviar();
push.Enviar();

// Atividade-5

Entrega expressa = new EntregaExpressa(100);
Entrega economico = new EntregaEconomica(100);
Entrega local = new RetiradaLocal(100);

List<Entrega> listaFrete = new()
{
    expressa,
    economico,
    local
};
foreach (var lista in listaFrete)
{
    Console.WriteLine($"Frete: {lista.CalcularFrete():C2}");
}