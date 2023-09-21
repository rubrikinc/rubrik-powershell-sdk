// New-RscGqlQueryOraclePdbDetails.cs
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
    /// Create new GraphQL Query oraclePdbDetails
    /// oraclePdbDetails(input: OraclePdbDetailsInput!): OraclePdbDetails!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOraclePdbDetails")
    ]
    public class New_RscGqlQueryOraclePdbDetails : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oraclePdbDetails");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oraclePdbDetails
        /// oraclePdbDetails(input: OraclePdbDetailsInput!): OraclePdbDetails!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oraclePdbDetails();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oraclePdbDetails()
        {
            this._logger.name += " -oraclePdbDetails";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OraclePdbDetailsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOraclePdbDetails",
                "($input: OraclePdbDetailsInput!)",
                "OraclePdbDetails",
                Query.OraclePdbDetails_ObjectFieldSpec,
                Query.OraclePdbDetailsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	pdbDetailsRequest = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
}"
            );
        }

    } // class New-RscGqlQueryOraclePdbDetails
}