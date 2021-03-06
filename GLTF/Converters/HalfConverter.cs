﻿using System;
using Newtonsoft.Json;
using Half = DragonLib.Numerics.Half;

namespace DragonLib.GLTF.Converters
{
    public class HalfConverter : JsonConverter<Half?>
    {
        public override void WriteJson(JsonWriter writer, Half? value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteNull();
            else
                writer.WriteValue((float) value);
        }

        public override Half? ReadJson(JsonReader reader, Type objectType, Half? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            return new Half(reader.ReadAsDouble() ?? 0d);
        }
    }
}
