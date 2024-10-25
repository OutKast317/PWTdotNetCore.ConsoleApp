// See https://aka.ms/new-console-template for more information
using PWTdotNetCore.ConsoleApp;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create();
//adoDotNetExample.Edit();
adoDotNetExample.Update();

Console.ReadKey();