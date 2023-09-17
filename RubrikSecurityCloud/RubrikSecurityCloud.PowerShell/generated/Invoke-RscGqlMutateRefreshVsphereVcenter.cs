// Invoke-RscGqlMutateRefreshVsphereVcenter.cs
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
    /// Invoke GraphQL Mutation refreshVsphereVcenter
    /// refreshVsphereVcenter(input: RefreshVsphereVcenterInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRefreshVsphereVcenter")
    ]
    public class Invoke_RscGqlMutateRefreshVsphereVcenter : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("refreshVsphereVcenter");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation refreshVsphereVcenter
        /// refreshVsphereVcenter(input: RefreshVsphereVcenterInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_refreshVsphereVcenter();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_refreshVsphereVcenter()
        {
            this._logger.name += " -refreshVsphereVcenter";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshVsphereVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshVsphereVcenter",
                "($input: RefreshVsphereVcenterInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshVsphereVcenter_ObjectFieldSpec,
                Mutation.RefreshVsphereVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	fid = <System.String>
	# OPTIONAL
	shouldDiagnose = <System.Boolean>
}"
            );
        }

    } // class Invoke-RscGqlMutateRefreshVsphereVcenter
}