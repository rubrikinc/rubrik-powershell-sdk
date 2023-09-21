// New-RscGqlMutationCreateMongodbSource.cs
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
    /// Create new GraphQL Mutation createMongodbSource
    /// createMongodbSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateMongodbSource")
    ]
    public class New_RscGqlMutationCreateMongodbSource : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createMongodbSource");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createMongodbSource
        /// createMongodbSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createMongodbSource();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createMongodbSource()
        {
            this._logger.name += " -createMongodbSource";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMongodbSource",
                "($input: AddMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.CreateMongodbSource_ObjectFieldSpec,
                Mutation.CreateMongodbSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# OPTIONAL
		cassandraYaml = @(
			<System.String>
		)
		# OPTIONAL
		dseYaml = @(
			<System.String>
		)
		# OPTIONAL
		enableSsl = <System.Boolean>
		# OPTIONAL
		httpsCertificate = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		jmxPassword = <System.String>
		# OPTIONAL
		jmxUser = <System.String>
		# OPTIONAL
		parameterEncoded = <System.Boolean>
		# OPTIONAL
		sourceAuthKey = <System.String>
		# OPTIONAL
		sourceAuthKeyfile = <System.String>
		# OPTIONAL
		sourceAuthPassphrase = <System.String>
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sourceHttpsPort = <System.String>
		# OPTIONAL
		sourcePassword = <System.String>
		# OPTIONAL
		sourcePort = <System.String>
		# OPTIONAL
		sourceRpcPort = <System.String>
		# OPTIONAL
		sourceSshPort = <System.String>
		# OPTIONAL
		sourceUser = <System.String>
		# OPTIONAL
		sslCaCerts = <System.String>
		# OPTIONAL
		sslCertfile = <System.String>
		# OPTIONAL
		sslKeyfile = <System.String>
		# REQUIRED
		sourceType = <SourceSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = <SourceSslCertReqs> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			<System.String>
		)
		# REQUIRED
		sourceName = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationCreateMongodbSource
}