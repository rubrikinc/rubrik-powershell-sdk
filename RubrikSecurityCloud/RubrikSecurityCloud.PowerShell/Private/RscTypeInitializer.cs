using System;
using System.Linq;
using RubrikSecurityCloud.PowerShell.Models;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.Management.Automation;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.Client;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Private
{
    /// <summary>
    /// Static helper for Get-RscType. Creates and initializes .NET objects
    /// from the RSC GraphQL schema, using reflection against the
    /// RubrikSecurityCloud.Schema assembly.
    ///
    /// Three entry points:
    ///   - GetAllTypeNames()   → list types/interfaces (for -ListAvailable)
    ///   - GetTypeByName()     → resolve a type name to a System.Type
    ///   - InitializeTypeWithSelectedProperties() → build field-spec objects
    ///     (for -InitialProperties)
    ///   - InitializeInputWithSelectedFields() → build input objects with
    ///     user-provided values (for -InitialValues)
    ///
    /// Known issues:
    ///   - GetAllTypeNames() iterates all types in the assembly on each call.
    ///     Combined with the tab completer calling it on every tab press,
    ///     this is unnecessarily expensive.
    ///   - InitializeTypeWithSelectedProperties is a ~200-line method with
    ///     deeply nested if/else chains handling every property type (string,
    ///     list, interface, class, enum, bool, int, long, double, DateTime).
    ///     Should be refactored into per-type handlers.
    ///   - Property lookups are repeated redundantly: the code calls
    ///     GetProperty() to check if a value is null, even though
    ///     currentProperty already holds the same PropertyInfo.
    ///     Should use currentProperty.GetValue(currentObject) instead.
    /// </summary>
    public class RscTypeInitializer
    {
        /// <summary>
        /// Cached reference to the RubrikSecurityCloud.Schema assembly.
        /// Loaded once on first access; immutable at runtime.
        /// </summary>
        private static readonly Assembly _schemaAssembly =
            Assembly.Load("RubrikSecurityCloud.Schema")
            ?? throw new Exception("Unable to load RubrikSecurityCloud.Schema");

        /// <summary>
        /// Check if a PropertyInfo represents a Nullable&lt;Enum&gt;.
        /// </summary>
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

        /// <summary>
        /// Unwrap Nullable&lt;T&gt; to T, or return the type as-is.
        /// Used to get the underlying enum type for Nullable&lt;Enum&gt;.
        /// </summary>
        private static System.Type GetNullableUnderlyingType(PropertyInfo propertyInfo)
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

        /// <summary>
        /// List all RSC schema types whose names contain nameFilter (case-insensitive).
        /// Returns output types (subclasses of BaseType), input types (IInput),
        /// or interfaces (IFieldSpec), depending on the interfaces flag.
        ///
        /// </summary>
        public static List<RscTypeSummary> GetAllTypeNames(
               string nameFilter = null,
               bool interfaces = false)
        {
            List<RscTypeSummary> types = new List<RscTypeSummary>();
            System.Type baseType = typeof(BaseType);
            System.Type inputInterface = typeof(IInput); // For input types
            System.Type fieldSpecInterface = typeof(IFieldSpec);
            var allTypes = _schemaAssembly.GetTypes();
            foreach (var type in allTypes)
            {
                if (type.Namespace != "RubrikSecurityCloud.Types")
                {
                    continue;
                }
                if (nameFilter != null
                    && !type.Name.ToLower().Contains(nameFilter.ToLower()))
                {
                    continue;
                }
                // Add output types (derived from BaseType)
                if (!interfaces && type.IsClass && type.IsSubclassOf(baseType))
                {
                    types.Add(new RscTypeSummary { Name = type.Name });
                }
                // Add input types (implementing IInput)
                else if (!interfaces && type.IsClass && inputInterface.IsAssignableFrom(type))
                {
                    types.Add(new RscTypeSummary { Name = type.Name });
                }
                // Add interfaces if requested
                else if (interfaces && type.IsInterface && fieldSpecInterface.IsAssignableFrom(type))
                {
                    types.Add(new RscTypeSummary { Name = type.Name });
                }
            }

            return types.OrderBy(type => type.Name).ToList();
        }

        /// <summary>
        /// Resolve a short type name (e.g. "Cluster") to its System.Type
        /// in the RubrikSecurityCloud.Types namespace. Case-insensitive.
        /// Returns null if not found.
        /// </summary>
        public static System.Type GetTypeByName(string name)
        {
            return _schemaAssembly.GetType(
                "RubrikSecurityCloud.Types." + name, false, true);
        }

        /// <summary>
        /// Create an instance of an input type and set fields to user-provided values.
        /// Used by Get-RscType -InitialValues.
        ///
        /// Handles PowerShell → C# type coercion:
        ///   - PSObject wrappers are unwrapped to their BaseObject.
        ///   - PowerShell arrays (object[]) targeting a List&lt;T&gt; property
        ///     are converted to the appropriate generic List.
        ///
        /// Property lookup is case-insensitive.
        /// Throws on unknown field names or type mismatches.
        /// </summary>
        public static object InitializeInputWithSelectedFields(
            string inputTypeName,
            Hashtable providedInputFields
        ){
            System.Type inputType = GetTypeByName(inputTypeName);

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
                    // Non-scalar values in a PowerShell hashtable are
                    // wrapped with PSObject. Unwrap to the real object.
                    if (fieldValue is PSObject) {
                        var psObject = (PSObject)fieldValue;
                        inputTypeField.SetValue(
                            inputInstance,
                            psObject.BaseObject
                        );
                    } else {
                        // PowerShell arrays (@("a","b")) arrive as object[].
                        // If the target property is List<T>, convert automatically.
                        if (fieldValue is object[] objArray &&
                            inputTypeField.PropertyType.IsGenericType &&
                            inputTypeField.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            var genericArgumentType = inputTypeField.PropertyType.GetGenericArguments()[0];
                            var listType = typeof(List<>).MakeGenericType(genericArgumentType);
                            var list = (IList)Activator.CreateInstance(listType);

                            foreach (var item in objArray)
                            {
                                try
                                {
                                    var convertedItem = Convert.ChangeType(item, genericArgumentType);
                                    list.Add(convertedItem);
                                }
                                catch (Exception ex)
                                {
                                    throw new ArgumentException(
                                        $"Unable to convert item '{item}' to type '{genericArgumentType.Name}'. " +
                                        $"Error: {ex.Message}", ex);
                                }
                            }

                            fieldValue = list;
                        }

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
        /// Create an instance of an output type and set requested properties
        /// to sentinel values. Used by Get-RscType -InitialProperties.
        ///
        /// This is the main method for building GraphQL field-spec objects.
        /// The SDK convention: null = "don't request", non-null = "request."
        /// The actual sentinel values don't matter for the query — they just
        /// make the property non-null. The response is deserialized into a
        /// separate fresh object.
        ///
        /// ## Sentinel values by type
        ///   string    → "FETCH"
        ///   bool/bool? → true
        ///   int/int?   → 0
        ///   long/long? → 0L
        ///   double     → 0.0
        ///   DateTime?  → new DateTime()
        ///   enum?      → first enum value (index 0, usually UNKNOWN)
        ///   class      → new instance (Activator.CreateInstance)
        ///   interface  → first implementing type (InterfaceHelper)
        ///   List&lt;T&gt;    → new list with one element of type T
        ///   List&lt;Interface&gt; → list with one instance of EVERY implementing
        ///                       type, so the field spec includes all possible
        ///                       inline fragments (... on TypeA, ... on TypeB).
        ///
        /// ## Dotted paths
        /// Properties can be dotted paths like "nodes.id". The method splits
        /// on '.' and walks into nested objects, instantiating intermediate
        /// objects as needed. For example, "cloudInfo.name" will:
        ///   1. Find/create the CloudInfo object on the parent
        ///   2. Set CloudInfo.Name to "FETCH"
        ///
        /// ## List&lt;Interface&gt; behavior
        /// When a property is a List of an interface type (e.g.
        /// List&lt;MssqlTopLevelDescendantType&gt;), this method creates one
        /// instance of EVERY implementing type and adds them all to the list.
        /// This ensures the generated GraphQL query includes inline fragments
        /// for all possible types.
        ///
        /// If you only want a SINGLE implementing type (e.g. just PhysicalHost),
        /// you cannot achieve that with -InitialProperties alone. You must:
        ///   1. Create the specific type separately with Get-RscType
        ///   2. Manually assign it to the list property
        /// See the unit test "Double interface list" for a worked example.
        ///
        /// The remaining property paths are stripped of the parent prefix
        /// before being passed to recursive calls on implementing types.
        /// For example, if requestedProperties is ["nodes.id"] and we're
        /// processing "nodes" (a List&lt;Interface&gt;), each implementing type
        /// receives ["id"], not ["nodes.id"].
        ///
        /// ## Known issues
        ///   - This method is ~200 lines with deeply nested if/else chains.
        ///     The type-dispatch logic (string, list, class, interface, enum,
        ///     bool, int, etc.) should be refactored into separate handlers.
        ///   - Property lookups are repeated: the code calls GetProperty()
        ///     again to check if a value is null, even though currentProperty
        ///     already holds the same PropertyInfo. Should just use
        ///     currentProperty.GetValue(currentObject).
        ///   - The `implementingInstances` variable (line ~325) is computed
        ///     but never used — it's dead code.
        /// </summary>
        public static object InitializeTypeWithSelectedProperties(string objectClassName,
            string[] requestedProperties)
        {

            System.Type returnType = GetTypeByName(objectClassName);

            if (returnType != null)
            {
                object returnInstance = Activator.CreateInstance(returnType);
                // Note: returnInstanceProperties is fetched but never used
                // directly — property lookup happens via currentObject.GetType()
                // inside the loop, since currentObject changes as we walk
                // dotted paths.
                PropertyInfo[] returnInstanceProperties = returnType.GetProperties();

                // Outer loop: each requestedProperty is an independent path.
                // "currentObject" is reset to returnInstance for each one.
                foreach (string requestedProperty in requestedProperties)
                {
                    object currentObject = returnInstance;
                    string[] requestedPropertyTree = requestedProperty.Split('.');

                    // Inner loop: walk the dotted path segment by segment.
                    // At each step, currentObject advances to the nested object.
                    for (int i = 0; i < requestedPropertyTree.Length; i++)
                    {
                        PropertyInfo currentProperty = currentObject.GetType()
                            .GetProperty(requestedPropertyTree[i],
                            BindingFlags.IgnoreCase |
                            BindingFlags.Instance |
                            BindingFlags.Public);

                        if (currentProperty == null)
                        {
                            throw new Exception(
                                $"Property '{requestedPropertyTree[i]}' not found on type " +
                                $"'{currentObject.GetType().Name}' when evaluating '{requestedProperty}'."
                            );
                        }

                        // --- Leaf types: set sentinel and continue ---

                        if (currentProperty.PropertyType == typeof(string))
                        {
                            currentProperty.SetValue(currentObject, "FETCH");
                            continue;
                        }

                        // --- List<T>: init the list if null, then advance
                        // currentObject to the first element ---

                        if (currentProperty.PropertyType.IsGenericType &&
                            currentProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            System.Type genericArgumentType = currentProperty.PropertyType
                                .GetGenericArguments()[0];

                            // Known issue: redundant GetProperty() call — should
                            // use currentProperty.GetValue(currentObject) instead.
                            if (currentObject.GetType()
                                .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject) == null)
                            {
                                System.Type currentPropertyType = genericArgumentType;

                                // --- List<Interface>: create ALL implementing types ---
                                if (genericArgumentType.IsInterface)
                                {
                                    // Use reflection to call the generic method
                                    // InterfaceHelper.CreateInstancesOfImplementingTypes<T>()
                                    // with the correct type parameter.
                                    MethodInfo typeInstancesMethod =
                                        typeof(InterfaceHelper)
                                        .GetMethod("CreateInstancesOfImplementingTypes");
                                    MethodInfo getInstancesMethod =
                                        typeInstancesMethod
                                        .MakeGenericMethod(genericArgumentType);

                                    object[] parameters = new object[] { genericArgumentType };

                                    IList value = (IList)getInstancesMethod.Invoke(null, parameters);

                                    // Known issue: implementingInstances is dead code —
                                    // computed but never used.
                                    IList implementingInstances =
                                        InterfaceHelper
                                        .CreateInstancesOfImplementingTypes<object>(genericArgumentType);

                                    IList rtnObjs = CopyList(value);
                                    rtnObjs.Clear();

                                    // Strip the parent prefix from property paths before
                                    // recursing into implementing types.
                                    // e.g. ["nodes.id", "nodes.name"] at depth i=0 ("nodes")
                                    //    → ["id", "name"] for each implementing type.
                                    string[] remainingProperties = requestedProperties
                                        .Select(rp => {
                                            string[] parts = rp.Split('.');
                                            if (parts.Length > i + 1 && string.Equals(parts[i], requestedPropertyTree[i], StringComparison.OrdinalIgnoreCase))
                                            {
                                                return string.Join(".", parts.Skip(i + 1));
                                            }
                                            return null;
                                        })
                                        .Where(rp => rp != null)
                                        .ToArray();

                                    foreach (var item in value)
                                    {
                                        if (remainingProperties.Length > 0)
                                        {
                                            rtnObjs.Add(InitializeTypeWithSelectedProperties(
                                                item.GetType().Name,
                                                remainingProperties));
                                        }
                                        else
                                        {
                                            rtnObjs.Add(item);
                                        }
                                    }

                                    currentProperty.SetValue(currentObject, rtnObjs);
                                    currentObject = rtnObjs[0];
                                }
                                // --- List<ConcreteType>: create one element ---
                                else
                                {
                                    IList value = (IList)Activator.
                                        CreateInstance(currentProperty.PropertyType)
                                        ?? new List<object>();
                                    value.Add(Activator.
                                        CreateInstance(currentPropertyType));

                                    currentProperty.SetValue(currentObject, value);
                                    currentObject = value[0];
                                }
                            }
                            // List already exists — advance into its first element.
                            else
                            {
                                // Known issue: redundant GetProperty() call.
                                IList value = (IList)currentObject?.GetType()?
                                    .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public)?.GetValue(currentObject);
                                currentObject = value[0];
                            }

                            continue;
                        }

                        // --- Class: instantiate if null, then advance ---

                        if (currentProperty.PropertyType.IsClass)
                        {
                            // Known issue: redundant GetProperty() call.
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
                                // Known issue: redundant GetProperty() call.
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

                        // --- Single interface (not a list): pick first
                        // implementing type ---

                        if (currentProperty.PropertyType.IsInterface)
                        {
                            // Known issue: redundant GetProperty() call.
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
                                // Known issue: redundant GetProperty() call.
                                object item = currentObject.GetType()
                                    .GetProperty(requestedPropertyTree[i],
                                    BindingFlags.IgnoreCase |
                                    BindingFlags.Instance |
                                    BindingFlags.Public).GetValue(currentObject);
                                currentObject = item;
                            }
                            continue;
                        }

                        // --- Scalar leaf types: set sentinel values ---

                        else if (currentProperty.PropertyType.IsEnum ||
                            IsNullableEnum(currentProperty))
                        {
                            // Always picks index 0, usually UNKNOWN/UNSPECIFIED.
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

        /// <summary>
        /// Deep-copy an IList (preserving its concrete generic type).
        /// </summary>
        private static IList CopyList(IList source)
        {
            IList copy = (IList)Activator.CreateInstance(source.GetType());
            foreach (var item in source)
            {
                copy.Add(item);
            }
            return copy;
        }
    }
}
