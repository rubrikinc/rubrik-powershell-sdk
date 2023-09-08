// K8sSnapshotInfo.cs
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
    #region K8sSnapshotInfo
    public class K8sSnapshotInfo: BaseType
    {
        #region members

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        [JsonProperty("namespace")]
        public System.String? Namespace { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime! (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> List<PvcInformation>? PvcList
        // GraphQL -> pvcList: [PvcInformation!]! (type)
        [JsonProperty("pvcList")]
        public List<PvcInformation>? PvcList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sSnapshotInfo";
    }

    public K8sSnapshotInfo Set(
        DateTime? ExpirationTime = null,
        System.Boolean? IsArchived = null,
        System.String? Namespace = null,
        DateTime? SnapshotTime = null,
        List<PvcInformation>? PvcList = null
    ) 
    {
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( Namespace != null ) {
            this.Namespace = Namespace;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( PvcList != null ) {
            this.PvcList = PvcList;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            s += ind + "expirationTime\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (this.Namespace != null) {
            s += ind + "namespace\n" ;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime! (scalar)
        if (this.SnapshotTime != null) {
            s += ind + "snapshotTime\n" ;
        }
        //      C# -> List<PvcInformation>? PvcList
        // GraphQL -> pvcList: [PvcInformation!]! (type)
        if (this.PvcList != null) {
            var fspec = this.PvcList.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pvcList {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime == null && ec.Includes("expirationTime",true))
        {
            this.ExpirationTime = new DateTime();
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && ec.Includes("isArchived",true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (this.Namespace == null && ec.Includes("namespace",true))
        {
            this.Namespace = "FETCH";
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime! (scalar)
        if (this.SnapshotTime == null && ec.Includes("snapshotTime",true))
        {
            this.SnapshotTime = new DateTime();
        }
        //      C# -> List<PvcInformation>? PvcList
        // GraphQL -> pvcList: [PvcInformation!]! (type)
        if (this.PvcList == null && ec.Includes("pvcList",false))
        {
            this.PvcList = new List<PvcInformation>();
            this.PvcList.ApplyExploratoryFieldSpec(ec.NewChild("pvcList"));
        }
    }


    #endregion

    } // class K8sSnapshotInfo
    
    #endregion

    public static class ListK8sSnapshotInfoExtensions
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
            this List<K8sSnapshotInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<K8sSnapshotInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sSnapshotInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<K8sSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types