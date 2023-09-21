// New-RscGqlMutationDownloadNutanixVmFromLocation.cs
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
    /// Create new GraphQL Mutation downloadNutanixVmFromLocation
    /// downloadNutanixVmFromLocation(input: DownloadNutanixVmFromLocationInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadNutanixVmFromLocation")
    ]
    public class New_RscGqlMutationDownloadNutanixVmFromLocation : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadNutanixVmFromLocation");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadNutanixVmFromLocation
        /// downloadNutanixVmFromLocation(input: DownloadNutanixVmFromLocationInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadNutanixVmFromLocation();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadNutanixVmFromLocation()
        {
            this._logger.name += " -downloadNutanixVmFromLocation";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadNutanixVmFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadNutanixVmFromLocation",
                "($input: DownloadNutanixVmFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadNutanixVmFromLocation_ObjectFieldSpec,
                Mutation.DownloadNutanixVmFromLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadNutanixVmFromLocation
}