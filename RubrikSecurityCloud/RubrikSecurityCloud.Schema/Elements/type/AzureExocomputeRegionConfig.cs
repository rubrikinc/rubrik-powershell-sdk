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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (this.IsRscManaged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRscManaged\n" ;
            } else {
                s += ind + "isRscManaged\n" ;
            }
        }
        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        if (this.PodOverlayNetworkCidr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "podOverlayNetworkCidr\n" ;
            } else {
                s += ind + "podOverlayNetworkCidr\n" ;
            }
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (this.PodSubnetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "podSubnetNativeId\n" ;
            } else {
                s += ind + "podSubnetNativeId\n" ;
            }
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetNativeId\n" ;
            } else {
                s += ind + "subnetNativeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AzureCloudAccountRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        if (ec.Includes("isRscManaged",true))
        {
            if(this.IsRscManaged == null) {

                this.IsRscManaged = true;

            } else {


            }
        }
        else if (this.IsRscManaged != null && ec.Excludes("isRscManaged",true))
        {
            this.IsRscManaged = null;
        }
        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String! (scalar)
        if (ec.Includes("podOverlayNetworkCidr",true))
        {
            if(this.PodOverlayNetworkCidr == null) {

                this.PodOverlayNetworkCidr = "FETCH";

            } else {


            }
        }
        else if (this.PodOverlayNetworkCidr != null && ec.Excludes("podOverlayNetworkCidr",true))
        {
            this.PodOverlayNetworkCidr = null;
        }
        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        if (ec.Includes("podSubnetNativeId",true))
        {
            if(this.PodSubnetNativeId == null) {

                this.PodSubnetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.PodSubnetNativeId != null && ec.Excludes("podSubnetNativeId",true))
        {
            this.PodSubnetNativeId = null;
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (ec.Includes("subnetNativeId",true))
        {
            if(this.SubnetNativeId == null) {

                this.SubnetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SubnetNativeId != null && ec.Excludes("subnetNativeId",true))
        {
            this.SubnetNativeId = null;
        }
    }


    #endregion

    } // class AzureExocomputeRegionConfig
    
    #endregion

    public static class ListAzureExocomputeRegionConfigExtensions
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
            this List<AzureExocomputeRegionConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureExocomputeRegionConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<AzureExocomputeRegionConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types