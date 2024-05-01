using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQLParser.AST;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Client;
using System.Reflection;
using RubrikSecurityCloud.Client.Models;
using RubrikSecurityCloud.Types;
using System.Collections;

public class GraphQLInterfaceConverter : JsonConverter
{
    private string _typeName = "";
    private IRscLogger _logger = null;

    public GraphQLInterfaceConverter(string typeName, IRscLogger logger = null)
    {
        _typeName = typeName;
        _logger = logger;
    }

    // objectType is the type of the property in the receiving .NET object
    // that is supposed to receive the deserialized JSON object.
    public override bool CanConvert(Type objectType)
    {
        // Check if the type is a constructed type from the
        // generic definitions of RscInterface<> or RscInterfaceList<>
        if (objectType.IsGenericType)
        {
            // Get the generic type definition of the objectType
            Type genericTypeDef = objectType.GetGenericTypeDefinition();

            // Check if it is either RscInterface<> or RscInterfaceList<>
            return (genericTypeDef == typeof(RscInterface<>) ||
                genericTypeDef == typeof(RscInterfaceList<>));
        }
        return false;
    }

    private string jsonObjectInfo(JObject jsonObject, JsonReader reader, Type objectType, string sep = "\n")
    {
        return "Root object: " + _typeName + sep +
            "Interface: " + objectType.FullName + sep +
            "JSON Path: " + reader.Path + sep +
            "JSON object:" + sep + jsonObject.ToString() + sep;
    }

    public override object ReadJson(
        JsonReader reader,
        Type objectType,
        object existingValue,
        JsonSerializer serializer
    )
    {
        Type interfaceType = objectType.GetGenericArguments()[0]; // Get the specific interface type
        if (reader.TokenType == JsonToken.StartArray)
        {
            JArray jsonArray = JArray.Load(reader);
            var listType = typeof(RscInterfaceList<>).MakeGenericType(interfaceType);
            var list = (IList)Activator.CreateInstance(listType);
            foreach (JObject jsonObject in jsonArray.Children<JObject>())
            {
                var item = DeserializeInterfaceObject(reader, objectType, jsonObject, interfaceType, serializer);
                list.Add(item);
            }
            return list;
        }
        else if (reader.TokenType == JsonToken.StartObject)
        {
            JObject jsonObject = JObject.Load(reader);
            // RscInterface<T> is a list of 1 item
            var listType = typeof(RscInterface<>).MakeGenericType(interfaceType);
            var list = (IList)Activator.CreateInstance(listType);
            var item = DeserializeInterfaceObject(reader, objectType, jsonObject, interfaceType, serializer);
            list.Add(item);
            return list;
        }
        else
        {
            throw new JsonSerializationException("Expected JSON object or array for interface field.");
        }
    }

    private object DeserializeInterfaceObject(JsonReader reader,
        Type objectType, JObject jsonObject, Type interfaceType, JsonSerializer serializer)
    {
        if (!jsonObject.ContainsKey("__typename"))
        {
            string msg = "API returned object of interface-implementing type without " +
                            "__typename info.\n" + jsonObjectInfo(jsonObject, reader, objectType);
            if (RubrikSecurityCloud.Config.SchemaStrict)
            {
                throw new RscServerSchemaMismatchException(msg);
            }
            else
            {
                if (RubrikSecurityCloud.Config.MuteSchemaWarnings)
                {
                    _logger?.Info(msg);
                }
                else
                {
                    _logger?.Warning(msg);
                }
                return null;
            }
        }
        string gqlTypeName = jsonObject["__typename"].ToString();
        Type? gqlType = ReflectionUtils.GetType(gqlTypeName);
        if (gqlType == null || !interfaceType.IsAssignableFrom(gqlType))
        {
            JToken parentToken = jsonObject.Parent;
            string parentString = parentToken?.ToString() ?? "Unknown";

            string msg = "API returned object of type '" + gqlTypeName +
                "' for interface field of type '" + interfaceType.Name + "'";
            if (gqlType == null)
            {
                msg += " which is unknown in the schema used by this SDK.";
            } else
            {
                msg += " which is not assignable to the interface type.";
            }
             msg += "\n" + jsonObjectInfo(jsonObject, reader, objectType);
            ;
            if (RubrikSecurityCloud.Config.SchemaStrict)
            {
                throw new RscServerSchemaMismatchException(msg);
            }
            else
            {
                if (RubrikSecurityCloud.Config.MuteSchemaWarnings)
                {
                    _logger?.Info(msg);
                }
                else
                {
                    _logger?.Warning(msg);
                }
                return null;
            }
        }
        var gqlObject = Activator.CreateInstance(gqlType);
        serializer.Populate(jsonObject.CreateReader(), gqlObject);
        return gqlObject;
    }

    public override void WriteJson(
        JsonWriter writer,
        object value,
        JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
