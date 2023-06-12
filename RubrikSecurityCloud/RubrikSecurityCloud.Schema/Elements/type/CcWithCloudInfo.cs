// CcWithCloudInfo.cs
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
    #region CcWithCloudInfo
    public class CcWithCloudInfo: BaseType
    {
        #region members

        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        [JsonProperty("vendor")]
        public CcpVendorType? Vendor { get; set; }

        //      C# -> System.String? CloudAccount
        // GraphQL -> cloudAccount: String! (scalar)
        [JsonProperty("cloudAccount")]
        public System.String? CloudAccount { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeCloudAccountId
        // GraphQL -> nativeCloudAccountId: String! (scalar)
        [JsonProperty("nativeCloudAccountId")]
        public System.String? NativeCloudAccountId { get; set; }

        //      C# -> System.String? NativeCloudAccountName
        // GraphQL -> nativeCloudAccountName: String! (scalar)
        [JsonProperty("nativeCloudAccountName")]
        public System.String? NativeCloudAccountName { get; set; }

        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
        [JsonProperty("networkName")]
        public System.String? NetworkName { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.String? RegionId
        // GraphQL -> regionId: String! (scalar)
        [JsonProperty("regionId")]
        public System.String? RegionId { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> ElasticStorageConfig? StorageConfig
        // GraphQL -> storageConfig: ElasticStorageConfig (type)
        [JsonProperty("storageConfig")]
        public ElasticStorageConfig? StorageConfig { get; set; }


        #endregion

    #region methods

    public CcWithCloudInfo Set(
        CcpVendorType? Vendor = null,
        System.String? CloudAccount = null,
        System.String? CloudAccountId = null,
        System.String? Name = null,
        System.String? NativeCloudAccountId = null,
        System.String? NativeCloudAccountName = null,
        System.String? NetworkName = null,
        System.String? Region = null,
        System.String? RegionId = null,
        System.String? Uuid = null,
        ElasticStorageConfig? StorageConfig = null
    ) 
    {
        if ( Vendor != null ) {
            this.Vendor = Vendor;
        }
        if ( CloudAccount != null ) {
            this.CloudAccount = CloudAccount;
        }
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeCloudAccountId != null ) {
            this.NativeCloudAccountId = NativeCloudAccountId;
        }
        if ( NativeCloudAccountName != null ) {
            this.NativeCloudAccountName = NativeCloudAccountName;
        }
        if ( NetworkName != null ) {
            this.NetworkName = NetworkName;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( RegionId != null ) {
            this.RegionId = RegionId;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( StorageConfig != null ) {
            this.StorageConfig = StorageConfig;
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
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor != null) {
            s += ind + "vendor\n" ;
        }
        //      C# -> System.String? CloudAccount
        // GraphQL -> cloudAccount: String! (scalar)
        if (this.CloudAccount != null) {
            s += ind + "cloudAccount\n" ;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        if (this.CloudAccountId != null) {
            s += ind + "cloudAccountId\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NativeCloudAccountId
        // GraphQL -> nativeCloudAccountId: String! (scalar)
        if (this.NativeCloudAccountId != null) {
            s += ind + "nativeCloudAccountId\n" ;
        }
        //      C# -> System.String? NativeCloudAccountName
        // GraphQL -> nativeCloudAccountName: String! (scalar)
        if (this.NativeCloudAccountName != null) {
            s += ind + "nativeCloudAccountName\n" ;
        }
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
        if (this.NetworkName != null) {
            s += ind + "networkName\n" ;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? RegionId
        // GraphQL -> regionId: String! (scalar)
        if (this.RegionId != null) {
            s += ind + "regionId\n" ;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid != null) {
            s += ind + "uuid\n" ;
        }
        //      C# -> ElasticStorageConfig? StorageConfig
        // GraphQL -> storageConfig: ElasticStorageConfig (type)
        if (this.StorageConfig != null) {
            var fspec = this.StorageConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "storageConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor == null && Exploration.Includes(parent + ".vendor", true))
        {
            this.Vendor = new CcpVendorType();
        }
        //      C# -> System.String? CloudAccount
        // GraphQL -> cloudAccount: String! (scalar)
        if (this.CloudAccount == null && Exploration.Includes(parent + ".cloudAccount", true))
        {
            this.CloudAccount = "FETCH";
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        if (this.CloudAccountId == null && Exploration.Includes(parent + ".cloudAccountId", true))
        {
            this.CloudAccountId = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NativeCloudAccountId
        // GraphQL -> nativeCloudAccountId: String! (scalar)
        if (this.NativeCloudAccountId == null && Exploration.Includes(parent + ".nativeCloudAccountId", true))
        {
            this.NativeCloudAccountId = "FETCH";
        }
        //      C# -> System.String? NativeCloudAccountName
        // GraphQL -> nativeCloudAccountName: String! (scalar)
        if (this.NativeCloudAccountName == null && Exploration.Includes(parent + ".nativeCloudAccountName", true))
        {
            this.NativeCloudAccountName = "FETCH";
        }
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
        if (this.NetworkName == null && Exploration.Includes(parent + ".networkName", true))
        {
            this.NetworkName = "FETCH";
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = "FETCH";
        }
        //      C# -> System.String? RegionId
        // GraphQL -> regionId: String! (scalar)
        if (this.RegionId == null && Exploration.Includes(parent + ".regionId", true))
        {
            this.RegionId = "FETCH";
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid == null && Exploration.Includes(parent + ".uuid", true))
        {
            this.Uuid = "FETCH";
        }
        //      C# -> ElasticStorageConfig? StorageConfig
        // GraphQL -> storageConfig: ElasticStorageConfig (type)
        if (this.StorageConfig == null && Exploration.Includes(parent + ".storageConfig"))
        {
            this.StorageConfig = new ElasticStorageConfig();
            this.StorageConfig.ApplyExploratoryFieldSpec(parent + ".storageConfig");
        }
    }


    #endregion

    } // class CcWithCloudInfo
    
    #endregion

    public static class ListCcWithCloudInfoExtensions
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
            this List<CcWithCloudInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CcWithCloudInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CcWithCloudInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types