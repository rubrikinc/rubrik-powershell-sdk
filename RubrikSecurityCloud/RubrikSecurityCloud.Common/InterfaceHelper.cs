#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RubrikSecurityCloud.Types;
namespace RubrikSecurityCloud
{
    public static class InterfaceHelper
    {
        public static object? CreateInstanceOfFirstType(Type gqlType,
                                                     int returnIndex = 0)
        {
            IEnumerable<Type> types = from type in gqlType.Assembly.GetTypes()
                        where gqlType .IsAssignableFrom(type) &&
                        !type.IsInterface
                        select type;

            if (types != null)
            {
                int typeCount = types.ToArray().Length;
                if (typeCount > 0 && returnIndex <= typeCount - 1)
                {
                    Type firstType = types.ToArray()[returnIndex];
                    return Activator.CreateInstance(firstType);
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Return a list of instances of all types that implement
        /// a given interface as provided by the gqlType parameter.
        /// This is required when constructing GQL queries from AsFieldSpec()
        /// where interfaces need to be instantiated for all possible object
        /// types that implement a given interface.
        /// </summary>
        /// <param name="gqlType"></param>
        /// <returns>List<object></returns>
        public static List<T> CreateInstancesOfImplementingTypes<T>(Type gqlType)
        {
            List<T> returnData = new List<T>();
            IEnumerable<Type> types = from type in gqlType.Assembly.GetTypes()
                                      where gqlType.IsAssignableFrom(type) &&
                                      !type.IsInterface
                                      select type;

            if (types != null)
            {
                int typeCount = types.ToArray().Length;
                if (typeCount > 0)
                {
                    foreach (Type currentType in types)
                    {
                        returnData.Add((T)Activator.CreateInstance(currentType));
                    }
                }
            }
            return returnData;
        }

        public static void AddInstancesOfImplementingTypes<T>(
            List<T> list, 
            Action<T>? initializeInstance = null) where T : class
        {
            var assembly = Assembly.Load("RubrikSecurityCloud.Schema")
                ?? throw new Exception(
                    "Unable to load RubrikSecurityCloud.Schema");
            foreach (var type in assembly.GetTypes())
            {
                if (typeof(T).IsAssignableFrom(type) && !type.IsInterface
                    && !type.IsAbstract)
                {
                    var instance = Activator.CreateInstance(type) as T;
                    if (instance == null)
                    {
                        throw new Exception(
                            $"Unable to create instance of {type.Name}");
                    }
                    initializeInstance?.Invoke(instance);
                    list.Add(instance);
                }
            }
        }

        public static List<BaseType> MakeListFromComposite(BaseType composite)
        {
            var list = new List<BaseType>();
            BaseType? current = composite;

            while (current != null)
            {
                list.Add(current);
                current = current.GetNext();
            }

            return list;
        }

        public static string CompositeAsFieldSpec(BaseType composite, FieldSpecConfig conf)
        {
            var list = MakeListFromComposite(composite);
            return list.AsFieldSpec(conf.Copy(ignoreComposition: true));
        }

        public static void ConvertListsToRscInterfaces(object obj)
        {
            if (obj == null) return;

            Type objType = obj.GetType();

            // Check if the object itself is a List<T>
            if (objType.IsGenericType && objType.GetGenericTypeDefinition() == typeof(List<>))
            {
                // root object itself is a List<T>
                // This case needs to be handled in the parent,
                // since this method replaces properties in place
                // in the input object.
                throw new Exception("Root object is a List<> : cannot convert to RscInterface<> in place.");
            }
            else
            {
                // Recursively convert List<T> properties to RscInterface<T>
                PropertyInfo[] properties = objType.GetProperties();
                foreach (var property in properties)
                {
                    Type propertyType = property.PropertyType;

                    // Check if the property is of type List<T>
                    if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        Type itemType = propertyType.GetGenericArguments()[0]; // Get the <T> in List<T>
                        Type rscListType = typeof(RscInterface<>).MakeGenericType(itemType); // Create RscInterface<T>
                        IList originalList = (IList)property.GetValue(obj);
                        IList rscList = (IList)Activator.CreateInstance(rscListType);

                        if (originalList != null)
                        {
                            foreach (var item in originalList)
                            {
                                rscList.Add(item); // Populate RscInterface<T> with items from the original List<T>
                            }
                            property.SetValue(obj, rscList); // Replace the original List<T> with RscInterface<T>
                        }
                    }
                    else
                    {
                        // Skip recursion for nullable primitives
                        Type underlyingType = Nullable.GetUnderlyingType(propertyType);
                        if (underlyingType != null && underlyingType.IsPrimitive)
                        {
                            continue; // Skip recursion for nullable primitives
                        }

                        if (!propertyType.IsPrimitive && propertyType != typeof(string))
                        {
                            // If the property is not a list but could contain lists, recursively convert its lists
                            var propertyValue = property.GetValue(obj);
                            if (propertyValue != null)
                            {
                                ConvertListsToRscInterfaces(propertyValue); // Recursive call
                            }
                        }
                    }
                }
            }
        }
    }
}
