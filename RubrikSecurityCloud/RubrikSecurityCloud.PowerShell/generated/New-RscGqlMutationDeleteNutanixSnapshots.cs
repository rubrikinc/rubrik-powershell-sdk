// New-RscGqlMutationDeleteNutanixSnapshots.cs
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
    /// Create new GraphQL Mutation deleteNutanixSnapshots
    /// deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteNutanixSnapshots")
    ]
    public class New_RscGqlMutationDeleteNutanixSnapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteNutanixSnapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteNutanixSnapshots
        /// deleteNutanixSnapshots(input: DeleteNutanixSnapshotsInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteNutanixSnapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteNutanixSnapshots()
        {
            this._logger.name += " -deleteNutanixSnapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixSnapshots",
                "($input: DeleteNutanixSnapshotsInput!)",
                "RequestSuccess",
                Mutation.DeleteNutanixSnapshots_ObjectFieldSpec,
                Mutation.DeleteNutanixSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteNutanixSnapshots
}