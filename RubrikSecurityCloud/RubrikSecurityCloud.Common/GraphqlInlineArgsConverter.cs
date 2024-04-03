using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud
{

    public class GraphqlInlineArgsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) ||
                objectType == typeof(string);
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object? existingValue,
            JsonSerializer serializer
        )
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(
            JsonWriter writer,
            object? value,
            JsonSerializer serializer
        )
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            Type objectType = value.GetType();
            if (objectType == typeof(DateTime)) {
                DateTime datetime = (DateTime)value;
                serializer.Serialize(
                    writer,
                    datetime.ToString(
                        "\"yyyy-MM-ddTHH:mm:sszzz\"",
                        System.Globalization.CultureInfo.InvariantCulture
                    )
                );
            } else
            {
                string stringVal = (string)value;
                serializer.Serialize(
                    writer,
                    "\"" + stringVal + "\""
                );
            }
        }
    }
}
