// New-RscGqlMutationCreateMssqlLogShippingConfiguration.cs
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
    /// Create new GraphQL Mutation createMssqlLogShippingConfiguration
    /// createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateMssqlLogShippingConfiguration")
    ]
    public class New_RscGqlMutationCreateMssqlLogShippingConfiguration : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createMssqlLogShippingConfiguration");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createMssqlLogShippingConfiguration
        /// createMssqlLogShippingConfiguration(input: CreateMssqlLogShippingConfigurationInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createMssqlLogShippingConfiguration();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createMssqlLogShippingConfiguration()
        {
            this._logger.name += " -createMssqlLogShippingConfiguration";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMssqlLogShippingConfigurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMssqlLogShippingConfiguration",
                "($input: CreateMssqlLogShippingConfigurationInput!)",
                "AsyncRequestStatus",
                Mutation.CreateMssqlLogShippingConfiguration_ObjectFieldSpec,
                Mutation.CreateMssqlLogShippingConfigurationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		makeupReseedLimit = <System.Int32>
		# OPTIONAL
		mssqlLogShippingCreateConfig = @{
			# OPTIONAL
			maxDataStreams = <System.Int32>
			# OPTIONAL
			targetDataFilePath = <System.String>
			# OPTIONAL
			targetFilePaths = @(
				@{
					# OPTIONAL
					newFilename = <System.String>
					# OPTIONAL
					newLogicalName = <System.String>
					# REQUIRED
					exportPath = <System.String>
					# REQUIRED
					logicalName = <System.String>
				}
			)
			# OPTIONAL
			targetLogFilePath = <System.String>
			# OPTIONAL
			mssqlLogShippingTargetStateOptions = @{
				# OPTIONAL
				shouldDisconnectStandbyUsers = <System.Boolean>
				# REQUIRED
				state = <MssqlLogShippingOkState> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingOkState]) for enum values.
			}
			# REQUIRED
			targetDatabaseName = <System.String>
			# REQUIRED
			targetInstanceId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationCreateMssqlLogShippingConfiguration
}