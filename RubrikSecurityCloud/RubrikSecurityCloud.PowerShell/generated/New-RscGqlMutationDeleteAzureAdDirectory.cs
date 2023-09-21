// New-RscGqlMutationDeleteAzureAdDirectory.cs
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
    /// Create new GraphQL Mutation deleteAzureAdDirectory
    /// deleteAzureAdDirectory(input: DeleteAzureAdDirectoryInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteAzureAdDirectory")
    ]
    public class New_RscGqlMutationDeleteAzureAdDirectory : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteAzureAdDirectory");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteAzureAdDirectory
        /// deleteAzureAdDirectory(input: DeleteAzureAdDirectoryInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteAzureAdDirectory();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteAzureAdDirectory()
        {
            this._logger.name += " -deleteAzureAdDirectory";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureAdDirectoryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureAdDirectory",
                "($input: DeleteAzureAdDirectoryInput!)",
                "CreateOnDemandJobReply",
                Mutation.DeleteAzureAdDirectory_ObjectFieldSpec,
                Mutation.DeleteAzureAdDirectoryFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	workloadFid = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteAzureAdDirectory
}