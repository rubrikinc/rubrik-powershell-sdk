// Invoke-RscGqlQueryO365OrgAtSnappableLevel.cs
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
    /// Invoke GraphQL Query o365OrgAtSnappableLevel
    /// o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!): O365Org!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryO365OrgAtSnappableLevel")
    ]
    public class Invoke_RscGqlQueryO365OrgAtSnappableLevel : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365OrgAtSnappableLevel");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query o365OrgAtSnappableLevel
        /// o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!): O365Org!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365OrgAtSnappableLevel();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365OrgAtSnappableLevel()
        {
            this._logger.name += " -o365OrgAtSnappableLevel";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("snappableType", "SnappableType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365OrgAtSnappableLevel",
                "($fid: UUID!,$snappableType: SnappableType!)",
                "O365Org",
                Query.O365OrgAtSnappableLevel_ObjectFieldSpec,
                Query.O365OrgAtSnappableLevelFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>
# REQUIRED
$inputs.Var.snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values."
            );
        }

    } // class Invoke-RscGqlQueryO365OrgAtSnappableLevel
}