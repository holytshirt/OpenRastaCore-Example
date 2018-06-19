using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BasicOpenRastaSite
{
  public class Program
  {
    public static void Main(string[] args)
    {
        var builder = new WebHostBuilder()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            .UseKestrel();
            
        var host = builder.Build();
        host.Run();
    }
  }
}