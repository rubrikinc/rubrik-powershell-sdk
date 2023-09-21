// New-RscGqlQueryHypervVmDetail.cs
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
    /// Create new GraphQL Query hypervVmDetail
    /// hypervVmDetail(input: GetHypervVirtualMachineInput!): HypervVirtualMachineDetail!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryHypervVmDetail")
    ]
    public class New_RscGqlQueryHypervVmDetail : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervVmDetail");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query hypervVmDetail
        /// hypervVmDetail(input: GetHypervVirtualMachineInput!): HypervVirtualMachineDetail!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervVmDetail();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervVmDetail()
        {
            this._logger.name += " -hypervVmDetail";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVmDetail",
                "($input: GetHypervVirtualMachineInput!)",
                "HypervVirtualMachineDetail",
                Query.HypervVmDetail_ObjectFieldSpec,
                Query.HypervVmDetailFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryHypervVmDetail
}