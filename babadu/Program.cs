using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using read;

List<User> user = Read.Reading();
Console.WriteLine(user[0].desk[0].name);
string json= JsonSerializer.Serialize<List<User>>(user);
Console.WriteLine(json);
//foreach (var item in user)
//{
//    Console.WriteLine(item.);
//}
//user.ForEach(ConsoleWriteLine);
//AllChecks allChecks = new AllChecks();
//bool ch = allChecks.CheckingForEngaged("test");
////bool ch = new AllChecks.CheckingForEngaged("test");
//Console.WriteLine(ch);