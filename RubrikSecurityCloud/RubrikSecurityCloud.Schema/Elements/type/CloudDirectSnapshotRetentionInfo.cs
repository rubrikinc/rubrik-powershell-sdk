// CloudDirectSnapshotRetentionInfo.cs
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
    #region CloudDirectSnapshotRetentionInfo
    public class CloudDirectSnapshotRetentionInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        [JsonProperty("isCustomRetentionApplied")]
        public System.Boolean? IsCustomRetentionApplied { get; set; }

        //      C# -> CloudDirectSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: CloudDirectSnapshotLocationRetentionInfo (type)
        [JsonProperty("localInfo")]
        public CloudDirectSnapshotLocationRetentionInfo? LocalInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectSnapshotRetentionInfo";
    }

    public CloudDirectSnapshotRetentionInfo Set(
        System.Boolean? IsCustomRetentionApplied = null,
        CloudDirectSnapshotLocationRetentionInfo? LocalInfo = null
    ) 
    {
        if ( IsCustomRetentionApplied != null ) {
            this.IsCustomRetentionApplied = IsCustomRetentionApplied;
        }
        if ( LocalInfo != null ) {
            this.LocalInfo = LocalInfo;
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
        //      C# -> CloudDirectSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: CloudDirectSnapshotLocationRetentionInfo (type)
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
        //      C# -> CloudDirectSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: CloudDirectSnapshotLocationRetentionInfo (type)
        if (ec.Includes("localInfo",false))
        {
            if(this.LocalInfo == null) {

                this.LocalInfo = new CloudDirectSnapshotLocationRetentionInfo();
                this.LocalInfo.ApplyExploratoryFieldSpec(ec.NewChild("localInfo"));

            } else {

                this.LocalInfo.ApplyExploratoryFieldSpec(ec.NewChild("localInfo"));

            }
        }
        else if (this.LocalInfo != null && ec.Excludes("localInfo",false))
        {
            this.LocalInfo = null;
        }
    }


    #endregion

    } // class CloudDirectSnapshotRetentionInfo
    
    #endregion

    public static class ListCloudDirectSnapshotRetentionInfoExtensions
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
            this List<CloudDirectSnapshotRetentionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectSnapshotRetentionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectSnapshotRetentionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectSnapshotRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectSnapshotRetentionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types