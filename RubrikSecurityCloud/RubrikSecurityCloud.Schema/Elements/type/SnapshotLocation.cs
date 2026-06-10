// SnapshotLocation.cs
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
    #region SnapshotLocation
    public class SnapshotLocation: BaseType
    {
        #region members

        //      C# -> SnapshotLocType? LocationType
        // GraphQL -> locationType: SnapshotLocType! (enum)
        [JsonProperty("locationType")]
        public SnapshotLocType? LocationType { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotLocation";
    }

    public SnapshotLocation Set(
        SnapshotLocType? LocationType = null,
        System.String? LocationId = null,
        System.String? LocationName = null,
        System.Int32? SnapshotCount = null
    ) 
    {
        if ( LocationType != null ) {
            this.LocationType = LocationType;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
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
        //      C# -> SnapshotLocType? LocationType
        // GraphQL -> locationType: SnapshotLocType! (enum)
        if (this.LocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationType\n" ;
            } else {
                s += ind + "locationType\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationName\n" ;
            } else {
                s += ind + "locationName\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int (scalar)
        if (this.SnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCount\n" ;
            } else {
                s += ind + "snapshotCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SnapshotLocType? LocationType
        // GraphQL -> locationType: SnapshotLocType! (enum)
        if (ec.Includes("locationType",true))
        {
            if(this.LocationType == null) {

                this.LocationType = new SnapshotLocType();

            } else {


            }
        }
        else if (this.LocationType != null && ec.Excludes("locationType",true))
        {
            this.LocationType = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (ec.Includes("locationName",true))
        {
            if(this.LocationName == null) {

                this.LocationName = "FETCH";

            } else {


            }
        }
        else if (this.LocationName != null && ec.Excludes("locationName",true))
        {
            this.LocationName = null;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int (scalar)
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
    }


    #endregion

    } // class SnapshotLocation
    
    #endregion

    public static class ListSnapshotLocationExtensions
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
            this List<SnapshotLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotLocation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types