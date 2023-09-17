// Invoke-RscGqlMutateBackupO365SharePointSite.cs
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
    /// Invoke GraphQL Mutation backupO365SharePointSite
    /// backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateBackupO365SharePointSite")
    ]
    public class Invoke_RscGqlMutateBackupO365SharePointSite : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
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
        /// Invoke GraphQL Mutation backupO365SharePointSite
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

    } // class Invoke-RscGqlMutateBackupO365SharePointSite
}