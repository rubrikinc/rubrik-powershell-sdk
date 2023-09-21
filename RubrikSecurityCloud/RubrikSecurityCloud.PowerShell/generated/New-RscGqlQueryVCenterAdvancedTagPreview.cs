// New-RscGqlQueryVCenterAdvancedTagPreview.cs
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
    /// Create new GraphQL Query vCenterAdvancedTagPreview
    /// vCenterAdvancedTagPreview(input: PreviewFilterInput!): VcenterAdvancedTagPreviewReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVCenterAdvancedTagPreview")
    ]
    public class New_RscGqlQueryVCenterAdvancedTagPreview : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vCenterAdvancedTagPreview");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vCenterAdvancedTagPreview
        /// vCenterAdvancedTagPreview(input: PreviewFilterInput!): VcenterAdvancedTagPreviewReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vCenterAdvancedTagPreview();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vCenterAdvancedTagPreview()
        {
            this._logger.name += " -vCenterAdvancedTagPreview";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreviewFilterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterAdvancedTagPreview",
                "($input: PreviewFilterInput!)",
                "VcenterAdvancedTagPreviewReply",
                Query.VcenterAdvancedTagPreview_ObjectFieldSpec,
                Query.VcenterAdvancedTagPreviewFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# REQUIRED
	filterCondition = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryVCenterAdvancedTagPreview
}