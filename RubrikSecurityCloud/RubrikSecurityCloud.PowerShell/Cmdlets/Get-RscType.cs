using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using RubrikSecurityCloud.PowerShell.Models;
using RubrikSecurityCloud.PowerShell.Private;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
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
    /// valid Rubrik.SecurityCloud.Types.
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
    [Cmdlet(VerbsCommon.Get, "RscType", DefaultParameterSetName = "GetTypeList")]
    public class Get_RscType : PSCmdlet
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

        //cmdlet code
        protected override void ProcessRecord()
        {
            try
            {
                switch (ParameterSetName)
                {
                    case "GetTypeList":
                        WriteObject(RscTypeInitializer.GetAllTypeNames(FilterByName));
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
                var error = new ErrorRecord(
                    ex,
                    "InvalidArgumentToCmdlet",
                    ErrorCategory.InvalidArgument,
                    null);
                ThrowTerminatingError(error);
            }
        }

    }
}

