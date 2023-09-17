// Invoke-RscGqlQueryMongoBulkRecoverableRanges.cs
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
    /// Invoke GraphQL Query mongoBulkRecoverableRanges
    /// mongoBulkRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryMongoBulkRecoverableRanges")
    ]
    public class Invoke_RscGqlQueryMongoBulkRecoverableRanges : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mongoBulkRecoverableRanges");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query mongoBulkRecoverableRanges
        /// mongoBulkRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mongoBulkRecoverableRanges();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mongoBulkRecoverableRanges()
        {
            this._logger.name += " -mongoBulkRecoverableRanges";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverableRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongoBulkRecoverableRanges",
                "($input: RecoverableRangeInput!)",
                "MongoRecoverableRanges",
                Query.MongoBulkRecoverableRanges_ObjectFieldSpec,
                Query.MongoBulkRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	source = <System.String>
	# OPTIONAL
	databases = @(
		<System.String>
	)
	# OPTIONAL
	collections = @(
		<System.String>
	)
}"
            );
        }

    } // class Invoke-RscGqlQueryMongoBulkRecoverableRanges
}