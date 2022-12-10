#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rubrik.SecurityCloud.Types
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
        /// This is required when constructing GQL queries from AsFragment()
        /// where intefaces need to be instantiated for all possible object
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
    }
}
