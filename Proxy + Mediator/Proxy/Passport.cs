using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proxy___Mediator.Proxy
{
    internal class Passport
    {
        public string PassportId { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            options.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
            return JsonSerializer.Serialize(this, options);
        }

    }
}
