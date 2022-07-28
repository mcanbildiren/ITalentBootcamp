// See https://aka.ms/new-console-template for more information
using Abstraction.App;

Console.WriteLine("Hello, World!");


var bl = new BL(new OracleDAL());

bl.GetProduct().ForEach(x =>
{

    Console.WriteLine(x);
});

bl.SetDAL(new DALFactory().GetDAL());

bl.GetProduct().ForEach(x =>
{

    Console.WriteLine(x);
});


