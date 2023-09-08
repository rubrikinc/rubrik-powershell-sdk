using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQLParser.AST;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud;
using System.Reflection;
using System.Linq;

namespace RubrikSecurityCloud
{
    public static class ReflectionUtils
    {
        const string ListPrefix = "System.Collections.Generic.List`1[";
        const string ListSuffix = "]";
        public static String StripList(string typeName)
        {
            // It's a System.Collections.Generic.List
            // remove "System.Collections.Generic.List`1[" at start and
            // "]" at end
            if (typeName.StartsWith(ListPrefix) &&
                typeName.EndsWith(ListSuffix)) {
                    return typeName.Substring(
                        ListPrefix.Length,
                        typeName.Length - ListPrefix.Length - ListSuffix.Length
                    );
            } else {
                return typeName;
            }
        }

        public static Type? GetType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return typeof(object);
            }

            var innerTypeName = StripList(typeName);
            if (innerTypeName != typeName) {
                var innerType = GetType(innerTypeName);
                if (innerType == null)
                {
                    return null;
                }

                return typeof(List<>).MakeGenericType(innerType);
            }

            var type = Type.GetType(typeName);
            if (type != null)
            {
                return type;
            }
            // type = Type.GetType("RubrikSecurityCloud.Operations." + typeName + ", RubrikSecurityCloud.Schema");
            // if (type != null)
            //     return type;
            type = Type.GetType("RubrikSecurityCloud.Types." + typeName
                + ", RubrikSecurityCloud.Schema");
            if (type != null)
            {
                return type;
            }

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies)
            {
                type = a.GetType(typeName);
                if (type != null)
                {
                    return type;
                }
            }
            return null;
        }

        public static List<string> FlattenField(
            string typeName,
            HashSet<Type>? visited = null
        ){
            Type? type = ReflectionUtils.GetType(StripList(typeName));
            if (type == null)
            {
                return new List<string>();
            }
            if (visited == null)
            {
                visited = new HashSet<Type>();
            }
            if (visited.Contains(type))
            {
                return new List<string>();
            }

            visited.Add(type);

            List<string> fields = new List<string>();

            FieldInfo[] fieldInfos =
                type.GetFields(
                    BindingFlags.Instance |
                    BindingFlags.Public |
                    BindingFlags.NonPublic
                );
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                if (!fieldInfo.Name.StartsWith("<"))
                {
                    continue;
                }
                int index = fieldInfo.Name.IndexOf(">");

                string fieldName = fieldInfo.Name.Substring(1, index - 1);

                if (
                    fieldInfo.FieldType.IsClass &&
                    fieldInfo.FieldType != typeof(string) &&
                    !fieldInfo.FieldType.IsEnum
                ){
                    List<string> nestedFields =
                        FlattenField(fieldInfo.FieldType.ToString(), visited);
                    nestedFields =
                        nestedFields
                            .Select(
                                nestedField => String.Format("{0}.{1}",
                                fieldName, nestedField)
                            )
                            .ToList();
                    fields.AddRange(nestedFields);
                }
                else
                {
                    fields.Add(fieldName);
                }
            }

            visited.Remove(type);

            return fields;
        }
    }
}
