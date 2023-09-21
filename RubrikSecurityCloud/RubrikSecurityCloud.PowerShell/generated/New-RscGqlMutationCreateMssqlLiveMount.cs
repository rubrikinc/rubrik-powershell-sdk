// New-RscGqlMutationCreateMssqlLiveMount.cs
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
    /// Create new GraphQL Mutation createMssqlLiveMount
    /// createMssqlLiveMount(input: CreateMssqlLiveMountInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateMssqlLiveMount")
    ]
    public class New_RscGqlMutationCreateMssqlLiveMount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createMssqlLiveMount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createMssqlLiveMount
        /// createMssqlLiveMount(input: CreateMssqlLiveMountInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createMssqlLiveMount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createMssqlLiveMount()
        {
            this._logger.name += " -createMssqlLiveMount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMssqlLiveMount",
                "($input: CreateMssqlLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateMssqlLiveMount_ObjectFieldSpec,
                Mutation.CreateMssqlLiveMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetInstanceId = <System.String>
		# OPTIONAL
		recoveryModel = <MssqlDatabaseRecoveryModel> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseRecoveryModel]) for enum values.
		# REQUIRED
		mountedDatabaseName = <System.String>
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

    } // class New-RscGqlMutationCreateMssqlLiveMount
}