using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RubrikSecurityCloud.Types;
using System.Linq;
using System.Management.Automation;
using System.Text;

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

        private IRscLogger? _logger = null;
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

        private readonly JsonSerializerSettings _inlineVarsSettings =
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter> {
                    new Newtonsoft.Json.Converters.StringEnumConverter()
                    },
                ContractResolver = new SortedCamelCasePropertyNamesContractResolver()
            };

        private readonly JsonSerializerSettings _inlineObjectSettings =
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter> {
                    new GraphqlInlineEnumConverter()
                    },
                ContractResolver = new SortedCamelCasePropertyNamesContractResolver()
            };

        public string AsJson(IRscLogger? logger = null)
        {
            JObject variables = processVariables(logger);
            return JsonConvert.SerializeObject(variables, _serializerSettings);

        }

        public string AsInlineVariables(IRscLogger? logger = null)
        {
            JObject variables = processVariables(logger, inline: true);
            quoteInlineValues(variables);
            string jsonStr = JsonConvert.SerializeObject(variables, _inlineVarsSettings);
            string placeholder = "strPlaceholder";
            jsonStr = jsonStr.Replace("\\\"\"", placeholder);
            jsonStr = jsonStr.Replace("\"\\\"", placeholder);
            jsonStr = jsonStr.Replace("\"", string.Empty);
            jsonStr = jsonStr.Replace(placeholder, "\"");
            jsonStr = jsonStr.Substring(1, jsonStr.Length - 2);
            return jsonStr;
        }

        // Adds the quotes GraphQL needs around strings and dates in inline
        // arguments; the quote handling in AsInlineVariables relies on them.
        // Enums are Raw tokens (GraphqlInlineEnumConverter), so they stay bare.
        private static void quoteInlineValues(JContainer root)
        {
            foreach (var value in root.DescendantsAndSelf().OfType<JValue>().ToList())
            {
                if (value.Type == JTokenType.String)
                {
                    value.Value = "\"" + (string)value.Value! + "\"";
                }
                else if (value.Value is DateTime datetime)
                {
                    value.Value = "\"" + datetime.ToString(
                        "yyyy-MM-ddTHH:mm:sszzz",
                        System.Globalization.CultureInfo.InvariantCulture) + "\"";
                }
            }
        }

        private JObject processVariables(IRscLogger? logger = null, bool inline = false)
        {
            _logger = logger;
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
                logger?.Debug($"Var {key} = " +
                    StringUtils.FormatObjectForLogging(Variables[key]));
                var processedValue = processVariable(Variables[key], inline);
                variables.Add(key, processedValue);
            }

            return variables;
        }

        private JToken processVariable(object? obj, bool inline = false)
        {
            var objectSettings = inline ? _inlineObjectSettings : _serializerSettings;
            if (obj is null)
            {
                return JValue.CreateNull();
            }
            if (obj is DateTime dtVal)
            {
                return dtVal.ToString(
                        "yyyy-MM-ddTHH:mm:sszzz",
                        System.Globalization.CultureInfo
                            .InvariantCulture);
            }

            // IConvertible is an interface that many of the
            // built-in simple types (like int, double, bool,
            // string, etc.) implement, and we're using it to
            // identify such scalar types
            if (obj is IConvertible || obj.GetType().IsEnum)
            {
                return new JValue(obj);
            }
            if (obj is string[] sarrVal)
            {
                return new JArray(sarrVal);
            }
            if (obj is object[] objArrVal)
            {
                var arr = new JArray();
                foreach (var arrItem in objArrVal)
                {
                    arr.Add(processVariable(arrItem, inline));
                }
                return arr;
            }
            if (obj is VarDict vdObj)
            {
                JObject vdJObject = new JObject();
                foreach (var vdItem in vdObj)
                {
                    vdJObject[vdItem.Key] = processVariable(vdItem.Value, inline);
                }
                return vdJObject;
            }
            // If value is a List<>
            if (obj is ICollection objListVal)
            {
                var arr = new JArray();
                foreach (var listItem in objListVal)
                {
                    arr.Add(processVariable(listItem, inline));
                }
                return arr;
            }

            if (obj is PSObject psObject)
            {
                return JObject.FromObject(
                    psObject.BaseObject,
                    JsonSerializer.Create(objectSettings)
                );
            }

            // default:
            return JObject.FromObject(
                    obj,
                    JsonSerializer.Create(objectSettings)
            );
        }
    }
}
