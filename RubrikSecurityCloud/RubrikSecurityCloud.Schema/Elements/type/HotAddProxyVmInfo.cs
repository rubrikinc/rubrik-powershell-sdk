// HotAddProxyVmInfo.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region HotAddProxyVmInfo
    public class HotAddProxyVmInfo: BaseType
    {
        #region members

        //      C# -> HotAddProxyVmStatusType? Status
        // GraphQL -> status: HotAddProxyVmStatusType! (enum)
        [JsonProperty("status")]
        public HotAddProxyVmStatusType? Status { get; set; }

        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String (scalar)
        [JsonProperty("computeClusterName")]
        public System.String? ComputeClusterName { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        [JsonProperty("usedPortCount")]
        public System.Int32? UsedPortCount { get; set; }

        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        [JsonProperty("vcenterName")]
        public System.String? VcenterName { get; set; }

        //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
        // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
        [JsonProperty("proxyNetworkInfo")]
        public HotAddNetworkConfigWithName? ProxyNetworkInfo { get; set; }


        #endregion

    #region methods

    public HotAddProxyVmInfo Set(
        HotAddProxyVmStatusType? Status = null,
        System.String? ComputeClusterName = null,
        System.String? DatastoreName = null,
        System.String? HostName = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? UsedPortCount = null,
        System.String? VcenterName = null,
        HotAddNetworkConfigWithName? ProxyNetworkInfo = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ComputeClusterName != null ) {
            this.ComputeClusterName = ComputeClusterName;
        }
        if ( DatastoreName != null ) {
            this.DatastoreName = DatastoreName;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( UsedPortCount != null ) {
            this.UsedPortCount = UsedPortCount;
        }
        if ( VcenterName != null ) {
            this.VcenterName = VcenterName;
        }
        if ( ProxyNetworkInfo != null ) {
            this.ProxyNetworkInfo = ProxyNetworkInfo;
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
        //      C# -> HotAddProxyVmStatusType? Status
        // GraphQL -> status: HotAddProxyVmStatusType! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String (scalar)
        if (this.ComputeClusterName != null) {
            s += ind + "computeClusterName\n" ;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (this.DatastoreName != null) {
            s += ind + "datastoreName\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        if (this.UsedPortCount != null) {
            s += ind + "usedPortCount\n" ;
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (this.VcenterName != null) {
            s += ind + "vcenterName\n" ;
        }
        //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
        // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
        if (this.ProxyNetworkInfo != null) {
            s += ind + "proxyNetworkInfo {\n" + this.ProxyNetworkInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HotAddProxyVmStatusType? Status
        // GraphQL -> status: HotAddProxyVmStatusType! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new HotAddProxyVmStatusType();
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String (scalar)
        if (this.ComputeClusterName == null && Exploration.Includes(parent + ".computeClusterName", true))
        {
            this.ComputeClusterName = new System.String("FETCH");
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (this.DatastoreName == null && Exploration.Includes(parent + ".datastoreName", true))
        {
            this.DatastoreName = new System.String("FETCH");
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        if (this.UsedPortCount == null && Exploration.Includes(parent + ".usedPortCount", true))
        {
            this.UsedPortCount = new System.Int32();
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (this.VcenterName == null && Exploration.Includes(parent + ".vcenterName", true))
        {
            this.VcenterName = new System.String("FETCH");
        }
        //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
        // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
        if (this.ProxyNetworkInfo == null && Exploration.Includes(parent + ".proxyNetworkInfo"))
        {
            this.ProxyNetworkInfo = new HotAddNetworkConfigWithName();
            this.ProxyNetworkInfo.ApplyExploratoryFieldSpec(parent + ".proxyNetworkInfo");
        }
    }


    #endregion

    } // class HotAddProxyVmInfo
    
    #endregion

    public static class ListHotAddProxyVmInfoExtensions
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
            this List<HotAddProxyVmInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HotAddProxyVmInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HotAddProxyVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types