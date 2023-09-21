// New-RscGqlQueryAllAwsCdmVersions.cs
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
    /// Create new GraphQL Query allAwsCdmVersions
    /// allAwsCdmVersions(input: AwsCdmVersionRequest!): [AwsCdmVersion!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAwsCdmVersions")
    ]
    public class New_RscGqlQueryAllAwsCdmVersions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAwsCdmVersions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAwsCdmVersions
        /// allAwsCdmVersions(input: AwsCdmVersionRequest!): [AwsCdmVersion!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAwsCdmVersions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAwsCdmVersions()
        {
            this._logger.name += " -allAwsCdmVersions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsCdmVersionRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCdmVersions",
                "($input: AwsCdmVersionRequest!)",
                "List<AwsCdmVersion>",
                Query.AllAwsCdmVersions_ObjectFieldSpec,
                Query.AllAwsCdmVersionsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	region = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAwsCdmVersions
}