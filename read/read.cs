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
        for (int i=0; i < users.Count; i++)
        {

        }
    }
}
namespace read
{
    public class Read
    {
        public static List<User> Reading()
        {
            string pathToJson = @"C:\Users\Tessia\Desktop\bede.json";

            string json = File.ReadAllText(pathToJson);

            List<User> user = JsonSerializer.Deserialize<List<User>>(json);
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
    }

   
}

public class Card
{
    public string name;
    public string description;
    public string colour;
}
public class Column
{
    public string name;
    public List<Card> cards;
}
public class Desk
{
    public int access;
    public int[] whitelist;
    public string name;
    public List<Column> column;
}
public class User
{
    public int id;
    public string login;
    public string password;
    public string email;

    public List<Desk> desk;
}

