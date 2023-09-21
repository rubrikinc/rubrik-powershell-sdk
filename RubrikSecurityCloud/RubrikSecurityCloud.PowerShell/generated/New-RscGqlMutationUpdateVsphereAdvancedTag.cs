// New-RscGqlMutationUpdateVsphereAdvancedTag.cs
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
    /// Create new GraphQL Mutation updateVsphereAdvancedTag
    /// updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateVsphereAdvancedTag")
    ]
    public class New_RscGqlMutationUpdateVsphereAdvancedTag : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateVsphereAdvancedTag");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateVsphereAdvancedTag
        /// updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateVsphereAdvancedTag();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateVsphereAdvancedTag()
        {
            this._logger.name += " -updateVsphereAdvancedTag";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVsphereAdvancedTag",
                "($input: UpdateVsphereAdvancedTagInput!)",
                "UpdateVsphereAdvancedTagReply",
                Mutation.UpdateVsphereAdvancedTag_ObjectFieldSpec,
                Mutation.UpdateVsphereAdvancedTagFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
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

    } // class New-RscGqlMutationUpdateVsphereAdvancedTag
}