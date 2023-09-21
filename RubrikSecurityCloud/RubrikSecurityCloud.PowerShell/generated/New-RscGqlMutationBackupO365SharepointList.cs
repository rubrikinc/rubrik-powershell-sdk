// New-RscGqlMutationBackupO365SharepointList.cs
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
    /// Create new GraphQL Mutation backupO365SharepointList
    /// backupO365SharepointList(input: BackupO365SharePointListInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBackupO365SharepointList")
    ]
    public class New_RscGqlMutationBackupO365SharepointList : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("backupO365SharepointList");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation backupO365SharepointList
        /// backupO365SharepointList(input: BackupO365SharePointListInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_backupO365SharepointList();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_backupO365SharepointList()
        {
            this._logger.name += " -backupO365SharepointList";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointListInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointList",
                "($input: BackupO365SharePointListInput!)",
                "CreateOnDemandJobReply",
                Mutation.BackupO365SharepointList_ObjectFieldSpec,
                Mutation.BackupO365SharepointListFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationBackupO365SharepointList
}