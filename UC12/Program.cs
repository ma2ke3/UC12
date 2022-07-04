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
Carregamento("Iniciando", 100, 10);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

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
            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
.__________________________.
|                          |
|       PESSOA FÍSICA      |
|    Escolha uma opção:    |
|                          |
|    1 - Cadastrar         |
|    2 - Listar            |
|                          |
|    0 - Voltar            |
.__________________________.
");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da Pessoa Física");
                        novaPf.Nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();
                            dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                            if (dataValida)
                            {
                                DateTime DataConvertida;
                                DateTime.TryParse(dataNascimento, out DataConvertida);
                                novaPf.dataNasc = DataConvertida;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada inválida, por favor digitc uma data valida");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                        } while (dataValida == false);

                        Console.WriteLine($"Digite o numero do CPF");
                        novaPf.Cpf = Console.ReadLine();
                        Console.WriteLine($"Digite o rendimento mensal (apenas números)");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.logradouro = Console.ReadLine();
                        Console.WriteLine($"Digite o número");
                        novoEndPf.numero = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Digite o complemenlo (tecle ENTER para vazio)");
                        novoEndPf.complemento = Console.ReadLine();
                        Console.WriteLine($"Endereço é comercial? S/N");
                        string endcom = Console.ReadLine().ToUpper();
                        if (endcom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }
                        novaPf.Endereco = novoEndPf;

                        listaPf.Add(novaPf);

                        // StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        // sw.WriteLine(novaPf.Nome);
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.Nome}
                        // Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero} 
                        // Maior de idade: {(metodosPf.ValidarDataNasc(cadaPessoa.dataNasc) ? "Sim" : "Não")}
                        // Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
                        // ");
                        //                                 Console.WriteLine("Aperle ENTER para continuar");
                        //                                 Console.ReadLine();
                        //                             }
                        //                         }
                        //                         else
                        //                         {
                        //                             Console.WriteLine($"Lista vazia");
                        //                             Thread.Sleep(3000);
                        //                         }

                        using (StreamReader sr = new StreamReader("João.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();

                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida. Por favor, digite uma opção válida.");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }

            } while (opcaoPf != "0");
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

            metodosPj.Inserir(novaPj);

            List<PessoaJuridica> ListaPj = metodosPj.LerArquivo();
            foreach (PessoaJuridica cadaItem in ListaPj)
            {
                Console.Clear();
                Console.WriteLine(@$"
Nome: {cadaItem.Nome}
Razão Social: {cadaItem.RazaoSocial}
CNPJ: {cadaItem.Cnpj}
");
                Console.WriteLine($"Tecle ENTER para seguir");
                Console.ReadLine();
            }

//             Console.Clear();
//             Console.WriteLine(@$"
// Nome: {novaPj.Nome}
// Razão Social: {novaPj.RazaoSocial}
// CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
// Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
// Complemento: {novaPj.Endereco.complemento}
// Imposto a ser pago: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C")}
// ");
            // Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));

            Console.WriteLine($"Tecle ENTER para seguir");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por usar nosso sistema!");
            Thread.Sleep(3000);
            Carregamento("Finalizando", 500, 6);
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