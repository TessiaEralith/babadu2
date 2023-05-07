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
    public int id { get; set; }
    public string login { get; set; }
    public string pass { get; set; }
    public string mail { get; set; }
    //public string Phone { get; set; }
}
