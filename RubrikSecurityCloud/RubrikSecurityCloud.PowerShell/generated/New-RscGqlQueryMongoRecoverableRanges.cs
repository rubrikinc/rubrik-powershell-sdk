// New-RscGqlQueryMongoRecoverableRanges.cs
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
    /// Create new GraphQL Query mongoRecoverableRanges
    /// mongoRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMongoRecoverableRanges")
    ]
    public class New_RscGqlQueryMongoRecoverableRanges : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mongoRecoverableRanges");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mongoRecoverableRanges
        /// mongoRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mongoRecoverableRanges();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mongoRecoverableRanges()
        {
            this._logger.name += " -mongoRecoverableRanges";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverableRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongoRecoverableRanges",
                "($input: RecoverableRangeInput!)",
                "MongoRecoverableRanges",
                Query.MongoRecoverableRanges_ObjectFieldSpec,
                Query.MongoRecoverableRangesFieldSpec,
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

    } // class New-RscGqlQueryMongoRecoverableRanges
}