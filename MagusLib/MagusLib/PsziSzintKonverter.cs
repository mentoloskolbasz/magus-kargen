using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MagusLib
{
    public class PsziSzintKonverter : JsonConverter<PsziSzint>
    {
        public override PsziSzint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, PsziSzint value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (var item in value)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("Iskola");
                writer.WriteNumberValue((int)item.Iskola);
                writer.WritePropertyName("Foka");
                writer.WriteNumberValue((int)item.Foka);
                writer.WriteEndObject();

            }
            writer.WriteEndArray();
        }
    }
}
