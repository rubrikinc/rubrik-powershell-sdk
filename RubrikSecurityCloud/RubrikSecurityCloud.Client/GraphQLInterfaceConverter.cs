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

public class GraphQLInterfaceConverter : JsonConverter
{
    private string _typeName = "";
    private IRscLogger _logger = null;

    public GraphQLInterfaceConverter(string typeName, IRscLogger logger = null)
    {
        _typeName = typeName;
        _logger = logger;
    }

    public override bool CanConvert(Type objectType)
    {
        bool isRscType = objectType.AssemblyQualifiedName.StartsWith("Rubrik");
        // In .NET, the BaseType property of the Type class returns null
        // for interfaces ( and for the System.Object class itself,
        // but if the type starts with "Rubrik" then it can't be System.Object)
        bool isInterface = objectType.BaseType == null;
        if (isInterface && isRscType)
        {
            return true;
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
        JObject jsonObject = JObject.Load(reader);
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
                    _logger?.Verbose(msg);
                }
                else
                {
                    _logger?.Warning(msg);
                }
                return null;
            }
        }

        //var gqlTypeName = jsonObject.Last.First.Value<string>();
        string gqlTypeName = jsonObject["__typename"].Value<string>();
        Type gqlType = Type.GetType(
            String.Format(
                "RubrikSecurityCloud.Types.{0}, RubrikSecurityCloud.Schema",
                gqlTypeName)
        );
        if (gqlType == null)
        {
            JToken parentToken = jsonObject.Parent;
            string parentString = parentToken?.ToString() ?? "Unknown";

            string msg = "API returned object of interface-implementing type \"" +
                gqlTypeName +
                "\" which is unknown in the schema used by this SDK.\n" +
                jsonObjectInfo(jsonObject, reader, objectType);
            ;
            if (RubrikSecurityCloud.Config.SchemaStrict)
            {
                throw new RscServerSchemaMismatchException(msg);
            }
            else
            {
                if (RubrikSecurityCloud.Config.MuteSchemaWarnings)
                {
                    _logger?.Verbose(msg);
                }
                else
                {
                    _logger?.Warning(msg);
                }
                return null;
            }
        }
        object gqlObject = Activator.CreateInstance(gqlType);
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
