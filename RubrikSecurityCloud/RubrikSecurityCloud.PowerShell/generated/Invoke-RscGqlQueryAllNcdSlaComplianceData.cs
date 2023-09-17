// Invoke-RscGqlQueryAllNcdSlaComplianceData.cs
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
    /// Invoke GraphQL Query allNcdSlaComplianceData
    /// allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAllNcdSlaComplianceData")
    ]
    public class Invoke_RscGqlQueryAllNcdSlaComplianceData : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allNcdSlaComplianceData");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query allNcdSlaComplianceData
        /// allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allNcdSlaComplianceData();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allNcdSlaComplianceData()
        {
            this._logger.name += " -allNcdSlaComplianceData";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdSlaComplianceData",
                "($clusters: [UUID!]!)",
                "List<NcdSlaComplianceData>",
                Query.AllNcdSlaComplianceData_ObjectFieldSpec,
                Query.AllNcdSlaComplianceDataFieldSpec,
                @"# REQUIRED
$inputs.Var.clusters = @(
	<System.String>
)"
            );
        }

    } // class Invoke-RscGqlQueryAllNcdSlaComplianceData
}