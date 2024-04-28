// CrossAccountReplicatedObjectInfo.cs
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
    #region CrossAccountReplicatedObjectInfo
    public class CrossAccountReplicatedObjectInfo: BaseType
    {
        #region members

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> CrossAccountPairInfo? CrossAccountPairInfo
        // GraphQL -> crossAccountPairInfo: CrossAccountPairInfo (type)
        [JsonProperty("crossAccountPairInfo")]
        public CrossAccountPairInfo? CrossAccountPairInfo { get; set; }

        //      C# -> List<ReplicatedObjectInfo>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [ReplicatedObjectInfo!]! (type)
        [JsonProperty("replicatedObjects")]
        public List<ReplicatedObjectInfo>? ReplicatedObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CrossAccountReplicatedObjectInfo";
    }

    public CrossAccountReplicatedObjectInfo Set(
        System.String? Fid = null,
        CrossAccountPairInfo? CrossAccountPairInfo = null,
        List<ReplicatedObjectInfo>? ReplicatedObjects = null
    ) 
    {
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( CrossAccountPairInfo != null ) {
            this.CrossAccountPairInfo = CrossAccountPairInfo;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> CrossAccountPairInfo? CrossAccountPairInfo
        // GraphQL -> crossAccountPairInfo: CrossAccountPairInfo (type)
        if (this.CrossAccountPairInfo != null) {
            var fspec = this.CrossAccountPairInfo.AsFieldSpec(conf.Child("crossAccountPairInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crossAccountPairInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReplicatedObjectInfo>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [ReplicatedObjectInfo!]! (type)
        if (this.ReplicatedObjects != null) {
            var fspec = this.ReplicatedObjects.AsFieldSpec(conf.Child("replicatedObjects"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicatedObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> CrossAccountPairInfo? CrossAccountPairInfo
        // GraphQL -> crossAccountPairInfo: CrossAccountPairInfo (type)
        if (ec.Includes("crossAccountPairInfo",false))
        {
            if(this.CrossAccountPairInfo == null) {

                this.CrossAccountPairInfo = new CrossAccountPairInfo();
                this.CrossAccountPairInfo.ApplyExploratoryFieldSpec(ec.NewChild("crossAccountPairInfo"));

            } else {

                this.CrossAccountPairInfo.ApplyExploratoryFieldSpec(ec.NewChild("crossAccountPairInfo"));

            }
        }
        else if (this.CrossAccountPairInfo != null && ec.Excludes("crossAccountPairInfo",false))
        {
            this.CrossAccountPairInfo = null;
        }
        //      C# -> List<ReplicatedObjectInfo>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [ReplicatedObjectInfo!]! (type)
        if (ec.Includes("replicatedObjects",false))
        {
            if(this.ReplicatedObjects == null) {

                this.ReplicatedObjects = new List<ReplicatedObjectInfo>();
                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            } else {

                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            }
        }
        else if (this.ReplicatedObjects != null && ec.Excludes("replicatedObjects",false))
        {
            this.ReplicatedObjects = null;
        }
    }


    #endregion

    } // class CrossAccountReplicatedObjectInfo
    
    #endregion

    public static class ListCrossAccountReplicatedObjectInfoExtensions
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
            this List<CrossAccountReplicatedObjectInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CrossAccountReplicatedObjectInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CrossAccountReplicatedObjectInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CrossAccountReplicatedObjectInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CrossAccountReplicatedObjectInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types