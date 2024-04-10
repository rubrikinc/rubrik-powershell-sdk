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
            ref List<T> list, 
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

        // This doesn't work because there's no conversion
        // from List<SomeSchemaType> to List<BaseType>
        // hence version with List<IEnumerable> below
        // public static BaseType? MakeCompositeFromList(List<BaseType> list)
        // {
        //     if (list == null || list.Count == 0)
        //     {
        //         return null;
        //     }

        //     for (int i = 0; i < list.Count - 1; i++)
        //     {
        //         list[i]._next = list[i + 1];
        //     }

        //     return list[0];
        // }

        public static BaseType MakeCompositeFromList(IEnumerable<object> list)
        {
            if (list == null || !list.Any())
            {
                throw new ArgumentException("List cannot be null or empty", nameof(list));
            }

            BaseType? current = null;
            foreach (var item in list)
            {
                if (item is BaseType baseTypeItem)
                {
                    if (current == null)
                    {
                        current = baseTypeItem;
                    } else
                    {
                        current.SetNext(baseTypeItem);
                        // move to next item
                        current = current.GetNext();
                    }
                    current?.SetNext(null);
            }
                else
                {
                    throw new ArgumentException("List item is not of BaseType or derived from BaseType", nameof(list));
                }
            }

            if (list.First() is BaseType firstBaseTypeItem)
            {
                return firstBaseTypeItem;
            }

            // this should never be reached due to check above
            throw new InvalidOperationException("First item in list is not of BaseType or derived from BaseType");
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

        public static void ConvertListsToRscLists(object obj)
        {
            if (obj == null) return;

            Type objType = obj.GetType();

            // Check if the object itself is a List<T>
            if (objType.IsGenericType && objType.GetGenericTypeDefinition() == typeof(List<>))
            {
                // This case handles when the object itself is a List<T>
                // Note: You would need to replace the object in its parent, which may be complex
                // depending on the context. This example does not cover that scenario directly.
            }
            else
            {
                // Recursively convert List<T> properties to RscList<T>
                PropertyInfo[] properties = objType.GetProperties();
                foreach (var property in properties)
                {
                    Type propertyType = property.PropertyType;

                    // Check if the property is of type List<T>
                    if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        Type itemType = propertyType.GetGenericArguments()[0]; // Get the <T> in List<T>
                        Type rscListType = typeof(RscList<>).MakeGenericType(itemType); // Create RscList<T>
                        IList originalList = (IList)property.GetValue(obj);
                        IList rscList = (IList)Activator.CreateInstance(rscListType);

                        if (originalList != null)
                        {
                            foreach (var item in originalList)
                            {
                                rscList.Add(item); // Populate RscList<T> with items from the original List<T>
                            }
                            property.SetValue(obj, rscList); // Replace the original List<T> with RscList<T>
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
                                ConvertListsToRscLists(propertyValue); // Recursive call
                            }
                        }
                    }
                }
            }
        }
    }
}
