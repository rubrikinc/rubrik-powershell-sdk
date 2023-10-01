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

    public override string GetGqlTypeName() {
        return "MosaicStoreObject";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MosaicStoreObjectStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
        if (this.StoreType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storeType\n" ;
            } else {
                s += ind + "storeType\n" ;
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
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (this.StoreName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storeName\n" ;
            } else {
                s += ind + "storeName\n" ;
            }
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (this.StoreUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storeUrl\n" ;
            } else {
                s += ind + "storeUrl\n" ;
            }
        }
        //      C# -> System.String? SurlNfs
        // GraphQL -> surlNfs: String (scalar)
        if (this.SurlNfs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "surlNfs\n" ;
            } else {
                s += ind + "surlNfs\n" ;
            }
        }
        //      C# -> StoreMetadata? StoreMetadata
        // GraphQL -> storeMetadata: StoreMetadata (type)
        if (this.StoreMetadata != null) {
            var fspec = this.StoreMetadata.AsFieldSpec(conf.Child("storeMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "storeMetadata {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MosaicStoreObjectStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreObjectStoreType! (enum)
        if (ec.Includes("storeType",true))
        {
            if(this.StoreType == null) {

                this.StoreType = new MosaicStoreObjectStoreType();

            } else {


            }
        }
        else if (this.StoreType != null && ec.Excludes("storeType",true))
        {
            this.StoreType = null;
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
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (ec.Includes("storeName",true))
        {
            if(this.StoreName == null) {

                this.StoreName = "FETCH";

            } else {


            }
        }
        else if (this.StoreName != null && ec.Excludes("storeName",true))
        {
            this.StoreName = null;
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (ec.Includes("storeUrl",true))
        {
            if(this.StoreUrl == null) {

                this.StoreUrl = "FETCH";

            } else {


            }
        }
        else if (this.StoreUrl != null && ec.Excludes("storeUrl",true))
        {
            this.StoreUrl = null;
        }
        //      C# -> System.String? SurlNfs
        // GraphQL -> surlNfs: String (scalar)
        if (ec.Includes("surlNfs",true))
        {
            if(this.SurlNfs == null) {

                this.SurlNfs = "FETCH";

            } else {


            }
        }
        else if (this.SurlNfs != null && ec.Excludes("surlNfs",true))
        {
            this.SurlNfs = null;
        }
        //      C# -> StoreMetadata? StoreMetadata
        // GraphQL -> storeMetadata: StoreMetadata (type)
        if (ec.Includes("storeMetadata",false))
        {
            if(this.StoreMetadata == null) {

                this.StoreMetadata = new StoreMetadata();
                this.StoreMetadata.ApplyExploratoryFieldSpec(ec.NewChild("storeMetadata"));

            } else {

                this.StoreMetadata.ApplyExploratoryFieldSpec(ec.NewChild("storeMetadata"));

            }
        }
        else if (this.StoreMetadata != null && ec.Excludes("storeMetadata",false))
        {
            this.StoreMetadata = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MosaicStoreObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MosaicStoreObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicStoreObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicStoreObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types