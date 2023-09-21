// New-RscGqlQueryO365SharepointSite.cs
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
    /// Create new GraphQL Query o365SharepointSite
    /// o365SharepointSite(siteFid: UUID!): O365Site!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365SharepointSite")
    ]
    public class New_RscGqlQueryO365SharepointSite : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365SharepointSite");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365SharepointSite
        /// o365SharepointSite(siteFid: UUID!): O365Site!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365SharepointSite();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365SharepointSite()
        {
            this._logger.name += " -o365SharepointSite";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("siteFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointSite",
                "($siteFid: UUID!)",
                "O365Site",
                Query.O365SharepointSite_ObjectFieldSpec,
                Query.O365SharepointSiteFieldSpec,
                @"# REQUIRED
$inputs.Var.siteFid = <System.String>"
            );
        }

    } // class New-RscGqlQueryO365SharepointSite
}