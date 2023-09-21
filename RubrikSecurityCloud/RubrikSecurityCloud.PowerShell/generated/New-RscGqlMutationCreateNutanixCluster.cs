// New-RscGqlMutationCreateNutanixCluster.cs
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
    /// Create new GraphQL Mutation createNutanixCluster
    /// createNutanixCluster(input: CreateNutanixClusterInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateNutanixCluster")
    ]
    public class New_RscGqlMutationCreateNutanixCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createNutanixCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createNutanixCluster
        /// createNutanixCluster(input: CreateNutanixClusterInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createNutanixCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createNutanixCluster()
        {
            this._logger.name += " -createNutanixCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateNutanixCluster",
                "($input: CreateNutanixClusterInput!)",
                "AsyncRequestStatus",
                Mutation.CreateNutanixCluster_ObjectFieldSpec,
                Mutation.CreateNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	nutanixClusterConfig = @{
		# REQUIRED
		caCerts = <System.String>
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		nutanixClusterUuid = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationCreateNutanixCluster
}