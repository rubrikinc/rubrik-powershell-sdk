// VcenterPreAddInfo.cs
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
    #region VcenterPreAddInfo
    public class VcenterPreAddInfo: BaseType
    {
        #region members

        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        [JsonProperty("clusterHostGroupInfo")]
        public List<ClusterHostGroupInfo>? ClusterHostGroupInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcenterPreAddInfo";
    }

    public VcenterPreAddInfo Set(
        List<ClusterHostGroupInfo>? ClusterHostGroupInfo = null
    ) 
    {
        if ( ClusterHostGroupInfo != null ) {
            this.ClusterHostGroupInfo = ClusterHostGroupInfo;
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
        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        if (this.ClusterHostGroupInfo != null) {
            var fspec = this.ClusterHostGroupInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterHostGroupInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ClusterHostGroupInfo>? ClusterHostGroupInfo
        // GraphQL -> clusterHostGroupInfo: [ClusterHostGroupInfo!]! (type)
        if (this.ClusterHostGroupInfo == null && ec.Includes("clusterHostGroupInfo",false))
        {
            this.ClusterHostGroupInfo = new List<ClusterHostGroupInfo>();
            this.ClusterHostGroupInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterHostGroupInfo"));
        }
    }


    #endregion

    } // class VcenterPreAddInfo
    
    #endregion

    public static class ListVcenterPreAddInfoExtensions
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
            this List<VcenterPreAddInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcenterPreAddInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterPreAddInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VcenterPreAddInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types