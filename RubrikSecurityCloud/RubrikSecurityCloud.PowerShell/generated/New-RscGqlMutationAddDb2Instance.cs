// New-RscGqlMutationAddDb2Instance.cs
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
    /// Create new GraphQL Mutation addDb2Instance
    /// addDb2Instance(input: AddDb2InstanceInput!): AddDb2InstanceReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAddDb2Instance")
    ]
    public class New_RscGqlMutationAddDb2Instance : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("addDb2Instance");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation addDb2Instance
        /// addDb2Instance(input: AddDb2InstanceInput!): AddDb2InstanceReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_addDb2Instance();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_addDb2Instance()
        {
            this._logger.name += " -addDb2Instance";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddDb2Instance",
                "($input: AddDb2InstanceInput!)",
                "AddDb2InstanceReply",
                Mutation.AddDb2Instance_ObjectFieldSpec,
                Mutation.AddDb2InstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	db2InstanceRequestConfig = @{
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		instanceName = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationAddDb2Instance
}