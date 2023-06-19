// UpdateVolumeGroupReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UpdateVolumeGroupReply
    public class UpdateVolumeGroupReply: BaseType
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        [JsonProperty("blackoutWindowResponseInfo")]
        public BlackoutWindowResponseInfo? BlackoutWindowResponseInfo { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> VolumeGroupSummary? VolumeGroupSummary
        // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
        [JsonProperty("volumeGroupSummary")]
        public VolumeGroupSummary? VolumeGroupSummary { get; set; }

        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        [JsonProperty("volumes")]
        public List<HostVolumeSummary>? Volumes { get; set; }


        #endregion

    #region methods

    public UpdateVolumeGroupReply Set(
        System.String? ConfiguredSlaDomainId = null,
        System.Boolean? IsPaused = null,
        BlackoutWindowResponseInfo? BlackoutWindowResponseInfo = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        VolumeGroupSummary? VolumeGroupSummary = null,
        List<HostVolumeSummary>? Volumes = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( IsPaused != null ) {
            this.IsPaused = IsPaused;
        }
        if ( BlackoutWindowResponseInfo != null ) {
            this.BlackoutWindowResponseInfo = BlackoutWindowResponseInfo;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( VolumeGroupSummary != null ) {
            this.VolumeGroupSummary = VolumeGroupSummary;
        }
        if ( Volumes != null ) {
            this.Volumes = Volumes;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (this.IsPaused != null) {
            s += ind + "isPaused\n" ;
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (this.BlackoutWindowResponseInfo != null) {
            var fspec = this.BlackoutWindowResponseInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "blackoutWindowResponseInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VolumeGroupSummary? VolumeGroupSummary
        // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
        if (this.VolumeGroupSummary != null) {
            var fspec = this.VolumeGroupSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "volumeGroupSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        if (this.Volumes != null) {
            var fspec = this.Volumes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "volumes {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId", true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (this.IsPaused == null && Exploration.Includes(parent + ".isPaused", true))
        {
            this.IsPaused = true;
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (this.BlackoutWindowResponseInfo == null && Exploration.Includes(parent + ".blackoutWindowResponseInfo"))
        {
            this.BlackoutWindowResponseInfo = new BlackoutWindowResponseInfo();
            this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(parent + ".blackoutWindowResponseInfo");
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
        {
            this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
            this.PendingSlaDomain.ApplyExploratoryFieldSpec(parent + ".pendingSlaDomain");
        }
        //      C# -> VolumeGroupSummary? VolumeGroupSummary
        // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
        if (this.VolumeGroupSummary == null && Exploration.Includes(parent + ".volumeGroupSummary"))
        {
            this.VolumeGroupSummary = new VolumeGroupSummary();
            this.VolumeGroupSummary.ApplyExploratoryFieldSpec(parent + ".volumeGroupSummary");
        }
        //      C# -> List<HostVolumeSummary>? Volumes
        // GraphQL -> volumes: [HostVolumeSummary!]! (type)
        if (this.Volumes == null && Exploration.Includes(parent + ".volumes"))
        {
            this.Volumes = new List<HostVolumeSummary>();
            this.Volumes.ApplyExploratoryFieldSpec(parent + ".volumes");
        }
    }


    #endregion

    } // class UpdateVolumeGroupReply
    
    #endregion

    public static class ListUpdateVolumeGroupReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<UpdateVolumeGroupReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateVolumeGroupReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateVolumeGroupReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types