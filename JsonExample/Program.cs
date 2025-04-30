using Newtonsoft.Json;
using System;
using System.IO;

class Program
{
   
    //aprasyti klase atitinkancia json struktura
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    static void Main(string[] args)
    {
        //nuoroda i json fila
        string filePath = $"{Environment.CurrentDirectory}\\user.json";
        
        //perskaito json failo duomenis
        string jsonResponse = File.ReadAllText(filePath);
        
        //json failas deserializuojamas i C# objekta
        User user = JsonConvert.DeserializeObject<User>(jsonResponse);
        
        //atspauzdinama vartotojo(user) informacija
        Console.WriteLine($"Name: {user.Name}");
        Console.WriteLine($"Age: {user.Age}");
        Console.WriteLine($"City: {user.City}");
    }
}