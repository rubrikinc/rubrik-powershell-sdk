// New-RscGqlQueryAllDbSubnetGroupsByRegionFromAws.cs
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
    /// Create new GraphQL Query allDbSubnetGroupsByRegionFromAws
    /// allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [SubnetGroup!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllDbSubnetGroupsByRegionFromAws")
    ]
    public class New_RscGqlQueryAllDbSubnetGroupsByRegionFromAws : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allDbSubnetGroupsByRegionFromAws");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allDbSubnetGroupsByRegionFromAws
        /// allDbSubnetGroupsByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [SubnetGroup!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allDbSubnetGroupsByRegionFromAws();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allDbSubnetGroupsByRegionFromAws()
        {
            this._logger.name += " -allDbSubnetGroupsByRegionFromAws";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDbSubnetGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<SubnetGroup>",
                Query.AllDbSubnetGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllDbSubnetGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

    } // class New-RscGqlQueryAllDbSubnetGroupsByRegionFromAws
}