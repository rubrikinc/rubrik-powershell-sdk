using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Rubrik.SecurityCloud.Types;

namespace Rubrik.SecurityCloud.NetSDK.Library.HelperClasses
{

    public class GraphQLDateTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer
        )
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer
        )
        {
            DateTime datetime = (DateTime)value;
            serializer.Serialize(
                writer,
                datetime.ToString(
                    "yyyy-MM-ddTHH:mm:sszzz",
                    System.Globalization.CultureInfo.InvariantCulture
                )
            );
        }
    }

    public class OperationVariableSet
    {
        public IDictionary<string, object> Variables { get; set; }
        public List<Filter> Filters { get; set; }

        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Converters = new List<JsonConverter> {
                new Newtonsoft.Json.Converters.StringEnumConverter(),
                new GraphQLDateTimeConverter()
            },
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public string AsJson()
        {
            JObject variables = new JObject();
            if (Variables != null)
            {
                foreach (var item in Variables)
                {
                    if (item.Value is string)
                    {
                        variables.Add(item.Key, (string)item.Value);
                    }
                    else if (item.Value is string[])
                    {
                        variables.Add(item.Key,
                            new JArray((string[])item.Value));
                    }
                    else if (item.Value is int)
                    {
                        variables.Add(item.Key, (int)item.Value);
                    }
                    else if (item.Value is bool)
                    {
                        variables.Add(item.Key, (bool)item.Value);
                    }
                    else if (item.Value is DateTime)
                    {
                        DateTime datetime = (DateTime)item.Value;
                        variables.Add(
                            item.Key,
                            datetime.ToString(
                                "yyyy-MM-ddTHH:mm:sszzz",
                                System.Globalization.CultureInfo.InvariantCulture
                            )
                        );
                    }
                    else if (item.Value is null)
                    {
                        variables.Add(item.Key, null);
                    }
                    else
                    {
                        variables.Add(
                            item.Key,
                            JObject.FromObject(
                                item.Value,
                                JsonSerializer.Create(_serializerSettings)
                            )
                        );
                    }
                }
            }           

            if (Filters != null)
            {
                variables.Add("filter", JToken.FromObject(Filters, JsonSerializer.Create(_serializerSettings)));
            }

            return JsonConvert.SerializeObject(variables,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = { new GraphQLDateTimeConverter() }
                });
        }
    }
}
