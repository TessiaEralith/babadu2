using System.Data.Common;
using System.Text.Json;

namespace read
{
    public class Read
    {
        public static List<User> Reading()
        {
            string pathToJson = @"C:\Users\JESUS\Downloads\TelegramDesktop\bede.json";

            string json = File.ReadAllText(pathToJson);

            List<User> user = JsonSerializer.Deserialize<List<User>>(json);

            return user;
        }


    }

  
}

public class Column
{
    public string Name { get; set; }
    public List<string> Card { get; set; }
    public Column(string name, List<string> cards)
    {
        Name = name;
        Card = cards;
    }
}
public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public Column column {get; set;}

    public User(int id, string login, string password, string email)
    {
        Id = id;
        Login = login;
        Password = password;
        Email = email;
    }

}
public class AllChecks
{
    List<User> user = read.Read.Reading();
     public static  bool CheckingForEngaged(string login)
    {
        List<User> user = read.Read.Reading();
        bool check = true;
        for (int i = 0; i < user.Count; i++)
        {
            if (user[i].Login == login)
            {
                check = false;
                return check;
            }
        }
        return check;
    }
}
    


