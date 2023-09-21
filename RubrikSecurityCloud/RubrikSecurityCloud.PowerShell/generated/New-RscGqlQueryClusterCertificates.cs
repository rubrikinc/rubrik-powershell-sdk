// New-RscGqlQueryClusterCertificates.cs
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
    /// Create new GraphQL Query clusterCertificates
    /// clusterCertificates(input: QueryCertificatesInput!): CertificateSummaryListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterCertificates")
    ]
    public class New_RscGqlQueryClusterCertificates : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterCertificates");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterCertificates
        /// clusterCertificates(input: QueryCertificatesInput!): CertificateSummaryListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterCertificates();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterCertificates()
        {
            this._logger.name += " -clusterCertificates";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryCertificatesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterCertificates",
                "($input: QueryCertificatesInput!)",
                "CertificateSummaryListResponse",
                Query.ClusterCertificates_ObjectFieldSpec,
                Query.ClusterCertificatesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	expiration = <System.String>
	# OPTIONAL
	hasKey = <System.Boolean>
	# OPTIONAL
	includeExpired = <System.Boolean>
	# OPTIONAL
	isTrusted = <System.Boolean>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	sortBy = <V1QueryCertificatesRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V1QueryCertificatesRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryClusterCertificates
}