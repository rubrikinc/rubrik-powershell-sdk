// RestoreFormConfigurationS3ArchivalLocation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:18.
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
    #region RestoreFormConfigurationS3ArchivalLocation
    public class RestoreFormConfigurationS3ArchivalLocation: IFragment
    {
        #region members
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String (scalar)
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> System.String? CloudRehydrationSpeed
        // GraphQL -> cloudRehydrationSpeed: String (scalar)
        [JsonProperty("cloudRehydrationSpeed")]
        public System.String? CloudRehydrationSpeed { get; set; }

        //      C# -> System.String? DefaultRegion
        // GraphQL -> defaultRegion: String (scalar)
        [JsonProperty("defaultRegion")]
        public System.String? DefaultRegion { get; set; }

        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        [JsonProperty("encryptionType")]
        public System.String? EncryptionType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String (scalar)
        [JsonProperty("storageClass")]
        public System.String? StorageClass { get; set; }

        //      C# -> RestoreFormArchivalProxyConfig? ArchivalProxyConfig
        // GraphQL -> archivalProxyConfig: RestoreFormArchivalProxyConfig (type)
        [JsonProperty("archivalProxyConfig")]
        public RestoreFormArchivalProxyConfig? ArchivalProxyConfig { get; set; }

        //      C# -> RestoreFormComputeProxyConfig? ComputeProxyConfig
        // GraphQL -> computeProxyConfig: RestoreFormComputeProxyConfig (type)
        [JsonProperty("computeProxyConfig")]
        public RestoreFormComputeProxyConfig? ComputeProxyConfig { get; set; }

        #endregion

    #region methods

    public RestoreFormConfigurationS3ArchivalLocation Set(
        System.String? Bucket = null,
        System.String? CloudRehydrationSpeed = null,
        System.String? DefaultRegion = null,
        System.String? EncryptionType = null,
        System.String? Name = null,
        System.String? StorageClass = null,
        RestoreFormArchivalProxyConfig? ArchivalProxyConfig = null,
        RestoreFormComputeProxyConfig? ComputeProxyConfig = null
    ) 
    {
        if ( Bucket != null ) {
            this.Bucket = Bucket;
        }
        if ( CloudRehydrationSpeed != null ) {
            this.CloudRehydrationSpeed = CloudRehydrationSpeed;
        }
        if ( DefaultRegion != null ) {
            this.DefaultRegion = DefaultRegion;
        }
        if ( EncryptionType != null ) {
            this.EncryptionType = EncryptionType;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( StorageClass != null ) {
            this.StorageClass = StorageClass;
        }
        if ( ArchivalProxyConfig != null ) {
            this.ArchivalProxyConfig = ArchivalProxyConfig;
        }
        if ( ComputeProxyConfig != null ) {
            this.ComputeProxyConfig = ComputeProxyConfig;
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
            //      C# -> System.String? Bucket
            // GraphQL -> bucket: String (scalar)
            if (this.Bucket != null)
            {
                 s += ind + "bucket\n";

            }
            //      C# -> System.String? CloudRehydrationSpeed
            // GraphQL -> cloudRehydrationSpeed: String (scalar)
            if (this.CloudRehydrationSpeed != null)
            {
                 s += ind + "cloudRehydrationSpeed\n";

            }
            //      C# -> System.String? DefaultRegion
            // GraphQL -> defaultRegion: String (scalar)
            if (this.DefaultRegion != null)
            {
                 s += ind + "defaultRegion\n";

            }
            //      C# -> System.String? EncryptionType
            // GraphQL -> encryptionType: String (scalar)
            if (this.EncryptionType != null)
            {
                 s += ind + "encryptionType\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? StorageClass
            // GraphQL -> storageClass: String (scalar)
            if (this.StorageClass != null)
            {
                 s += ind + "storageClass\n";

            }
            //      C# -> RestoreFormArchivalProxyConfig? ArchivalProxyConfig
            // GraphQL -> archivalProxyConfig: RestoreFormArchivalProxyConfig (type)
            if (this.ArchivalProxyConfig != null)
            {
                 s += ind + "archivalProxyConfig\n";

                 s += ind + "{\n" + 
                 this.ArchivalProxyConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RestoreFormComputeProxyConfig? ComputeProxyConfig
            // GraphQL -> computeProxyConfig: RestoreFormComputeProxyConfig (type)
            if (this.ComputeProxyConfig != null)
            {
                 s += ind + "computeProxyConfig\n";

                 s += ind + "{\n" + 
                 this.ComputeProxyConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Bucket
            // GraphQL -> bucket: String (scalar)
            if (this.Bucket == null && Exploration.Includes(parent + ".bucket$"))
            {
                this.Bucket = new System.String("FETCH");
            }
            //      C# -> System.String? CloudRehydrationSpeed
            // GraphQL -> cloudRehydrationSpeed: String (scalar)
            if (this.CloudRehydrationSpeed == null && Exploration.Includes(parent + ".cloudRehydrationSpeed$"))
            {
                this.CloudRehydrationSpeed = new System.String("FETCH");
            }
            //      C# -> System.String? DefaultRegion
            // GraphQL -> defaultRegion: String (scalar)
            if (this.DefaultRegion == null && Exploration.Includes(parent + ".defaultRegion$"))
            {
                this.DefaultRegion = new System.String("FETCH");
            }
            //      C# -> System.String? EncryptionType
            // GraphQL -> encryptionType: String (scalar)
            if (this.EncryptionType == null && Exploration.Includes(parent + ".encryptionType$"))
            {
                this.EncryptionType = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? StorageClass
            // GraphQL -> storageClass: String (scalar)
            if (this.StorageClass == null && Exploration.Includes(parent + ".storageClass$"))
            {
                this.StorageClass = new System.String("FETCH");
            }
            //      C# -> RestoreFormArchivalProxyConfig? ArchivalProxyConfig
            // GraphQL -> archivalProxyConfig: RestoreFormArchivalProxyConfig (type)
            if (this.ArchivalProxyConfig == null && Exploration.Includes(parent + ".archivalProxyConfig"))
            {
                this.ArchivalProxyConfig = new RestoreFormArchivalProxyConfig();
                this.ArchivalProxyConfig.ApplyExploratoryFragment(parent + ".archivalProxyConfig");
            }
            //      C# -> RestoreFormComputeProxyConfig? ComputeProxyConfig
            // GraphQL -> computeProxyConfig: RestoreFormComputeProxyConfig (type)
            if (this.ComputeProxyConfig == null && Exploration.Includes(parent + ".computeProxyConfig"))
            {
                this.ComputeProxyConfig = new RestoreFormComputeProxyConfig();
                this.ComputeProxyConfig.ApplyExploratoryFragment(parent + ".computeProxyConfig");
            }
        }


    #endregion

    } // class RestoreFormConfigurationS3ArchivalLocation
    #endregion

    public static class ListRestoreFormConfigurationS3ArchivalLocationExtensions
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
            this List<RestoreFormConfigurationS3ArchivalLocation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RestoreFormConfigurationS3ArchivalLocation> list, 
            String parent = "")
        {
            var item = new RestoreFormConfigurationS3ArchivalLocation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types