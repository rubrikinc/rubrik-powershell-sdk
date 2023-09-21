// New-RscGqlQueryNutanixBrowseSnapshot.cs
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
    /// Create new GraphQL Query nutanixBrowseSnapshot
    /// nutanixBrowseSnapshot(input: BrowseNutanixSnapshotInput!): BrowseResponseListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryNutanixBrowseSnapshot")
    ]
    public class New_RscGqlQueryNutanixBrowseSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixBrowseSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query nutanixBrowseSnapshot
        /// nutanixBrowseSnapshot(input: BrowseNutanixSnapshotInput!): BrowseResponseListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixBrowseSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixBrowseSnapshot()
        {
            this._logger.name += " -nutanixBrowseSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BrowseNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixBrowseSnapshot",
                "($input: BrowseNutanixSnapshotInput!)",
                "BrowseResponseListResponse",
                Query.NutanixBrowseSnapshot_ObjectFieldSpec,
                Query.NutanixBrowseSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# REQUIRED
	id = <System.String>
	# REQUIRED
	path = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryNutanixBrowseSnapshot
}