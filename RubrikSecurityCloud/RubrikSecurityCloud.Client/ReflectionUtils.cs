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
namespace Rubrik.SecurityCloud.NetSDK.Client
{
    public static class ReflectionUtils
    {
        public static Type GetType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return typeof(object);
            }

            if (typeName.StartsWith("List<") && typeName.EndsWith(">"))
            {
                // It's a List<T>
                var innerTypeName = typeName.Substring(5, typeName.Length - 6); // remove "List<" at start and ">" at end
                var innerType = GetType(innerTypeName);
                if (innerType == null) return null; // or throw exception, up to you
                return typeof(List<>).MakeGenericType(innerType);
            }

            var type = Type.GetType(typeName);
            if (type != null)
                return type;
            // type = Type.GetType("Rubrik.SecurityCloud.Operations." + typeName + ", RubrikSecurityCloud.Schema");
            // if (type != null)
            //     return type;
            type = Type.GetType("Rubrik.SecurityCloud.Types." + typeName
                + ", RubrikSecurityCloud.Schema");
            if (type != null)
                return type;
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies)
            {
                type = a.GetType(typeName);
                if (type != null)
                    return type;
            }
            return null;
        }
    }
}
