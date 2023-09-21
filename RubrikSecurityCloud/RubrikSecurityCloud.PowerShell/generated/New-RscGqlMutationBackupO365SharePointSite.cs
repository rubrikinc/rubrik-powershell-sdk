// New-RscGqlMutationBackupO365SharePointSite.cs
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
    /// Create new GraphQL Mutation backupO365SharePointSite
    /// backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBackupO365SharePointSite")
    ]
    public class New_RscGqlMutationBackupO365SharePointSite : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("backupO365SharePointSite");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation backupO365SharePointSite
        /// backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_backupO365SharePointSite();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_backupO365SharePointSite()
        {
            this._logger.name += " -backupO365SharePointSite";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointSiteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharePointSite",
                "($input: BackupO365SharePointSiteInput!)",
                "CreateOnDemandJobReply",
                Mutation.BackupO365SharePointSite_ObjectFieldSpec,
                Mutation.BackupO365SharePointSiteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	siteFid = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationBackupO365SharePointSite
}