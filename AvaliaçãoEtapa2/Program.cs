using AvaliaçãoEtapa2;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

//1. Cadastre um banco chamado “Banco do Brasil”

//using var db = new AppDbContext();

//db.Database.EnsureCreated();

//var banco = new Banco
//{
//    Codigo = 1,
//    Nome = "Banco do Brasil"
//};

//db.Bancos.Add(banco);

//db.SaveChanges();


//2.Cadastre uma agência vinculada ao banco cadastrado “Banco do Brasil”.


//using var db = new AppDbContext();

//db.Database.EnsureCreated();

//var agencia = new Agencia
//{
//    Numero = 100,
//    Endereco = "Rua XV de Novembro, 500",
//    BancoCodigo = 1
//};

//db.Agencias.Add(agencia);

//db.SaveChanges();


//3.Cadastre um banco chamado “Caixa”.

//using var db = new AppDbContext();

//db.Database.EnsureCreated();

//var banco = new Banco
//{
//    Codigo = 2,
//    Nome = "Caixa"
//};

//db.Bancos.Add(banco);

//db.SaveChanges();




//4.Exiba na tela todos os dados dos bancos.



//using var db = new AppDbContext();

//db.Database.EnsureCreated();

//var bancos = db.Bancos.ToList();

//bancos.ForEach(banco =>
//    Console.WriteLine($"{banco.Codigo} - {banco.Nome}")
//);




//5. Cadastre uma agência vinculada ao banco cadastrado “Caixa”.

//using var db = new AppDbContext();

//db.Database.EnsureCreated();

//var agencia = new Agencia
//{
//    Numero = 101,
//    Endereco = "Rua 31 Tangamandapio, 499",
//    BancoCodigo = 2
//};

//db.Agencias.Add(agencia);

//db.SaveChanges();


//6.Exibir na tela todos os dados das agências e dos respectivos bancos vinculados.



//using var db = new AppDbContext();

//db.Database.EnsureCreated();

//var agencias = db.Agencias.ToList();

//agencias.ForEach(agencia =>
    //Console.WriteLine($"{agencia.Numero} - {agencia.Endereco}")
//);
