using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQLParser.AST;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud.Schema.Utils;
using System.Management.Automation;
using RubrikSecurityCloud.Client;
using System.Reflection;

public class GraphQLInterfaceConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType.AssemblyQualifiedName.StartsWith("Rubrik")
            && objectType.BaseType == null;
    }

    public override object ReadJson(
        JsonReader reader,
        Type objectType,
        object existingValue,
        JsonSerializer serializer
    )
    {
        JObject jsonObject = JObject.Load(reader);

        var gqlTypeName = jsonObject.Last.First.Value<string>();
        var gqlType = Type.GetType(
            String.Format(
                "Rubrik.SecurityCloud.Types.{0}, RubrikSecurityCloud.Schema",
                gqlTypeName)
        );
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
