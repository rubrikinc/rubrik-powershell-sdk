// AzureComputeSettings.cs
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
    #region AzureComputeSettings
    public class AzureComputeSettings: BaseType
    {
        #region members

        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        [JsonProperty("region")]
        public AzureRegion? Region { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? GeneralPurposeStorageContainer
        // GraphQL -> generalPurposeStorageContainer: String! (scalar)
        [JsonProperty("generalPurposeStorageContainer")]
        public System.String? GeneralPurposeStorageContainer { get; set; }

        //      C# -> System.String? GeneralPurposeStorageName
        // GraphQL -> generalPurposeStorageName: String! (scalar)
        [JsonProperty("generalPurposeStorageName")]
        public System.String? GeneralPurposeStorageName { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? VirtualNetworkId
        // GraphQL -> virtualNetworkId: String! (scalar)
        [JsonProperty("virtualNetworkId")]
        public System.String? VirtualNetworkId { get; set; }

        //      C# -> ProxySettings? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettings (type)
        [JsonProperty("computeProxySettings")]
        public ProxySettings? ComputeProxySettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureComputeSettings";
    }

    public AzureComputeSettings Set(
        AzureRegion? Region = null,
        System.String? AppId = null,
        System.String? CloudAccountId = null,
        System.String? GeneralPurposeStorageContainer = null,
        System.String? GeneralPurposeStorageName = null,
        System.String? ResourceGroup = null,
        System.String? SecurityGroupId = null,
        System.String? SubnetId = null,
        System.String? VirtualNetworkId = null,
        ProxySettings? ComputeProxySettings = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( GeneralPurposeStorageContainer != null ) {
            this.GeneralPurposeStorageContainer = GeneralPurposeStorageContainer;
        }
        if ( GeneralPurposeStorageName != null ) {
            this.GeneralPurposeStorageName = GeneralPurposeStorageName;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        if ( SecurityGroupId != null ) {
            this.SecurityGroupId = SecurityGroupId;
        }
        if ( SubnetId != null ) {
            this.SubnetId = SubnetId;
        }
        if ( VirtualNetworkId != null ) {
            this.VirtualNetworkId = VirtualNetworkId;
        }
        if ( ComputeProxySettings != null ) {
            this.ComputeProxySettings = ComputeProxySettings;
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
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            s += ind + "appId\n" ;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            s += ind + "cloudAccountId\n" ;
        }
        //      C# -> System.String? GeneralPurposeStorageContainer
        // GraphQL -> generalPurposeStorageContainer: String! (scalar)
        if (this.GeneralPurposeStorageContainer != null) {
            s += ind + "generalPurposeStorageContainer\n" ;
        }
        //      C# -> System.String? GeneralPurposeStorageName
        // GraphQL -> generalPurposeStorageName: String! (scalar)
        if (this.GeneralPurposeStorageName != null) {
            s += ind + "generalPurposeStorageName\n" ;
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (this.ResourceGroup != null) {
            s += ind + "resourceGroup\n" ;
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId != null) {
            s += ind + "securityGroupId\n" ;
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId != null) {
            s += ind + "subnetId\n" ;
        }
        //      C# -> System.String? VirtualNetworkId
        // GraphQL -> virtualNetworkId: String! (scalar)
        if (this.VirtualNetworkId != null) {
            s += ind + "virtualNetworkId\n" ;
        }
        //      C# -> ProxySettings? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettings (type)
        if (this.ComputeProxySettings != null) {
            var fspec = this.ComputeProxySettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "computeProxySettings {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (this.Region == null && ec.Includes("region",true))
        {
            this.Region = new AzureRegion();
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId == null && ec.Includes("appId",true))
        {
            this.AppId = "FETCH";
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId == null && ec.Includes("cloudAccountId",true))
        {
            this.CloudAccountId = "FETCH";
        }
        //      C# -> System.String? GeneralPurposeStorageContainer
        // GraphQL -> generalPurposeStorageContainer: String! (scalar)
        if (this.GeneralPurposeStorageContainer == null && ec.Includes("generalPurposeStorageContainer",true))
        {
            this.GeneralPurposeStorageContainer = "FETCH";
        }
        //      C# -> System.String? GeneralPurposeStorageName
        // GraphQL -> generalPurposeStorageName: String! (scalar)
        if (this.GeneralPurposeStorageName == null && ec.Includes("generalPurposeStorageName",true))
        {
            this.GeneralPurposeStorageName = "FETCH";
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (this.ResourceGroup == null && ec.Includes("resourceGroup",true))
        {
            this.ResourceGroup = "FETCH";
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId == null && ec.Includes("securityGroupId",true))
        {
            this.SecurityGroupId = "FETCH";
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId == null && ec.Includes("subnetId",true))
        {
            this.SubnetId = "FETCH";
        }
        //      C# -> System.String? VirtualNetworkId
        // GraphQL -> virtualNetworkId: String! (scalar)
        if (this.VirtualNetworkId == null && ec.Includes("virtualNetworkId",true))
        {
            this.VirtualNetworkId = "FETCH";
        }
        //      C# -> ProxySettings? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettings (type)
        if (this.ComputeProxySettings == null && ec.Includes("computeProxySettings",false))
        {
            this.ComputeProxySettings = new ProxySettings();
            this.ComputeProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("computeProxySettings"));
        }
    }


    #endregion

    } // class AzureComputeSettings
    
    #endregion

    public static class ListAzureComputeSettingsExtensions
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
            this List<AzureComputeSettings> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureComputeSettings> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureComputeSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureComputeSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types