// New-RscGqlMutationDownloadNutanixSnapshot.cs
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
    /// Create new GraphQL Mutation downloadNutanixSnapshot
    /// downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadNutanixSnapshot")
    ]
    public class New_RscGqlMutationDownloadNutanixSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadNutanixSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadNutanixSnapshot
        /// downloadNutanixSnapshot(input: DownloadNutanixSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadNutanixSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadNutanixSnapshot()
        {
            this._logger.name += " -downloadNutanixSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadNutanixSnapshot",
                "($input: DownloadNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadNutanixSnapshot_ObjectFieldSpec,
                Mutation.DownloadNutanixSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadNutanixSnapshot
}