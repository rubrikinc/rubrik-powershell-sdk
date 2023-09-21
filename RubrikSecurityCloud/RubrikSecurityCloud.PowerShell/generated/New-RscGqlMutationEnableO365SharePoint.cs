// New-RscGqlMutationEnableO365SharePoint.cs
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
    /// Create new GraphQL Mutation enableO365SharePoint
    /// enableO365SharePoint(input: EnableO365SharePointInput!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationEnableO365SharePoint")
    ]
    public class New_RscGqlMutationEnableO365SharePoint : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("enableO365SharePoint");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation enableO365SharePoint
        /// enableO365SharePoint(input: EnableO365SharePointInput!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_enableO365SharePoint();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_enableO365SharePoint()
        {
            this._logger.name += " -enableO365SharePoint";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableO365SharePointInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365SharePoint",
                "($input: EnableO365SharePointInput!)",
                "RequestStatus",
                Mutation.EnableO365SharePoint_ObjectFieldSpec,
                Mutation.EnableO365SharePointFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	exocomputeClusterId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationEnableO365SharePoint
}