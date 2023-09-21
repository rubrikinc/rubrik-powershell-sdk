// New-RscGqlQueryOracleAcoExampleDownloadLink.cs
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
    /// Create new GraphQL Query oracleAcoExampleDownloadLink
    /// oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!): OracleFileDownloadLink!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleAcoExampleDownloadLink")
    ]
    public class New_RscGqlQueryOracleAcoExampleDownloadLink : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleAcoExampleDownloadLink");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleAcoExampleDownloadLink
        /// oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!): OracleFileDownloadLink!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleAcoExampleDownloadLink();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleAcoExampleDownloadLink()
        {
            this._logger.name += " -oracleAcoExampleDownloadLink";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleAcoExampleDownloadLink",
                "($input: ClusterUuidWithDbIdInput!)",
                "OracleFileDownloadLink",
                Query.OracleAcoExampleDownloadLink_ObjectFieldSpec,
                Query.OracleAcoExampleDownloadLinkFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryOracleAcoExampleDownloadLink
}