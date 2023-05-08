using System.Text.Json;

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


}
public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

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
    public bool CheckingForEngaged(string login)
    {
        bool check = true;
        for (int i = 0; i < user.Count; i++)
        {
            if (user[i].Login == login)
            {
                check = false; return check;
            }
                
            return check;

        }
    }
}
