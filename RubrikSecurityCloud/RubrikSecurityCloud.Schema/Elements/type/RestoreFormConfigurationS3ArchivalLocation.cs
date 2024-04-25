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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> System.String? CloudRehydrationSpeed
        // GraphQL -> cloudRehydrationSpeed: String (scalar)
        if (this.CloudRehydrationSpeed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudRehydrationSpeed\n" ;
            } else {
                s += ind + "cloudRehydrationSpeed\n" ;
            }
        }
        //      C# -> System.String? DefaultRegion
        // GraphQL -> defaultRegion: String (scalar)
        if (this.DefaultRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultRegion\n" ;
            } else {
                s += ind + "defaultRegion\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String (scalar)
        if (this.StorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageClass\n" ;
            } else {
                s += ind + "storageClass\n" ;
            }
        }
        //      C# -> RestoreFormArchivalProxyConfig? ArchivalProxyConfig
        // GraphQL -> archivalProxyConfig: RestoreFormArchivalProxyConfig (type)
        if (this.ArchivalProxyConfig != null) {
            var fspec = this.ArchivalProxyConfig.AsFieldSpec(conf.Child("archivalProxyConfig"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalProxyConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RestoreFormComputeProxyConfig? ComputeProxyConfig
        // GraphQL -> computeProxyConfig: RestoreFormComputeProxyConfig (type)
        if (this.ComputeProxyConfig != null) {
            var fspec = this.ComputeProxyConfig.AsFieldSpec(conf.Child("computeProxyConfig"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "computeProxyConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> System.String? CloudRehydrationSpeed
        // GraphQL -> cloudRehydrationSpeed: String (scalar)
        if (ec.Includes("cloudRehydrationSpeed",true))
        {
            if(this.CloudRehydrationSpeed == null) {

                this.CloudRehydrationSpeed = "FETCH";

            } else {


            }
        }
        else if (this.CloudRehydrationSpeed != null && ec.Excludes("cloudRehydrationSpeed",true))
        {
            this.CloudRehydrationSpeed = null;
        }
        //      C# -> System.String? DefaultRegion
        // GraphQL -> defaultRegion: String (scalar)
        if (ec.Includes("defaultRegion",true))
        {
            if(this.DefaultRegion == null) {

                this.DefaultRegion = "FETCH";

            } else {


            }
        }
        else if (this.DefaultRegion != null && ec.Excludes("defaultRegion",true))
        {
            this.DefaultRegion = null;
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
        //      C# -> System.String? StorageClass
        // GraphQL -> storageClass: String (scalar)
        if (ec.Includes("storageClass",true))
        {
            if(this.StorageClass == null) {

                this.StorageClass = "FETCH";

            } else {


            }
        }
        else if (this.StorageClass != null && ec.Excludes("storageClass",true))
        {
            this.StorageClass = null;
        }
        //      C# -> RestoreFormArchivalProxyConfig? ArchivalProxyConfig
        // GraphQL -> archivalProxyConfig: RestoreFormArchivalProxyConfig (type)
        if (ec.Includes("archivalProxyConfig",false))
        {
            if(this.ArchivalProxyConfig == null) {

                this.ArchivalProxyConfig = new RestoreFormArchivalProxyConfig();
                this.ArchivalProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("archivalProxyConfig"));

            } else {

                this.ArchivalProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("archivalProxyConfig"));

            }
        }
        else if (this.ArchivalProxyConfig != null && ec.Excludes("archivalProxyConfig",false))
        {
            this.ArchivalProxyConfig = null;
        }
        //      C# -> RestoreFormComputeProxyConfig? ComputeProxyConfig
        // GraphQL -> computeProxyConfig: RestoreFormComputeProxyConfig (type)
        if (ec.Includes("computeProxyConfig",false))
        {
            if(this.ComputeProxyConfig == null) {

                this.ComputeProxyConfig = new RestoreFormComputeProxyConfig();
                this.ComputeProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("computeProxyConfig"));

            } else {

                this.ComputeProxyConfig.ApplyExploratoryFieldSpec(ec.NewChild("computeProxyConfig"));

            }
        }
        else if (this.ComputeProxyConfig != null && ec.Excludes("computeProxyConfig",false))
        {
            this.ComputeProxyConfig = null;
        }
    }


    #endregion

    } // class RestoreFormConfigurationS3ArchivalLocation
    
    #endregion

    public static class ListRestoreFormConfigurationS3ArchivalLocationExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RestoreFormConfigurationS3ArchivalLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RestoreFormConfigurationS3ArchivalLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<RestoreFormConfigurationS3ArchivalLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types