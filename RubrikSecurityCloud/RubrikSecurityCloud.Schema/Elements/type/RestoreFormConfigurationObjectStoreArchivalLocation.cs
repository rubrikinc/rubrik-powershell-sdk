// RestoreFormConfigurationObjectStoreArchivalLocation.cs
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
    #region RestoreFormConfigurationObjectStoreArchivalLocation
    public class RestoreFormConfigurationObjectStoreArchivalLocation: IFragment
    {
        #region members
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String (scalar)
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        [JsonProperty("encryptionType")]
        public System.String? EncryptionType { get; set; }

        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: String (scalar)
        [JsonProperty("endpoint")]
        public System.String? Endpoint { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? NumBuckets
        // GraphQL -> numBuckets: Long (scalar)
        [JsonProperty("numBuckets")]
        public System.Int64? NumBuckets { get; set; }

        #endregion

    #region methods

    public RestoreFormConfigurationObjectStoreArchivalLocation Set(
        System.String? Bucket = null,
        System.String? EncryptionType = null,
        System.String? Endpoint = null,
        System.String? Name = null,
        System.Int64? NumBuckets = null
    ) 
    {
        if ( Bucket != null ) {
            this.Bucket = Bucket;
        }
        if ( EncryptionType != null ) {
            this.EncryptionType = EncryptionType;
        }
        if ( Endpoint != null ) {
            this.Endpoint = Endpoint;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumBuckets != null ) {
            this.NumBuckets = NumBuckets;
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
            //      C# -> System.String? EncryptionType
            // GraphQL -> encryptionType: String (scalar)
            if (this.EncryptionType != null)
            {
                 s += ind + "encryptionType\n";

            }
            //      C# -> System.String? Endpoint
            // GraphQL -> endpoint: String (scalar)
            if (this.Endpoint != null)
            {
                 s += ind + "endpoint\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int64? NumBuckets
            // GraphQL -> numBuckets: Long (scalar)
            if (this.NumBuckets != null)
            {
                 s += ind + "numBuckets\n";

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
            //      C# -> System.String? EncryptionType
            // GraphQL -> encryptionType: String (scalar)
            if (this.EncryptionType == null && Exploration.Includes(parent + ".encryptionType$"))
            {
                this.EncryptionType = new System.String("FETCH");
            }
            //      C# -> System.String? Endpoint
            // GraphQL -> endpoint: String (scalar)
            if (this.Endpoint == null && Exploration.Includes(parent + ".endpoint$"))
            {
                this.Endpoint = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int64? NumBuckets
            // GraphQL -> numBuckets: Long (scalar)
            if (this.NumBuckets == null && Exploration.Includes(parent + ".numBuckets$"))
            {
                this.NumBuckets = new System.Int64();
            }
        }


    #endregion

    } // class RestoreFormConfigurationObjectStoreArchivalLocation
    #endregion

    public static class ListRestoreFormConfigurationObjectStoreArchivalLocationExtensions
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
            this List<RestoreFormConfigurationObjectStoreArchivalLocation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RestoreFormConfigurationObjectStoreArchivalLocation> list, 
            String parent = "")
        {
            var item = new RestoreFormConfigurationObjectStoreArchivalLocation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types