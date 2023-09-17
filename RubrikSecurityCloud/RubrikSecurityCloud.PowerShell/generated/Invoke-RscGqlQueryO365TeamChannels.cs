// Invoke-RscGqlQueryO365TeamChannels.cs
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
    /// Invoke GraphQL Query o365TeamChannels
    /// o365TeamChannels(
    ///     first: Int
    ///     after: String
    ///     snappableFid: UUID!
    ///     excludeArchived: Boolean!
    ///     channelMembershipTypeFilter: ChannelMembershipType!
    ///     nameFilter: String
    ///   ): O365TeamsChannelConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryO365TeamChannels")
    ]
    public class Invoke_RscGqlQueryO365TeamChannels : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365TeamChannels");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query o365TeamChannels
        /// o365TeamChannels(
        ///     first: Int
        ///     after: String
        ///     snappableFid: UUID!
        ///     excludeArchived: Boolean!
        ///     channelMembershipTypeFilter: ChannelMembershipType!
        ///     nameFilter: String
        ///   ): O365TeamsChannelConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365TeamChannels();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365TeamChannels()
        {
            this._logger.name += " -o365TeamChannels";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("excludeArchived", "Boolean!"),
                Tuple.Create("channelMembershipTypeFilter", "ChannelMembershipType!"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365TeamChannels",
                "($first: Int,$after: String,$snappableFid: UUID!,$excludeArchived: Boolean!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)",
                "O365TeamsChannelConnection",
                Query.O365TeamChannels_ObjectFieldSpec,
                Query.O365TeamChannelsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.excludeArchived = <System.Boolean>
# REQUIRED
$inputs.Var.channelMembershipTypeFilter = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
# OPTIONAL
$inputs.Var.nameFilter = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryO365TeamChannels
}