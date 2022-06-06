using UC12.Classes;

PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco ();

novaPj.Nome = "Nome PJ";
novaPj.RazaoSocial = "Razão Social PJ";
novaPj.Cnpj = "00.000.000/0001-00";
novaPj.Rendimento = 10000.5f;

novoEndPj.logradouro = "Alameda Barão de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "SENAI Informatica";
novoEndPj.endComercial = true;

novaPj.Endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

// Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));

// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome = "Marco";
// novaPf.dataNasc = new DateTime(1995, 06, 14);
// novaPf.Cpf = "1234567890";
// novaPf.Rendimento = 3500.5f;

// novoEndPf.complemento = "SENAI informatica";
// novoEndPf.endComercial = true;
// novoEndPf.logradouro = "Alameda Barao de Limeira";
// novoEndPf.numero = 539;

// novaPf.Endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero} 
// Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}");

// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);
// Console.Write(novaPf.Nome);
// Console.Write(novaPf.Nome);
// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome}");
// Console.WriteLine("Nome: "+novaPf.Nome);
