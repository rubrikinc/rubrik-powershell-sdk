using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Models;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{

    /// <summary>
    /// Return a valid empty .NET object for the
    /// RubrikSecurityCloud.PowerShell SDK
    /// </summary>
    /// <description>
    /// Return a valid empty .NET object for the
    /// RubrikSecurityCloud.PowerShell SDK.
    /// 
    /// The cmdlet will return a .NET object by name.
    /// The -ListAvailable parameter will return a list of
    /// valid RubrikSecurityCloud.Types.
    /// </description>
    /// <example>
    /// Get a list of all available Rsc .NET types
    /// <code>
    /// PS C:\> Get-RscType -ListAvailable
    /// </code>
    /// </example>
    /// <example>
    /// Get a list of available Rsc .NET types filtered by name
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

    [Cmdlet(VerbsCommon.Get, "RscType", DefaultParameterSetName = "GetTypeList")]
    public class Get_RscType : RscBasePSCmdlet
    {
        /// <summary>
        /// The name of the Rsc Type to return
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = "GetType")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Specify an array of string containing the names of the
        /// properties to initialize.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = false,
            ParameterSetName = "GetType")]
        [ValidateNotNullOrEmpty]
        public string[] InitialProperties { get; set; }

        /// <summary>
        /// Specify a hashtable mapping the requested
        /// fields to their values.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipeline = false,
            ParameterSetName = "GetType")]
        [ValidateNotNullOrEmpty]
        public Hashtable InitialValues { get; set; }

        /// <summary>
        /// Used to request a list of valid Rsc Type Names.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ParameterSetName = "GetTypeList")]
        public SwitchParameter ListAvailable { get; set; }

        /// <summary>
        /// Optional to filter results by name.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ParameterSetName = "GetTypeList")]
        [ValidateNotNullOrEmpty]
        public string FilterByName { get; set; }

        /// <summary>
        /// Flag to specify if interfaces should be returned.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 3,
            ParameterSetName = "GetTypeList")]
        public SwitchParameter Interfaces { get; set; }

        /// <summary>
        /// Used to request a list of types implementing a given interface.
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
                            RscTypeInitializer
                                .GetTypesImplementingInterface(Interface)
                        );
                        break;

                    case "GetTypeList":
                        WriteObject(RscTypeInitializer.GetAllTypeNames(FilterByName, Interfaces));
                        break;

                    case "GetType":
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

