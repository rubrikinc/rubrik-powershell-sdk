// MosaicStoreObject.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:18.
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
    #region MosaicStoreObject
    public class MosaicStoreObject: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        [JsonProperty("storeName")]
        public System.String? StoreName { get; set; }

        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        [JsonProperty("storeUrl")]
        public System.String? StoreUrl { get; set; }

        //      C# -> System.String? SurlNfs
        // GraphQL -> surlNfs: String (scalar)
        [JsonProperty("surlNfs")]
        public System.String? SurlNfs { get; set; }

        //      C# -> StoreMetadata? StoreMetadata
        // GraphQL -> storeMetadata: StoreMetadata (type)
        [JsonProperty("storeMetadata")]
        public StoreMetadata? StoreMetadata { get; set; }

        //      C# -> MosaicStoreObjectStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
        [JsonProperty("storeType")]
        public MosaicStoreObjectStoreType? StoreType { get; set; }

        #endregion

    #region methods

    public MosaicStoreObject Set(
        System.String? Id = null,
        System.String? StoreName = null,
        System.String? StoreUrl = null,
        System.String? SurlNfs = null,
        StoreMetadata? StoreMetadata = null,
        MosaicStoreObjectStoreType? StoreType = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( StoreName != null ) {
            this.StoreName = StoreName;
        }
        if ( StoreUrl != null ) {
            this.StoreUrl = StoreUrl;
        }
        if ( SurlNfs != null ) {
            this.SurlNfs = SurlNfs;
        }
        if ( StoreMetadata != null ) {
            this.StoreMetadata = StoreMetadata;
        }
        if ( StoreType != null ) {
            this.StoreType = StoreType;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? StoreName
            // GraphQL -> storeName: String! (scalar)
            if (this.StoreName != null)
            {
                 s += ind + "storeName\n";

            }
            //      C# -> System.String? StoreUrl
            // GraphQL -> storeUrl: String! (scalar)
            if (this.StoreUrl != null)
            {
                 s += ind + "storeUrl\n";

            }
            //      C# -> System.String? SurlNfs
            // GraphQL -> surlNfs: String (scalar)
            if (this.SurlNfs != null)
            {
                 s += ind + "surlNfs\n";

            }
            //      C# -> StoreMetadata? StoreMetadata
            // GraphQL -> storeMetadata: StoreMetadata (type)
            if (this.StoreMetadata != null)
            {
                 s += ind + "storeMetadata\n";

                 s += ind + "{\n" + 
                 this.StoreMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MosaicStoreObjectStoreType? StoreType
            // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
            if (this.StoreType != null)
            {
                 s += ind + "storeType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? StoreName
            // GraphQL -> storeName: String! (scalar)
            if (this.StoreName == null && Exploration.Includes(parent + ".storeName$"))
            {
                this.StoreName = new System.String("FETCH");
            }
            //      C# -> System.String? StoreUrl
            // GraphQL -> storeUrl: String! (scalar)
            if (this.StoreUrl == null && Exploration.Includes(parent + ".storeUrl$"))
            {
                this.StoreUrl = new System.String("FETCH");
            }
            //      C# -> System.String? SurlNfs
            // GraphQL -> surlNfs: String (scalar)
            if (this.SurlNfs == null && Exploration.Includes(parent + ".surlNfs$"))
            {
                this.SurlNfs = new System.String("FETCH");
            }
            //      C# -> StoreMetadata? StoreMetadata
            // GraphQL -> storeMetadata: StoreMetadata (type)
            if (this.StoreMetadata == null && Exploration.Includes(parent + ".storeMetadata"))
            {
                this.StoreMetadata = new StoreMetadata();
                this.StoreMetadata.ApplyExploratoryFragment(parent + ".storeMetadata");
            }
            //      C# -> MosaicStoreObjectStoreType? StoreType
            // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
            if (this.StoreType == null && Exploration.Includes(parent + ".storeType$"))
            {
                this.StoreType = new MosaicStoreObjectStoreType();
            }
        }


    #endregion

    } // class MosaicStoreObject
    #endregion

    public static class ListMosaicStoreObjectExtensions
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
            this List<MosaicStoreObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MosaicStoreObject> list, 
            String parent = "")
        {
            var item = new MosaicStoreObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types