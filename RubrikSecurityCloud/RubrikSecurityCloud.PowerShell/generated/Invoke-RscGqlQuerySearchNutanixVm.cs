// Invoke-RscGqlQuerySearchNutanixVm.cs
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
    /// Invoke GraphQL Query searchNutanixVm
    /// searchNutanixVm(input: SearchNutanixVmInput!): SearchResponseListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQuerySearchNutanixVm")
    ]
    public class Invoke_RscGqlQuerySearchNutanixVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("searchNutanixVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query searchNutanixVm
        /// searchNutanixVm(input: SearchNutanixVmInput!): SearchResponseListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_searchNutanixVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_searchNutanixVm()
        {
            this._logger.name += " -searchNutanixVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SearchNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchNutanixVm",
                "($input: SearchNutanixVmInput!)",
                "SearchResponseListResponse",
                Query.SearchNutanixVm_ObjectFieldSpec,
                Query.SearchNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cursor = <System.String>
	# OPTIONAL
	limit = <System.Int32>
	# REQUIRED
	id = <System.String>
	# REQUIRED
	path = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlQuerySearchNutanixVm
}