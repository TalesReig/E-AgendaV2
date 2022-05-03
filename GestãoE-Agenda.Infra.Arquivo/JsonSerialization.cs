using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GestãoE_Agenda.Infra.Arquivo
{
    public class JsonSerialization<T> : ISerializator<T> where T : class
    {
        private readonly string _path;
        private readonly JsonSerializerSettings _jsonSettings;

        public JsonSerialization(string path)
        {
            _path = path + ".json";
            _jsonSettings = new();
            _jsonSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        }

        public List<T> Load()
        {
            if (File.Exists(_path) == false)
                return new List<T>();

            string json = File.ReadAllText(_path);

            return JsonConvert.DeserializeObject<List<T>>(json, _jsonSettings);
        }

        public void Save(List<T> t)
        {
            string json = JsonConvert.SerializeObject(t, _jsonSettings);

            File.WriteAllText(_path, json);
        }

    }
}