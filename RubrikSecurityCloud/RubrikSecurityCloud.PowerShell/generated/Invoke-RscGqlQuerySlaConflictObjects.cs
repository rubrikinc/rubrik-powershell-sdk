// Invoke-RscGqlQuerySlaConflictObjects.cs
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
    /// Invoke GraphQL Query slaConflictObjects
    /// slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQuerySlaConflictObjects")
    ]
    public class Invoke_RscGqlQuerySlaConflictObjects : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("slaConflictObjects");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query slaConflictObjects
        /// slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_slaConflictObjects();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_slaConflictObjects()
        {
            this._logger.name += " -slaConflictObjects";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaConflictObjects",
                "($fids: [UUID!]!)",
                "List<HierarchyObject>",
                Query.SlaConflictObjects_ObjectFieldSpec,
                Query.SlaConflictObjectsFieldSpec,
                @"# REQUIRED
$inputs.Var.fids = @(
	<System.String>
)"
            );
        }

    } // class Invoke-RscGqlQuerySlaConflictObjects
}