// New-RscGqlMutationCreateOnDemandNutanixBackup.cs
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
    /// Create new GraphQL Mutation createOnDemandNutanixBackup
    /// createOnDemandNutanixBackup(input: CreateOnDemandNutanixBackupInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateOnDemandNutanixBackup")
    ]
    public class New_RscGqlMutationCreateOnDemandNutanixBackup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createOnDemandNutanixBackup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createOnDemandNutanixBackup
        /// createOnDemandNutanixBackup(input: CreateOnDemandNutanixBackupInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createOnDemandNutanixBackup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createOnDemandNutanixBackup()
        {
            this._logger.name += " -createOnDemandNutanixBackup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandNutanixBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandNutanixBackup",
                "($input: CreateOnDemandNutanixBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandNutanixBackup_ObjectFieldSpec,
                Mutation.CreateOnDemandNutanixBackupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationCreateOnDemandNutanixBackup
}