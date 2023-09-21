// New-RscGqlQueryCassandraColumnFamily.cs
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
    /// Create new GraphQL Query cassandraColumnFamily
    /// cassandraColumnFamily(fid: UUID!): CassandraColumnFamily!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryCassandraColumnFamily")
    ]
    public class New_RscGqlQueryCassandraColumnFamily : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("cassandraColumnFamily");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query cassandraColumnFamily
        /// cassandraColumnFamily(fid: UUID!): CassandraColumnFamily!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_cassandraColumnFamily();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_cassandraColumnFamily()
        {
            this._logger.name += " -cassandraColumnFamily";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCassandraColumnFamily",
                "($fid: UUID!)",
                "CassandraColumnFamily",
                Query.CassandraColumnFamily_ObjectFieldSpec,
                Query.CassandraColumnFamilyFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

    } // class New-RscGqlQueryCassandraColumnFamily
}