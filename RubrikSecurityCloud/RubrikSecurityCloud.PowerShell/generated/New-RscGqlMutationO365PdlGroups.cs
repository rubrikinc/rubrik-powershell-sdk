// New-RscGqlMutationO365PdlGroups.cs
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
    /// Create new GraphQL Mutation o365PdlGroups
    /// o365PdlGroups(input: O365PdlGroupsInput!): O365PdlGroupsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationO365PdlGroups")
    ]
    public class New_RscGqlMutationO365PdlGroups : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365PdlGroups");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation o365PdlGroups
        /// o365PdlGroups(input: O365PdlGroupsInput!): O365PdlGroupsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365PdlGroups();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365PdlGroups()
        {
            this._logger.name += " -o365PdlGroups";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365PdlGroupsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365PdlGroups",
                "($input: O365PdlGroupsInput!)",
                "O365PdlGroupsReply",
                Mutation.O365PdlGroups_ObjectFieldSpec,
                Mutation.O365PdlGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	pdlAndWorkloadPairs = @(
		@{
			# REQUIRED
			pdl = <System.String>
			# REQUIRED
			workload = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationO365PdlGroups
}