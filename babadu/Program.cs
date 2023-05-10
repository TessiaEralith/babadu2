using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using read;

List<User> user = Read.Reading();
AllChecks allChecks = new AllChecks();
bool ch = allChecks.CheckingForEngaged("test");
//bool ch = new AllChecks.CheckingForEngaged("test");
Console.WriteLine(ch);