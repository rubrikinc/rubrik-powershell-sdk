// ObjectVersionWithSnapshot.cs
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
    #region ObjectVersionWithSnapshot
    public class ObjectVersionWithSnapshot: BaseType
    {
        #region members

        //      C# -> CloudNativeSnapshotInfo? LatestSnapshotInfo
        // GraphQL -> latestSnapshotInfo: CloudNativeSnapshotInfo (type)
        [JsonProperty("latestSnapshotInfo")]
        public CloudNativeSnapshotInfo? LatestSnapshotInfo { get; set; }

        //      C# -> ObjectVersion? ObjectVersion
        // GraphQL -> objectVersion: ObjectVersion (type)
        [JsonProperty("objectVersion")]
        public ObjectVersion? ObjectVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectVersionWithSnapshot";
    }

    public ObjectVersionWithSnapshot Set(
        CloudNativeSnapshotInfo? LatestSnapshotInfo = null,
        ObjectVersion? ObjectVersion = null
    ) 
    {
        if ( LatestSnapshotInfo != null ) {
            this.LatestSnapshotInfo = LatestSnapshotInfo;
        }
        if ( ObjectVersion != null ) {
            this.ObjectVersion = ObjectVersion;
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
        //      C# -> CloudNativeSnapshotInfo? LatestSnapshotInfo
        // GraphQL -> latestSnapshotInfo: CloudNativeSnapshotInfo (type)
        if (this.LatestSnapshotInfo != null) {
            var fspec = this.LatestSnapshotInfo.AsFieldSpec(conf.Child("latestSnapshotInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestSnapshotInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectVersion? ObjectVersion
        // GraphQL -> objectVersion: ObjectVersion (type)
        if (this.ObjectVersion != null) {
            var fspec = this.ObjectVersion.AsFieldSpec(conf.Child("objectVersion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectVersion" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudNativeSnapshotInfo? LatestSnapshotInfo
        // GraphQL -> latestSnapshotInfo: CloudNativeSnapshotInfo (type)
        if (ec.Includes("latestSnapshotInfo",false))
        {
            if(this.LatestSnapshotInfo == null) {

                this.LatestSnapshotInfo = new CloudNativeSnapshotInfo();
                this.LatestSnapshotInfo.ApplyExploratoryFieldSpec(ec.NewChild("latestSnapshotInfo"));

            } else {

                this.LatestSnapshotInfo.ApplyExploratoryFieldSpec(ec.NewChild("latestSnapshotInfo"));

            }
        }
        else if (this.LatestSnapshotInfo != null && ec.Excludes("latestSnapshotInfo",false))
        {
            this.LatestSnapshotInfo = null;
        }
        //      C# -> ObjectVersion? ObjectVersion
        // GraphQL -> objectVersion: ObjectVersion (type)
        if (ec.Includes("objectVersion",false))
        {
            if(this.ObjectVersion == null) {

                this.ObjectVersion = new ObjectVersion();
                this.ObjectVersion.ApplyExploratoryFieldSpec(ec.NewChild("objectVersion"));

            } else {

                this.ObjectVersion.ApplyExploratoryFieldSpec(ec.NewChild("objectVersion"));

            }
        }
        else if (this.ObjectVersion != null && ec.Excludes("objectVersion",false))
        {
            this.ObjectVersion = null;
        }
    }


    #endregion

    } // class ObjectVersionWithSnapshot
    
    #endregion

    public static class ListObjectVersionWithSnapshotExtensions
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
            this List<ObjectVersionWithSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectVersionWithSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectVersionWithSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectVersionWithSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectVersionWithSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types