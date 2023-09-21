// New-RscGqlQueryO365TeamConversationsFolderID.cs
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
    /// Create new GraphQL Query o365TeamConversationsFolderID
    /// o365TeamConversationsFolderID(snappableFid: UUID!, snapshotFid: UUID!, o365OrgId: UUID!): String!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365TeamConversationsFolderID")
    ]
    public class New_RscGqlQueryO365TeamConversationsFolderID : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365TeamConversationsFolderID");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365TeamConversationsFolderID
        /// o365TeamConversationsFolderID(snappableFid: UUID!, snapshotFid: UUID!, o365OrgId: UUID!): String!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365TeamConversationsFolderID();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365TeamConversationsFolderID()
        {
            this._logger.name += " -o365TeamConversationsFolderID";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365TeamConversationsFolderId",
                "($snappableFid: UUID!,$snapshotFid: UUID!,$o365OrgId: UUID!)",
                "System.String",
                Query.O365TeamConversationsFolderId_ObjectFieldSpec,
                Query.O365TeamConversationsFolderIdFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.snapshotFid = <System.String>
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

    } // class New-RscGqlQueryO365TeamConversationsFolderID
}