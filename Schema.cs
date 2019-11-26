using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Moomoo_Client
{
    [JsonConverter(typeof(SpawnConverter))]
    class Spawn
    {

        [JsonProperty(Order = 0)]
        public readonly string type = "sp";
        [JsonProperty(Order = 1)]
        public SpawnArgs[] args;

        public Spawn()
        {
        }

        public static Spawn Create(string name, int skin, bool bonus)
        {
            var spawn = new Spawn();
            spawn.args = new SpawnArgs[] { new SpawnArgs() };
            spawn.args[0].name = name;
            spawn.args[0].skin = skin;
            spawn.args[0].bonus = bonus;
            return spawn;
        }


    }
    class SpawnConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Spawn));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JArray ja = JArray.Load(reader);
            var sargs = ja[1].Value<SpawnArgs[]>()[0];
            Spawn spawn = Spawn.Create(sargs.name, sargs.skin, sargs.bonus);
            return spawn;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JArray ja = new JArray();
            Spawn spawn = (Spawn)value;
            ja.Add(spawn.type);
            ja.Add(JToken.FromObject(spawn.args));
            ja.WriteTo(writer);
        }
    }
    [JsonObject]
    public class SpawnArgs
    {

        [JsonProperty]
        public string name;
        [JsonProperty]
        public int skin;
        [JsonProperty(PropertyName = "moofoll")] //spawn bonus for materials
        public bool bonus;
    }

    [JsonConverter(typeof(SpinConverter))]
    public class Spin{
        public string type;
        public double rotation;
        public static Spin Create(double sargs)
        {
            return new Spin()
            {
                type = "",
                rotation = sargs
            };
        }
    }

    class SpinConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Spin));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JArray ja = JArray.Load(reader);
            double angle = ja[1].Value<double>();
            Spin spin = Spin.Create(angle);
            return spin;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JArray ja = new JArray();
            Spin spin = (Spin)value;
            ja.Add(spin.type);
            ja.Add(spin.rotation);
            ja.WriteTo(writer);
        }
    }
}
