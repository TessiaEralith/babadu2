using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using read;

List<User> user = read.Read.Reading();
foreach (var item in user)
{
    Console.WriteLine(item.id);
    Console.WriteLine(item.login);
    Console.WriteLine(item.pass);
    Console.WriteLine(item.mail);
}