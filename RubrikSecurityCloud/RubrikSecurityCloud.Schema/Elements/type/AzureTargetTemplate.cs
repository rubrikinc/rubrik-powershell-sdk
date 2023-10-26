// AzureTargetTemplate.cs
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
    #region AzureTargetTemplate
 
    public class AzureTargetTemplate: BaseType, TargetTemplate
    {
        #region members

        //      C# -> InstanceTypeEnum? InstanceType
        // GraphQL -> instanceType: InstanceTypeEnum! (enum)
        [JsonProperty("instanceType")]
        public InstanceTypeEnum? InstanceType { get; set; }

        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        [JsonProperty("targetType")]
        public TargetType? TargetType { get; set; }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        [JsonProperty("cloudAccount")]
        public CloudAccount? CloudAccount { get; set; }

        //      C# -> System.String? ContainerNamePrefix
        // GraphQL -> containerNamePrefix: String! (scalar)
        [JsonProperty("containerNamePrefix")]
        public System.String? ContainerNamePrefix { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        [JsonProperty("storageAccountName")]
        public System.String? StorageAccountName { get; set; }

        //      C# -> AzureCloudNativeTargetCompanion? CloudNativeCompanion
        // GraphQL -> cloudNativeCompanion: AzureCloudNativeTargetCompanion (type)
        [JsonProperty("cloudNativeCompanion")]
        public AzureCloudNativeTargetCompanion? CloudNativeCompanion { get; set; }

        //      C# -> AzureComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AzureComputeSettings (type)
        [JsonProperty("computeSettings")]
        public AzureComputeSettings? ComputeSettings { get; set; }

        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        [JsonProperty("proxySettings")]
        public ProxySettings? ProxySettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureTargetTemplate";
    }

    public AzureTargetTemplate Set(
        InstanceTypeEnum? InstanceType = null,
        TargetType? TargetType = null,
        CloudAccount? CloudAccount = null,
        System.String? ContainerNamePrefix = null,
        System.Boolean? IsConsolidationEnabled = null,
        System.String? StorageAccountName = null,
        AzureCloudNativeTargetCompanion? CloudNativeCompanion = null,
        AzureComputeSettings? ComputeSettings = null,
        ProxySettings? ProxySettings = null
    ) 
    {
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( CloudAccount != null ) {
            this.CloudAccount = CloudAccount;
        }
        if ( ContainerNamePrefix != null ) {
            this.ContainerNamePrefix = ContainerNamePrefix;
        }
        if ( IsConsolidationEnabled != null ) {
            this.IsConsolidationEnabled = IsConsolidationEnabled;
        }
        if ( StorageAccountName != null ) {
            this.StorageAccountName = StorageAccountName;
        }
        if ( CloudNativeCompanion != null ) {
            this.CloudNativeCompanion = CloudNativeCompanion;
        }
        if ( ComputeSettings != null ) {
            this.ComputeSettings = ComputeSettings;
        }
        if ( ProxySettings != null ) {
            this.ProxySettings = ProxySettings;
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
        //      C# -> InstanceTypeEnum? InstanceType
        // GraphQL -> instanceType: InstanceTypeEnum! (enum)
        if (this.InstanceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceType\n" ;
            } else {
                s += ind + "instanceType\n" ;
            }
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CloudAccount).AsFieldSpec(conf.Child("cloudAccount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudAccount {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? ContainerNamePrefix
        // GraphQL -> containerNamePrefix: String! (scalar)
        if (this.ContainerNamePrefix != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containerNamePrefix\n" ;
            } else {
                s += ind + "containerNamePrefix\n" ;
            }
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConsolidationEnabled\n" ;
            } else {
                s += ind + "isConsolidationEnabled\n" ;
            }
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (this.StorageAccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageAccountName\n" ;
            } else {
                s += ind + "storageAccountName\n" ;
            }
        }
        //      C# -> AzureCloudNativeTargetCompanion? CloudNativeCompanion
        // GraphQL -> cloudNativeCompanion: AzureCloudNativeTargetCompanion (type)
        if (this.CloudNativeCompanion != null) {
            var fspec = this.CloudNativeCompanion.AsFieldSpec(conf.Child("cloudNativeCompanion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudNativeCompanion {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AzureComputeSettings (type)
        if (this.ComputeSettings != null) {
            var fspec = this.ComputeSettings.AsFieldSpec(conf.Child("computeSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "computeSettings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings != null) {
            var fspec = this.ProxySettings.AsFieldSpec(conf.Child("proxySettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "proxySettings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InstanceTypeEnum? InstanceType
        // GraphQL -> instanceType: InstanceTypeEnum! (enum)
        if (ec.Includes("instanceType",true))
        {
            if(this.InstanceType == null) {

                this.InstanceType = new InstanceTypeEnum();

            } else {


            }
        }
        else if (this.InstanceType != null && ec.Excludes("instanceType",true))
        {
            this.InstanceType = null;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new TargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (ec.Includes("cloudAccount",false))
        {
            if(this.CloudAccount == null) {

                var impls = new List<CloudAccount>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccount"));
                this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<CloudAccount>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccount"));
                this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.CloudAccount != null && ec.Excludes("cloudAccount",false))
        {
            this.CloudAccount = null;
        }
        //      C# -> System.String? ContainerNamePrefix
        // GraphQL -> containerNamePrefix: String! (scalar)
        if (ec.Includes("containerNamePrefix",true))
        {
            if(this.ContainerNamePrefix == null) {

                this.ContainerNamePrefix = "FETCH";

            } else {


            }
        }
        else if (this.ContainerNamePrefix != null && ec.Excludes("containerNamePrefix",true))
        {
            this.ContainerNamePrefix = null;
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (ec.Includes("isConsolidationEnabled",true))
        {
            if(this.IsConsolidationEnabled == null) {

                this.IsConsolidationEnabled = true;

            } else {


            }
        }
        else if (this.IsConsolidationEnabled != null && ec.Excludes("isConsolidationEnabled",true))
        {
            this.IsConsolidationEnabled = null;
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (ec.Includes("storageAccountName",true))
        {
            if(this.StorageAccountName == null) {

                this.StorageAccountName = "FETCH";

            } else {


            }
        }
        else if (this.StorageAccountName != null && ec.Excludes("storageAccountName",true))
        {
            this.StorageAccountName = null;
        }
        //      C# -> AzureCloudNativeTargetCompanion? CloudNativeCompanion
        // GraphQL -> cloudNativeCompanion: AzureCloudNativeTargetCompanion (type)
        if (ec.Includes("cloudNativeCompanion",false))
        {
            if(this.CloudNativeCompanion == null) {

                this.CloudNativeCompanion = new AzureCloudNativeTargetCompanion();
                this.CloudNativeCompanion.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeCompanion"));

            } else {

                this.CloudNativeCompanion.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeCompanion"));

            }
        }
        else if (this.CloudNativeCompanion != null && ec.Excludes("cloudNativeCompanion",false))
        {
            this.CloudNativeCompanion = null;
        }
        //      C# -> AzureComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AzureComputeSettings (type)
        if (ec.Includes("computeSettings",false))
        {
            if(this.ComputeSettings == null) {

                this.ComputeSettings = new AzureComputeSettings();
                this.ComputeSettings.ApplyExploratoryFieldSpec(ec.NewChild("computeSettings"));

            } else {

                this.ComputeSettings.ApplyExploratoryFieldSpec(ec.NewChild("computeSettings"));

            }
        }
        else if (this.ComputeSettings != null && ec.Excludes("computeSettings",false))
        {
            this.ComputeSettings = null;
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (ec.Includes("proxySettings",false))
        {
            if(this.ProxySettings == null) {

                this.ProxySettings = new ProxySettings();
                this.ProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("proxySettings"));

            } else {

                this.ProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("proxySettings"));

            }
        }
        else if (this.ProxySettings != null && ec.Excludes("proxySettings",false))
        {
            this.ProxySettings = null;
        }
    }


    #endregion

    } // class AzureTargetTemplate
    
    #endregion

    public static class ListAzureTargetTemplateExtensions
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
            this List<AzureTargetTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureTargetTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureTargetTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureTargetTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureTargetTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types