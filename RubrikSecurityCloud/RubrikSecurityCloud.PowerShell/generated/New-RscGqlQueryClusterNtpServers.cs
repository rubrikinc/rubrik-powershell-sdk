// New-RscGqlQueryClusterNtpServers.cs
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
    /// Create new GraphQL Query clusterNtpServers
    /// clusterNtpServers(input: GetClusterNtpServersInput!): NtpServerConfigurationListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterNtpServers")
    ]
    public class New_RscGqlQueryClusterNtpServers : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterNtpServers");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterNtpServers
        /// clusterNtpServers(input: GetClusterNtpServersInput!): NtpServerConfigurationListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterNtpServers();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterNtpServers()
        {
            this._logger.name += " -clusterNtpServers";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterNtpServersInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterNtpServers",
                "($input: GetClusterNtpServersInput!)",
                "NtpServerConfigurationListResponse",
                Query.ClusterNtpServers_ObjectFieldSpec,
                Query.ClusterNtpServersFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryClusterNtpServers
}