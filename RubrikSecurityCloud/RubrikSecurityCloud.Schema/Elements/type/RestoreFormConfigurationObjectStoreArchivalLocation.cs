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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region RestoreFormConfigurationObjectStoreArchivalLocation
    public class RestoreFormConfigurationObjectStoreArchivalLocation: BaseType
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

    public override string GetGqlTypeName() {
        return "RestoreFormConfigurationObjectStoreArchivalLocation";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String (scalar)
        if (this.Bucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucket\n" ;
            } else {
                s += ind + "bucket\n" ;
            }
        }
        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        if (this.EncryptionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionType\n" ;
            } else {
                s += ind + "encryptionType\n" ;
            }
        }
        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: String (scalar)
        if (this.Endpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endpoint\n" ;
            } else {
                s += ind + "endpoint\n" ;
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
        //      C# -> System.Int64? NumBuckets
        // GraphQL -> numBuckets: Long (scalar)
        if (this.NumBuckets != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numBuckets\n" ;
            } else {
                s += ind + "numBuckets\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String (scalar)
        if (ec.Includes("bucket",true))
        {
            if(this.Bucket == null) {

                this.Bucket = "FETCH";

            } else {


            }
        }
        else if (this.Bucket != null && ec.Excludes("bucket",true))
        {
            this.Bucket = null;
        }
        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        if (ec.Includes("encryptionType",true))
        {
            if(this.EncryptionType == null) {

                this.EncryptionType = "FETCH";

            } else {


            }
        }
        else if (this.EncryptionType != null && ec.Excludes("encryptionType",true))
        {
            this.EncryptionType = null;
        }
        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: String (scalar)
        if (ec.Includes("endpoint",true))
        {
            if(this.Endpoint == null) {

                this.Endpoint = "FETCH";

            } else {


            }
        }
        else if (this.Endpoint != null && ec.Excludes("endpoint",true))
        {
            this.Endpoint = null;
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
        //      C# -> System.Int64? NumBuckets
        // GraphQL -> numBuckets: Long (scalar)
        if (ec.Includes("numBuckets",true))
        {
            if(this.NumBuckets == null) {

                this.NumBuckets = new System.Int64();

            } else {


            }
        }
        else if (this.NumBuckets != null && ec.Excludes("numBuckets",true))
        {
            this.NumBuckets = null;
        }
    }


    #endregion

    } // class RestoreFormConfigurationObjectStoreArchivalLocation
    
    #endregion

    public static class ListRestoreFormConfigurationObjectStoreArchivalLocationExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RestoreFormConfigurationObjectStoreArchivalLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RestoreFormConfigurationObjectStoreArchivalLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurationObjectStoreArchivalLocation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurationObjectStoreArchivalLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RestoreFormConfigurationObjectStoreArchivalLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types