using System;
using RubrikSecurityCloud.PowerShell.Models;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.Management.Automation;
using Rubrik.SecurityCloud.Types;
using RubrikSecurityCloud.Client;
using Rubrik.SecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Private
{
	public class RscTypeInitializer
	{

        private static bool IsNullableEnum(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.IsGenericType &&
                propertyInfo.PropertyType.GetGenericTypeDefinition() ==
                typeof(Nullable<>))
            {
                var underlyingType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                return underlyingType.IsEnum;
            }
            return false;
        }

        private static Type GetNullableUnderlyingType(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.IsGenericType &&
                propertyInfo.PropertyType.GetGenericTypeDefinition() ==
                typeof(Nullable<>))
            {
                var underlyingType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                return underlyingType;
            }
            else return propertyInfo.PropertyType;
        }

        public static List<RscTypeSummary> GetAllTypeNames(string namefilter = null)
        {
            List<RscTypeSummary> types = new List<RscTypeSummary>();
            var assembly = Assembly.Load("RubrikSecurityCloud.Schema");
            if (assembly != null)
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (type.Namespace == "Rubrik.SecurityCloud.Types")
                    {
                        if (namefilter != null)
                        {
                            if (type.Name.ToLower().Contains(namefilter.ToLower()))
                            {
                                if (type.IsClass)
                                {
                                    types.Add(new RscTypeSummary
                                    {
                                        Name = type.Name
                                    });
                                }
                            }
                        }
                        else
                        {
                            if (type.IsClass)
                            {
                                types.Add(new RscTypeSummary
                                {
                                    Name = type.Name
                                });
                            }
                        }
                    }
                }
            }

            return types;
        }

        public static Type GetTypeByName(string name)
        {
            var assembly = Assembly.Load("RubrikSecurityCloud.Schema");

            if (assembly != null)
            {
                var type = assembly.GetType("Rubrik.SecurityCloud.Types." + name, false, true);
                return type;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Return an instance of an input, with fields contained in
        /// inputFields initialized to non-null values.
        /// </summary>
        /// <param name="inputTypeName"></param>
        /// <param name="providedInputFields"></param>
        /// <returns>object</returns>
        /// <exception cref="Exception"></exception>
        public static object InitializeInputWithSelectedFields(
            string inputTypeName,
            Hashtable providedInputFields
        ){
            Type inputType = GetTypeByName(inputTypeName);

            if (inputType == null) {
                throw new Exception(
                    String.Format("No type found matching {0}", inputTypeName)
                );
            }

            object inputInstance = Activator.CreateInstance(inputType);
            foreach (DictionaryEntry inputField in providedInputFields) {
                string fieldName = "";
                object fieldValue = null;

                try {
                    fieldName = (string) inputField.Key;
                    fieldValue = inputField.Value;
                }
                catch (InvalidCastException e) {
                    throw new Exception(
                        String.Format(
                            "Input field {0} should be a string: {1}",
                            fieldName,
                            e
                        )
                    );
                }

                PropertyInfo inputTypeField =
                    inputInstance
                        .GetType()
                        .GetProperty(
                            fieldName,
                            BindingFlags.IgnoreCase |
                            BindingFlags.Instance |
                            BindingFlags.Public
                        );

                if (inputTypeField == null) {
                    throw new Exception(
                        String.Format(
                            "Input field {0} does not exist in {1}",
                            fieldName,
                            inputTypeName
                        )
                    );
                }

                try {
                    // non-scalar values in a PowerShell
                    // hashtable are wrapped with PSObject
                    if (fieldValue is PSObject) {
                        var psObject = (PSObject)fieldValue;
                        inputTypeField.SetValue(
                            inputInstance,
                            psObject.BaseObject
                        ); 
                    } else {
                        inputTypeField.SetValue(
                            inputInstance,
                            fieldValue
                        );
                    }
                }
                catch (ArgumentException e) {
                    throw new Exception(
                        String.Format(
                            "Provided value of input field {0} is wrong type: {1}",
                            fieldName,
                            e
                        )
                    );
                }
            }

            return inputInstance;
        }

        /// <summary>
        /// Return an instance of an class, with properties listed in
        /// requestedProperties initialized to non-null values.
        /// </summary>
        /// <param name="objectClassName"></param>
        /// <param name="requestedProperties"></param>
        /// <returns>object</returns>
        /// <exception cref="Exception"></exception>
        public static object InitializeTypeWithSelectedProperties(string objectClassName,
            string[] requestedProperties)
        {

            Type returnType = GetTypeByName(objectClassName);

            if (returnType != null)
            {
                object returnInstance = Activator.CreateInstance(returnType);
                PropertyInfo[] returnInstanceProperties = returnType.GetProperties();

                foreach (string requestedProperty in requestedProperties)
                {
                    //reset the object tree back to the return instance
                    object currentObject = returnInstance;
                    string[] requestedPropertyTree = requestedProperty.Split('.');

                    //Walk the requestedPropertyTree
                    for (int i = 0; i < requestedPropertyTree.Length; i++)
                    {
                        PropertyInfo currentProperty = currentObject.GetType()
                            .GetProperty(requestedPropertyTree[i],
                            BindingFlags.IgnoreCase |
                            BindingFlags.Instance |
                            BindingFlags.Public);

                        if (currentProperty == null)
                        {
                            //Console.WriteLine($"WARN: Unable to find property: " +
                            //    $"'{requestedPropertyTree[0]}' when evaluating " +
                            //    $"'{ requestedProperty }'");
                            continue;
                        }

                        //If current property is a a string
                        if (currentProperty.PropertyType == typeof(string))
                        {
                            currentProperty.SetValue(currentObject, "FETCH");
                            continue;
                        }

                        //if the property is a list, load or init it.
                        if (currentProperty.PropertyType.IsGenericType &&
                            currentProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            /*Console.WriteLine($"Property {currentProperty.Name} " +
                                $"is a list of type" +
                                $" {currentProperty.PropertyType.GetGenericArguments()[0]}");
                            */
                            Type genericArgumentType = currentProperty.PropertyType
                                .GetGenericArguments()[0];

                            if (returnInstance.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(returnInstance) == null)
                            {
                                // If the list if of an interface type,
                                // instantiate a compatible class to
                                // avoid a runtime exception
                                Type currentPropertyType = genericArgumentType;
                                if (genericArgumentType.IsInterface)
                                {
                                    currentPropertyType = 
                                        InterfaceHelper.CreateInstanceOfFirstType
                                        (genericArgumentType).GetType();
                                }

                                IList value = (IList)Activator.
                                    CreateInstance(currentProperty.PropertyType)
                                    ?? new List<object>();
                                value.Add(Activator.
                                    CreateInstance(currentPropertyType));

                                currentProperty.SetValue(currentObject, value);
                                currentObject = value[0];
                            }
                            else
                            {
                                IList value = (IList)returnInstance.GetType()
                                    .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(returnInstance);
                                currentObject = value[0];
                            }

                            continue;
                        }
                        //If a class, load or instantiate it
                        if (currentProperty.PropertyType.IsClass)
                        {
                            //Console.WriteLine($"Property {currentProperty.Name} is a Class");
                            if (currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject) == null)
                            {
                                object item = Activator.CreateInstance(currentProperty.PropertyType);
                                currentProperty.SetValue(currentObject, item);
                                currentObject = item;
                            }
                            else
                            {
                                object item = currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public)
                                .GetValue(currentObject);
                                currentObject = item;
                            }

                            continue;
                        }
                        //If interface, get a compatible concrete class
                        if (currentProperty.PropertyType.IsInterface)
                        {
                            //Console.WriteLine($"Property {currentProperty.Name} is an Interface");
                            if (currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject) == null)
                            {
                                object item = InterfaceHelper.CreateInstanceOfFirstType(currentProperty.PropertyType);
                                currentProperty.SetValue(currentObject, item);
                                currentObject = item;
                            }
                            else
                            {
                                object item = currentObject.GetType()
                                    .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject);
                                currentObject = item;
                            }
                            continue;
                        }

                        //If enum
                        else if (currentProperty.PropertyType.IsEnum ||
                            IsNullableEnum(currentProperty))
                        {
                            currentProperty.SetValue(currentObject,
                                Enum.GetValues(GetNullableUnderlyingType(currentProperty))
                                .GetValue(0));
                        }

                        else if (currentProperty.PropertyType == typeof(bool) ||
                            currentProperty.PropertyType == typeof(Boolean) ||
                            currentProperty.PropertyType == typeof(Boolean?))
                        {
                            currentProperty.SetValue(currentObject, true);
                        }
                        else if (currentProperty.PropertyType == typeof(int) ||
                            currentProperty.PropertyType == typeof(Int32) ||
                            currentProperty.PropertyType == typeof(Int32?))
                        {
                            currentProperty.SetValue(currentObject, 0);
                        }
                        else if (currentProperty.PropertyType == typeof(Int64) ||
                            currentProperty.PropertyType == typeof(Int64?))
                        {
                            currentProperty.SetValue(currentObject, (Int64)0);
                        }
                        else if (currentProperty.PropertyType == typeof(double) ||
                            currentProperty.PropertyType == typeof(Double))
                        {
                            currentProperty.SetValue(currentObject, 0);
                        }
                        else if (currentProperty.PropertyType == typeof(DateTime?) ||
                            currentProperty.PropertyType == typeof(DateTime))
                        {
                            currentProperty.SetValue(currentObject, new DateTime());
                        }
                        else
                        {
                            throw new Exception($"Property type not handled: '{currentProperty.PropertyType}'");
                        }
                    }
                }
                return returnInstance;
            }
            else
            {
                throw new Exception($"No type found matching: '{ objectClassName }'");
            }
		}
	}
}

