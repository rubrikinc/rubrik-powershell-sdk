// LegalHoldSnappableDetail.cs
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
    #region LegalHoldSnappableDetail
    public class LegalHoldSnappableDetail: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        [JsonProperty("snappableType")]
        public ManagedObjectType? SnappableType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        [JsonProperty("physicalLocation")]
        public List<LocationPathPoint>? PhysicalLocation { get; set; }

        //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
        // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
        [JsonProperty("snapshotDetails")]
        public List<LegalHoldSnapshotDetail>? SnapshotDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LegalHoldSnappableDetail";
    }

    public LegalHoldSnappableDetail Set(
        ManagedObjectType? SnappableType = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? SnapshotCount = null,
        List<LocationPathPoint>? PhysicalLocation = null,
        List<LegalHoldSnapshotDetail>? SnapshotDetails = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( PhysicalLocation != null ) {
            this.PhysicalLocation = PhysicalLocation;
        }
        if ( SnapshotDetails != null ) {
            this.SnapshotDetails = SnapshotDetails;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (this.SnappableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableType\n" ;
            } else {
                s += ind + "snappableType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (this.SnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCount\n" ;
            } else {
                s += ind + "snapshotCount\n" ;
            }
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            var fspec = this.PhysicalLocation.AsFieldSpec(conf.Child("physicalLocation"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
        // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
        if (this.SnapshotDetails != null) {
            var fspec = this.SnapshotDetails.AsFieldSpec(conf.Child("snapshotDetails"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? SnappableType
        // GraphQL -> snappableType: ManagedObjectType! (enum)
        if (ec.Includes("snappableType",true))
        {
            if(this.SnappableType == null) {

                this.SnappableType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.SnappableType != null && ec.Excludes("snappableType",true))
        {
            this.SnappableType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int! (scalar)
        if (ec.Includes("snapshotCount",true))
        {
            if(this.SnapshotCount == null) {

                this.SnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnapshotCount != null && ec.Excludes("snapshotCount",true))
        {
            this.SnapshotCount = null;
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (ec.Includes("physicalLocation",false))
        {
            if(this.PhysicalLocation == null) {

                this.PhysicalLocation = new List<LocationPathPoint>();
                this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));

            } else {

                this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));

            }
        }
        else if (this.PhysicalLocation != null && ec.Excludes("physicalLocation",false))
        {
            this.PhysicalLocation = null;
        }
        //      C# -> List<LegalHoldSnapshotDetail>? SnapshotDetails
        // GraphQL -> snapshotDetails: [LegalHoldSnapshotDetail!]! (type)
        if (ec.Includes("snapshotDetails",false))
        {
            if(this.SnapshotDetails == null) {

                this.SnapshotDetails = new List<LegalHoldSnapshotDetail>();
                this.SnapshotDetails.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDetails"));

            } else {

                this.SnapshotDetails.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDetails"));

            }
        }
        else if (this.SnapshotDetails != null && ec.Excludes("snapshotDetails",false))
        {
            this.SnapshotDetails = null;
        }
    }


    #endregion

    } // class LegalHoldSnappableDetail
    
    #endregion

    public static class ListLegalHoldSnappableDetailExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<LegalHoldSnappableDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LegalHoldSnappableDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LegalHoldSnappableDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LegalHoldSnappableDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LegalHoldSnappableDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types