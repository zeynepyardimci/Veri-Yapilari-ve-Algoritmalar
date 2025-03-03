using ConversionLib;
using System.ComponentModel.DataAnnotations;

//var bit = "00001111";
//Console.WriteLine(bit);
var bits = new List<String>()
{
    "00000000",
    "00000001",
    "00000010",
    "00001111",
    "10000000",
    "11111111",
    "10000000",
    "10000001"
};

//foreach (var bit in bits)
//{
//    Console.WriteLine($"{bit,-10} = {ToUNumber(bit),-5}");
//}


var conversion = new Conversion();

foreach (var bit in bits)
{
    Console.WriteLine($"{bit,-10} = {conversion.ToUNumber(bit),-5} = {conversion.ToNumber(bit),-5}");
}