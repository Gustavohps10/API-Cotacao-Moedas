using Newtonsoft.Json;

namespace API
{
    public class Mercado
    {
        public Mercado()
        {
            this.Moeda = new Moeda();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Moeda Moeda { get; set; }
    }
}
