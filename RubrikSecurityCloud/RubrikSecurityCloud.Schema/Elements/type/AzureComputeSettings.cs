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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountId\n" ;
            } else {
                s += ind + "cloudAccountId\n" ;
            }
        }
        //      C# -> System.String? GeneralPurposeStorageContainer
        // GraphQL -> generalPurposeStorageContainer: String! (scalar)
        if (this.GeneralPurposeStorageContainer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "generalPurposeStorageContainer\n" ;
            } else {
                s += ind + "generalPurposeStorageContainer\n" ;
            }
        }
        //      C# -> System.String? GeneralPurposeStorageName
        // GraphQL -> generalPurposeStorageName: String! (scalar)
        if (this.GeneralPurposeStorageName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "generalPurposeStorageName\n" ;
            } else {
                s += ind + "generalPurposeStorageName\n" ;
            }
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (this.ResourceGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroup\n" ;
            } else {
                s += ind + "resourceGroup\n" ;
            }
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "securityGroupId\n" ;
            } else {
                s += ind + "securityGroupId\n" ;
            }
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetId\n" ;
            } else {
                s += ind + "subnetId\n" ;
            }
        }
        //      C# -> System.String? VirtualNetworkId
        // GraphQL -> virtualNetworkId: String! (scalar)
        if (this.VirtualNetworkId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualNetworkId\n" ;
            } else {
                s += ind + "virtualNetworkId\n" ;
            }
        }
        //      C# -> ProxySettings? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettings (type)
        if (this.ComputeProxySettings != null) {
            var fspec = this.ComputeProxySettings.AsFieldSpec(conf.Child("computeProxySettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "computeProxySettings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AzureRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (ec.Includes("cloudAccountId",true))
        {
            if(this.CloudAccountId == null) {

                this.CloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccountId != null && ec.Excludes("cloudAccountId",true))
        {
            this.CloudAccountId = null;
        }
        //      C# -> System.String? GeneralPurposeStorageContainer
        // GraphQL -> generalPurposeStorageContainer: String! (scalar)
        if (ec.Includes("generalPurposeStorageContainer",true))
        {
            if(this.GeneralPurposeStorageContainer == null) {

                this.GeneralPurposeStorageContainer = "FETCH";

            } else {


            }
        }
        else if (this.GeneralPurposeStorageContainer != null && ec.Excludes("generalPurposeStorageContainer",true))
        {
            this.GeneralPurposeStorageContainer = null;
        }
        //      C# -> System.String? GeneralPurposeStorageName
        // GraphQL -> generalPurposeStorageName: String! (scalar)
        if (ec.Includes("generalPurposeStorageName",true))
        {
            if(this.GeneralPurposeStorageName == null) {

                this.GeneralPurposeStorageName = "FETCH";

            } else {


            }
        }
        else if (this.GeneralPurposeStorageName != null && ec.Excludes("generalPurposeStorageName",true))
        {
            this.GeneralPurposeStorageName = null;
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (ec.Includes("resourceGroup",true))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",true))
        {
            this.ResourceGroup = null;
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (ec.Includes("securityGroupId",true))
        {
            if(this.SecurityGroupId == null) {

                this.SecurityGroupId = "FETCH";

            } else {


            }
        }
        else if (this.SecurityGroupId != null && ec.Excludes("securityGroupId",true))
        {
            this.SecurityGroupId = null;
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (ec.Includes("subnetId",true))
        {
            if(this.SubnetId == null) {

                this.SubnetId = "FETCH";

            } else {


            }
        }
        else if (this.SubnetId != null && ec.Excludes("subnetId",true))
        {
            this.SubnetId = null;
        }
        //      C# -> System.String? VirtualNetworkId
        // GraphQL -> virtualNetworkId: String! (scalar)
        if (ec.Includes("virtualNetworkId",true))
        {
            if(this.VirtualNetworkId == null) {

                this.VirtualNetworkId = "FETCH";

            } else {


            }
        }
        else if (this.VirtualNetworkId != null && ec.Excludes("virtualNetworkId",true))
        {
            this.VirtualNetworkId = null;
        }
        //      C# -> ProxySettings? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettings (type)
        if (ec.Includes("computeProxySettings",false))
        {
            if(this.ComputeProxySettings == null) {

                this.ComputeProxySettings = new ProxySettings();
                this.ComputeProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("computeProxySettings"));

            } else {

                this.ComputeProxySettings.ApplyExploratoryFieldSpec(ec.NewChild("computeProxySettings"));

            }
        }
        else if (this.ComputeProxySettings != null && ec.Excludes("computeProxySettings",false))
        {
            this.ComputeProxySettings = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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