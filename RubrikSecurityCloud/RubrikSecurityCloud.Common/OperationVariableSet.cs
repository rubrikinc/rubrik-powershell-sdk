using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud
{
    public class OperationVariableSet
    {
        public IDictionary<string, object>? Variables { get; set; }

        private readonly JsonSerializerSettings _serializerSettings =
            new JsonSerializerSettings {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter> {
                    new Newtonsoft.Json.Converters.StringEnumConverter(),
                    new GraphQLDateTimeConverter()
                    },
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        public string AsJson(IRscLogger? logger = null)
        {
            JObject variables = new JObject();
            if (Variables != null)
            {
                foreach (var item in Variables)
                {
                    logger?.Verbose(
                        "item.Key: "
                            + item.Key +
                            ", item.Value: "
                            + item.Value +
                            " type: "
                            + item.Value?.GetType() );
                    if (item.Value is string sVal)
                    {
                        variables.Add(item.Key, sVal);
                    }
                    else if (item.Value is string[] sarrVal)
                    {
                        variables.Add(item.Key, new JArray(sarrVal));
                    }
                    else if (item.Value is object[] objArrVal)
                    {
                        var arr = new JArray();
                        foreach (var obj in objArrVal)
                        {
                            arr.Add(
                                JObject.FromObject(
                                    obj,
                                    JsonSerializer.Create(_serializerSettings)
                                )
                            );
                        }
                        variables.Add(item.Key, arr);
                    }

                    // If value is a List<>
                    else if (item.Value is ICollection objListVal)
                    {
                        var arr = new JArray();
                        foreach (var obj in objListVal)
                        {
                            arr.Add(
                                JObject.FromObject(
                                    obj,
                                    JsonSerializer.Create(_serializerSettings)
                                )
                            );
                        }
                        variables.Add(item.Key, arr);
                    }

                    else if (item.Value is int iVal)
                    {
                        variables.Add(item.Key, iVal);
                    }
                    else if (item.Value is bool bVal)
                    {
                        variables.Add(item.Key, bVal);
                    }
                    else if (item.Value is DateTime dtVal)
                    {
                        variables.Add(
                            item.Key,
                            dtVal.ToString(
                                "yyyy-MM-ddTHH:mm:sszzz",
                                System.Globalization.CultureInfo
                                    .InvariantCulture
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

            return JsonConvert.SerializeObject(
                variables,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = { new GraphQLDateTimeConverter() }
                });
        }
    }
}
