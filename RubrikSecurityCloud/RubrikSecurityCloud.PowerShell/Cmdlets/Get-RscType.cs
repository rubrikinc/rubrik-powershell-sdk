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
        public string[] InitialProperties { get; set; }

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
