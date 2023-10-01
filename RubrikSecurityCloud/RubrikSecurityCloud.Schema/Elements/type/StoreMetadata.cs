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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region StoreMetadata
    public class StoreMetadata: BaseType
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

    public override string GetGqlTypeName() {
        return "StoreMetadata";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? S3Bucket
        // GraphQL -> s3Bucket: String (scalar)
        if (this.S3Bucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "s3Bucket\n" ;
            } else {
                s += ind + "s3Bucket\n" ;
            }
        }
        //      C# -> System.String? S3Region
        // GraphQL -> s3Region: String (scalar)
        if (this.S3Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "s3Region\n" ;
            } else {
                s += ind + "s3Region\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? S3Bucket
        // GraphQL -> s3Bucket: String (scalar)
        if (ec.Includes("s3Bucket",true))
        {
            if(this.S3Bucket == null) {

                this.S3Bucket = "FETCH";

            } else {


            }
        }
        else if (this.S3Bucket != null && ec.Excludes("s3Bucket",true))
        {
            this.S3Bucket = null;
        }
        //      C# -> System.String? S3Region
        // GraphQL -> s3Region: String (scalar)
        if (ec.Includes("s3Region",true))
        {
            if(this.S3Region == null) {

                this.S3Region = "FETCH";

            } else {


            }
        }
        else if (this.S3Region != null && ec.Excludes("s3Region",true))
        {
            this.S3Region = null;
        }
    }


    #endregion

    } // class StoreMetadata
    
    #endregion

    public static class ListStoreMetadataExtensions
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
            this List<StoreMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<StoreMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StoreMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StoreMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StoreMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types