// NetworkConfig.cs
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
    #region NetworkConfig
    public class NetworkConfig: BaseType
    {
        #region members

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? VnetId
        // GraphQL -> vnetId: String! (scalar)
        [JsonProperty("vnetId")]
        public System.String? VnetId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NetworkConfig";
    }

    public NetworkConfig Set(
        System.String? SecurityGroupId = null,
        System.String? SubnetId = null,
        System.String? VnetId = null
    ) 
    {
        if ( SecurityGroupId != null ) {
            this.SecurityGroupId = SecurityGroupId;
        }
        if ( SubnetId != null ) {
            this.SubnetId = SubnetId;
        }
        if ( VnetId != null ) {
            this.VnetId = VnetId;
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
        //      C# -> System.String? VnetId
        // GraphQL -> vnetId: String! (scalar)
        if (this.VnetId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vnetId\n" ;
            } else {
                s += ind + "vnetId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? VnetId
        // GraphQL -> vnetId: String! (scalar)
        if (ec.Includes("vnetId",true))
        {
            if(this.VnetId == null) {

                this.VnetId = "FETCH";

            } else {


            }
        }
        else if (this.VnetId != null && ec.Excludes("vnetId",true))
        {
            this.VnetId = null;
        }
    }


    #endregion

    } // class NetworkConfig
    
    #endregion

    public static class ListNetworkConfigExtensions
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
            this List<NetworkConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NetworkConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NetworkConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types