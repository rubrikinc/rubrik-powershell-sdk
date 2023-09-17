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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String (scalar)
        if (this.Bucket != null) {
            s += ind + "bucket\n" ;
        }
        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        if (this.EncryptionType != null) {
            s += ind + "encryptionType\n" ;
        }
        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: String (scalar)
        if (this.Endpoint != null) {
            s += ind + "endpoint\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int64? NumBuckets
        // GraphQL -> numBuckets: Long (scalar)
        if (this.NumBuckets != null) {
            s += ind + "numBuckets\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String (scalar)
        if (this.Bucket == null && ec.Includes("bucket",true))
        {
            this.Bucket = "FETCH";
        }
        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        if (this.EncryptionType == null && ec.Includes("encryptionType",true))
        {
            this.EncryptionType = "FETCH";
        }
        //      C# -> System.String? Endpoint
        // GraphQL -> endpoint: String (scalar)
        if (this.Endpoint == null && ec.Includes("endpoint",true))
        {
            this.Endpoint = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int64? NumBuckets
        // GraphQL -> numBuckets: Long (scalar)
        if (this.NumBuckets == null && ec.Includes("numBuckets",true))
        {
            this.NumBuckets = new System.Int64();
        }
    }


    #endregion

    } // class RestoreFormConfigurationObjectStoreArchivalLocation
    
    #endregion

    public static class ListRestoreFormConfigurationObjectStoreArchivalLocationExtensions
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
            this List<RestoreFormConfigurationObjectStoreArchivalLocation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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