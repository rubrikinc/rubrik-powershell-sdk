// RscSnapshotRetentionInfo.cs
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
    #region RscSnapshotRetentionInfo
    public class RscSnapshotRetentionInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        [JsonProperty("isCustomRetentionApplied")]
        public System.Boolean? IsCustomRetentionApplied { get; set; }

        //      C# -> List<RscSnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [RscSnapshotLocationRetentionInfo!] (type)
        [JsonProperty("archivalInfos")]
        public List<RscSnapshotLocationRetentionInfo>? ArchivalInfos { get; set; }

        //      C# -> RscSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: RscSnapshotLocationRetentionInfo (type)
        [JsonProperty("localInfo")]
        public RscSnapshotLocationRetentionInfo? LocalInfo { get; set; }

        //      C# -> List<RscSnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [RscSnapshotLocationRetentionInfo!] (type)
        [JsonProperty("replicationInfos")]
        public List<RscSnapshotLocationRetentionInfo>? ReplicationInfos { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RscSnapshotRetentionInfo";
    }

    public RscSnapshotRetentionInfo Set(
        System.Boolean? IsCustomRetentionApplied = null,
        List<RscSnapshotLocationRetentionInfo>? ArchivalInfos = null,
        RscSnapshotLocationRetentionInfo? LocalInfo = null,
        List<RscSnapshotLocationRetentionInfo>? ReplicationInfos = null
    ) 
    {
        if ( IsCustomRetentionApplied != null ) {
            this.IsCustomRetentionApplied = IsCustomRetentionApplied;
        }
        if ( ArchivalInfos != null ) {
            this.ArchivalInfos = ArchivalInfos;
        }
        if ( LocalInfo != null ) {
            this.LocalInfo = LocalInfo;
        }
        if ( ReplicationInfos != null ) {
            this.ReplicationInfos = ReplicationInfos;
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
        //      C# -> List<RscSnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [RscSnapshotLocationRetentionInfo!] (type)
        if (this.ArchivalInfos != null) {
            var fspec = this.ArchivalInfos.AsFieldSpec(conf.Child("archivalInfos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RscSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: RscSnapshotLocationRetentionInfo (type)
        if (this.LocalInfo != null) {
            var fspec = this.LocalInfo.AsFieldSpec(conf.Child("localInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "localInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RscSnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [RscSnapshotLocationRetentionInfo!] (type)
        if (this.ReplicationInfos != null) {
            var fspec = this.ReplicationInfos.AsFieldSpec(conf.Child("replicationInfos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationInfos" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<RscSnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [RscSnapshotLocationRetentionInfo!] (type)
        if (ec.Includes("archivalInfos",false))
        {
            if(this.ArchivalInfos == null) {

                this.ArchivalInfos = new List<RscSnapshotLocationRetentionInfo>();
                this.ArchivalInfos.ApplyExploratoryFieldSpec(ec.NewChild("archivalInfos"));

            } else {

                this.ArchivalInfos.ApplyExploratoryFieldSpec(ec.NewChild("archivalInfos"));

            }
        }
        else if (this.ArchivalInfos != null && ec.Excludes("archivalInfos",false))
        {
            this.ArchivalInfos = null;
        }
        //      C# -> RscSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: RscSnapshotLocationRetentionInfo (type)
        if (ec.Includes("localInfo",false))
        {
            if(this.LocalInfo == null) {

                this.LocalInfo = new RscSnapshotLocationRetentionInfo();
                this.LocalInfo.ApplyExploratoryFieldSpec(ec.NewChild("localInfo"));

            } else {

                this.LocalInfo.ApplyExploratoryFieldSpec(ec.NewChild("localInfo"));

            }
        }
        else if (this.LocalInfo != null && ec.Excludes("localInfo",false))
        {
            this.LocalInfo = null;
        }
        //      C# -> List<RscSnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [RscSnapshotLocationRetentionInfo!] (type)
        if (ec.Includes("replicationInfos",false))
        {
            if(this.ReplicationInfos == null) {

                this.ReplicationInfos = new List<RscSnapshotLocationRetentionInfo>();
                this.ReplicationInfos.ApplyExploratoryFieldSpec(ec.NewChild("replicationInfos"));

            } else {

                this.ReplicationInfos.ApplyExploratoryFieldSpec(ec.NewChild("replicationInfos"));

            }
        }
        else if (this.ReplicationInfos != null && ec.Excludes("replicationInfos",false))
        {
            this.ReplicationInfos = null;
        }
    }


    #endregion

    } // class RscSnapshotRetentionInfo
    
    #endregion

    public static class ListRscSnapshotRetentionInfoExtensions
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
            this List<RscSnapshotRetentionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RscSnapshotRetentionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RscSnapshotRetentionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RscSnapshotRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RscSnapshotRetentionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types