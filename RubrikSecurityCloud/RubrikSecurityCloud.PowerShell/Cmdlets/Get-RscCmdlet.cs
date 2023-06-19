using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Models;
using RubrikSecurityCloud.PowerShell.Private;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    public class RscInvokeCommandInfo
    {
        public string GqlOperation { get; set; }
        public string InvokeCommand { get; set; }
        public RscInvokeCommandInfo(string invokeCommand, string gqlOperation)
        {
            GqlOperation = gqlOperation;
            InvokeCommand = invokeCommand;
        }
    }
    /// <summary>
    /// Return info about SDK cmdlets
    /// </summary>
    /// <description>
    /// Look up a GraphQL Operation and
    /// return info about the cmdlet that implements it.
    /// </description>
    /// <example>
    /// Retrieve the name of the cmdlet that implements the
    /// GraphQL query clusterConnection
    /// <code>
    /// PS> Get-RscCmdlet clusterConnection
    /// </code>
    /// </example>
    /// <example>
    /// Retrieve info for a GraphQL operation that is
    /// not implemented by a cmdlet.
    /// <code>
    /// PS> Get-RscCmdlet notImplementedOperation
    /// </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "RscCmdlet", DefaultParameterSetName = "LookupExistingOperation")]
    public class Get_RscCmdlet : PSCmdlet
    {
        /// <summary>
        /// The name of the GraphQL Operation to look up.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = "LookupExistingOperation")]
        [ValidateNotNullOrEmpty]
        public SchemaMeta.GqlOperationName ExistingGqlOpName { get; set; } = SchemaMeta.GqlOperationName.Unknown;

        /// <summary>
        /// The name of the GraphQL Operation to look up.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = "LookupAnyOperation")]
        [ValidateNotNullOrEmpty]
        public string AnyGqlOpName { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch (ParameterSetName)
                {
                    case "LookupExistingOperation":
                        LookupExistingOperation();
                        break;
                    case "LookupAnyOperation":
                        LookupAnyOperation();
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

        protected void LookupExistingOperation()
        {
            if ( ExistingGqlOpName != SchemaMeta.GqlOperationName.Unknown )
            {
                WriteObject(
                    new RscInvokeCommandInfo(
                        SchemaMeta.OperationLookup(ExistingGqlOpName),
                        ExistingGqlOpName.ToString()
                    )
                );
                return;
            }
            var rscCmdletInfos = Enum
                .GetValues(typeof(SchemaMeta.GqlOperationName))
                .Cast<SchemaMeta.GqlOperationName>()
                .Select(value => new RscInvokeCommandInfo(SchemaMeta.OperationLookup(value), value.ToString()))
                .ToArray();

            WriteObject(rscCmdletInfos, /*enumerateCollection=*/ true );
        }

        protected void LookupAnyOperation()
        {
            if (Enum.TryParse<SchemaMeta.GqlOperationName>(AnyGqlOpName, out SchemaMeta.GqlOperationName operation))
            {
                // The provided operation is a valid enum member. Use the existing operation lookup logic.
                ExistingGqlOpName = operation;
                LookupExistingOperation();
            }
            else
            {
                // The provided operation is not a valid enum member. Continue with the existing logic.
                WriteObject(
                    new RscInvokeCommandInfo(
                        $"Invoke-Rsc -Op {AnyGqlOpName}",
                        AnyGqlOpName
                    )
                );
            }
        }

    }
}

