// TprSnapshotInfo.cs
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
    #region TprSnapshotInfo
    public class TprSnapshotInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        [JsonProperty("isCustomRetentionApplied")]
        public System.Boolean? IsCustomRetentionApplied { get; set; }

        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean! (scalar)
        [JsonProperty("isDownloadedSnapshot")]
        public System.Boolean? IsDownloadedSnapshot { get; set; }

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<TprPerLocationSnapshotInfo>? PerLocationSnapshotInfos
        // GraphQL -> perLocationSnapshotInfos: [TprPerLocationSnapshotInfo!]! (type)
        [JsonProperty("perLocationSnapshotInfos")]
        public List<TprPerLocationSnapshotInfo>? PerLocationSnapshotInfos { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprSnapshotInfo";
    }

    public TprSnapshotInfo Set(
        System.Boolean? IsCustomRetentionApplied = null,
        System.Boolean? IsDownloadedSnapshot = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.String? ObjectId = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotId = null,
        List<TprPerLocationSnapshotInfo>? PerLocationSnapshotInfos = null
    ) 
    {
        if ( IsCustomRetentionApplied != null ) {
            this.IsCustomRetentionApplied = IsCustomRetentionApplied;
        }
        if ( IsDownloadedSnapshot != null ) {
            this.IsDownloadedSnapshot = IsDownloadedSnapshot;
        }
        if ( IsOnDemandSnapshot != null ) {
            this.IsOnDemandSnapshot = IsOnDemandSnapshot;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( PerLocationSnapshotInfos != null ) {
            this.PerLocationSnapshotInfos = PerLocationSnapshotInfos;
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
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (this.IsCustomRetentionApplied != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCustomRetentionApplied\n" ;
            } else {
                s += ind + "isCustomRetentionApplied\n" ;
            }
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean! (scalar)
        if (this.IsDownloadedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDownloadedSnapshot\n" ;
            } else {
                s += ind + "isDownloadedSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnDemandSnapshot\n" ;
            } else {
                s += ind + "isOnDemandSnapshot\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> List<TprPerLocationSnapshotInfo>? PerLocationSnapshotInfos
        // GraphQL -> perLocationSnapshotInfos: [TprPerLocationSnapshotInfo!]! (type)
        if (this.PerLocationSnapshotInfos != null) {
            var fspec = this.PerLocationSnapshotInfos.AsFieldSpec(conf.Child("perLocationSnapshotInfos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "perLocationSnapshotInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (ec.Includes("isCustomRetentionApplied",true))
        {
            if(this.IsCustomRetentionApplied == null) {

                this.IsCustomRetentionApplied = true;

            } else {


            }
        }
        else if (this.IsCustomRetentionApplied != null && ec.Excludes("isCustomRetentionApplied",true))
        {
            this.IsCustomRetentionApplied = null;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean! (scalar)
        if (ec.Includes("isDownloadedSnapshot",true))
        {
            if(this.IsDownloadedSnapshot == null) {

                this.IsDownloadedSnapshot = true;

            } else {


            }
        }
        else if (this.IsDownloadedSnapshot != null && ec.Excludes("isDownloadedSnapshot",true))
        {
            this.IsDownloadedSnapshot = null;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (ec.Includes("isOnDemandSnapshot",true))
        {
            if(this.IsOnDemandSnapshot == null) {

                this.IsOnDemandSnapshot = true;

            } else {


            }
        }
        else if (this.IsOnDemandSnapshot != null && ec.Excludes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> List<TprPerLocationSnapshotInfo>? PerLocationSnapshotInfos
        // GraphQL -> perLocationSnapshotInfos: [TprPerLocationSnapshotInfo!]! (type)
        if (ec.Includes("perLocationSnapshotInfos",false))
        {
            if(this.PerLocationSnapshotInfos == null) {

                this.PerLocationSnapshotInfos = new List<TprPerLocationSnapshotInfo>();
                this.PerLocationSnapshotInfos.ApplyExploratoryFieldSpec(ec.NewChild("perLocationSnapshotInfos"));

            } else {

                this.PerLocationSnapshotInfos.ApplyExploratoryFieldSpec(ec.NewChild("perLocationSnapshotInfos"));

            }
        }
        else if (this.PerLocationSnapshotInfos != null && ec.Excludes("perLocationSnapshotInfos",false))
        {
            this.PerLocationSnapshotInfos = null;
        }
    }


    #endregion

    } // class TprSnapshotInfo
    
    #endregion

    public static class ListTprSnapshotInfoExtensions
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
            this List<TprSnapshotInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprSnapshotInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprSnapshotInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprSnapshotInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types