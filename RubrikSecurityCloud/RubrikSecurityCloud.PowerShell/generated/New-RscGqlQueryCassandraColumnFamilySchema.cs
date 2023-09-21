// New-RscGqlQueryCassandraColumnFamilySchema.cs
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
    /// Create new GraphQL Query cassandraColumnFamilySchema
    /// cassandraColumnFamilySchema(input: GetMosaicTableSchemaInput!): GetSchemaResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryCassandraColumnFamilySchema")
    ]
    public class New_RscGqlQueryCassandraColumnFamilySchema : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("cassandraColumnFamilySchema");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query cassandraColumnFamilySchema
        /// cassandraColumnFamilySchema(input: GetMosaicTableSchemaInput!): GetSchemaResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_cassandraColumnFamilySchema();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_cassandraColumnFamilySchema()
        {
            this._logger.name += " -cassandraColumnFamilySchema";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicTableSchemaInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCassandraColumnFamilySchema",
                "($input: GetMosaicTableSchemaInput!)",
                "GetSchemaResponse",
                Query.CassandraColumnFamilySchema_ObjectFieldSpec,
                Query.CassandraColumnFamilySchemaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	schemaRequestData = @{
		# REQUIRED
		databaseName = <System.String>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		tableName = <System.String>
		# REQUIRED
		versionTimestamp = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlQueryCassandraColumnFamilySchema
}