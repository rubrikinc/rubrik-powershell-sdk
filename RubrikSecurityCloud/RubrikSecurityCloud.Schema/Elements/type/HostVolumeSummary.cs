// HostVolumeSummary.cs
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
    #region HostVolumeSummary
    public class HostVolumeSummary: BaseType
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

    public override string GetGqlTypeName() {
        return "HostVolumeSummary";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsCurrentlyPresentOnSystem
        // GraphQL -> isCurrentlyPresentOnSystem: Boolean! (scalar)
        if (this.IsCurrentlyPresentOnSystem != null) {
            s += ind + "isCurrentlyPresentOnSystem\n" ;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            s += ind + "naturalId\n" ;
        }
        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        if (this.VolumeGroupId != null) {
            s += ind + "volumeGroupId\n" ;
        }
        //      C# -> VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary
        // GraphQL -> volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary (type)
        if (this.VolumeGroupSnapshotVolumeSummary != null) {
            var fspec = this.VolumeGroupSnapshotVolumeSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "volumeGroupSnapshotVolumeSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsCurrentlyPresentOnSystem
        // GraphQL -> isCurrentlyPresentOnSystem: Boolean! (scalar)
        if (this.IsCurrentlyPresentOnSystem == null && ec.Includes("isCurrentlyPresentOnSystem",true))
        {
            this.IsCurrentlyPresentOnSystem = true;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId == null && ec.Includes("naturalId",true))
        {
            this.NaturalId = "FETCH";
        }
        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        if (this.VolumeGroupId == null && ec.Includes("volumeGroupId",true))
        {
            this.VolumeGroupId = "FETCH";
        }
        //      C# -> VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary
        // GraphQL -> volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary (type)
        if (this.VolumeGroupSnapshotVolumeSummary == null && ec.Includes("volumeGroupSnapshotVolumeSummary",false))
        {
            this.VolumeGroupSnapshotVolumeSummary = new VolumeGroupSnapshotVolumeSummary();
            this.VolumeGroupSnapshotVolumeSummary.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSnapshotVolumeSummary"));
        }
    }


    #endregion

    } // class HostVolumeSummary
    
    #endregion

    public static class ListHostVolumeSummaryExtensions
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
            this List<HostVolumeSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HostVolumeSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HostVolumeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<HostVolumeSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types