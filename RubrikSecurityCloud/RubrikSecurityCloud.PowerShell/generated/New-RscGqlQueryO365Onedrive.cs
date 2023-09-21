// New-RscGqlQueryO365Onedrive.cs
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
    /// Create new GraphQL Query o365Onedrive
    /// o365Onedrive(snappableFid: UUID!): O365Onedrive!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365Onedrive")
    ]
    public class New_RscGqlQueryO365Onedrive : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365Onedrive");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365Onedrive
        /// o365Onedrive(snappableFid: UUID!): O365Onedrive!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365Onedrive();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365Onedrive()
        {
            this._logger.name += " -o365Onedrive";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Onedrive",
                "($snappableFid: UUID!)",
                "O365Onedrive",
                Query.O365Onedrive_ObjectFieldSpec,
                Query.O365OnedriveFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

    } // class New-RscGqlQueryO365Onedrive
}