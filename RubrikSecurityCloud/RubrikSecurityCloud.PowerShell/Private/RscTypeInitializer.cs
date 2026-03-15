using System;
using System.Linq;
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
        /// Cached sorted list of all class type names (output + input types).
        /// Built lazily on first access from the schema assembly.
        /// </summary>
        private static List<string> _allClassNames = null;

        /// <summary>
        /// Cached sorted list of all interface type names (IFieldSpec interfaces).
        /// Built lazily on first access from the schema assembly.
        /// </summary>
        private static List<string> _allInterfaceNames = null;

        /// <summary>
        /// Scan the schema assembly once and populate both caches.
        /// </summary>
        private static void EnsureTypeNameCaches()
        {
            if (_allClassNames != null)
            {
                return;
            }

            var classes = new List<string>();
            var ifaces = new List<string>();
            System.Type baseType = typeof(BaseType);
            System.Type inputInterface = typeof(IInput);
            System.Type fieldSpecInterface = typeof(IFieldSpec);

            foreach (var type in _schemaAssembly.GetTypes())
            {
                if (type.Namespace != "RubrikSecurityCloud.Types")
                {
                    continue;
                }
                // Output types (derived from BaseType)
                if (type.IsClass && type.IsSubclassOf(baseType))
                {
                    classes.Add(type.Name);
                }
                // Input types (implementing IInput)
                else if (type.IsClass && inputInterface.IsAssignableFrom(type))
                {
                    classes.Add(type.Name);
                }
                // Interfaces (implementing IFieldSpec)
                if (type.IsInterface && fieldSpecInterface.IsAssignableFrom(type))
                {
                    ifaces.Add(type.Name);
                }
            }

            _allClassNames = classes.OrderBy(n => n).ToList();
            _allInterfaceNames = ifaces.OrderBy(n => n).ToList();
        }

        /// <summary>
        /// List RSC schema type names containing nameFilter (case-insensitive).
        /// Returns output+input types by default, or interfaces with interfaces=true.
        /// Results are filtered from a cached list built on first call.
        /// </summary>
        public static List<string> GetAllTypeNames(
               string nameFilter = null,
               bool interfaces = false)
        {
            EnsureTypeNameCaches();

            var source = interfaces ? _allInterfaceNames : _allClassNames;

            if (nameFilter == null)
            {
                return source;
            }

            var lowerFilter = nameFilter.ToLower();
            return source
                .Where(n => n.ToLower().Contains(lowerFilter))
                .ToList();
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

        // ---------------------------------------------------------------
        //  InitializeTypeWithSelectedProperties and its helpers
        // ---------------------------------------------------------------

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
        /// Properties can be dotted paths like "nodes.id". The method splits
        /// on '.' and walks into nested objects, instantiating intermediate
        /// objects as needed.
        ///
        /// See SetScalarSentinel for sentinel values by type.
        /// See InitializeInterfaceList for List&lt;Interface&gt; behavior.
        /// See GetOrCreatePropertyValue for class/interface instantiation.
        /// </summary>
        public static object InitializeTypeWithSelectedProperties(
            string objectClassName,
            string[] requestedProperties)
        {
            System.Type returnType = GetTypeByName(objectClassName);

            if (returnType == null)
            {
                throw new Exception(
                    $"No type found matching: '{objectClassName}'");
            }

            // Interface root: delegate to InitializeInterfaceRoot
            if (returnType.IsInterface)
            {
                return InitializeInterfaceRoot(
                    returnType, requestedProperties);
            }

            object returnInstance = Activator.CreateInstance(returnType);

            // Outer loop: each requestedProperty is an independent path.
            // "currentObject" is reset to returnInstance for each one.
            foreach (string requestedProperty in requestedProperties)
            {
                object currentObject = returnInstance;
                string[] segments = requestedProperty.Split('.');

                // Inner loop: walk the dotted path segment by segment.
                // At each step, currentObject advances to the nested object.
                for (int i = 0; i < segments.Length; i++)
                {
                    // "*" wildcard: set all scalar properties on
                    // the current object. Must be the last segment.
                    if (segments[i] == "*")
                    {
                        foreach (PropertyInfo p in currentObject.GetType()
                            .GetProperties(BindingFlags.Instance |
                                           BindingFlags.Public))
                        {
                            SetScalarSentinel(currentObject, p);
                        }
                        break;
                    }

                    PropertyInfo prop = currentObject.GetType()
                        .GetProperty(segments[i],
                            BindingFlags.IgnoreCase |
                            BindingFlags.Instance |
                            BindingFlags.Public);

                    if (prop == null)
                    {
                        throw new Exception(
                            $"Property '{segments[i]}' not found on type " +
                            $"'{currentObject.GetType().Name}' " +
                            $"when evaluating '{requestedProperty}'.");
                    }

                    // Scalar leaf: set sentinel and move to next property.
                    if (SetScalarSentinel(currentObject, prop))
                    {
                        continue;
                    }

                    // List<T>: initialize if null, then advance into
                    // the first element.
                    if (prop.PropertyType.IsGenericType &&
                        prop.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        System.Type elementType =
                            prop.PropertyType.GetGenericArguments()[0];

                        if (prop.GetValue(currentObject) == null)
                        {
                            if (elementType.IsInterface)
                            {
                                // Check for on: type selector in next segment
                                string typeFilter = null;
                                if (i + 1 < segments.Length &&
                                    segments[i + 1].StartsWith("on:", StringComparison.OrdinalIgnoreCase))
                                {
                                    string selector = segments[i + 1].Substring(3);
                                    typeFilter = selector == "*" ? null : selector;
                                    i++; // consume the on: segment
                                }
                                currentObject = InitializeInterfaceList(
                                    currentObject, prop, elementType,
                                    typeFilter,
                                    requestedProperties, segments, i);
                            }
                            else
                            {
                                // List<ConcreteType>: create list with one element.
                                IList list = (IList)Activator
                                    .CreateInstance(prop.PropertyType);
                                list.Add(Activator.CreateInstance(elementType));
                                prop.SetValue(currentObject, list);
                                currentObject = list[0];
                            }
                        }
                        else
                        {
                            // List already exists.
                            IList existingList = (IList)prop.GetValue(currentObject);

                            // Check for on: type selector
                            if (i + 1 < segments.Length &&
                                segments[i + 1].StartsWith("on:", StringComparison.OrdinalIgnoreCase))
                            {
                                string selector = segments[i + 1].Substring(3);
                                i++; // consume the on: segment

                                if (selector != "*")
                                {
                                    // Find existing element of this type, or create and add one.
                                    object match = null;
                                    foreach (var item in existingList)
                                    {
                                        if (string.Equals(item.GetType().Name, selector,
                                            StringComparison.OrdinalIgnoreCase))
                                        {
                                            match = item;
                                            break;
                                        }
                                    }
                                    if (match == null)
                                    {
                                        System.Type matchType = GetTypeByName(selector);
                                        if (matchType == null || !elementType.IsAssignableFrom(matchType))
                                        {
                                            throw new Exception(
                                                $"Type '{selector}' does not implement " +
                                                $"interface '{elementType.Name}'. " +
                                                $"Use on:* to see all implementing types.");
                                        }
                                        match = Activator.CreateInstance(matchType);
                                        existingList.Add(match);
                                    }
                                    currentObject = match;
                                }
                                else
                                {
                                    // on:* with existing list — advance into first element.
                                    currentObject = existingList[0];
                                }
                            }
                            else
                            {
                                // No on: selector — advance into first element.
                                currentObject = existingList[0];
                            }
                        }
                        continue;
                    }

                    // Class or interface: get existing value or create new,
                    // then advance.
                    if (prop.PropertyType.IsClass || prop.PropertyType.IsInterface)
                    {
                        if (prop.PropertyType.IsInterface &&
                            i + 1 < segments.Length &&
                            segments[i + 1].StartsWith("on:",
                                StringComparison.OrdinalIgnoreCase))
                        {
                            string selector = segments[i + 1].Substring(3);
                            i++; // consume the on: segment
                            if (selector == "*")
                            {
                                currentObject = GetOrCreatePropertyValue(
                                    currentObject, prop);
                            }
                            else
                            {
                                currentObject = GetOrCreatePropertyValue(
                                    currentObject, prop, selector);
                            }
                        }
                        else
                        {
                            currentObject = GetOrCreatePropertyValue(
                                currentObject, prop);
                        }
                        continue;
                    }

                    // Should not reach here — SetScalarSentinel handles
                    // all known leaf types.
                    throw new Exception(
                        $"Property type not handled: '{prop.PropertyType}'");
                }
            }
            return returnInstance;
        }

        /// <summary>
        /// Handle an interface as the root type. Groups requestedProperties
        /// by on: type selector, initializes each implementing type
        /// independently, then chains them into a composite via
        /// MakeCompositeFromList.
        ///
        /// Supported property forms:
        ///   on:TypeName.field  → only that implementing type
        ///   on:*.field         → all implementing types
        ///   field (no on:)     → all implementing types (backward compat)
        /// </summary>
        private static object InitializeInterfaceRoot(
            System.Type interfaceType,
            string[] requestedProperties)
        {
            var implNames = ReflectionUtils.GetTypesImplementingInterface(
                interfaceType.Name);

            // Group properties: key = type name or "*" for wildcard/bare.
            var groups = new Dictionary<string, List<string>>(
                StringComparer.OrdinalIgnoreCase);

            foreach (string rp in requestedProperties)
            {
                string[] parts = rp.Split(new[] { '.' }, 2);
                string first = parts[0];
                string rest = parts.Length > 1 ? parts[1] : null;

                if (first.StartsWith("on:", StringComparison.OrdinalIgnoreCase))
                {
                    string selector = first.Substring(3);
                    string key = selector == "*" ? "*" : selector;
                    if (!groups.ContainsKey(key))
                        groups[key] = new List<string>();
                    if (rest != null)
                        groups[key].Add(rest);
                }
                else
                {
                    // Bare property — treat as wildcard
                    if (!groups.ContainsKey("*"))
                        groups["*"] = new List<string>();
                    groups["*"].Add(rp);
                }
            }

            // Validate specific type names
            foreach (string key in groups.Keys)
            {
                if (key == "*") continue;
                if (!implNames.Contains(key, StringComparer.OrdinalIgnoreCase))
                {
                    throw new Exception(
                        $"Type '{key}' does not implement " +
                        $"interface '{interfaceType.Name}'. " +
                        $"Use on:* to see all implementing types.");
                }
            }

            List<string> wildcardProps = groups.ContainsKey("*")
                ? groups["*"] : null;

            // Always create ALL implementing types so AsFieldSpec()
            // produces proper inline fragments (... on TypeName).
            // Only selected types get their properties initialized;
            // unselected types remain empty (all nulls → skipped by
            // AsFieldSpec).
            var instances = new List<object>();
            foreach (string typeName in implNames)
            {
                var props = new List<string>();

                // Add wildcard properties
                if (wildcardProps != null)
                    props.AddRange(wildcardProps);

                // Add type-specific properties
                if (groups.ContainsKey(typeName))
                    props.AddRange(groups[typeName]);

                if (props.Count > 0)
                {
                    instances.Add(InitializeTypeWithSelectedProperties(
                        typeName, props.ToArray()));
                }
                else
                {
                    instances.Add(Activator.CreateInstance(
                        GetTypeByName(typeName)));
                }
            }

            return InterfaceHelper.MakeCompositeFromList(instances);
        }

        /// <summary>
        /// Try to set a sentinel value on a scalar/leaf property.
        /// Returns true if the property was a scalar type (and was set),
        /// false if the property is a complex type that needs further walking.
        ///
        /// Sentinel values:
        ///   string     → "FETCH"
        ///   enum?      → first enum value (index 0, usually UNKNOWN)
        ///   bool/bool? → true
        ///   int/int?   → 0
        ///   long/long? → 0L
        ///   double     → 0.0
        ///   DateTime?  → new DateTime()
        /// </summary>
        private static bool SetScalarSentinel(object obj, PropertyInfo prop)
        {
            System.Type t = prop.PropertyType;

            if (t == typeof(string))
            {
                prop.SetValue(obj, "FETCH");
                return true;
            }
            if (t.IsEnum || IsNullableEnum(prop))
            {
                prop.SetValue(obj,
                    Enum.GetValues(GetNullableUnderlyingType(prop))
                        .GetValue(0));
                return true;
            }
            if (t == typeof(bool) || t == typeof(Boolean) || t == typeof(Boolean?))
            {
                prop.SetValue(obj, true);
                return true;
            }
            if (t == typeof(int) || t == typeof(Int32) || t == typeof(Int32?))
            {
                prop.SetValue(obj, 0);
                return true;
            }
            if (t == typeof(Int64) || t == typeof(Int64?))
            {
                prop.SetValue(obj, (Int64)0);
                return true;
            }
            if (t == typeof(double) || t == typeof(Double))
            {
                prop.SetValue(obj, 0.0);
                return true;
            }
            if (t == typeof(DateTime?) || t == typeof(DateTime))
            {
                prop.SetValue(obj, new DateTime());
                return true;
            }

            return false;
        }

        /// <summary>
        /// Get the current value of a class or interface property. If null,
        /// create a new instance and set it on the parent.
        ///
        /// For interfaces, creates the first implementing type via
        /// InterfaceHelper.CreateInstanceOfFirstType.
        ///
        /// Returns the (possibly new) child object for further walking.
        /// </summary>
        private static object GetOrCreatePropertyValue(
            object parent, PropertyInfo prop)
        {
            object child = prop.GetValue(parent);
            if (child != null)
            {
                return child;
            }

            if (prop.PropertyType.IsInterface)
            {
                child = InterfaceHelper.CreateInstanceOfFirstType(
                    prop.PropertyType);
            }
            else
            {
                child = Activator.CreateInstance(prop.PropertyType);
            }

            prop.SetValue(parent, child);
            return child;
        }

        /// <summary>
        /// Overload: create a specific implementing type for an interface
        /// property. Used when an on:TypeName selector is provided.
        /// </summary>
        private static object GetOrCreatePropertyValue(
            object parent, PropertyInfo prop, string typeName)
        {
            object child = prop.GetValue(parent);
            if (child != null) return child;

            System.Type targetType = GetTypeByName(typeName);
            if (targetType == null ||
                !prop.PropertyType.IsAssignableFrom(targetType))
            {
                throw new Exception(
                    $"Type '{typeName}' does not implement " +
                    $"interface '{prop.PropertyType.Name}'.");
            }
            child = Activator.CreateInstance(targetType);
            prop.SetValue(parent, child);
            return child;
        }

        /// <summary>
        /// Handle a List&lt;Interface&gt; property: create instances of
        /// implementing types so the field spec includes inline fragments.
        ///
        /// When typeFilter is null, creates ALL implementing types
        /// (... on TypeA, ... on TypeB, etc.).
        /// When typeFilter is a type name, creates only that type.
        ///
        /// Strips the parent prefix from property paths before recursing.
        /// For example, ["nodes.id"] at depth i=0 ("nodes") becomes ["id"]
        /// for each implementing type.
        ///
        /// Returns the first element of the initialized list (for further
        /// walking by the caller).
        /// </summary>
        private static object InitializeInterfaceList(
            object currentObject,
            PropertyInfo prop,
            System.Type interfaceType,
            string typeFilter,
            string[] requestedProperties,
            string[] currentSegments,
            int depth)
        {
            // Create a typed List<Interface> with one instance per
            // implementing type via InterfaceHelper.
            MethodInfo method = typeof(InterfaceHelper)
                .GetMethod("CreateInstancesOfImplementingTypes")
                .MakeGenericMethod(interfaceType);

            IList templateList = (IList)method.Invoke(
                null, new object[] { interfaceType });

            // Filter to a single implementing type if requested.
            if (typeFilter != null)
            {
                var filtered = new List<object>();
                foreach (var item in templateList)
                {
                    if (string.Equals(item.GetType().Name, typeFilter,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        filtered.Add(item);
                    }
                }
                if (filtered.Count == 0)
                {
                    throw new Exception(
                        $"Type '{typeFilter}' does not implement " +
                        $"interface '{interfaceType.Name}'. " +
                        $"Use on:* to see all implementing types.");
                }
                // Rebuild templateList with only the matching type.
                IList filteredList = (IList)Activator.CreateInstance(
                    templateList.GetType());
                foreach (var item in filtered)
                {
                    filteredList.Add(item);
                }
                templateList = filteredList;
            }

            // Build an empty list of the same generic type.
            IList resultList = (IList)Activator.CreateInstance(
                templateList.GetType());

            // Strip the parent prefix from property paths.
            // e.g. ["nodes.id", "nodes.name"] at depth 0 ("nodes")
            //    → ["id", "name"]
            string currentSegment = currentSegments[depth];
            string[] remainingProperties = requestedProperties
                .Select(rp => {
                    string[] parts = rp.Split('.');
                    if (parts.Length > depth + 1 &&
                        string.Equals(parts[depth], currentSegment,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        return string.Join(".", parts.Skip(depth + 1));
                    }
                    return null;
                })
                .Where(rp => rp != null)
                .ToArray();

            // Recursively initialize each implementing type with the
            // remaining property paths.
            foreach (var item in templateList)
            {
                if (remainingProperties.Length > 0)
                {
                    resultList.Add(InitializeTypeWithSelectedProperties(
                        item.GetType().Name, remainingProperties));
                }
                else
                {
                    resultList.Add(item);
                }
            }

            prop.SetValue(currentObject, resultList);
            return resultList[0];
        }
    }
}
