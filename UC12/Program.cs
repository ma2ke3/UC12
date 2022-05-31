using UC12.Classes;

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

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero} 
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}");

// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);
// Console.Write(novaPf.Nome);
// Console.Write(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome}");
// Console.WriteLine("Nome: "+novaPf.Nome);
