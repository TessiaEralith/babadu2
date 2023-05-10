using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using read;


List<User> user = read.Read.Reading();

Console.WriteLine(AllChecks.CheckingForEngaged("test"));
 
