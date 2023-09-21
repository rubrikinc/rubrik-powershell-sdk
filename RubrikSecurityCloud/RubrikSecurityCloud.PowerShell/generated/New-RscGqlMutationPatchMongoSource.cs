// New-RscGqlMutationPatchMongoSource.cs
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
    /// Create new GraphQL Mutation patchMongoSource
    /// patchMongoSource(input: PatchMongoSourceInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationPatchMongoSource")
    ]
    public class New_RscGqlMutationPatchMongoSource : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("patchMongoSource");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation patchMongoSource
        /// patchMongoSource(input: PatchMongoSourceInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_patchMongoSource();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_patchMongoSource()
        {
            this._logger.name += " -patchMongoSource";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchMongoSource",
                "($input: PatchMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.PatchMongoSource_ObjectFieldSpec,
                Mutation.PatchMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	mongoSourcePatchRequestConfig = @{
		# OPTIONAL
		caCertfilePath = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sslKeyfilePath = <System.String>
		# OPTIONAL
		sslCertfilePath = <System.String>
		# OPTIONAL
		sslCertificateRequired = <MongoSslCertificateRequirement> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
	}
}"
            );
        }

    } // class New-RscGqlMutationPatchMongoSource
}