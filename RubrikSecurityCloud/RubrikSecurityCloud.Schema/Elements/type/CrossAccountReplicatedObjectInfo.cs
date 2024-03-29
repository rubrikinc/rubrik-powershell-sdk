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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crossAccountPairInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReplicatedObjectInfo>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [ReplicatedObjectInfo!]! (type)
        if (this.ReplicatedObjects != null) {
            var fspec = this.ReplicatedObjects.AsFieldSpec(conf.Child("replicatedObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicatedObjects {\n" + fspec + ind + "}\n" ;
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
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CrossAccountReplicatedObjectInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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