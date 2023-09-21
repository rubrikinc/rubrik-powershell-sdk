// New-RscGqlMutationValidateOracleAcoFile.cs
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
    /// Create new GraphQL Mutation validateOracleAcoFile
    /// validateOracleAcoFile(input: ValidateOracleAcoFileInput!): ValidateOracleAcoFileReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationValidateOracleAcoFile")
    ]
    public class New_RscGqlMutationValidateOracleAcoFile : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("validateOracleAcoFile");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation validateOracleAcoFile
        /// validateOracleAcoFile(input: ValidateOracleAcoFileInput!): ValidateOracleAcoFileReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_validateOracleAcoFile();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_validateOracleAcoFile()
        {
            this._logger.name += " -validateOracleAcoFile";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleAcoFileInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateOracleAcoFile",
                "($input: ValidateOracleAcoFileInput!)",
                "ValidateOracleAcoFileReply",
                Mutation.ValidateOracleAcoFile_ObjectFieldSpec,
                Mutation.ValidateOracleAcoFileFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	acoContentsBase64 = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	isLiveMount = <System.Boolean>
	# REQUIRED
	dbId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationValidateOracleAcoFile
}