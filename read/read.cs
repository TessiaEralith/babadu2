using read;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.IO;
using System.Text.Json;
static void Write(List<User> users)
{
    using (StreamWriter fstream = new StreamWriter(@"C:\Users\Tessia\Desktop\bede.json"))
    {
        string json = JsonSerializer.Serialize<List<User>>(users);
        fstream.WriteLine(json);
    }
}
namespace read
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public List<Desk> desk { get; set; }
    }
    public class Desk
    {
        public int access { get; set; }
        public int[] whitelist { get; set; }
        public string name { get; set; }
        public List<Column> column { get; set; }
    }
    public class Column
    {
        public string name { get; set; }
        public List<Card> cards { get; set; }
    }

    public class Card
    {
        public string name { get; set; }
        public string description { get; set; }
        public string colour { get; set; }
    }
    public class Read
    {
        public static List<User> Reading()
        {
            string pathToJson = @"C:\Users\Tessia\Desktop\bede.json";

            string json = File.ReadAllText(pathToJson);
            //Console.WriteLine(json);

            List<User> user = JsonSerializer.Deserialize<List<User>>(json);
            //Console.WriteLine(user[0].login);
            return user;
        }
    }
    public class AllChecks
    {
        List<User> user = Read.Reading();
        public bool CheckingForEngaged(string login)
        {
            bool check = true;
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i].login == login)
                {
                    check = false; return check;
                }
            }
            return check;
        }
        public string Log(string login)
        {
            if (CheckingForEngaged(login))
            {
                return ("False");
            }
            else
            {
                for (int i = 0; i < user.Count; i++)
                {
                    if (user[i].login == login)
                    {
                        return user[i].password;
                    }
                }
            }
        }
    }
}
  