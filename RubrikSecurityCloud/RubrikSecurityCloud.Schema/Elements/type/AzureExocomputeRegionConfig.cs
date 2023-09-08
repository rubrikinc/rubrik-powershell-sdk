// AzureExocomputeRegionConfig.cs
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
    #region AzureExocomputeRegionConfig
    public class AzureExocomputeRegionConfig: BaseType
    {
        #region members

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }

        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        [JsonProperty("isRscManaged")]
        public System.Boolean? IsRscManaged { get; set; }

        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        [JsonProperty("podOverlayNetworkCidr")]
        public System.String? PodOverlayNetworkCidr { get; set; }

        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        [JsonProperty("podSubnetNativeId")]
        public System.String? PodSubnetNativeId { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureExocomputeRegionConfig";
    }

    public AzureExocomputeRegionConfig Set(
        AzureCloudAccountRegion? Region = null,
        System.Boolean? IsRscManaged = null,
        System.String? PodOverlayNetworkCidr = null,
        System.String? PodSubnetNativeId = null,
        System.String? SubnetNativeId = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( IsRscManaged != null ) {
            this.IsRscManaged = IsRscManaged;
        }
        if ( PodOverlayNetworkCidr != null ) {
            this.PodOverlayNetworkCidr = PodOverlayNetworkCidr;
        }
        if ( PodSubnetNativeId != null ) {
            this.PodSubnetNativeId = PodSubnetNativeId;
        }
        if ( SubnetNativeId != null ) {
            this.SubnetNativeId = SubnetNativeId;
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
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged != null) {
            s += ind + "isRscManaged\n" ;
        }
        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        if (this.PodOverlayNetworkCidr != null) {
            s += ind + "podOverlayNetworkCidr\n" ;
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (this.PodSubnetNativeId != null) {
            s += ind + "podSubnetNativeId\n" ;
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId != null) {
            s += ind + "subnetNativeId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region == null && ec.Includes("region",true))
        {
            this.Region = new AzureCloudAccountRegion();
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged == null && ec.Includes("isRscManaged",true))
        {
            this.IsRscManaged = true;
        }
        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        if (this.PodOverlayNetworkCidr == null && ec.Includes("podOverlayNetworkCidr",true))
        {
            this.PodOverlayNetworkCidr = "FETCH";
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (this.PodSubnetNativeId == null && ec.Includes("podSubnetNativeId",true))
        {
            this.PodSubnetNativeId = "FETCH";
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId == null && ec.Includes("subnetNativeId",true))
        {
            this.SubnetNativeId = "FETCH";
        }
    }


    #endregion

    } // class AzureExocomputeRegionConfig
    
    #endregion

    public static class ListAzureExocomputeRegionConfigExtensions
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
            this List<AzureExocomputeRegionConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeRegionConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeRegionConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureExocomputeRegionConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types