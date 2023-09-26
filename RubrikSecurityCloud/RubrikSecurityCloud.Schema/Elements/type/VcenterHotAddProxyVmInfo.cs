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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HotAddProxyVmInfoListResponse? ProxyVmInfo
        // GraphQL -> proxyVmInfo: HotAddProxyVmInfoListResponse! (type)
        if (this.ProxyVmInfo != null) {
            var fspec = this.ProxyVmInfo.AsFieldSpec(conf.Child("proxyVmInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "proxyVmInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> HotAddProxyVmInfoListResponse? ProxyVmInfo
        // GraphQL -> proxyVmInfo: HotAddProxyVmInfoListResponse! (type)
        if (ec.Includes("proxyVmInfo",false))
        {
            if(this.ProxyVmInfo == null) {

                this.ProxyVmInfo = new HotAddProxyVmInfoListResponse();
                this.ProxyVmInfo.ApplyExploratoryFieldSpec(ec.NewChild("proxyVmInfo"));

            } else {

                this.ProxyVmInfo.ApplyExploratoryFieldSpec(ec.NewChild("proxyVmInfo"));

            }
        }
        else if (this.ProxyVmInfo != null && ec.Excludes("proxyVmInfo",false))
        {
            this.ProxyVmInfo = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcenterHotAddProxyVmInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterHotAddProxyVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcenterHotAddProxyVmInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types