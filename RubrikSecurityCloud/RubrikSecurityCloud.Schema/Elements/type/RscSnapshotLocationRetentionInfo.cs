// RscSnapshotLocationRetentionInfo.cs
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
    #region RscSnapshotLocationRetentionInfo
    public class RscSnapshotLocationRetentionInfo: BaseType
    {
        #region members

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        [JsonProperty("isExpirationDateCalculated")]
        public System.Boolean? IsExpirationDateCalculated { get; set; }

        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        [JsonProperty("isSnapshotPresent")]
        public System.Boolean? IsSnapshotPresent { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RscSnapshotLocationRetentionInfo";
    }

    public RscSnapshotLocationRetentionInfo Set(
        DateTime? ExpirationTime = null,
        System.Boolean? IsExpirationDateCalculated = null,
        System.Boolean? IsSnapshotPresent = null,
        System.String? LocationId = null,
        System.String? LocationName = null
    ) 
    {
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( IsExpirationDateCalculated != null ) {
            this.IsExpirationDateCalculated = IsExpirationDateCalculated;
        }
        if ( IsSnapshotPresent != null ) {
            this.IsSnapshotPresent = IsSnapshotPresent;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
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
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationTime\n" ;
            } else {
                s += ind + "expirationTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        if (this.IsExpirationDateCalculated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExpirationDateCalculated\n" ;
            } else {
                s += ind + "isExpirationDateCalculated\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (this.IsSnapshotPresent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnapshotPresent\n" ;
            } else {
                s += ind + "isSnapshotPresent\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (ec.Includes("expirationTime",true))
        {
            if(this.ExpirationTime == null) {

                this.ExpirationTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationTime != null && ec.Excludes("expirationTime",true))
        {
            this.ExpirationTime = null;
        }
        //      C# -> System.Boolean? IsExpirationDateCalculated
        // GraphQL -> isExpirationDateCalculated: Boolean! (scalar)
        if (ec.Includes("isExpirationDateCalculated",true))
        {
            if(this.IsExpirationDateCalculated == null) {

                this.IsExpirationDateCalculated = true;

            } else {


            }
        }
        else if (this.IsExpirationDateCalculated != null && ec.Excludes("isExpirationDateCalculated",true))
        {
            this.IsExpirationDateCalculated = null;
        }
        //      C# -> System.Boolean? IsSnapshotPresent
        // GraphQL -> isSnapshotPresent: Boolean! (scalar)
        if (ec.Includes("isSnapshotPresent",true))
        {
            if(this.IsSnapshotPresent == null) {

                this.IsSnapshotPresent = true;

            } else {


            }
        }
        else if (this.IsSnapshotPresent != null && ec.Excludes("isSnapshotPresent",true))
        {
            this.IsSnapshotPresent = null;
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
    }


    #endregion

    } // class RscSnapshotLocationRetentionInfo
    
    #endregion

    public static class ListRscSnapshotLocationRetentionInfoExtensions
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
            this List<RscSnapshotLocationRetentionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RscSnapshotLocationRetentionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RscSnapshotLocationRetentionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RscSnapshotLocationRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RscSnapshotLocationRetentionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types