using Newtonsoft.Json;
using System;
using System.IO;

class Program
{
    //apsirasau enumeratoriu, kad lengviau atskirti vartotojo tipa
    public enum UserType
    {
        User,
        Administrator
    }
    
    //user klase pervadinama i BaseUser, ji yra tevine
    public class BaseUser
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    // sukuriu dvi vaikines klases: administrator, user
    public class Administrator : BaseUser
    {
        public UserType UserType { get; set; }
        
    }

    public class User : BaseUser
    {
        public UserType UserType { get; set; }
    }
    
    static void Main(string[] args)
    {
        //nuorodos i json filus
        string usersFilePath = $"{Environment.CurrentDirectory}\\users.json";
        string adminsFilePath = $"{Environment.CurrentDirectory}\\admins.json";
        
        //perskaito json failu duomenis
        string usersJsonResponse = File.ReadAllText(usersFilePath);
        string adminsJsonResponse = File.ReadAllText(usersFilePath);
        
        //json failai deserializuojami i C# objektus
        List<User> users = JsonConvert.DeserializeObject<List<User>>(usersJsonResponse);
        List<Administrator> admins = JsonConvert.DeserializeObject<List<Administrator>>(adminsJsonResponse);
        
        //atspauzdinama vartotoju (users, admins) informacija
       
        foreach (User u in users)
        {
            Console.WriteLine($"Name: {u.Name}");
            Console.WriteLine($"Age: {u.Age}");
            Console.WriteLine($"City: {u.City}");
            Console.WriteLine($"City: {u.UserType}");
            Console.WriteLine();
            
        }
        
        foreach (Administrator u in admins)
        {
            Console.WriteLine($"Name: {u.Name}");
            Console.WriteLine($"Age: {u.Age}");
            Console.WriteLine($"City: {u.City}");
            Console.WriteLine($"City: {u.UserType}");
            Console.WriteLine();
            
        }
        
    }
}