// New-RscGqlQueryO365TeamPostedBy.cs
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
    /// Create new GraphQL Query o365TeamPostedBy
    /// o365TeamPostedBy(
    ///     first: Int
    ///     after: String
    ///     snappableFid: UUID!
    ///     o365OrgId: UUID!
    ///     nameFilter: String
    ///   ): O365TeamConversationsSenderConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365TeamPostedBy")
    ]
    public class New_RscGqlQueryO365TeamPostedBy : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365TeamPostedBy");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365TeamPostedBy
        /// o365TeamPostedBy(
        ///     first: Int
        ///     after: String
        ///     snappableFid: UUID!
        ///     o365OrgId: UUID!
        ///     nameFilter: String
        ///   ): O365TeamConversationsSenderConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365TeamPostedBy();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365TeamPostedBy()
        {
            this._logger.name += " -o365TeamPostedBy";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365TeamPostedBy",
                "($first: Int,$after: String,$snappableFid: UUID!,$o365OrgId: UUID!,$nameFilter: String)",
                "O365TeamConversationsSenderConnection",
                Query.O365TeamPostedBy_ObjectFieldSpec,
                Query.O365TeamPostedByFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
# OPTIONAL
$inputs.Var.nameFilter = <System.String>"
            );
        }

    } // class New-RscGqlQueryO365TeamPostedBy
}