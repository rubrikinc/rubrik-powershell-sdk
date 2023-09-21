// New-RscGqlQueryClusterOperationJobProgress.cs
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
    /// Create new GraphQL Query clusterOperationJobProgress
    /// clusterOperationJobProgress(input: ClusterOperationJobProgressInput!): ClusterOperationJobProgress!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterOperationJobProgress")
    ]
    public class New_RscGqlQueryClusterOperationJobProgress : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterOperationJobProgress");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterOperationJobProgress
        /// clusterOperationJobProgress(input: ClusterOperationJobProgressInput!): ClusterOperationJobProgress!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterOperationJobProgress();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterOperationJobProgress()
        {
            this._logger.name += " -clusterOperationJobProgress";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterOperationJobProgressInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterOperationJobProgress",
                "($input: ClusterOperationJobProgressInput!)",
                "ClusterOperationJobProgress",
                Query.ClusterOperationJobProgress_ObjectFieldSpec,
                Query.ClusterOperationJobProgressFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
	# REQUIRED
	jobType = <CcpJobType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
}"
            );
        }

    } // class New-RscGqlQueryClusterOperationJobProgress
}