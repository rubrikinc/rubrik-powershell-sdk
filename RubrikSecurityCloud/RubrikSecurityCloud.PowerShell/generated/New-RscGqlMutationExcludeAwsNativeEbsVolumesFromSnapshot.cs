// New-RscGqlMutationExcludeAwsNativeEbsVolumesFromSnapshot.cs
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
    /// Create new GraphQL Mutation excludeAwsNativeEbsVolumesFromSnapshot
    /// excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!): Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExcludeAwsNativeEbsVolumesFromSnapshot")
    ]
    public class New_RscGqlMutationExcludeAwsNativeEbsVolumesFromSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("excludeAwsNativeEbsVolumesFromSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation excludeAwsNativeEbsVolumesFromSnapshot
        /// excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!): Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_excludeAwsNativeEbsVolumesFromSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_excludeAwsNativeEbsVolumesFromSnapshot()
        {
            this._logger.name += " -excludeAwsNativeEbsVolumesFromSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAwsNativeEbsVolumesFromSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeAwsNativeEbsVolumesFromSnapshot",
                "($input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!)",
                "System.String",
                Mutation.ExcludeAwsNativeEbsVolumesFromSnapshot_ObjectFieldSpec,
                Mutation.ExcludeAwsNativeEbsVolumesFromSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsNativeEc2InstanceId = <System.String>
	# REQUIRED
	volumeIdExclusions = @(
		@{
			# REQUIRED
			volumeId = <System.String>
			# REQUIRED
			isExcluded = <System.Boolean>
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationExcludeAwsNativeEbsVolumesFromSnapshot
}