// MatchedSnapshotInfo.cs
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
    #region MatchedSnapshotInfo
    public class MatchedSnapshotInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsPathQuarantinedAtSnapshot
        // GraphQL -> isPathQuarantinedAtSnapshot: Boolean! (scalar)
        [JsonProperty("isPathQuarantinedAtSnapshot")]
        public System.Boolean? IsPathQuarantinedAtSnapshot { get; set; }

        //      C# -> System.Boolean? IsSnapshotExpired
        // GraphQL -> isSnapshotExpired: Boolean! (scalar)
        [JsonProperty("isSnapshotExpired")]
        public System.Boolean? IsSnapshotExpired { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MatchedSnapshotInfo";
    }

    public MatchedSnapshotInfo Set(
        System.Boolean? IsPathQuarantinedAtSnapshot = null,
        System.Boolean? IsSnapshotExpired = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotFid = null
    ) 
    {
        if ( IsPathQuarantinedAtSnapshot != null ) {
            this.IsPathQuarantinedAtSnapshot = IsPathQuarantinedAtSnapshot;
        }
        if ( IsSnapshotExpired != null ) {
            this.IsSnapshotExpired = IsSnapshotExpired;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
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
        //      C# -> System.Boolean? IsPathQuarantinedAtSnapshot
        // GraphQL -> isPathQuarantinedAtSnapshot: Boolean! (scalar)
        if (this.IsPathQuarantinedAtSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPathQuarantinedAtSnapshot\n" ;
            } else {
                s += ind + "isPathQuarantinedAtSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnapshotExpired
        // GraphQL -> isSnapshotExpired: Boolean! (scalar)
        if (this.IsSnapshotExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnapshotExpired\n" ;
            } else {
                s += ind + "isSnapshotExpired\n" ;
            }
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotDate\n" ;
            } else {
                s += ind + "snapshotDate\n" ;
            }
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsPathQuarantinedAtSnapshot
        // GraphQL -> isPathQuarantinedAtSnapshot: Boolean! (scalar)
        if (ec.Includes("isPathQuarantinedAtSnapshot",true))
        {
            if(this.IsPathQuarantinedAtSnapshot == null) {

                this.IsPathQuarantinedAtSnapshot = true;

            } else {


            }
        }
        else if (this.IsPathQuarantinedAtSnapshot != null && ec.Excludes("isPathQuarantinedAtSnapshot",true))
        {
            this.IsPathQuarantinedAtSnapshot = null;
        }
        //      C# -> System.Boolean? IsSnapshotExpired
        // GraphQL -> isSnapshotExpired: Boolean! (scalar)
        if (ec.Includes("isSnapshotExpired",true))
        {
            if(this.IsSnapshotExpired == null) {

                this.IsSnapshotExpired = true;

            } else {


            }
        }
        else if (this.IsSnapshotExpired != null && ec.Excludes("isSnapshotExpired",true))
        {
            this.IsSnapshotExpired = null;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (ec.Includes("snapshotDate",true))
        {
            if(this.SnapshotDate == null) {

                this.SnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotDate != null && ec.Excludes("snapshotDate",true))
        {
            this.SnapshotDate = null;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
        }
    }


    #endregion

    } // class MatchedSnapshotInfo
    
    #endregion

    public static class ListMatchedSnapshotInfoExtensions
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
            this List<MatchedSnapshotInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MatchedSnapshotInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MatchedSnapshotInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MatchedSnapshotInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MatchedSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types