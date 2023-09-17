// Invoke-RscGqlQueryBrowseO365TeamConvChannels.cs
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
    /// Invoke GraphQL Query browseO365TeamConvChannels
    /// browseO365TeamConvChannels(
    ///     first: Int
    ///     after: String
    ///     snappableFid: UUID!
    ///     snapshotFidOpt: UUID
    ///     excludeArchived: Boolean!
    ///     orgId: UUID!
    ///     channelMembershipTypeFilter: ChannelMembershipType!
    ///     nameFilter: String
    ///   ): O365TeamConvChannelConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryBrowseO365TeamConvChannels")
    ]
    public class Invoke_RscGqlQueryBrowseO365TeamConvChannels : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("browseO365TeamConvChannels");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query browseO365TeamConvChannels
        /// browseO365TeamConvChannels(
        ///     first: Int
        ///     after: String
        ///     snappableFid: UUID!
        ///     snapshotFidOpt: UUID
        ///     excludeArchived: Boolean!
        ///     orgId: UUID!
        ///     channelMembershipTypeFilter: ChannelMembershipType!
        ///     nameFilter: String
        ///   ): O365TeamConvChannelConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_browseO365TeamConvChannels();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_browseO365TeamConvChannels()
        {
            this._logger.name += " -browseO365TeamConvChannels";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFidOpt", "UUID"),
                Tuple.Create("excludeArchived", "Boolean!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("channelMembershipTypeFilter", "ChannelMembershipType!"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseO365TeamConvChannels",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFidOpt: UUID,$excludeArchived: Boolean!,$orgId: UUID!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)",
                "O365TeamConvChannelConnection",
                Query.BrowseO365TeamConvChannels_ObjectFieldSpec,
                Query.BrowseO365TeamConvChannelsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.snapshotFidOpt = <System.String>
# REQUIRED
$inputs.Var.excludeArchived = <System.Boolean>
# REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.channelMembershipTypeFilter = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
# OPTIONAL
$inputs.Var.nameFilter = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryBrowseO365TeamConvChannels
}