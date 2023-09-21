// New-RscGqlQueryO365Mailbox.cs
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
    /// Create new GraphQL Query o365Mailbox
    /// o365Mailbox(snappableFid: UUID!): O365Mailbox!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365Mailbox")
    ]
    public class New_RscGqlQueryO365Mailbox : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365Mailbox");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365Mailbox
        /// o365Mailbox(snappableFid: UUID!): O365Mailbox!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365Mailbox();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365Mailbox()
        {
            this._logger.name += " -o365Mailbox";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Mailbox",
                "($snappableFid: UUID!)",
                "O365Mailbox",
                Query.O365Mailbox_ObjectFieldSpec,
                Query.O365MailboxFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

    } // class New-RscGqlQueryO365Mailbox
}