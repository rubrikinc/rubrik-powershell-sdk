// New-RscGqlQueryVCenterPreAddInfo.cs
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
    /// Create new GraphQL Query vCenterPreAddInfo
    /// vCenterPreAddInfo(input: PreAddVcenterInput!): VcenterPreAddInfo!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVCenterPreAddInfo")
    ]
    public class New_RscGqlQueryVCenterPreAddInfo : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vCenterPreAddInfo");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vCenterPreAddInfo
        /// vCenterPreAddInfo(input: PreAddVcenterInput!): VcenterPreAddInfo!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vCenterPreAddInfo();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vCenterPreAddInfo()
        {
            this._logger.name += " -vCenterPreAddInfo";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreAddVcenterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterPreAddInfo",
                "($input: PreAddVcenterInput!)",
                "VcenterPreAddInfo",
                Query.VcenterPreAddInfo_ObjectFieldSpec,
                Query.VcenterPreAddInfoFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	vcenterConfig = @{
		# OPTIONAL
		connectionConfig = @{
			# OPTIONAL
			caCerts = <System.String>
			# REQUIRED
			hostname = <System.String>
			# REQUIRED
			password = <System.String>
			# REQUIRED
			username = <System.String>
		}
		# OPTIONAL
		id = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlQueryVCenterPreAddInfo
}