// New-RscGqlMutationUpdateO365AppPermissions.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create new GraphQL Mutation updateO365AppPermissions
    /// updateO365AppPermissions(input: UpdateO365AppPermissionsInput!): Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateO365AppPermissions")
    ]
    public class New_RscGqlMutationUpdateO365AppPermissions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateO365AppPermissions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateO365AppPermissions
        /// updateO365AppPermissions(input: UpdateO365AppPermissionsInput!): Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateO365AppPermissions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateO365AppPermissions()
        {
            this._logger.name += " -updateO365AppPermissions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppPermissionsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppPermissions",
                "($input: UpdateO365AppPermissionsInput!)",
                "System.String",
                Mutation.UpdateO365AppPermissions_ObjectFieldSpec,
                Mutation.UpdateO365AppPermissionsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365AppType = <O365AppType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AppType]) for enum values.
	# REQUIRED
	o365AppId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateO365AppPermissions
}