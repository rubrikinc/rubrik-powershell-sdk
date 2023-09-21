// New-RscGqlQueryMongodbBulkRecoverableRange.cs
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
    /// Create new GraphQL Query mongodbBulkRecoverableRange
    /// mongodbBulkRecoverableRange(input: MosaicBulkRecoveryRangeInput!): MosaicRecoveryRangeResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMongodbBulkRecoverableRange")
    ]
    public class New_RscGqlQueryMongodbBulkRecoverableRange : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mongodbBulkRecoverableRange");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mongodbBulkRecoverableRange
        /// mongodbBulkRecoverableRange(input: MosaicBulkRecoveryRangeInput!): MosaicRecoveryRangeResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mongodbBulkRecoverableRange();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mongodbBulkRecoverableRange()
        {
            this._logger.name += " -mongodbBulkRecoverableRange";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicBulkRecoveryRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongodbBulkRecoverableRange",
                "($input: MosaicBulkRecoveryRangeInput!)",
                "MosaicRecoveryRangeResponse",
                Query.MongodbBulkRecoverableRange_ObjectFieldSpec,
                Query.MongodbBulkRecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryRangeData = @{
		# OPTIONAL
		sourceType = <MosaicBulkRecoverableRangeRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicBulkRecoverableRangeRequestSourceType]) for enum values.
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# REQUIRED
		sourceName = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlQueryMongodbBulkRecoverableRange
}