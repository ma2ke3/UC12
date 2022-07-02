using UC12.Classes;

Console.Clear();
Console.WriteLine(@$"
.__________________________.
|                          |
|       Boas-vindas!       |
|   Sistema de Cadastro    |
| Pessoa Física / Jurídica |
.__________________________.
");
Carregamento ("Iniciando", 1000, 10);
string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
.__________________________.
|                          |
|    Escolha uma opção:    |
|                          |
|    1 -Pessoa Física      |
|    2 -Pessoa Jurídica    |
|                          |
|    0 - Sair              |
.__________________________.
");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.Nome = "Marco";
            novaPf.dataNasc = new DateTime(1995, 06, 14);
            novaPf.Cpf = "1234567890";
            novaPf.Rendimento = 3500.5f;

            novoEndPf.complemento = "SENAI informatica";
            novoEndPf.endComercial = true;
            novoEndPf.logradouro = "Alameda Barao de Limeira";
            novoEndPf.numero = 539;

            novaPf.Endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero} 
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}");

            Console.WriteLine($"Tecle ENTER para seguir");
            Console.ReadLine();
            break;
        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome PJ";
            novaPj.RazaoSocial = "Razão Social PJ";
            novaPj.Cnpj = "00.000.000/0001-00";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Alameda Barão de Limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "SENAI Informatica";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");
            // Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));

            Console.WriteLine($"Tecle ENTER para seguir");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por usar nosso sistema!");
            Thread.Sleep(3000);
            Carregamento ("Finalizando", 500, 6);
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida. Por favor, digite uma opção válida.");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");

static void Carregamento(string texto, int tempo, int quantidade)
{
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.Write(texto);
    for (var contador = 0; contador < quantidade; contador++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}