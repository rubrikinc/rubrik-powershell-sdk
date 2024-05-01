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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsCurrentlyPresentOnSystem
        // GraphQL -> isCurrentlyPresentOnSystem: Boolean! (scalar)
        if (this.IsCurrentlyPresentOnSystem != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCurrentlyPresentOnSystem\n" ;
            } else {
                s += ind + "isCurrentlyPresentOnSystem\n" ;
            }
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (this.NaturalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "naturalId\n" ;
            } else {
                s += ind + "naturalId\n" ;
            }
        }
        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        if (this.VolumeGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeGroupId\n" ;
            } else {
                s += ind + "volumeGroupId\n" ;
            }
        }
        //      C# -> VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary
        // GraphQL -> volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary (type)
        if (this.VolumeGroupSnapshotVolumeSummary != null) {
            var fspec = this.VolumeGroupSnapshotVolumeSummary.AsFieldSpec(conf.Child("volumeGroupSnapshotVolumeSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumeGroupSnapshotVolumeSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsCurrentlyPresentOnSystem
        // GraphQL -> isCurrentlyPresentOnSystem: Boolean! (scalar)
        if (ec.Includes("isCurrentlyPresentOnSystem",true))
        {
            if(this.IsCurrentlyPresentOnSystem == null) {

                this.IsCurrentlyPresentOnSystem = true;

            } else {


            }
        }
        else if (this.IsCurrentlyPresentOnSystem != null && ec.Excludes("isCurrentlyPresentOnSystem",true))
        {
            this.IsCurrentlyPresentOnSystem = null;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        if (ec.Includes("naturalId",true))
        {
            if(this.NaturalId == null) {

                this.NaturalId = "FETCH";

            } else {


            }
        }
        else if (this.NaturalId != null && ec.Excludes("naturalId",true))
        {
            this.NaturalId = null;
        }
        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        if (ec.Includes("volumeGroupId",true))
        {
            if(this.VolumeGroupId == null) {

                this.VolumeGroupId = "FETCH";

            } else {


            }
        }
        else if (this.VolumeGroupId != null && ec.Excludes("volumeGroupId",true))
        {
            this.VolumeGroupId = null;
        }
        //      C# -> VolumeGroupSnapshotVolumeSummary? VolumeGroupSnapshotVolumeSummary
        // GraphQL -> volumeGroupSnapshotVolumeSummary: VolumeGroupSnapshotVolumeSummary (type)
        if (ec.Includes("volumeGroupSnapshotVolumeSummary",false))
        {
            if(this.VolumeGroupSnapshotVolumeSummary == null) {

                this.VolumeGroupSnapshotVolumeSummary = new VolumeGroupSnapshotVolumeSummary();
                this.VolumeGroupSnapshotVolumeSummary.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSnapshotVolumeSummary"));

            } else {

                this.VolumeGroupSnapshotVolumeSummary.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSnapshotVolumeSummary"));

            }
        }
        else if (this.VolumeGroupSnapshotVolumeSummary != null && ec.Excludes("volumeGroupSnapshotVolumeSummary",false))
        {
            this.VolumeGroupSnapshotVolumeSummary = null;
        }
    }


    #endregion

    } // class HostVolumeSummary
    
    #endregion

    public static class ListHostVolumeSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<HostVolumeSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HostVolumeSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<HostVolumeSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types