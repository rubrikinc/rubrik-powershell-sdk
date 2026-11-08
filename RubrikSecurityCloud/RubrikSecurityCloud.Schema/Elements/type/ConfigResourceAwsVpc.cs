// ConfigResourceAwsVpc.cs
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
    #region ConfigResourceAwsVpc
    public class ConfigResourceAwsVpc: BaseType
    {
        #region members

        //      C# -> AwsVpcStatus? Status
        // GraphQL -> status: AwsVpcStatus! (enum)
        [JsonProperty("status")]
        public AwsVpcStatus? Status { get; set; }

        //      C# -> System.String? PrimaryCidr
        // GraphQL -> primaryCidr: String! (scalar)
        [JsonProperty("primaryCidr")]
        public System.String? PrimaryCidr { get; set; }

        //      C# -> List<System.String>? SecondaryCidrs
        // GraphQL -> secondaryCidrs: [String!]! (scalar)
        [JsonProperty("secondaryCidrs")]
        public List<System.String>? SecondaryCidrs { get; set; }

        //      C# -> System.Int32? TotalSubnets
        // GraphQL -> totalSubnets: Int! (scalar)
        [JsonProperty("totalSubnets")]
        public System.Int32? TotalSubnets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigResourceAwsVpc";
    }

    public ConfigResourceAwsVpc Set(
        AwsVpcStatus? Status = null,
        System.String? PrimaryCidr = null,
        List<System.String>? SecondaryCidrs = null,
        System.Int32? TotalSubnets = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( PrimaryCidr != null ) {
            this.PrimaryCidr = PrimaryCidr;
        }
        if ( SecondaryCidrs != null ) {
            this.SecondaryCidrs = SecondaryCidrs;
        }
        if ( TotalSubnets != null ) {
            this.TotalSubnets = TotalSubnets;
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
        //      C# -> AwsVpcStatus? Status
        // GraphQL -> status: AwsVpcStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? PrimaryCidr
        // GraphQL -> primaryCidr: String! (scalar)
        if (this.PrimaryCidr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryCidr\n" ;
            } else {
                s += ind + "primaryCidr\n" ;
            }
        }
        //      C# -> List<System.String>? SecondaryCidrs
        // GraphQL -> secondaryCidrs: [String!]! (scalar)
        if (this.SecondaryCidrs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryCidrs\n" ;
            } else {
                s += ind + "secondaryCidrs\n" ;
            }
        }
        //      C# -> System.Int32? TotalSubnets
        // GraphQL -> totalSubnets: Int! (scalar)
        if (this.TotalSubnets != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSubnets\n" ;
            } else {
                s += ind + "totalSubnets\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsVpcStatus? Status
        // GraphQL -> status: AwsVpcStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AwsVpcStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? PrimaryCidr
        // GraphQL -> primaryCidr: String! (scalar)
        if (ec.Includes("primaryCidr",true))
        {
            if(this.PrimaryCidr == null) {

                this.PrimaryCidr = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryCidr != null && ec.Excludes("primaryCidr",true))
        {
            this.PrimaryCidr = null;
        }
        //      C# -> List<System.String>? SecondaryCidrs
        // GraphQL -> secondaryCidrs: [String!]! (scalar)
        if (ec.Includes("secondaryCidrs",true))
        {
            if(this.SecondaryCidrs == null) {

                this.SecondaryCidrs = new List<System.String>();

            } else {


            }
        }
        else if (this.SecondaryCidrs != null && ec.Excludes("secondaryCidrs",true))
        {
            this.SecondaryCidrs = null;
        }
        //      C# -> System.Int32? TotalSubnets
        // GraphQL -> totalSubnets: Int! (scalar)
        if (ec.Includes("totalSubnets",true))
        {
            if(this.TotalSubnets == null) {

                this.TotalSubnets = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalSubnets != null && ec.Excludes("totalSubnets",true))
        {
            this.TotalSubnets = null;
        }
    }


    #endregion

    } // class ConfigResourceAwsVpc
    
    #endregion

    public static class ListConfigResourceAwsVpcExtensions
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
            this List<ConfigResourceAwsVpc> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigResourceAwsVpc> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigResourceAwsVpc> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigResourceAwsVpc());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigResourceAwsVpc> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types