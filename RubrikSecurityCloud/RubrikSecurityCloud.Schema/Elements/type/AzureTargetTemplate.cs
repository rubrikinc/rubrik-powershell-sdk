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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> InstanceTypeEnum? InstanceType
        // GraphQL -> instanceType: InstanceTypeEnum! (enum)
        if (this.InstanceType != null) {
            s += ind + "instanceType\n" ;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            s += ind + "targetType\n" ;
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CloudAccount).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudAccount {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? ContainerNamePrefix
        // GraphQL -> containerNamePrefix: String! (scalar)
        if (this.ContainerNamePrefix != null) {
            s += ind + "containerNamePrefix\n" ;
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled != null) {
            s += ind + "isConsolidationEnabled\n" ;
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (this.StorageAccountName != null) {
            s += ind + "storageAccountName\n" ;
        }
        //      C# -> AzureCloudNativeTargetCompanion? CloudNativeCompanion
        // GraphQL -> cloudNativeCompanion: AzureCloudNativeTargetCompanion (type)
        if (this.CloudNativeCompanion != null) {
            var fspec = this.CloudNativeCompanion.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudNativeCompanion {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AzureComputeSettings (type)
        if (this.ComputeSettings != null) {
            var fspec = this.ComputeSettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "computeSettings {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings != null) {
            var fspec = this.ProxySettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "proxySettings {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> InstanceTypeEnum? InstanceType
        // GraphQL -> instanceType: InstanceTypeEnum! (enum)
        if (this.InstanceType == null && Exploration.Includes(parent + ".instanceType", true))
        {
            this.InstanceType = new InstanceTypeEnum();
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType == null && Exploration.Includes(parent + ".targetType", true))
        {
            this.TargetType = new TargetType();
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount == null && Exploration.Includes(parent + ".cloudAccount"))
        {
            var impls = new List<CloudAccount>();
            impls.ApplyExploratoryFieldSpec(parent + ".cloudAccount");
            this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? ContainerNamePrefix
        // GraphQL -> containerNamePrefix: String! (scalar)
        if (this.ContainerNamePrefix == null && Exploration.Includes(parent + ".containerNamePrefix", true))
        {
            this.ContainerNamePrefix = "FETCH";
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled == null && Exploration.Includes(parent + ".isConsolidationEnabled", true))
        {
            this.IsConsolidationEnabled = true;
        }
        //      C# -> System.String? StorageAccountName
        // GraphQL -> storageAccountName: String! (scalar)
        if (this.StorageAccountName == null && Exploration.Includes(parent + ".storageAccountName", true))
        {
            this.StorageAccountName = "FETCH";
        }
        //      C# -> AzureCloudNativeTargetCompanion? CloudNativeCompanion
        // GraphQL -> cloudNativeCompanion: AzureCloudNativeTargetCompanion (type)
        if (this.CloudNativeCompanion == null && Exploration.Includes(parent + ".cloudNativeCompanion"))
        {
            this.CloudNativeCompanion = new AzureCloudNativeTargetCompanion();
            this.CloudNativeCompanion.ApplyExploratoryFieldSpec(parent + ".cloudNativeCompanion");
        }
        //      C# -> AzureComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AzureComputeSettings (type)
        if (this.ComputeSettings == null && Exploration.Includes(parent + ".computeSettings"))
        {
            this.ComputeSettings = new AzureComputeSettings();
            this.ComputeSettings.ApplyExploratoryFieldSpec(parent + ".computeSettings");
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings == null && Exploration.Includes(parent + ".proxySettings"))
        {
            this.ProxySettings = new ProxySettings();
            this.ProxySettings.ApplyExploratoryFieldSpec(parent + ".proxySettings");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureTargetTemplate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureTargetTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types