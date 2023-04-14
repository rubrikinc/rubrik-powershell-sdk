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

namespace Rubrik.SecurityCloud.Types
{
    #region CcWithCloudInfo
    public class CcWithCloudInfo: IFragment
    {
        #region members
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

        //      C# -> CcpVendorType? Vendor
        // GraphQL -> vendor: CcpVendorType! (enum)
        [JsonProperty("vendor")]
        public CcpVendorType? Vendor { get; set; }

        #endregion

    #region methods

    public CcWithCloudInfo Set(
        System.String? CloudAccount = null,
        System.String? CloudAccountId = null,
        System.String? Name = null,
        System.String? NativeCloudAccountId = null,
        System.String? NativeCloudAccountName = null,
        System.String? NetworkName = null,
        System.String? Region = null,
        System.String? RegionId = null,
        System.String? Uuid = null,
        ElasticStorageConfig? StorageConfig = null,
        CcpVendorType? Vendor = null
    ) 
    {
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
        if ( Vendor != null ) {
            this.Vendor = Vendor;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CloudAccount
            // GraphQL -> cloudAccount: String! (scalar)
            if (this.CloudAccount != null)
            {
                 s += ind + "cloudAccount\n";

            }
            //      C# -> System.String? CloudAccountId
            // GraphQL -> cloudAccountId: UUID! (scalar)
            if (this.CloudAccountId != null)
            {
                 s += ind + "cloudAccountId\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NativeCloudAccountId
            // GraphQL -> nativeCloudAccountId: String! (scalar)
            if (this.NativeCloudAccountId != null)
            {
                 s += ind + "nativeCloudAccountId\n";

            }
            //      C# -> System.String? NativeCloudAccountName
            // GraphQL -> nativeCloudAccountName: String! (scalar)
            if (this.NativeCloudAccountName != null)
            {
                 s += ind + "nativeCloudAccountName\n";

            }
            //      C# -> System.String? NetworkName
            // GraphQL -> networkName: String! (scalar)
            if (this.NetworkName != null)
            {
                 s += ind + "networkName\n";

            }
            //      C# -> System.String? Region
            // GraphQL -> region: String! (scalar)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
            //      C# -> System.String? RegionId
            // GraphQL -> regionId: String! (scalar)
            if (this.RegionId != null)
            {
                 s += ind + "regionId\n";

            }
            //      C# -> System.String? Uuid
            // GraphQL -> uuid: UUID! (scalar)
            if (this.Uuid != null)
            {
                 s += ind + "uuid\n";

            }
            //      C# -> ElasticStorageConfig? StorageConfig
            // GraphQL -> storageConfig: ElasticStorageConfig (type)
            if (this.StorageConfig != null)
            {
                 s += ind + "storageConfig\n";

                 s += ind + "{\n" + 
                 this.StorageConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CcpVendorType? Vendor
            // GraphQL -> vendor: CcpVendorType! (enum)
            if (this.Vendor != null)
            {
                 s += ind + "vendor\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CloudAccount
            // GraphQL -> cloudAccount: String! (scalar)
            if (this.CloudAccount == null && Exploration.Includes(parent + ".cloudAccount$"))
            {
                this.CloudAccount = new System.String("FETCH");
            }
            //      C# -> System.String? CloudAccountId
            // GraphQL -> cloudAccountId: UUID! (scalar)
            if (this.CloudAccountId == null && Exploration.Includes(parent + ".cloudAccountId$"))
            {
                this.CloudAccountId = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NativeCloudAccountId
            // GraphQL -> nativeCloudAccountId: String! (scalar)
            if (this.NativeCloudAccountId == null && Exploration.Includes(parent + ".nativeCloudAccountId$"))
            {
                this.NativeCloudAccountId = new System.String("FETCH");
            }
            //      C# -> System.String? NativeCloudAccountName
            // GraphQL -> nativeCloudAccountName: String! (scalar)
            if (this.NativeCloudAccountName == null && Exploration.Includes(parent + ".nativeCloudAccountName$"))
            {
                this.NativeCloudAccountName = new System.String("FETCH");
            }
            //      C# -> System.String? NetworkName
            // GraphQL -> networkName: String! (scalar)
            if (this.NetworkName == null && Exploration.Includes(parent + ".networkName$"))
            {
                this.NetworkName = new System.String("FETCH");
            }
            //      C# -> System.String? Region
            // GraphQL -> region: String! (scalar)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new System.String("FETCH");
            }
            //      C# -> System.String? RegionId
            // GraphQL -> regionId: String! (scalar)
            if (this.RegionId == null && Exploration.Includes(parent + ".regionId$"))
            {
                this.RegionId = new System.String("FETCH");
            }
            //      C# -> System.String? Uuid
            // GraphQL -> uuid: UUID! (scalar)
            if (this.Uuid == null && Exploration.Includes(parent + ".uuid$"))
            {
                this.Uuid = new System.String("FETCH");
            }
            //      C# -> ElasticStorageConfig? StorageConfig
            // GraphQL -> storageConfig: ElasticStorageConfig (type)
            if (this.StorageConfig == null && Exploration.Includes(parent + ".storageConfig"))
            {
                this.StorageConfig = new ElasticStorageConfig();
                this.StorageConfig.ApplyExploratoryFragment(parent + ".storageConfig");
            }
            //      C# -> CcpVendorType? Vendor
            // GraphQL -> vendor: CcpVendorType! (enum)
            if (this.Vendor == null && Exploration.Includes(parent + ".vendor$"))
            {
                this.Vendor = new CcpVendorType();
            }
        }


    #endregion

    } // class CcWithCloudInfo
    #endregion

    public static class ListCcWithCloudInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CcWithCloudInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CcWithCloudInfo> list, 
            String parent = "")
        {
            var item = new CcWithCloudInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types