// VcenterHotAddProxyVmInfo.cs
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
    #region VcenterHotAddProxyVmInfo
    public class VcenterHotAddProxyVmInfo: BaseType
    {
        #region members

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> HotAddProxyVmInfoListResponse? ProxyVmInfo
        // GraphQL -> proxyVmInfo: HotAddProxyVmInfoListResponse! (type)
        [JsonProperty("proxyVmInfo")]
        public HotAddProxyVmInfoListResponse? ProxyVmInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcenterHotAddProxyVmInfo";
    }

    public VcenterHotAddProxyVmInfo Set(
        Cluster? Cluster = null,
        HotAddProxyVmInfoListResponse? ProxyVmInfo = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( ProxyVmInfo != null ) {
            this.ProxyVmInfo = ProxyVmInfo;
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> HotAddProxyVmInfoListResponse? ProxyVmInfo
        // GraphQL -> proxyVmInfo: HotAddProxyVmInfoListResponse! (type)
        if (this.ProxyVmInfo != null) {
            var fspec = this.ProxyVmInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "proxyVmInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> HotAddProxyVmInfoListResponse? ProxyVmInfo
        // GraphQL -> proxyVmInfo: HotAddProxyVmInfoListResponse! (type)
        if (this.ProxyVmInfo == null && Exploration.Includes(parent + ".proxyVmInfo"))
        {
            this.ProxyVmInfo = new HotAddProxyVmInfoListResponse();
            this.ProxyVmInfo.ApplyExploratoryFieldSpec(parent + ".proxyVmInfo");
        }
    }


    #endregion

    } // class VcenterHotAddProxyVmInfo
    
    #endregion

    public static class ListVcenterHotAddProxyVmInfoExtensions
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
            this List<VcenterHotAddProxyVmInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcenterHotAddProxyVmInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterHotAddProxyVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types