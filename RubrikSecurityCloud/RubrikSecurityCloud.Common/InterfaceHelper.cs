#nullable enable
using System;
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
                        current._next = baseTypeItem;
                        current = current._next;
                    }
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
                current = current._next as BaseType;
            }

            return list;
        }
    }
}
