using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using read;
using Checks;
using create;

List<User> users = Read.Reading();
Console.WriteLine(users[0].desk[0].name);
string json= JsonSerializer.Serialize<List<User>>(users);
Console.WriteLine(json);
//Read.Write(users);
//Create.Reg("testik", "pa5sword", "@.");
int[] ints = new int[] { 1, 2,3};
Create.CreateDesk(users[2], 1, ints);















//foreach (var item in user)
//{
//    Console.WriteLine(item.);
//}
//user.ForEach(ConsoleWriteLine);
//AllChecks allChecks = new AllChecks();
//bool ch = allChecks.CheckingForEngaged("test");
////bool ch = new AllChecks.CheckingForEngaged("test");
//Console.WriteLine(ch);