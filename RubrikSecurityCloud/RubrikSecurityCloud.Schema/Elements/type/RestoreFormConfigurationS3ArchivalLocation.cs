// RestoreFormConfigurationS3ArchivalLocation.cs
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
    #region RestoreFormConfigurationS3ArchivalLocation
    public class RestoreFormConfigurationS3ArchivalLocation: BaseType
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

    public override string GetGqlTypeName() {
        return "RestoreFormConfigurationS3ArchivalLocation";
    }

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
        //      C# -> System.String? CloudRehydrationSpeed
        // GraphQL -> cloudRehydrationSpeed: String (scalar)
        if (this.CloudRehydrationSpeed != null) {
            s += ind + "cloudRehydrationSpeed\n" ;
        }
        //      C# -> System.String? DefaultRegion
        // GraphQL -> defaultRegion: String (scalar)
        if (this.DefaultRegion != null) {
            s += ind + "defaultRegion\n" ;
        }
        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        if (this.EncryptionType != null) {
            s += ind + "encryptionType\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String (scalar)
        if (this.StorageClass != null) {
            s += ind + "storageClass\n" ;
        }
        //      C# -> RestoreFormArchivalProxyConfig? ArchivalProxyConfig
        // GraphQL -> archivalProxyConfig: RestoreFormArchivalProxyConfig (type)
        if (this.ArchivalProxyConfig != null) {
            var fspec = this.ArchivalProxyConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalProxyConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RestoreFormComputeProxyConfig? ComputeProxyConfig
        // GraphQL -> computeProxyConfig: RestoreFormComputeProxyConfig (type)
        if (this.ComputeProxyConfig != null) {
            var fspec = this.ComputeProxyConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "computeProxyConfig {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> System.String? CloudRehydrationSpeed
        // GraphQL -> cloudRehydrationSpeed: String (scalar)
        if (this.CloudRehydrationSpeed == null && ec.Includes("cloudRehydrationSpeed",true))
        {
            this.CloudRehydrationSpeed = "FETCH";
        }
        //      C# -> System.String? DefaultRegion
        // GraphQL -> defaultRegion: String (scalar)
        if (this.DefaultRegion == null && ec.Includes("defaultRegion",true))
        {
            this.DefaultRegion = "FETCH";
        }
        //      C# -> System.String? EncryptionType
        // GraphQL -> encryptionType: String (scalar)
        if (this.EncryptionType == null && ec.Includes("encryptionType",true))
        {
            this.EncryptionType = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String (scalar)
        if (this.StorageClass == null && ec.Includes("storageClass",true))
        {
            this.StorageClass = "FETCH";
        }
        //      C# -> RestoreFormArchivalProxyConfig? ArchivalProxyConfig
        // GraphQL -> archivalProxyConfig: RestoreFormArchivalProxyConfig (type)
        if (this.ArchivalProxyConfig == null && ec.Includes("archivalProxyConfig",false))
        {
            this.ArchivalProxyConfig = new RestoreFormArchivalProxyConfig();
            this.ArchivalProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("archivalProxyConfig"));
        }
        //      C# -> RestoreFormComputeProxyConfig? ComputeProxyConfig
        // GraphQL -> computeProxyConfig: RestoreFormComputeProxyConfig (type)
        if (this.ComputeProxyConfig == null && ec.Includes("computeProxyConfig",false))
        {
            this.ComputeProxyConfig = new RestoreFormComputeProxyConfig();
            this.ComputeProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("computeProxyConfig"));
        }
    }


    #endregion

    } // class RestoreFormConfigurationS3ArchivalLocation
    
    #endregion

    public static class ListRestoreFormConfigurationS3ArchivalLocationExtensions
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
            this List<RestoreFormConfigurationS3ArchivalLocation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurationS3ArchivalLocation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurationS3ArchivalLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RestoreFormConfigurationS3ArchivalLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types