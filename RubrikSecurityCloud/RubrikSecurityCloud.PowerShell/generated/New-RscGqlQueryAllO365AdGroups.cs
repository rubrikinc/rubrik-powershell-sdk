// New-RscGqlQueryAllO365AdGroups.cs
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
    /// Create new GraphQL Query allO365AdGroups
    /// allO365AdGroups(orgId: UUID!, adGroupSearchFilter: String!): [AdGroup!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllO365AdGroups")
    ]
    public class New_RscGqlQueryAllO365AdGroups : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allO365AdGroups");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allO365AdGroups
        /// allO365AdGroups(orgId: UUID!, adGroupSearchFilter: String!): [AdGroup!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allO365AdGroups();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allO365AdGroups()
        {
            this._logger.name += " -allO365AdGroups";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("adGroupSearchFilter", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllO365AdGroups",
                "($orgId: UUID!,$adGroupSearchFilter: String!)",
                "List<AdGroup>",
                Query.AllO365AdGroups_ObjectFieldSpec,
                Query.AllO365AdGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.adGroupSearchFilter = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllO365AdGroups
}