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
using System.Globalization;
using RubrikSecurityCloud.Types;
using System.Collections;

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
            string stripped;
            // It's a System.Collections.Generic.List
            // remove "System.Collections.Generic.List`1[" at start and
            // "]" at end
            if (typeName.StartsWith(ListPrefix1) &&
                typeName.EndsWith(ListSuffix1))
            {
                 stripped = typeName.Substring(
                    ListPrefix1.Length,
                    typeName.Length - ListPrefix1.Length - ListSuffix1.Length
                );
            } else if (typeName.StartsWith(ListPrefix2) &&
                typeName.EndsWith(ListSuffix2))
            {
                stripped = typeName.Substring(
                    ListPrefix2.Length,
                    typeName.Length - ListPrefix2.Length - ListSuffix2.Length
                );
            } else
            {
                stripped = typeName;
            }

            return stripped;
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
            type = Type.GetType("RubrikSecurityCloud.Types." + typeName
                + ", RubrikSecurityCloud.Schema");
            if (type != null)
            {
                return type;
            }

            try
            {
                var utAssembly = Assembly.Load("RubrikSecurityCloud.Common.Tests");
                if (utAssembly != null)
                {
                    type = utAssembly.GetTypes().FirstOrDefault(t => t.Name == typeName || t.FullName == typeName);
                    if (type != null)
                    {
                        return type;
                    }
                }
            }
            catch (Exception)
            {
                // ignore
            }

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies)
            {
                type = a.GetTypes().FirstOrDefault(t => t.Name == typeName || t.FullName == typeName);
                if (type != null)
                {
                    return type;
                }
            }
            return null;
        }

        private static Dictionary<string,Type?> GetStrippedTypeCache = new Dictionary<string, Type?>();
        public static Type? GetStrippedType(string typeName)
        {
            if (GetStrippedTypeCache.ContainsKey(typeName))
            {
                return GetStrippedTypeCache[typeName];
            }
            Type? type = ReflectionUtils.GetType(StripList(typeName));
            GetStrippedTypeCache[typeName] = type;
            return type;
        }

        public static Dictionary<string,string> GetTypesImplementingInterfaceCache = new Dictionary<string, string>();

        /// <summary>
        /// Get a list of all types that implement the specified interface.
        /// </summary>
        public static List<string> GetTypesImplementingInterface(string interfaceName)
        {
            if (GetTypesImplementingInterfaceCache.ContainsKey(interfaceName))
            {
                return GetTypesImplementingInterfaceCache[interfaceName].Split(',').ToList();
            }

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
                // try in all assemblies
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var a in assemblies)
                {
                    interfaceType = a.GetTypes().FirstOrDefault(t => t.Name == interfaceName && t.IsInterface);
                    if (interfaceType != null)
                    {
                        assembly = a;
                        break;
                    }
                }
                if (interfaceType == null)
                {
                    throw new Exception($"Interface {interfaceName} not found.");
                }
            }

            foreach (var type in assembly.GetTypes())
            {
                if (interfaceType.IsAssignableFrom(type) && !type.IsInterface)
                {
                    typeNameList.Add(type.Name);
                }
            }

            var infImpls = typeNameList.OrderBy(type => type).ToList();
            GetTypesImplementingInterfaceCache[interfaceName] = string.Join(",", infImpls);
            return infImpls;
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
                    // SDK favors Nodes list over Edges list
                    SkipFieldNames = new HashSet<string> { "Edges" },
                    // AddClassNames = true means that non-simple object names are
                    // valid patch names. For example if a field X is an
                    // object with 2 fields A and B, the patch names
                    // "X.A" and "X.B" are always valid, but with AddClassNames = true
                    // the patch "X" is also valid.
                    AddClassNames = true,
                    MaxDepth = 5
                };
            }
            public HashSet<string>? SkipFieldNames { get; set; } = null;
            public bool AddClassNames { get; set; } = false;
            public int MaxDepth { get; set; } = 10;
            public HashSet<Type> Visited { get; set; } = new HashSet<Type>();
        }

        public static List<string> FlattenFieldFull(string typeName)
        {
            // note that it's still not "full" since MaxDepth is 10
            List<string> fields = FlattenField(typeName, new FlattenFieldContext());
            return fields;

        }
        
        // keep a cache of FlattenFieldPatch results
        public static Dictionary<string, string> FlattenFieldPatchCache = new Dictionary<string, string>();

        public static List<string> FlattenFieldPatch(string typeName)
        {
            if (FlattenFieldPatchCache.ContainsKey(typeName))
            {
                return FlattenFieldPatchCache[typeName].Split(',').ToList();
            }
            List<string> fields = FlattenField(typeName, FlattenFieldContext.PatchContext());
            FlattenFieldPatchCache[typeName] = string.Join(",", fields);
            return fields;
        }

        public static List<string> FlattenField(string typeName, FlattenFieldContext ctx)
        {
            List<string>? fields;
            Type? type = GetStrippedType(typeName);
            if (type == null)
            {
                throw new Exception($"FlattenField: {typeName} is null.");
            }

            // Reset cache
            _FlattenFieldCache = new Dictionary<string, List<string>>();

            // If the type is an interface, we need to expand all types that implement it
            if (type.IsInterface)
            {
                fields = new List<string>();
                var infImpls = GetTypesImplementingInterface(type.Name);
                infImpls.ForEach(impl =>
                {
                    var f = _FlattenField(impl, ctx, 0);
                    if (f != null && f.Any())
                    {
                        fields.AddRange(f);
                    }
                });
            }
            else // Otherwise, just expand the type
            {
                fields = _FlattenField(typeName, ctx, 0);
            }

            // Reset cache
            _FlattenFieldCache = new Dictionary<string, List<string>>();

            if (fields==null)
            {
                throw new Exception($"FlattenField: {typeName} is null.");
            }
            // Interface-implementing types may have fields in common,
            // so we need to remove duplicates
            fields = fields.Distinct().ToList();
            fields.Sort();
            return fields;
        }

        public static Dictionary<string, List<string>> _FlattenFieldCache = new Dictionary<string, List<string>>();

        private static List<string>? _FlattenField(
            string typeName,
            FlattenFieldContext ctx,
            int depth
            )
        {
            Type? type = GetStrippedType(typeName);
            if (type == null || depth >= ctx.MaxDepth)
            {
                return null;
            }

            if (_FlattenFieldCache.ContainsKey(typeName))
            {
                return _FlattenFieldCache[typeName];
            }

            if (ctx.Visited.Contains(type))
            {
                return null;
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

                if (TypeIsSimple(pType))
                {
                    fields.Add(fieldName);
                    continue;
                }
                List<string>? nestedFields = null;
                if (pType.IsClass)
                {
                    nestedFields = _FlattenField(pType.FullName, ctx, depth + 1);
                } else if (pType.IsInterface)
                {
                    var infImpls = GetTypesImplementingInterface(pType.Name);
                    nestedFields = new List<string>();
                    infImpls.ForEach(impl =>
                    {
                        // Going down sub-fields we should normally increase depth by 1,
                        // however, expanding interfaces grows the complexity of
                        // _FlattenField exponentially, and it takes in some cases *seconds*
                        // to complet at ctx.MaxDepth = 5. To mitigate the issue,
                        // we give up on expanding interfaces earlier:
                        var f = _FlattenField(impl, ctx, depth + 2);
                        if (f != null && f.Any())
                        {
                            nestedFields.AddRange(f);
                        }
                    });
                } else
                {
                    throw new Exception(
                        $"{type.Name}: Field {fieldName} of type {pType.Name} is not simple, not a class and not an interface.");
                }

                if (nestedFields!=null && nestedFields.Count > 0 )
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

            ctx.Visited.Remove(type);

            _FlattenFieldCache[typeName] = fields;
            return fields;
        }

        public static string GetObjFieldSpec(object obj, FieldSpecConfig? conf = null)
        {
            // If obj implements IFieldSpec, use AsFieldSpec method
            if (obj is IFieldSpec fieldSpec)
            {
                return fieldSpec.AsFieldSpec(conf);
            }

            // If obj is a collection, recurse on the first element
            if (obj is IEnumerable enumerable)
            {
                var enumerator = enumerable.GetEnumerator();
                if (enumerator.MoveNext())
                {
                    return GetObjFieldSpec(enumerator.Current, conf);
                }
            }

            // Fallback to ToString (for simple types like int, string, etc.)
            return obj.ToString();
        }
    }
}
