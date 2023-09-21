// New-RscGqlMutationDeleteNutanixSnapshot.cs
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
    /// Create new GraphQL Mutation deleteNutanixSnapshot
    /// deleteNutanixSnapshot(input: DeleteNutanixSnapshotInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteNutanixSnapshot")
    ]
    public class New_RscGqlMutationDeleteNutanixSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteNutanixSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteNutanixSnapshot
        /// deleteNutanixSnapshot(input: DeleteNutanixSnapshotInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteNutanixSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteNutanixSnapshot()
        {
            this._logger.name += " -deleteNutanixSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixSnapshot",
                "($input: DeleteNutanixSnapshotInput!)",
                "RequestSuccess",
                Mutation.DeleteNutanixSnapshot_ObjectFieldSpec,
                Mutation.DeleteNutanixSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteNutanixSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteNutanixSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteNutanixSnapshot
}