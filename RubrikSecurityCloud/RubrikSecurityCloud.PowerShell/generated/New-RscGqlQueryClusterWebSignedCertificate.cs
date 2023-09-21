// New-RscGqlQueryClusterWebSignedCertificate.cs
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
    /// Create new GraphQL Query clusterWebSignedCertificate
    /// clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!): ClusterWebSignedCertificateReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterWebSignedCertificate")
    ]
    public class New_RscGqlQueryClusterWebSignedCertificate : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterWebSignedCertificate");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterWebSignedCertificate
        /// clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!): ClusterWebSignedCertificateReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterWebSignedCertificate();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterWebSignedCertificate()
        {
            this._logger.name += " -clusterWebSignedCertificate";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterWebSignedCertificateInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterWebSignedCertificate",
                "($input: ClusterWebSignedCertificateInput!)",
                "ClusterWebSignedCertificateReply",
                Query.ClusterWebSignedCertificate_ObjectFieldSpec,
                Query.ClusterWebSignedCertificateFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryClusterWebSignedCertificate
}