// ConfigResourceAwsElasticache.cs
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
    #region ConfigResourceAwsElasticache
    public class ConfigResourceAwsElasticache: BaseType
    {
        #region members

        //      C# -> AwsElasticacheConfigurationType? Configuration
        // GraphQL -> configuration: AwsElasticacheConfigurationType! (enum)
        [JsonProperty("configuration")]
        public AwsElasticacheConfigurationType? Configuration { get; set; }

        //      C# -> AwsElasticacheEngineType? Engine
        // GraphQL -> engine: AwsElasticacheEngineType! (enum)
        [JsonProperty("engine")]
        public AwsElasticacheEngineType? Engine { get; set; }

        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        [JsonProperty("vpcName")]
        public System.String? VpcName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigResourceAwsElasticache";
    }

    public ConfigResourceAwsElasticache Set(
        AwsElasticacheConfigurationType? Configuration = null,
        AwsElasticacheEngineType? Engine = null,
        System.String? VpcName = null
    ) 
    {
        if ( Configuration != null ) {
            this.Configuration = Configuration;
        }
        if ( Engine != null ) {
            this.Engine = Engine;
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
        //      C# -> AwsElasticacheConfigurationType? Configuration
        // GraphQL -> configuration: AwsElasticacheConfigurationType! (enum)
        if (this.Configuration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuration\n" ;
            } else {
                s += ind + "configuration\n" ;
            }
        }
        //      C# -> AwsElasticacheEngineType? Engine
        // GraphQL -> engine: AwsElasticacheEngineType! (enum)
        if (this.Engine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "engine\n" ;
            } else {
                s += ind + "engine\n" ;
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
        //      C# -> AwsElasticacheConfigurationType? Configuration
        // GraphQL -> configuration: AwsElasticacheConfigurationType! (enum)
        if (ec.Includes("configuration",true))
        {
            if(this.Configuration == null) {

                this.Configuration = new AwsElasticacheConfigurationType();

            } else {


            }
        }
        else if (this.Configuration != null && ec.Excludes("configuration",true))
        {
            this.Configuration = null;
        }
        //      C# -> AwsElasticacheEngineType? Engine
        // GraphQL -> engine: AwsElasticacheEngineType! (enum)
        if (ec.Includes("engine",true))
        {
            if(this.Engine == null) {

                this.Engine = new AwsElasticacheEngineType();

            } else {


            }
        }
        else if (this.Engine != null && ec.Excludes("engine",true))
        {
            this.Engine = null;
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

    } // class ConfigResourceAwsElasticache
    
    #endregion

    public static class ListConfigResourceAwsElasticacheExtensions
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
            this List<ConfigResourceAwsElasticache> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigResourceAwsElasticache> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigResourceAwsElasticache> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigResourceAwsElasticache());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigResourceAwsElasticache> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types