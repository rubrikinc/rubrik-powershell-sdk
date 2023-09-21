// New-RscGqlQueryAllAzureCdmVersions.cs
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
    /// Create new GraphQL Query allAzureCdmVersions
    /// allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!): [AzureCdmVersion!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureCdmVersions")
    ]
    public class New_RscGqlQueryAllAzureCdmVersions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureCdmVersions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureCdmVersions
        /// allAzureCdmVersions(cdmVersionRequest: AzureCdmVersionReq!): [AzureCdmVersion!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureCdmVersions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureCdmVersions()
        {
            this._logger.name += " -allAzureCdmVersions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmVersionRequest", "AzureCdmVersionReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCdmVersions",
                "($cdmVersionRequest: AzureCdmVersionReq!)",
                "List<AzureCdmVersion>",
                Query.AllAzureCdmVersions_ObjectFieldSpec,
                Query.AllAzureCdmVersionsFieldSpec,
                @"# REQUIRED
$inputs.Var.cdmVersionRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	location = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureCdmVersions
}