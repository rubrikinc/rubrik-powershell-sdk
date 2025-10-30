// RegionalExocomputeConfig.cs
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
    #region RegionalExocomputeConfig
    public class RegionalExocomputeConfig: BaseType
    {
        #region members

        //      C# -> GcpCloudAccountRegion? Region
        // GraphQL -> region: GcpCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public GcpCloudAccountRegion? Region { get; set; }

        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        [JsonProperty("subnetName")]
        public System.String? SubnetName { get; set; }

        //      C# -> System.String? VpcNetworkName
        // GraphQL -> vpcNetworkName: String! (scalar)
        [JsonProperty("vpcNetworkName")]
        public System.String? VpcNetworkName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegionalExocomputeConfig";
    }

    public RegionalExocomputeConfig Set(
        GcpCloudAccountRegion? Region = null,
        System.String? SubnetName = null,
        System.String? VpcNetworkName = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( SubnetName != null ) {
            this.SubnetName = SubnetName;
        }
        if ( VpcNetworkName != null ) {
            this.VpcNetworkName = VpcNetworkName;
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
        //      C# -> GcpCloudAccountRegion? Region
        // GraphQL -> region: GcpCloudAccountRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (this.SubnetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetName\n" ;
            } else {
                s += ind + "subnetName\n" ;
            }
        }
        //      C# -> System.String? VpcNetworkName
        // GraphQL -> vpcNetworkName: String! (scalar)
        if (this.VpcNetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcNetworkName\n" ;
            } else {
                s += ind + "vpcNetworkName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> GcpCloudAccountRegion? Region
        // GraphQL -> region: GcpCloudAccountRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new GcpCloudAccountRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (ec.Includes("subnetName",true))
        {
            if(this.SubnetName == null) {

                this.SubnetName = "FETCH";

            } else {


            }
        }
        else if (this.SubnetName != null && ec.Excludes("subnetName",true))
        {
            this.SubnetName = null;
        }
        //      C# -> System.String? VpcNetworkName
        // GraphQL -> vpcNetworkName: String! (scalar)
        if (ec.Includes("vpcNetworkName",true))
        {
            if(this.VpcNetworkName == null) {

                this.VpcNetworkName = "FETCH";

            } else {


            }
        }
        else if (this.VpcNetworkName != null && ec.Excludes("vpcNetworkName",true))
        {
            this.VpcNetworkName = null;
        }
    }


    #endregion

    } // class RegionalExocomputeConfig
    
    #endregion

    public static class ListRegionalExocomputeConfigExtensions
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
            this List<RegionalExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RegionalExocomputeConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RegionalExocomputeConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegionalExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RegionalExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types