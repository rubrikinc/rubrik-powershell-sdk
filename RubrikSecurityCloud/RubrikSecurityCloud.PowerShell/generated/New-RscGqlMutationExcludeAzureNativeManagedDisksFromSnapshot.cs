// New-RscGqlMutationExcludeAzureNativeManagedDisksFromSnapshot.cs
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
    /// Create new GraphQL Mutation excludeAzureNativeManagedDisksFromSnapshot
    /// excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExcludeAzureNativeManagedDisksFromSnapshot")
    ]
    public class New_RscGqlMutationExcludeAzureNativeManagedDisksFromSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("excludeAzureNativeManagedDisksFromSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation excludeAzureNativeManagedDisksFromSnapshot
        /// excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_excludeAzureNativeManagedDisksFromSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_excludeAzureNativeManagedDisksFromSnapshot()
        {
            this._logger.name += " -excludeAzureNativeManagedDisksFromSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureNativeManagedDisksFromSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeAzureNativeManagedDisksFromSnapshot",
                "($input: ExcludeAzureNativeManagedDisksFromSnapshotInput!)",
                "System.String",
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshot_ObjectFieldSpec,
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	virtualMachineRubrikId = <System.String>
	# REQUIRED
	managedDiskExclusions = @(
		@{
			# REQUIRED
			managedDiskRubrikId = <System.String>
			# REQUIRED
			isExcludedFromSnapshot = <System.Boolean>
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationExcludeAzureNativeManagedDisksFromSnapshot
}