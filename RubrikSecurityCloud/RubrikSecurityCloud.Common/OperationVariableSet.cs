using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RubrikSecurityCloud.Types;
using System.Linq;

namespace RubrikSecurityCloud
{
    public class SortedCamelCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            return base.CreateProperties(type, memberSerialization).OrderBy(p => p.PropertyName).ToList();
        }
    }

    public class OperationVariableSet
    {
        public IDictionary<string, object>? Variables { get; set; }

        private readonly JsonSerializerSettings _serializerSettings =
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter> {
                    new Newtonsoft.Json.Converters.StringEnumConverter(),
                    new GraphQLDateTimeConverter()
                    },
                ContractResolver = new SortedCamelCasePropertyNamesContractResolver()
            };


        public string AsJson(IRscLogger? logger = null)
        {
            JObject variables = processVariables(logger);
            return JsonConvert.SerializeObject(variables, _serializerSettings);

        }

        private JObject processVariables(IRscLogger? logger = null)
        {
            JObject variables = new JObject();
            if (this.Variables == null)
            {
                return variables;
            }

            // Sort the keys of the Variables dictionary
            // so that the output is deterministic
            // (and easier to test)
            var sortedKeys = Variables.Keys.OrderBy(k => k).ToList();

            foreach (var key in sortedKeys)
            {
                var item = new KeyValuePair<string, object>(key, Variables[key]);

                logger?.Debug($"Var {item.Key} = " +
                    StringUtils.FormatObjectForLogging(item.Value));

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
                else if (item.Value is VarDict vdObj)
                {
                    JObject vdJObject = new JObject();
                    foreach (var vdItem in vdObj)
                    {
                        vdJObject[vdItem.Key] = JToken.FromObject(vdItem.Value);
                    }
                    variables.Add(item.Key, vdJObject);
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
            return variables;
        }

    }
}
