using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TestConsole;

public class Result
{
    public DateTime LastUpdate{ get; set; }
    [JsonProperty("Person")]
    public List<Person> Persons { get; set; }
}

public class Person
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public string Nationality { get; set; }
}