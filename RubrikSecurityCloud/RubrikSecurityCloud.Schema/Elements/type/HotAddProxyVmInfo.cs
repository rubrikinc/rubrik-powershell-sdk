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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "HotAddProxyVmInfo";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> HotAddProxyVmStatusType? Status
        // GraphQL -> status: HotAddProxyVmStatusType! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String (scalar)
        if (this.ComputeClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterName\n" ;
            } else {
                s += ind + "computeClusterName\n" ;
            }
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (this.DatastoreName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreName\n" ;
            } else {
                s += ind + "datastoreName\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        if (this.UsedPortCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedPortCount\n" ;
            } else {
                s += ind + "usedPortCount\n" ;
            }
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (this.VcenterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterName\n" ;
            } else {
                s += ind + "vcenterName\n" ;
            }
        }
        //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
        // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
        if (this.ProxyNetworkInfo != null) {
            var fspec = this.ProxyNetworkInfo.AsFieldSpec(conf.Child("proxyNetworkInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "proxyNetworkInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HotAddProxyVmStatusType? Status
        // GraphQL -> status: HotAddProxyVmStatusType! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new HotAddProxyVmStatusType();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String (scalar)
        if (ec.Includes("computeClusterName",true))
        {
            if(this.ComputeClusterName == null) {

                this.ComputeClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterName != null && ec.Excludes("computeClusterName",true))
        {
            this.ComputeClusterName = null;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (ec.Includes("datastoreName",true))
        {
            if(this.DatastoreName == null) {

                this.DatastoreName = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreName != null && ec.Excludes("datastoreName",true))
        {
            this.DatastoreName = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        if (ec.Includes("usedPortCount",true))
        {
            if(this.UsedPortCount == null) {

                this.UsedPortCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UsedPortCount != null && ec.Excludes("usedPortCount",true))
        {
            this.UsedPortCount = null;
        }
        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        if (ec.Includes("vcenterName",true))
        {
            if(this.VcenterName == null) {

                this.VcenterName = "FETCH";

            } else {


            }
        }
        else if (this.VcenterName != null && ec.Excludes("vcenterName",true))
        {
            this.VcenterName = null;
        }
        //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
        // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
        if (ec.Includes("proxyNetworkInfo",false))
        {
            if(this.ProxyNetworkInfo == null) {

                this.ProxyNetworkInfo = new HotAddNetworkConfigWithName();
                this.ProxyNetworkInfo.ApplyExploratoryFieldSpec(ec.NewChild("proxyNetworkInfo"));

            } else {

                this.ProxyNetworkInfo.ApplyExploratoryFieldSpec(ec.NewChild("proxyNetworkInfo"));

            }
        }
        else if (this.ProxyNetworkInfo != null && ec.Excludes("proxyNetworkInfo",false))
        {
            this.ProxyNetworkInfo = null;
        }
    }


    #endregion

    } // class HotAddProxyVmInfo
    
    #endregion

    public static class ListHotAddProxyVmInfoExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<HotAddProxyVmInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HotAddProxyVmInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HotAddProxyVmInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HotAddProxyVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HotAddProxyVmInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types