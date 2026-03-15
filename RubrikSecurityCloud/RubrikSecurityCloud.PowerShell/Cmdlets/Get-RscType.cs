using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Reflection;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{

    /// <summary>
    /// Instantiate, inspect, or list .NET types from the RSC GraphQL schema.
    /// </summary>
    /// <description>
    /// Get-RscType serves three purposes, selected by parameter set:
    ///
    /// 1. **GetTypeByName** (-Name): Instantiate a schema type and optionally
    ///    initialize selected properties. This is primarily used to build
    ///    GraphQL field specs — the SDK convention is that null properties
    ///    mean "don't request this field" and non-null means "request it."
    ///
    ///    -InitialProperties sets sentinel values (strings → "FETCH",
    ///    bools → true, enums → index 0, etc.) to mark fields as requested.
    ///    Supports dotted paths like "nodes.id" to walk into nested objects.
    ///
    ///    -InitialValues sets user-provided values on input type fields.
    ///    Handles PowerShell → C# type coercion (PSObject unwrapping,
    ///    object[] → List&lt;T&gt; conversion).
    ///
    ///    Only one of -InitialProperties and -InitialValues may be provided.
    ///
    /// 2. **GetTypeList** (-ListAvailable): List all schema types or
    ///    interfaces, optionally filtered by name substring.
    ///
    /// 3. **ListImplementingTypes** (-Interface): List all concrete types
    ///    that implement a given schema interface.
    ///
    /// Does not require an RSC connection (retrieveConnection: false).
    /// </description>
    /// <example>
    /// Create a filter input object with "a" "b" for text filters.
    /// <code>
    /// PS C:\> Get-RscType -Name Filter -InitialValues @{"texts" = @("a", "b")}
    /// </code>
    /// </example>
    /// <example>
    /// Get a list of all available RSC .NET types
    /// <code>
    /// PS C:\> Get-RscType -ListAvailable
    /// </code>
    /// </example>
    /// <example>
    /// Get a list of available RSC .NET types filtered by name
    /// <code>
    /// PS C:\> Get-RscType -ListAvailable -FilterByName "accountsetting"
    /// </code>
    /// </example>
    /// <example>
    /// Get an empty object that is compliant with the Rsc Type
    /// specified by name
    /// <code>
    /// PS C:\> Get-RscType -Name "AccountSetting"
    /// </code>
    /// </example>
    /// <example>
    /// Get an empty object that is compliant with the Rsc Type
    /// specified by name. Initialize the 'IsEulaAccepted' property
    /// <code>
    /// PS C:\> Get-RscType -Name "AccountSetting" -InitialProperties @("IsEulaAccepted")
    /// </code>
    /// </example>
    /// <example>
    /// Get an empty object that is compliant with the Rsc Type
    /// specified by name. Initialize the 'IsEulaAccepted' property
    /// with a specific value.
    /// <code>
    /// PS C:\> Get-RscType -Name "AccountSetting" -InitialValues @{"IsEulaAccepted"= $false}
    /// </code>
    /// </example>
    /// <example>
    /// Get a list of all available Rsc .NET Interfaces
    /// <code>
    /// PS C:\> Get-RscType -ListAvailable -Interfaces
    /// </code>
    /// </example>
    /// <example>
    /// Get a list of all available Rsc .NET Interfaces filtered by name
    /// <code>
    /// PS C:\> Get-RscType -ListAvailable -Interfaces -FilterByName "mssql"
    /// </code>
    /// </example>
    /// <example>
    /// Get a list of all Rsc .NET types that implement the
    /// MssqlTopLevelDescendantType interface
    /// <code>
    /// PS C:\> Get-RscType -Interface MssqlTopLevelDescendantType
    /// </code>
    /// </example>

    [Cmdlet(VerbsCommon.Get, "RscType", DefaultParameterSetName = "GetTypeByName")]
    public class Get_RscType : RscBasePSCmdlet
    {

        /// <summary>
        /// The name of an RSC schema type to instantiate.
        /// Case-insensitive. Tab-completion is provided via RscTypeNameCompleter.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = "GetTypeByName")]
        [ValidateNotNullOrEmpty]
        [ArgumentCompleter(typeof(RscTypeNameCompleter))]
        public string Name { get; set; }

        /// <summary>
        /// Tab-completion for the -Name parameter.
        /// Calls GetAllTypeNames() on every invocation, but the underlying
        /// type list is cached after the first call.
        /// </summary>
        public class RscTypeNameCompleter : IArgumentCompleter
        {
            /// <summary>Provide completions for the Name parameter.</summary>
            public IEnumerable<CompletionResult> CompleteArgument(
                string commandName,
                string parameterName,
                string wordToComplete,
                CommandAst commandAst,
                IDictionary fakeBoundParameters)
            {
                var validNames = RscTypeInitializer.GetAllTypeNames()
                    .Where(name => string.IsNullOrEmpty(wordToComplete) ||
                                   name.StartsWith(wordToComplete, StringComparison.OrdinalIgnoreCase));

                return validNames.Select(name => new CompletionResult(name)).ToList();
            }
        }

        /// <summary>
        /// Property names (or dotted paths) to initialize with sentinel values.
        /// Supports dotted paths like "nodes.id" to walk into nested objects.
        /// For List&lt;Interface&gt; fields, use "on:TypeName" to select a
        /// specific implementing type (e.g. "nodes.on:PhysicalHost.id")
        /// or "on:*" for all types.
        /// See RscTypeInitializer.InitializeTypeWithSelectedProperties for
        /// the sentinel values used for each property type.
        /// Mutually exclusive with -InitialValues.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = false,
            ParameterSetName = "GetTypeByName")]
        [ValidateNotNullOrEmpty]
        [ArgumentCompleter(typeof(InitialPropertiesCompleter))]
        public string[] InitialProperties { get; set; }

        /// <summary>
        /// Tab-completion for the -InitialProperties parameter.
        /// Walks the dotted path to determine the current type context,
        /// then offers property names or on:TypeName selectors for
        /// List&lt;Interface&gt; fields.
        /// </summary>
        public class InitialPropertiesCompleter : IArgumentCompleter
        {
            /// <summary>Provide completions for the InitialProperties parameter.</summary>
            public IEnumerable<CompletionResult> CompleteArgument(
                string commandName,
                string parameterName,
                string wordToComplete,
                CommandAst commandAst,
                IDictionary fakeBoundParameters)
            {
                // Need -Name to know which type we're completing for.
                if (!fakeBoundParameters.Contains("Name"))
                    return Enumerable.Empty<CompletionResult>();

                string typeName = fakeBoundParameters["Name"]?.ToString();
                if (string.IsNullOrEmpty(typeName))
                    return Enumerable.Empty<CompletionResult>();

                Type rootType = RscTypeInitializer.GetTypeByName(typeName);
                if (rootType == null)
                    return Enumerable.Empty<CompletionResult>();

                // PowerShell passes the opening quote as part of wordToComplete
                // when the user is typing inside quotes (e.g. "C or 'C).
                // Strip it so matching works, and remember the quote char
                // so we can wrap completion results.
                string raw = wordToComplete ?? "";
                char quoteChar = '\0';
                if (raw.Length > 0 && (raw[0] == '"' || raw[0] == '\''))
                {
                    quoteChar = raw[0];
                    raw = raw.Substring(1);
                }
                // Also strip a trailing quote if present.
                if (raw.Length > 0 && quoteChar != '\0' &&
                    raw[raw.Length - 1] == quoteChar)
                {
                    raw = raw.Substring(0, raw.Length - 1);
                }

                // Split the word being completed into segments.
                // e.g. "nodes.on:PhysicalHost.i" → ["nodes", "on:PhysicalHost", "i"]
                string[] segments = raw.Split('.');
                string prefix = ""; // rebuilt prefix of completed segments
                Type currentType = rootType;
                bool atInterfaceList = false;
                Type interfaceElementType = null;

                // Walk completed segments (all except the last, which is partial).
                for (int i = 0; i < segments.Length - 1; i++)
                {
                    string seg = segments[i];
                    if (string.IsNullOrEmpty(seg))
                        return Enumerable.Empty<CompletionResult>();

                    prefix += (i > 0 ? "." : "") + seg;

                    // Handle on: selector — switch into the selected type.
                    if (seg.StartsWith("on:", StringComparison.OrdinalIgnoreCase))
                    {
                        string selector = seg.Substring(3);
                        if (selector == "*")
                        {
                            // on:* — can't narrow type, but we know we're
                            // past the interface list. Pick the first
                            // implementing type for property completion.
                            if (interfaceElementType != null)
                            {
                                var impls = ReflectionUtils.GetTypesImplementingInterface(
                                    interfaceElementType.Name);
                                if (impls.Count > 0)
                                    currentType = RscTypeInitializer.GetTypeByName(impls[0]);
                            }
                        }
                        else
                        {
                            Type selectedType = RscTypeInitializer.GetTypeByName(selector);
                            if (selectedType != null)
                                currentType = selectedType;
                            else
                                return Enumerable.Empty<CompletionResult>();
                        }
                        atInterfaceList = false;
                        interfaceElementType = null;
                        continue;
                    }

                    // Regular property segment — resolve it.
                    PropertyInfo prop = currentType.GetProperty(seg,
                        BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
                    if (prop == null)
                        return Enumerable.Empty<CompletionResult>();

                    Type propType = prop.PropertyType;

                    // Check for List<T>
                    if (propType.IsGenericType &&
                        propType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        Type elemType = propType.GetGenericArguments()[0];
                        if (elemType.IsInterface)
                        {
                            atInterfaceList = true;
                            interfaceElementType = elemType;
                            continue;
                        }
                        currentType = elemType;
                        atInterfaceList = false;
                        interfaceElementType = null;
                        continue;
                    }

                    // Single interface
                    if (propType.IsInterface)
                    {
                        var impls = ReflectionUtils.GetTypesImplementingInterface(propType.Name);
                        if (impls.Count > 0)
                            currentType = RscTypeInitializer.GetTypeByName(impls[0]);
                        atInterfaceList = false;
                        interfaceElementType = null;
                        continue;
                    }

                    // Class — advance
                    currentType = propType;
                    atInterfaceList = false;
                    interfaceElementType = null;
                }

                // The last segment is the partial text being completed.
                string partial = segments[segments.Length - 1];
                if (segments.Length > 1)
                    prefix += ".";

                // Helper: wrap completionText in quotes when the user
                // started typing inside quotes.
                Func<string, string> q = (string val) =>
                    quoteChar == '\0' ? val : quoteChar + val + quoteChar;

                // If we're right after a List<Interface> field, offer on: selectors.
                if (atInterfaceList && interfaceElementType != null)
                {
                    var results = new List<CompletionResult>();
                    var impls = ReflectionUtils.GetTypesImplementingInterface(
                        interfaceElementType.Name);

                    // on:* completion
                    string onStar = "on:*";
                    if (onStar.StartsWith(partial, StringComparison.OrdinalIgnoreCase))
                    {
                        results.Add(new CompletionResult(
                            q(prefix + onStar), onStar, CompletionResultType.ParameterValue,
                            "All implementing types"));
                    }

                    // on:TypeName completions
                    foreach (string impl in impls)
                    {
                        string onType = "on:" + impl;
                        if (onType.StartsWith(partial, StringComparison.OrdinalIgnoreCase))
                        {
                            results.Add(new CompletionResult(
                                q(prefix + onType), onType, CompletionResultType.ParameterValue,
                                impl));
                        }
                    }

                    // Also offer bare field names expanded to on:*.field
                    // for backward compatibility discovery.
                    if (!partial.StartsWith("on:", StringComparison.OrdinalIgnoreCase) &&
                        impls.Count > 0)
                    {
                        Type firstImpl = RscTypeInitializer.GetTypeByName(impls[0]);
                        if (firstImpl != null)
                        {
                            foreach (PropertyInfo p in firstImpl.GetProperties(
                                BindingFlags.Instance | BindingFlags.Public))
                            {
                                if (string.IsNullOrEmpty(partial) ||
                                    p.Name.StartsWith(partial, StringComparison.OrdinalIgnoreCase))
                                {
                                    string expanded = "on:*." + p.Name;
                                    results.Add(new CompletionResult(
                                        q(prefix + expanded), expanded,
                                        CompletionResultType.ParameterValue,
                                        $"{p.Name} (all types)"));
                                }
                            }
                        }
                    }

                    return results;
                }

                // Regular property completion on currentType.
                var propResults = new List<CompletionResult>();
                foreach (PropertyInfo p in currentType.GetProperties(
                    BindingFlags.Instance | BindingFlags.Public))
                {
                    if (string.IsNullOrEmpty(partial) ||
                        p.Name.StartsWith(partial, StringComparison.OrdinalIgnoreCase))
                    {
                        propResults.Add(new CompletionResult(
                            q(prefix + p.Name), p.Name,
                            CompletionResultType.ParameterValue,
                            $"{p.PropertyType.Name}"));
                    }
                }
                return propResults;
            }
        }

        /// <summary>
        /// A hashtable mapping property names to specific values.
        /// Used for input types (e.g. filter inputs, mutation inputs).
        /// Handles PowerShell → C# coercion (PSObject, object[] → List).
        /// Mutually exclusive with -InitialProperties.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipeline = false,
            ParameterSetName = "GetTypeByName")]
        [ValidateNotNullOrEmpty]
        public Hashtable InitialValues { get; set; }

        /// <summary>
        /// List all available schema types (or interfaces with -Interfaces).
        /// </summary>
        [Parameter(
            Mandatory = true,
            Position = 0,
            ParameterSetName = "GetTypeList")]
        public SwitchParameter ListAvailable { get; set; }

        /// <summary>
        /// Case-insensitive substring filter for -ListAvailable results.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ParameterSetName = "GetTypeList")]
        [ValidateNotNullOrEmpty]
        public string FilterByName { get; set; }

        /// <summary>
        /// When used with -ListAvailable, return interfaces instead of
        /// classes. Only interfaces implementing IFieldSpec are included.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 2,
            ParameterSetName = "GetTypeList")]
        public SwitchParameter Interfaces { get; set; }

        /// <summary>
        /// Return a list of concrete type names that implement the
        /// given interface. Delegates to ReflectionUtils.
        /// </summary>
        [Parameter(
            Mandatory = true,
            Position = 0,
            ParameterSetName = "ListImplementingTypes")]
        [ValidateNotNullOrEmpty]
        public string Interface { get; set; }

    #pragma warning disable 1591 // ignore warning 'Missing XML comment'

        public Get_RscType() : base(retrieveConnection: false)
        {
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch (ParameterSetName)
                {
                    case "ListImplementingTypes":
                        WriteObject(
                            ReflectionUtils
                                .GetTypesImplementingInterface(Interface)
                        );
                        break;

                    case "GetTypeList":
                        WriteObject(RscTypeInitializer.GetAllTypeNames(FilterByName, Interfaces));
                        break;

                    case "GetTypeByName":
                        if (string.IsNullOrEmpty(Name)) {
                            throw new Exception(
                                "Specify -Name <TypeName> to instantiate a type, " +
                                "or -ListAvailable to list all types. " +
                                "See Get-Help Get-RscType for usage.");
                        }

                        Type returnType = RscTypeInitializer.GetTypeByName(Name);

                        if (returnType == null) {
                            throw new Exception($"No type found that matches {Name}. " +
                                $"Use -ListAvailable to get a list of valid " +
                                $"types");
                        }

                        if (InitialProperties != null && InitialValues != null) {
                            throw new Exception(
                                "Only one of InitialProperties and InitialValues" +
                                " should be provided."
                            );
                        }

                        if (InitialProperties != null && InitialProperties.Length > 0)
                        {
                            WriteObject(
                                RscTypeInitializer
                                    .InitializeTypeWithSelectedProperties(
                                        Name,
                                        InitialProperties
                                    )
                            );
                        }
                        else if (InitialValues != null && InitialValues.Count > 0)
                        {
                            WriteObject(
                                RscTypeInitializer
                                    .InitializeInputWithSelectedFields(
                                        Name,
                                        InitialValues
                                    )
                            );
                        }
                        else
                        {
                            WriteObject(Activator.CreateInstance(returnType));
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

    }
}
