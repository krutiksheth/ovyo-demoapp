// See https://aka.ms/new-console-template for more information

using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TestConsole;

Console.WriteLine("Hello, World!");
string filter = "Defender";
var personJson= File.ReadAllText("test.json");
var person = JsonConvert.DeserializeObject<Result>(personJson);

var filteredResult = person.Persons.Find(z => z.Position.ToLower() == filter);

