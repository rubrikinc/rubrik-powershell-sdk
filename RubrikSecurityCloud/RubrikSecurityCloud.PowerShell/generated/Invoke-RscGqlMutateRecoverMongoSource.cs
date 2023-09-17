// Invoke-RscGqlMutateRecoverMongoSource.cs
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
    /// Invoke GraphQL Mutation recoverMongoSource
    /// recoverMongoSource(input: RecoverMongoSourceInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRecoverMongoSource")
    ]
    public class Invoke_RscGqlMutateRecoverMongoSource : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("recoverMongoSource");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation recoverMongoSource
        /// recoverMongoSource(input: RecoverMongoSourceInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_recoverMongoSource();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_recoverMongoSource()
        {
            this._logger.name += " -recoverMongoSource";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverMongoSource",
                "($input: RecoverMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.RecoverMongoSource_ObjectFieldSpec,
                Mutation.RecoverMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	input = @{
		# OPTIONAL
		prefix = <System.String>
		# OPTIONAL
		restoreDbPassword = <System.String>
		# OPTIONAL
		restoreDbUsername = <System.String>
		# OPTIONAL
		shouldDropExistingCollection = <System.Boolean>
		# OPTIONAL
		sourceCollectionIds = @(
			<System.String>
		)
		# OPTIONAL
		sourceDatabaseIds = @(
			<System.String>
		)
		# OPTIONAL
		targetCollectionName = <System.String>
		# OPTIONAL
		targetDatabaseName = <System.String>
		# OPTIONAL
		versionTime = <DateTime>
		# OPTIONAL
		restoreThrottleInBytesPerSecond = <System.Int64>
		# OPTIONAL
		isRestoreWithIndex = <System.Boolean>
		# REQUIRED
		sourceMongoClusterId = <System.String>
		# REQUIRED
		targetMongoClusterId = <System.String>
	}
}"
            );
        }

    } // class Invoke-RscGqlMutateRecoverMongoSource
}