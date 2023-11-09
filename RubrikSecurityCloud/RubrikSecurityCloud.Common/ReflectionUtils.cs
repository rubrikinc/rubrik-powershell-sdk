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
        const string ListPrefix1 = "System.Collections.Generic.List`1[";
        const string ListSuffix1 = "]";
        const string ListPrefix2 = "List<";
        const string ListSuffix2 = ">";
        public static String StripList(string typeName)
        {
            // It's a System.Collections.Generic.List
            // remove "System.Collections.Generic.List`1[" at start and
            // "]" at end
            if (typeName.StartsWith(ListPrefix1) &&
                typeName.EndsWith(ListSuffix1))
            {
                return typeName.Substring(
                    ListPrefix1.Length,
                    typeName.Length - ListPrefix1.Length - ListSuffix1.Length
                );
            }

            if (typeName.StartsWith(ListPrefix2) &&
                typeName.EndsWith(ListSuffix2))
            {
                return typeName.Substring(
                    ListPrefix2.Length,
                    typeName.Length - ListPrefix2.Length - ListSuffix2.Length
                );
            }

            return typeName;
        }

        public static Type? GetType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return typeof(object);
            }

            var innerTypeName = StripList(typeName);
            if (innerTypeName != typeName)
            {
                var innerType = ReflectionUtils.GetType(innerTypeName);
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

        /// <summary>
        /// Get a list of all types that implement the specified interface.
        /// </summary>
        public static List<string> GetTypesImplementingInterface(string interfaceName)
        {
            var typeNameList = new List<string>();
            var assembly = Assembly.Load("RubrikSecurityCloud.Schema");

            if (assembly == null)
            {
                throw new Exception("Unable to load RubrikSecurityCloud.Schema");
            }

            // Get the type of the specified interface
            Type interfaceType = assembly.GetTypes().FirstOrDefault(t => t.Name == interfaceName && t.IsInterface);

            if (interfaceType == null)
            {
                throw new Exception($"Interface {interfaceName} not found.");
            }

            foreach (var type in assembly.GetTypes())
            {
                if (interfaceType.IsAssignableFrom(type) && !type.IsInterface)
                {
                    typeNameList.Add(type.Name);
                }
            }

            return typeNameList.OrderBy(type => type).ToList();
        }

        public static bool TypeIsSimple(Type type)
        {
            return
                type.IsPrimitive ||
                type.IsEnum ||
                type == typeof(string) ||
                type == typeof(decimal) ||
                type == typeof(DateTime) ||
                type == typeof(DateTimeOffset) ||
                type == typeof(TimeSpan) ||
                type == typeof(Guid);
        }

        public static Type StripNullableAndListContainers(Type type)
        {
            bool stripped = true;
            while (stripped)
            {
                stripped = false;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    type = type.GetGenericArguments()[0];
                    stripped = true;
                }
                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
                {
                    type = type.GetGenericArguments()[0];
                    stripped = true;
                }
            }
            return type;
        }

        public class FlattenFieldContext
        {
            // factory method:
            static public FlattenFieldContext PatchContext()
            {
                return new FlattenFieldContext
                {
                    SkipFieldNames = new HashSet<string> { "Edges" },
                    AddClassNames = true,
                    MaxDepth = 5
                };
            }
            public HashSet<string>? SkipFieldNames { get; set; } = null;
            public bool AddClassNames { get; set; } = false;
            public int MaxDepth { get; set; } = 10;
            public HashSet<Type> Visited { get; set; } = new HashSet<Type>();
        }

        public static List<string> FlattenField(
            string typeName,
            FlattenFieldContext? ctx = null,
            int depth = 0
        )
        {
            if (ctx == null)
            {
                ctx = new FlattenFieldContext();
            }
            Type? type = ReflectionUtils.GetType(StripList(typeName));
            if (type == null || depth >= ctx.MaxDepth)
            {
                return new List<string>();
            }
            if (ctx.Visited.Contains(type))
            {
                return new List<string>();
            }

            ctx.Visited.Add(type);

            List<string> fields = new List<string>();

            PropertyInfo[] propInfos =
                type.GetProperties(
                    BindingFlags.Instance |
                    BindingFlags.Public |
                    BindingFlags.NonPublic
                );
            foreach (PropertyInfo propInfo in propInfos)
            {
                Type pType = StripNullableAndListContainers(propInfo.PropertyType);
                string fieldName = propInfo.Name;

                if (ctx.SkipFieldNames != null && ctx.SkipFieldNames.Contains(fieldName))
                {
                    continue;
                }

                if (pType.IsClass && !TypeIsSimple(pType))
                {
                    string pTypeName = pType.FullName;
                    List<string> nestedFields =
                        FlattenField(pTypeName, ctx, depth + 1);
                    if (nestedFields.Count > 0)
                    {
                        nestedFields =
                            nestedFields
                                .Select(
                                    nestedField => String.Format("{0}.{1}",
                                    fieldName, nestedField)
                                )
                                .ToList();
                        if (ctx.AddClassNames)
                        {
                            fields.Add(fieldName);
                        }
                        fields.AddRange(nestedFields);
                    }
                }
                else
                {
                    fields.Add(fieldName);
                }
            }

            ctx.Visited.Remove(type);

            return fields;
        }
    }
}
