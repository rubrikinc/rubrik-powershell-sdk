// New-RscGqlMutationCreateVsphereAdvancedTag.cs
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
    /// Create new GraphQL Mutation createVsphereAdvancedTag
    /// createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateVsphereAdvancedTag")
    ]
    public class New_RscGqlMutationCreateVsphereAdvancedTag : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createVsphereAdvancedTag");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createVsphereAdvancedTag
        /// createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createVsphereAdvancedTag();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createVsphereAdvancedTag()
        {
            this._logger.name += " -createVsphereAdvancedTag";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVsphereAdvancedTag",
                "($input: CreateVsphereAdvancedTagInput!)",
                "CreateVsphereAdvancedTagReply",
                Mutation.CreateVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.CreateVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = <System.String>
		# REQUIRED
		condition = <System.String>
		# REQUIRED
		name = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationCreateVsphereAdvancedTag
}