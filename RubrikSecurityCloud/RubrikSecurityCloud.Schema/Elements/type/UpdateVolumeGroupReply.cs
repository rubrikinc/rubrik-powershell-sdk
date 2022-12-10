// UpdateVolumeGroupReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:40.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateVolumeGroupReply
    public class UpdateVolumeGroupReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String! (scalar)
            if (this.ConfiguredSlaDomainId != null)
            {
                 s += ind + "configuredSlaDomainId\n";

            }
            //      C# -> System.Boolean? IsPaused
            // GraphQL -> isPaused: Boolean! (scalar)
            if (this.IsPaused != null)
            {
                 s += ind + "isPaused\n";

            }
            //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
            // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
            if (this.BlackoutWindowResponseInfo != null)
            {
                 s += ind + "blackoutWindowResponseInfo\n";

                 s += ind + "{\n" + 
                 this.BlackoutWindowResponseInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain != null)
            {
                 s += ind + "pendingSlaDomain\n";

                 s += ind + "{\n" + 
                 this.PendingSlaDomain.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VolumeGroupSummary? VolumeGroupSummary
            // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
            if (this.VolumeGroupSummary != null)
            {
                 s += ind + "volumeGroupSummary\n";

                 s += ind + "{\n" + 
                 this.VolumeGroupSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<HostVolumeSummary>? Volumes
            // GraphQL -> volumes: [HostVolumeSummary!]! (type)
            if (this.Volumes != null)
            {
                 s += ind + "volumes\n";

                 s += ind + "{\n" + 
                 this.Volumes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String! (scalar)
            if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId$"))
            {
                this.ConfiguredSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsPaused
            // GraphQL -> isPaused: Boolean! (scalar)
            if (this.IsPaused == null && Exploration.Includes(parent + ".isPaused$"))
            {
                this.IsPaused = new System.Boolean();
            }
            //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
            // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
            if (this.BlackoutWindowResponseInfo == null && Exploration.Includes(parent + ".blackoutWindowResponseInfo"))
            {
                this.BlackoutWindowResponseInfo = new BlackoutWindowResponseInfo();
                this.BlackoutWindowResponseInfo.ApplyExploratoryFragment(parent + ".blackoutWindowResponseInfo");
            }
            //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
            // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
            if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
            {
                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFragment(parent + ".pendingSlaDomain");
            }
            //      C# -> VolumeGroupSummary? VolumeGroupSummary
            // GraphQL -> volumeGroupSummary: VolumeGroupSummary (type)
            if (this.VolumeGroupSummary == null && Exploration.Includes(parent + ".volumeGroupSummary"))
            {
                this.VolumeGroupSummary = new VolumeGroupSummary();
                this.VolumeGroupSummary.ApplyExploratoryFragment(parent + ".volumeGroupSummary");
            }
            //      C# -> List<HostVolumeSummary>? Volumes
            // GraphQL -> volumes: [HostVolumeSummary!]! (type)
            if (this.Volumes == null && Exploration.Includes(parent + ".volumes"))
            {
                this.Volumes = new List<HostVolumeSummary>();
                this.Volumes.ApplyExploratoryFragment(parent + ".volumes");
            }
        }


    #endregion

    } // class UpdateVolumeGroupReply
    #endregion

    public static class ListUpdateVolumeGroupReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<UpdateVolumeGroupReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateVolumeGroupReply> list, 
            String parent = "")
        {
            var item = new UpdateVolumeGroupReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types