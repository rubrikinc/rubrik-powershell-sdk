// New-RscGqlQueryAllO365SubscriptionsAppTypeCounts.cs
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
    /// Create new GraphQL Query allO365SubscriptionsAppTypeCounts
    /// allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllO365SubscriptionsAppTypeCounts")
    ]
    public class New_RscGqlQueryAllO365SubscriptionsAppTypeCounts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allO365SubscriptionsAppTypeCounts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allO365SubscriptionsAppTypeCounts
        /// allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allO365SubscriptionsAppTypeCounts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allO365SubscriptionsAppTypeCounts()
        {
            this._logger.name += " -allO365SubscriptionsAppTypeCounts";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllO365SubscriptionsAppTypeCounts",
                "",
                "List<O365SubscriptionAppTypeCounts>",
                Query.AllO365SubscriptionsAppTypeCounts_ObjectFieldSpec,
                Query.AllO365SubscriptionsAppTypeCountsFieldSpec,
                @""
            );
        }

    } // class New-RscGqlQueryAllO365SubscriptionsAppTypeCounts
}