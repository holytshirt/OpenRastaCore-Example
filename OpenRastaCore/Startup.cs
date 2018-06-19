using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using OpenRasta.Codecs.Newtonsoft.Json;
using OpenRasta.Configuration;
using OpenRasta.Hosting.AspNetCore;

namespace BasicOpenRastaSite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseOpenRasta(new OpenRastaConfiguration());
        }
    }

    public class OpenRastaConfiguration : IConfigurationSource
    {
        public void Configure()
        {
            ResourceSpace.Has
                .ResourcesOfType<IEnumerable<TaskItem>>()
                .AtUri("/tasks")
                .HandledBy<TaskHandler>()
                .TranscodedBy<NewtonsoftJsonCodec>();
        }
    }

    public class TaskHandler
    {
        public IEnumerable<TaskItem> Get()
        {
            return new[] {new TaskItem(1, "Title 1"), new TaskItem(2, "Title 2")};
        }
    }

    public class TaskItem
    {
        public TaskItem(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; }
        public string Title { get; }
    }
}