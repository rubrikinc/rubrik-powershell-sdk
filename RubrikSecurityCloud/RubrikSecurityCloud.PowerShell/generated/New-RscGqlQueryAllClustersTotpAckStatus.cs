// New-RscGqlQueryAllClustersTotpAckStatus.cs
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
    /// Create new GraphQL Query allClustersTotpAckStatus
    /// allClustersTotpAckStatus(listClusterUuid: [UUID!]!): [Boolean!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllClustersTotpAckStatus")
    ]
    public class New_RscGqlQueryAllClustersTotpAckStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allClustersTotpAckStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allClustersTotpAckStatus
        /// allClustersTotpAckStatus(listClusterUuid: [UUID!]!): [Boolean!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allClustersTotpAckStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allClustersTotpAckStatus()
        {
            this._logger.name += " -allClustersTotpAckStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClustersTotpAckStatus",
                "($listClusterUuid: [UUID!]!)",
                "List<System.Boolean>",
                Query.AllClustersTotpAckStatus_ObjectFieldSpec,
                Query.AllClustersTotpAckStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.listClusterUuid = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryAllClustersTotpAckStatus
}