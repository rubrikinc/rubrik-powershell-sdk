// New-RscGqlQueryMssqlAvailabilityGroup.cs
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
    /// Create new GraphQL Query mssqlAvailabilityGroup
    /// mssqlAvailabilityGroup(fid: UUID!): MssqlAvailabilityGroup!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMssqlAvailabilityGroup")
    ]
    public class New_RscGqlQueryMssqlAvailabilityGroup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mssqlAvailabilityGroup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mssqlAvailabilityGroup
        /// mssqlAvailabilityGroup(fid: UUID!): MssqlAvailabilityGroup!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mssqlAvailabilityGroup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mssqlAvailabilityGroup()
        {
            this._logger.name += " -mssqlAvailabilityGroup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlAvailabilityGroup",
                "($fid: UUID!)",
                "MssqlAvailabilityGroup",
                Query.MssqlAvailabilityGroup_ObjectFieldSpec,
                Query.MssqlAvailabilityGroupFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

    } // class New-RscGqlQueryMssqlAvailabilityGroup
}