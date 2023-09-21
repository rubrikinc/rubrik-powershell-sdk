// New-RscGqlQueryO365OrgAtSnappableLevel.cs
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
    /// Create new GraphQL Query o365OrgAtSnappableLevel
    /// o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!): O365Org!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365OrgAtSnappableLevel")
    ]
    public class New_RscGqlQueryO365OrgAtSnappableLevel : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
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
        /// Create new GraphQL Query o365OrgAtSnappableLevel
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

    } // class New-RscGqlQueryO365OrgAtSnappableLevel
}