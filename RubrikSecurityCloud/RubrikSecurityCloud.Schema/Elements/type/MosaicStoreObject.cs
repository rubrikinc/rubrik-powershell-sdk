// MosaicStoreObject.cs
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
    #region MosaicStoreObject
    public class MosaicStoreObject: BaseType
    {
        #region members

        //      C# -> MosaicStoreObjectStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
        [JsonProperty("storeType")]
        public MosaicStoreObjectStoreType? StoreType { get; set; }

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


        #endregion

    #region methods

    public MosaicStoreObject Set(
        MosaicStoreObjectStoreType? StoreType = null,
        System.String? Id = null,
        System.String? StoreName = null,
        System.String? StoreUrl = null,
        System.String? SurlNfs = null,
        StoreMetadata? StoreMetadata = null
    ) 
    {
        if ( StoreType != null ) {
            this.StoreType = StoreType;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> MosaicStoreObjectStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
        if (this.StoreType != null) {
            s += ind + "storeType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (this.StoreName != null) {
            s += ind + "storeName\n" ;
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (this.StoreUrl != null) {
            s += ind + "storeUrl\n" ;
        }
        //      C# -> System.String? SurlNfs
        // GraphQL -> surlNfs: String (scalar)
        if (this.SurlNfs != null) {
            s += ind + "surlNfs\n" ;
        }
        //      C# -> StoreMetadata? StoreMetadata
        // GraphQL -> storeMetadata: StoreMetadata (type)
        if (this.StoreMetadata != null) {
            var fspec = this.StoreMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "storeMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MosaicStoreObjectStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
        if (this.StoreType == null && Exploration.Includes(parent + ".storeType", true))
        {
            this.StoreType = new MosaicStoreObjectStoreType();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (this.StoreName == null && Exploration.Includes(parent + ".storeName", true))
        {
            this.StoreName = "FETCH";
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (this.StoreUrl == null && Exploration.Includes(parent + ".storeUrl", true))
        {
            this.StoreUrl = "FETCH";
        }
        //      C# -> System.String? SurlNfs
        // GraphQL -> surlNfs: String (scalar)
        if (this.SurlNfs == null && Exploration.Includes(parent + ".surlNfs", true))
        {
            this.SurlNfs = "FETCH";
        }
        //      C# -> StoreMetadata? StoreMetadata
        // GraphQL -> storeMetadata: StoreMetadata (type)
        if (this.StoreMetadata == null && Exploration.Includes(parent + ".storeMetadata"))
        {
            this.StoreMetadata = new StoreMetadata();
            this.StoreMetadata.ApplyExploratoryFieldSpec(parent + ".storeMetadata");
        }
    }


    #endregion

    } // class MosaicStoreObject
    
    #endregion

    public static class ListMosaicStoreObjectExtensions
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
            this List<MosaicStoreObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicStoreObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicStoreObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types