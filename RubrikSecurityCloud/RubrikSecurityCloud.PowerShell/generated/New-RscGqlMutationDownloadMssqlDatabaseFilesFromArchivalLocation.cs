// New-RscGqlMutationDownloadMssqlDatabaseFilesFromArchivalLocation.cs
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
    /// Create new GraphQL Mutation downloadMssqlDatabaseFilesFromArchivalLocation
    /// downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadMssqlDatabaseFilesFromArchivalLocation")
    ]
    public class New_RscGqlMutationDownloadMssqlDatabaseFilesFromArchivalLocation : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadMssqlDatabaseFilesFromArchivalLocation");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadMssqlDatabaseFilesFromArchivalLocation
        /// downloadMssqlDatabaseFilesFromArchivalLocation(input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadMssqlDatabaseFilesFromArchivalLocation();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadMssqlDatabaseFilesFromArchivalLocation()
        {
            this._logger.name += " -downloadMssqlDatabaseFilesFromArchivalLocation";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseFilesFromArchivalLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadMssqlDatabaseFilesFromArchivalLocation",
                "($input: DownloadMssqlDatabaseFilesFromArchivalLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadMssqlDatabaseFilesFromArchivalLocation_ObjectFieldSpec,
                Mutation.DownloadMssqlDatabaseFilesFromArchivalLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadMssqlDatabaseFilesFromArchivalLocation
}