// StoreMetadata.cs
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
    #region StoreMetadata
    public class StoreMetadata: IFragment
    {
        #region members
        //      C# -> System.String? S3Bucket
        // GraphQL -> s3Bucket: String (scalar)
        [JsonProperty("s3Bucket")]
        public System.String? S3Bucket { get; set; }

        //      C# -> System.String? S3Region
        // GraphQL -> s3Region: String (scalar)
        [JsonProperty("s3Region")]
        public System.String? S3Region { get; set; }

        #endregion

    #region methods

    public StoreMetadata Set(
        System.String? S3Bucket = null,
        System.String? S3Region = null
    ) 
    {
        if ( S3Bucket != null ) {
            this.S3Bucket = S3Bucket;
        }
        if ( S3Region != null ) {
            this.S3Region = S3Region;
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
            //      C# -> System.String? S3Bucket
            // GraphQL -> s3Bucket: String (scalar)
            if (this.S3Bucket != null)
            {
                 s += ind + "s3Bucket\n";

            }
            //      C# -> System.String? S3Region
            // GraphQL -> s3Region: String (scalar)
            if (this.S3Region != null)
            {
                 s += ind + "s3Region\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? S3Bucket
            // GraphQL -> s3Bucket: String (scalar)
            if (this.S3Bucket == null && Exploration.Includes(parent + ".s3Bucket$"))
            {
                this.S3Bucket = new System.String("FETCH");
            }
            //      C# -> System.String? S3Region
            // GraphQL -> s3Region: String (scalar)
            if (this.S3Region == null && Exploration.Includes(parent + ".s3Region$"))
            {
                this.S3Region = new System.String("FETCH");
            }
        }


    #endregion

    } // class StoreMetadata
    #endregion

    public static class ListStoreMetadataExtensions
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
            this List<StoreMetadata> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<StoreMetadata> list, 
            String parent = "")
        {
            var item = new StoreMetadata();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types