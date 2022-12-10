// HostVolumeSummary.cs
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
    #region HostVolumeSummary
    public class HostVolumeSummary: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsCurrentlyPresentOnSystem
        // GraphQL -> isCurrentlyPresentOnSystem: Boolean! (scalar)
        [JsonProperty("isCurrentlyPresentOnSystem")]
        public System.Boolean? IsCurrentlyPresentOnSystem { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        [JsonProperty("volumeGroupId")]
        public System.String? VolumeGroupId { get; set; }

        //      C# -> VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary
        // GraphQL -> volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary (type)
        [JsonProperty("volumeGroupSnapshotVolumeSummary")]
        public VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary { get; set; }

        #endregion

    #region methods

    public HostVolumeSummary Set(
        System.Boolean? IsCurrentlyPresentOnSystem = null,
        System.String? NaturalId = null,
        System.String? VolumeGroupId = null,
        VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary = null
    ) 
    {
        if ( IsCurrentlyPresentOnSystem != null ) {
            this.IsCurrentlyPresentOnSystem = IsCurrentlyPresentOnSystem;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
        }
        if ( VolumeGroupId != null ) {
            this.VolumeGroupId = VolumeGroupId;
        }
        if ( VolumeGroupSnapshotVolumeSummary != null ) {
            this.VolumeGroupSnapshotVolumeSummary = VolumeGroupSnapshotVolumeSummary;
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
            //      C# -> System.Boolean? IsCurrentlyPresentOnSystem
            // GraphQL -> isCurrentlyPresentOnSystem: Boolean! (scalar)
            if (this.IsCurrentlyPresentOnSystem != null)
            {
                 s += ind + "isCurrentlyPresentOnSystem\n";

            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String! (scalar)
            if (this.NaturalId != null)
            {
                 s += ind + "naturalId\n";

            }
            //      C# -> System.String? VolumeGroupId
            // GraphQL -> volumeGroupId: String (scalar)
            if (this.VolumeGroupId != null)
            {
                 s += ind + "volumeGroupId\n";

            }
            //      C# -> VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary
            // GraphQL -> volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary (type)
            if (this.VolumeGroupSnapshotVolumeSummary != null)
            {
                 s += ind + "volumeGroupSnapshotVolumeSummary\n";

                 s += ind + "{\n" + 
                 this.VolumeGroupSnapshotVolumeSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsCurrentlyPresentOnSystem
            // GraphQL -> isCurrentlyPresentOnSystem: Boolean! (scalar)
            if (this.IsCurrentlyPresentOnSystem == null && Exploration.Includes(parent + ".isCurrentlyPresentOnSystem$"))
            {
                this.IsCurrentlyPresentOnSystem = new System.Boolean();
            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String! (scalar)
            if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId$"))
            {
                this.NaturalId = new System.String("FETCH");
            }
            //      C# -> System.String? VolumeGroupId
            // GraphQL -> volumeGroupId: String (scalar)
            if (this.VolumeGroupId == null && Exploration.Includes(parent + ".volumeGroupId$"))
            {
                this.VolumeGroupId = new System.String("FETCH");
            }
            //      C# -> VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary
            // GraphQL -> volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary (type)
            if (this.VolumeGroupSnapshotVolumeSummary == null && Exploration.Includes(parent + ".volumeGroupSnapshotVolumeSummary"))
            {
                this.VolumeGroupSnapshotVolumeSummary = new VolumeGroupSnapshotVolumeSummary();
                this.VolumeGroupSnapshotVolumeSummary.ApplyExploratoryFragment(parent + ".volumeGroupSnapshotVolumeSummary");
            }
        }


    #endregion

    } // class HostVolumeSummary
    #endregion

    public static class ListHostVolumeSummaryExtensions
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
            this List<HostVolumeSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HostVolumeSummary> list, 
            String parent = "")
        {
            var item = new HostVolumeSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types