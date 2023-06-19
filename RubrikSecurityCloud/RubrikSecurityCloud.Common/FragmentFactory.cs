using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud
{
    public static class FragmentFactory
    {
        private static string GetGqlName(string netName)
        {
            return Regex.Replace(netName, @"^([A-Z])+", m => m.Groups[1].Value.ToLower());
        }

        private static bool IsNullableEnum(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.IsGenericType &&
                propertyInfo.PropertyType.GetGenericTypeDefinition() ==
                typeof(Nullable<>))
            {
                Type? underlyingType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                if (underlyingType != null)
                {
                    return underlyingType.IsEnum;
                }
                return false;
            }
            return false;
        }

        private static Type GetNullableUnderlyingType(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.IsGenericType &&
                propertyInfo.PropertyType.GetGenericTypeDefinition() ==
                typeof(Nullable<>))
            {
                Type? underlyingType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                if (underlyingType != null)
                {
                    return underlyingType;
                }
                else
                {
                    return propertyInfo.PropertyType;
                }

            }
            else return propertyInfo.PropertyType;
        }


        public static bool AreAllPropertiesNull(this object input)
        {
            PropertyInfo[] properties = input.GetType().GetProperties();
            bool returnValue = true;

            foreach (PropertyInfo property in properties)
            {

                Type basePropertyType = GetNullableUnderlyingType(property);
                var propertyValue = property.GetValue(input);

                if (propertyValue != null)
                {
                    if (IsSimpleType(propertyValue.GetType()))
                    {
                        if (propertyValue != null)
                        {
                            returnValue = false;
                            break;
                        }
                    }
                    else if (propertyValue.GetType().IsGenericType)
                    {
                        Type genericTypeDef = basePropertyType.GetGenericTypeDefinition();
                        Type genericTypeArg = genericTypeDef.GetGenericArguments()[0];

                        if (genericTypeDef == typeof(List<>))
                        {
                            IList list = (IList)propertyValue;
                            if (list.Count > 0)
                            {
                                if (IsSimpleType(list[0].GetType()) && list[0] != null)
                                {
                                    returnValue = false;
                                }
                                else
                                {
                                    if (list[0] != null)
                                    {
                                        returnValue = list[0].AreAllPropertiesNull();
                                    }
                                }
                            }
                        }
                    }
                    else if (propertyValue.GetType().IsClass)
                    {
                        returnValue = propertyValue.AreAllPropertiesNull();
                    }
                    else if (property.GetValue(input) != null)
                    {
                        returnValue = false;
                        break;
                    }
                }
            }
            return returnValue;
        }

        private static bool IsSimpleType(Type type)
        {
            return type.IsPrimitive || type.IsValueType || type == typeof(string);
        }

        /// <summary>
        /// Returns a string containing initialized fields in GQL query format.
        /// </summary>
        /// <param name="inputObject">Object to return fields as fragment.</param>
        /// <param name="indent">Text indentation.</param>
        /// <returns>System.String</returns>
        public static string GetFragment(object inputObject, int indent)
        {
            string ind = new string(' ', indent * 2);
            string returnData = "";

            Type objectType = inputObject.GetType();

            PropertyInfo[] properties = objectType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                try
                {
                    var propertyValue = property.GetValue(inputObject);

                    if (propertyValue != null)
                    {
                        Type basePropertyType = GetNullableUnderlyingType(property);

                        //If the property is a simple type, init it and
                        // append it's name to the return payload with a new
                        // line
                        if (IsSimpleType(property.PropertyType))
                        {
                            returnData += ind + GetGqlName(property.Name) + "\n";
                        }
                        //If not a simple type...
                        else
                        {
                            //If the property is generic, i.e. 'List<Type>'
                            if (property.PropertyType.IsGenericType)
                            {
                                Type genericTypeDefinition = basePropertyType.GetGenericTypeDefinition();
                                Type genericArgumentType = basePropertyType.GetGenericArguments()[0];

                                //If the property is a List<>
                                if (genericTypeDefinition == typeof(List<>))
                                {
                                    //Cast value into type IList
                                    IList list = (IList)propertyValue;

                                    // If the list is not null or empty
                                    if (list != null && list.Count > 0)
                                    {
                                        List<object> outputItems = new List<object>();

                                        if (IsSimpleType(genericArgumentType) ||
                                            genericArgumentType.IsEnum)
                                        {
                                            returnData += ind + GetGqlName(property.Name) + "\n";
                                            continue;
                                        }
                                        else
                                        {
                                            bool allNull = true;

                                            foreach(var item in list)
                                            {
                                                if (!item.AreAllPropertiesNull())
                                                {
                                                    allNull = false;
                                                    outputItems.Add(item);
                                                }
                                            }

                                            if (allNull) continue;
                                        }

                                        // Get the original property type (pre initialized)
                                        // to see if it is an interface
                                        Type baseType = (inputObject.GetType()
                                            .GetProperty(property.Name)
                                            .PropertyType).GetGenericArguments()[0];

                                        if (baseType.IsInterface)
                                        {
                                            if (outputItems.Count == 0)
                                            {
                                                outputItems = InterfaceHelper
                                                    .CreateInstancesOfImplementingTypes<object>
                                                    (genericArgumentType);
                                            }
                                            
                                            returnData += ind + GetGqlName(property.Name) + "\n{\n";
                                            foreach (var typeItem in outputItems)
                                            {
                                                returnData += ind + "... on " + typeItem.GetType().Name + "\n";
                                                returnData += "{\n";
                                                returnData += GetFragment(typeItem, 0);
                                                returnData += "}\n";
                                            }
                                        }
                                        else
                                        {
                                            returnData += ind + GetGqlName(property.Name) + " {\n";
                                            returnData += GetFragment(list[0], indent + 1);
                                        }
                                    }
                                }
                                returnData += ind + "}\n";
                            }
                            else
                            {
                                if (inputObject.GetType()
                                    .GetProperty(property.Name)
                                    .PropertyType.IsInterface)
                                {
                                    if (propertyValue.AreAllPropertiesNull())
                                    {
                                        continue;
                                    }
                                    returnData += ind + GetGqlName(property.Name) + "\n{\n";
                                    returnData += ind + "... on " + propertyValue.GetType().Name + "\n";
                                    returnData += "{\n";
                                    returnData += GetFragment(propertyValue, indent + 1);
                                    returnData += "}\n";
                                }
                                else if (property.PropertyType.IsClass)
                                {
                                    if (propertyValue.AreAllPropertiesNull())
                                    {
                                        continue;
                                    }

                                    returnData += ind + GetGqlName(property.Name) + "\n{\n";
                                    returnData += GetFragment(propertyValue, indent + 1);
                                }
                                returnData += ind + "}\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception on property {property.Name}: {ex.Message}: {ex.StackTrace}");
                    return "";
                }
            }
            return returnData;
        }

        /// <summary>
        /// Return an initialized object of input type.
        /// </summary>
        /// <param name="inputType"></param>
        /// <returns>object with an appropriate value</returns>
        private static object? InitializeSimpleValue(Type inputType)
        {
            Type propType = inputType;

            if (propType == typeof(string))
            {
                return new string("FETCH");
            }
            else if (propType == typeof(bool) ||
                propType == typeof(Boolean) ||
                propType == typeof(Boolean?))
            {
                return false;
            }
            else if (propType == typeof(int) ||
                propType == typeof(Int32) ||
                propType == typeof(Int32?))
            {
                return 0;
            }
            else if(propType == typeof(Int64) ||
                propType == typeof(Int64?))
            {
                return Convert.ToInt64(0);
            }
            else if (propType == typeof(Single))
            {
                return Convert.ToSingle(0);
            }
            else if (propType == typeof(double) ||
                propType == typeof(Double) ||
                propType == typeof(Double?) ||
                propType == typeof(long) ||
                propType == typeof(long?) ||
                propType == typeof(float) ||
                propType == typeof(float?))
            {
                return Convert.ToDouble(0);
            }
            else if (propType == typeof(DateTime) ||
                propType == typeof(DateTime?))
            {
                return new DateTime();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Initialize properties of an object to non-null values
        /// </summary>
        /// <param name="inputObject">Object to initialize properties of</param>
        /// <param name="maxDepth">Initialize nested object properties to level</param>
        /// <param name="currentDepth">Used for tracking recursive initialization</param>
        public static void InitializeToDefaultValues(this object inputObject,
                                                     int maxDepth = 0,
                                                     int currentDepth = 0)
        {
            if (maxDepth > 2)
            {
                Console.WriteLine("WARN: maxDepth is limited to 2. ");
                maxDepth = 2;
            }

            if (currentDepth > maxDepth) return;

            PropertyInfo[] inputObjProperties = inputObject.GetType().GetProperties();

            foreach (PropertyInfo inputObjProperty in inputObjProperties)
            {
                if (inputObjProperty.GetValue(inputObject) == null)
                {
                    string propertyName = inputObjProperty.Name;
                    try
                    {
                        Type basePropertyType = GetNullableUnderlyingType(inputObjProperty);

                        if (IsNullableEnum(inputObjProperty))
                        {
                            inputObjProperty.SetValue(inputObject,
                                Enum.GetValues(GetNullableUnderlyingType(inputObjProperty)).GetValue(0));
                        }
                        else if (IsSimpleType(basePropertyType))
                        {
                            inputObjProperty.SetValue(inputObject, InitializeSimpleValue(basePropertyType));
                        }
                        
                        else if (basePropertyType.IsClass && maxDepth > 0)
                        {
                            //Check if the property is a list
                            if (basePropertyType.IsGenericType)
                            {
                                Type genericTypeDefinition = basePropertyType.GetGenericTypeDefinition();
                                Type genericArgumentType = basePropertyType.GetGenericArguments()[0];

                                if (genericTypeDefinition == typeof(List<>))
                                {
                                    IList list = (IList)Activator.CreateInstance(basePropertyType) ?? new List<object>();

                                    IList testList = list;
                                    object? item;
                                    object? testItem = new object();

                                    if (genericArgumentType.IsInterface)
                                    {
                                        bool compatInterfaceReturned = false;
                                        int retryCount = 0;
                                        while (!compatInterfaceReturned && retryCount < 10)
                                        {
                                            try
                                            {
                                                testItem = InterfaceHelper.CreateInstanceOfFirstType(genericArgumentType, retryCount);
                                                if (testItem == null) throw new Exception("No results from InterfaceHelper...");
                                                testList.Add(testItem);
                                                compatInterfaceReturned = true;
                                            }
                                            catch(Exception ex)
                                            {
                                                if (retryCount >= 10) continue;
                                                retryCount++;
                                                Console.WriteLine($"Concrete class not suitable, "+
                                                    $"trying again. Retries: {retryCount}." +
                                                    $" MESSAGE: { ex.Message}");

                                                compatInterfaceReturned = false;
                                            }
                                        }

                                        item = testItem;
                                    }
                                    else
                                    {
                                        if (genericArgumentType.IsEnum)
                                        {
                                            item = Enum.GetValues(genericArgumentType).GetValue(0);
                                        }
                                        else if (IsSimpleType(genericArgumentType))
                                        {
                                            item = InitializeSimpleValue(genericArgumentType);
                                        }
                                        else
                                        {
                                            item = Activator.CreateInstance(genericArgumentType);
                                            if (currentDepth <= maxDepth)
                                            {
                                                int nextDepth = currentDepth + 1;
                                                Console.WriteLine($"Calling GetExploratoryFragment on {inputObjProperty.Name}");
                                                item.InitializeToDefaultValues(maxDepth, nextDepth);
                                            }
                                        }
                                    }
                                    
                                    list.Add(item);
                                    inputObjProperty.SetValue(inputObject, list);
                                }
                            }
                            else
                            {
                                object item = Activator.CreateInstance(basePropertyType);
                                if (currentDepth <= maxDepth)
                                {
                                    int nextDepth = currentDepth + 1;
                                    item.InitializeToDefaultValues(maxDepth, nextDepth);
                                }
                                inputObjProperty.SetValue(inputObject, item);
                            }
                        }
                        else if (basePropertyType.IsInterface && maxDepth > 0)
                        {
                            var item = InterfaceHelper.CreateInstanceOfFirstType(basePropertyType);

                            if (currentDepth <= maxDepth)
                            {
                                int nextDepth = currentDepth + 1;
                                item?.InitializeToDefaultValues(maxDepth, nextDepth);
                            }
                            inputObjProperty.SetValue(inputObject, item);       
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing property: '{inputObjProperty.Name}': {ex.StackTrace}.");
                    }
                }
            }
        }
    }
}