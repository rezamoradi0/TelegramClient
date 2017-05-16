using System.Collections.Generic;

namespace TelegramClient.Entities.Generator
{
    using Newtonsoft.Json;

    internal interface IHaveParams
    {
        List<Param> Params { get; set; }
    }

    internal class Method : IHaveParams
    {
        public int Id { get; set; }
        public string method { get; set; }

        [JsonProperty("params")]
        public List<Param> Params { get; set; }

        public string Type { get; set; }
    }

    internal class Param
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    internal class Constructor: IHaveParams
    {
        public int Id { get; set; }
        public string Predicate { get; set; }

        [JsonProperty("params")]
        public List<Param> Params { get; set; }

        public string Type { get; set; }
    }

    internal class Schema
    {
        public List<Constructor> Constructors { get; set; }
        public List<Method> Methods { get; set; }
    }
}