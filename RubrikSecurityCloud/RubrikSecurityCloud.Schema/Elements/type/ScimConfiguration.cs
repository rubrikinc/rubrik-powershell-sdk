// ScimConfiguration.cs
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
    #region ScimConfiguration
    public class ScimConfiguration: BaseType
    {
        #region members

        //      C# -> System.String? BaseUrl
        // GraphQL -> baseUrl: URL! (scalar)
        [JsonProperty("baseUrl")]
        public System.String? BaseUrl { get; set; }

        //      C# -> System.Boolean? IsConfigured
        // GraphQL -> isConfigured: Boolean! (scalar)
        [JsonProperty("isConfigured")]
        public System.Boolean? IsConfigured { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ScimConfiguration";
    }

    public ScimConfiguration Set(
        System.String? BaseUrl = null,
        System.Boolean? IsConfigured = null
    ) 
    {
        if ( BaseUrl != null ) {
            this.BaseUrl = BaseUrl;
        }
        if ( IsConfigured != null ) {
            this.IsConfigured = IsConfigured;
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
        //      C# -> System.String? BaseUrl
        // GraphQL -> baseUrl: URL! (scalar)
        if (this.BaseUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "baseUrl\n" ;
            } else {
                s += ind + "baseUrl\n" ;
            }
        }
        //      C# -> System.Boolean? IsConfigured
        // GraphQL -> isConfigured: Boolean! (scalar)
        if (this.IsConfigured != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isConfigured\n" ;
            } else {
                s += ind + "isConfigured\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? BaseUrl
        // GraphQL -> baseUrl: URL! (scalar)
        if (ec.Includes("baseUrl",true))
        {
            if(this.BaseUrl == null) {

                this.BaseUrl = "FETCH";

            } else {


            }
        }
        else if (this.BaseUrl != null && ec.Excludes("baseUrl",true))
        {
            this.BaseUrl = null;
        }
        //      C# -> System.Boolean? IsConfigured
        // GraphQL -> isConfigured: Boolean! (scalar)
        if (ec.Includes("isConfigured",true))
        {
            if(this.IsConfigured == null) {

                this.IsConfigured = true;

            } else {


            }
        }
        else if (this.IsConfigured != null && ec.Excludes("isConfigured",true))
        {
            this.IsConfigured = null;
        }
    }


    #endregion

    } // class ScimConfiguration
    
    #endregion

    public static class ListScimConfigurationExtensions
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
            this List<ScimConfiguration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ScimConfiguration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ScimConfiguration> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ScimConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ScimConfiguration> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types