// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TestConsole;

Console.WriteLine("Hello, World!");
string filter = "defender";
var personJson= File.ReadAllText("test.json");
var person = JsonConvert.DeserializeObject<Result>(personJson);
if (person != null && person.Persons!=null)
{
    var filteredResult = person.Persons.FindAll(z => z.Position.ToLower() == filter);
}


