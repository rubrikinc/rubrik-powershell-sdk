// New-RscGqlMutationEnableO365Teams.cs
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
    /// Create new GraphQL Mutation enableO365Teams
    /// enableO365Teams(exocomputeClusterId: String!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationEnableO365Teams")
    ]
    public class New_RscGqlMutationEnableO365Teams : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("enableO365Teams");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation enableO365Teams
        /// enableO365Teams(exocomputeClusterId: String!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_enableO365Teams();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_enableO365Teams()
        {
            this._logger.name += " -enableO365Teams";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365Teams",
                "($exocomputeClusterId: String!)",
                "RequestStatus",
                Mutation.EnableO365Teams_ObjectFieldSpec,
                Mutation.EnableO365TeamsFieldSpec,
                @"# REQUIRED
$inputs.Var.exocomputeClusterId = <System.String>"
            );
        }

    } // class New-RscGqlMutationEnableO365Teams
}