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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "CcWithCloudInfo";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (this.Vendor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendor\n" ;
            } else {
                s += ind + "vendor\n" ;
            }
        }
        //      C# -> System.String? CloudAccount
        // GraphQL -> cloudAccount: String! (scalar)
        if (this.CloudAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccount\n" ;
            } else {
                s += ind + "cloudAccount\n" ;
            }
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        if (this.CloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountId\n" ;
            } else {
                s += ind + "cloudAccountId\n" ;
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
        //      C# -> System.String? NativeCloudAccountId
        // GraphQL -> nativeCloudAccountId: String! (scalar)
        if (this.NativeCloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeCloudAccountId\n" ;
            } else {
                s += ind + "nativeCloudAccountId\n" ;
            }
        }
        //      C# -> System.String? NativeCloudAccountName
        // GraphQL -> nativeCloudAccountName: String! (scalar)
        if (this.NativeCloudAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeCloudAccountName\n" ;
            } else {
                s += ind + "nativeCloudAccountName\n" ;
            }
        }
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
        if (this.NetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkName\n" ;
            } else {
                s += ind + "networkName\n" ;
            }
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? RegionId
        // GraphQL -> regionId: String! (scalar)
        if (this.RegionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regionId\n" ;
            } else {
                s += ind + "regionId\n" ;
            }
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        //      C# -> ElasticStorageConfig? StorageConfig
        // GraphQL -> storageConfig: ElasticStorageConfig (type)
        if (this.StorageConfig != null) {
            var fspec = this.StorageConfig.AsFieldSpec(conf.Child("storageConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "storageConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        if (ec.Includes("vendor",true))
        {
            if(this.Vendor == null) {

                this.Vendor = new CcpVendorType();

            } else {


            }
        }
        else if (this.Vendor != null && ec.Excludes("vendor",true))
        {
            this.Vendor = null;
        }
        //      C# -> System.String? CloudAccount
        // GraphQL -> cloudAccount: String! (scalar)
        if (ec.Includes("cloudAccount",true))
        {
            if(this.CloudAccount == null) {

                this.CloudAccount = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccount != null && ec.Excludes("cloudAccount",true))
        {
            this.CloudAccount = null;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        if (ec.Includes("cloudAccountId",true))
        {
            if(this.CloudAccountId == null) {

                this.CloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccountId != null && ec.Excludes("cloudAccountId",true))
        {
            this.CloudAccountId = null;
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
        //      C# -> System.String? NativeCloudAccountId
        // GraphQL -> nativeCloudAccountId: String! (scalar)
        if (ec.Includes("nativeCloudAccountId",true))
        {
            if(this.NativeCloudAccountId == null) {

                this.NativeCloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.NativeCloudAccountId != null && ec.Excludes("nativeCloudAccountId",true))
        {
            this.NativeCloudAccountId = null;
        }
        //      C# -> System.String? NativeCloudAccountName
        // GraphQL -> nativeCloudAccountName: String! (scalar)
        if (ec.Includes("nativeCloudAccountName",true))
        {
            if(this.NativeCloudAccountName == null) {

                this.NativeCloudAccountName = "FETCH";

            } else {


            }
        }
        else if (this.NativeCloudAccountName != null && ec.Excludes("nativeCloudAccountName",true))
        {
            this.NativeCloudAccountName = null;
        }
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String! (scalar)
        if (ec.Includes("networkName",true))
        {
            if(this.NetworkName == null) {

                this.NetworkName = "FETCH";

            } else {


            }
        }
        else if (this.NetworkName != null && ec.Excludes("networkName",true))
        {
            this.NetworkName = null;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = "FETCH";

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? RegionId
        // GraphQL -> regionId: String! (scalar)
        if (ec.Includes("regionId",true))
        {
            if(this.RegionId == null) {

                this.RegionId = "FETCH";

            } else {


            }
        }
        else if (this.RegionId != null && ec.Excludes("regionId",true))
        {
            this.RegionId = null;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
        //      C# -> ElasticStorageConfig? StorageConfig
        // GraphQL -> storageConfig: ElasticStorageConfig (type)
        if (ec.Includes("storageConfig",false))
        {
            if(this.StorageConfig == null) {

                this.StorageConfig = new ElasticStorageConfig();
                this.StorageConfig.ApplyExploratoryFieldSpec(ec.NewChild("storageConfig"));

            } else {

                this.StorageConfig.ApplyExploratoryFieldSpec(ec.NewChild("storageConfig"));

            }
        }
        else if (this.StorageConfig != null && ec.Excludes("storageConfig",false))
        {
            this.StorageConfig = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CcWithCloudInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CcWithCloudInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CcWithCloudInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types