// New-RscGqlQueryNutanixSnapshotDetail.cs
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
    /// Create new GraphQL Query nutanixSnapshotDetail
    /// nutanixSnapshotDetail(input: GetNutanixSnapshotDetailInput!): NutanixVmSnapshotDetail!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryNutanixSnapshotDetail")
    ]
    public class New_RscGqlQueryNutanixSnapshotDetail : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixSnapshotDetail");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query nutanixSnapshotDetail
        /// nutanixSnapshotDetail(input: GetNutanixSnapshotDetailInput!): NutanixVmSnapshotDetail!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixSnapshotDetail();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixSnapshotDetail()
        {
            this._logger.name += " -nutanixSnapshotDetail";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixSnapshotDetailInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixSnapshotDetail",
                "($input: GetNutanixSnapshotDetailInput!)",
                "NutanixVmSnapshotDetail",
                Query.NutanixSnapshotDetail_ObjectFieldSpec,
                Query.NutanixSnapshotDetailFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryNutanixSnapshotDetail
}