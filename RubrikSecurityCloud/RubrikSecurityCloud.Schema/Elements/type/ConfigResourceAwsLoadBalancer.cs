// ConfigResourceAwsLoadBalancer.cs
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
    #region ConfigResourceAwsLoadBalancer
    public class ConfigResourceAwsLoadBalancer: BaseType
    {
        #region members

        //      C# -> AwsLoadBalancerStatus? Status
        // GraphQL -> status: AwsLoadBalancerStatus! (enum)
        [JsonProperty("status")]
        public AwsLoadBalancerStatus? Status { get; set; }

        //      C# -> AwsLoadBalancerType? Type
        // GraphQL -> type: AwsLoadBalancerType! (enum)
        [JsonProperty("type")]
        public AwsLoadBalancerType? Type { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.Int32? TargetGroupsCount
        // GraphQL -> targetGroupsCount: Int! (scalar)
        [JsonProperty("targetGroupsCount")]
        public System.Int32? TargetGroupsCount { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        [JsonProperty("vpcName")]
        public System.String? VpcName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigResourceAwsLoadBalancer";
    }

    public ConfigResourceAwsLoadBalancer Set(
        AwsLoadBalancerStatus? Status = null,
        AwsLoadBalancerType? Type = null,
        System.String? IpAddress = null,
        System.Int32? TargetGroupsCount = null,
        System.String? VpcId = null,
        System.String? VpcName = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( TargetGroupsCount != null ) {
            this.TargetGroupsCount = TargetGroupsCount;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( VpcName != null ) {
            this.VpcName = VpcName;
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
        //      C# -> AwsLoadBalancerStatus? Status
        // GraphQL -> status: AwsLoadBalancerStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> AwsLoadBalancerType? Type
        // GraphQL -> type: AwsLoadBalancerType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
            }
        }
        //      C# -> System.Int32? TargetGroupsCount
        // GraphQL -> targetGroupsCount: Int! (scalar)
        if (this.TargetGroupsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetGroupsCount\n" ;
            } else {
                s += ind + "targetGroupsCount\n" ;
            }
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcId\n" ;
            } else {
                s += ind + "vpcId\n" ;
            }
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (this.VpcName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcName\n" ;
            } else {
                s += ind + "vpcName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsLoadBalancerStatus? Status
        // GraphQL -> status: AwsLoadBalancerStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AwsLoadBalancerStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> AwsLoadBalancerType? Type
        // GraphQL -> type: AwsLoadBalancerType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new AwsLoadBalancerType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
        }
        //      C# -> System.Int32? TargetGroupsCount
        // GraphQL -> targetGroupsCount: Int! (scalar)
        if (ec.Includes("targetGroupsCount",true))
        {
            if(this.TargetGroupsCount == null) {

                this.TargetGroupsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TargetGroupsCount != null && ec.Excludes("targetGroupsCount",true))
        {
            this.TargetGroupsCount = null;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (ec.Includes("vpcId",true))
        {
            if(this.VpcId == null) {

                this.VpcId = "FETCH";

            } else {


            }
        }
        else if (this.VpcId != null && ec.Excludes("vpcId",true))
        {
            this.VpcId = null;
        }
        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        if (ec.Includes("vpcName",true))
        {
            if(this.VpcName == null) {

                this.VpcName = "FETCH";

            } else {


            }
        }
        else if (this.VpcName != null && ec.Excludes("vpcName",true))
        {
            this.VpcName = null;
        }
    }


    #endregion

    } // class ConfigResourceAwsLoadBalancer
    
    #endregion

    public static class ListConfigResourceAwsLoadBalancerExtensions
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
            this List<ConfigResourceAwsLoadBalancer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigResourceAwsLoadBalancer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigResourceAwsLoadBalancer> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigResourceAwsLoadBalancer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigResourceAwsLoadBalancer> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types