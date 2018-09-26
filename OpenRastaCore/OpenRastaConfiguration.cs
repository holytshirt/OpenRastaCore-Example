using System.Collections.Generic;
using OpenRasta.Codecs.Newtonsoft.Json;
using OpenRasta.Configuration;

namespace BasicOpenRastaSite
{
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
}