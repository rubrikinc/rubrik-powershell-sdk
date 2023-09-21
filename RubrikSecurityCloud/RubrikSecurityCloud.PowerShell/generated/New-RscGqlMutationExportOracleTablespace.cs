// New-RscGqlMutationExportOracleTablespace.cs
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
    /// Create new GraphQL Mutation exportOracleTablespace
    /// exportOracleTablespace(input: ExportOracleTablespaceInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExportOracleTablespace")
    ]
    public class New_RscGqlMutationExportOracleTablespace : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("exportOracleTablespace");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation exportOracleTablespace
        /// exportOracleTablespace(input: ExportOracleTablespaceInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_exportOracleTablespace();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_exportOracleTablespace()
        {
            this._logger.name += " -exportOracleTablespace";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleTablespaceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportOracleTablespace",
                "($input: ExportOracleTablespaceInput!)",
                "AsyncRequestStatus",
                Mutation.ExportOracleTablespace_ObjectFieldSpec,
                Mutation.ExportOracleTablespaceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		exposeAllLogs = <System.Boolean>
		# REQUIRED
		auxiliaryDestinationPath = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
		# REQUIRED
		tablespaceName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationExportOracleTablespace
}