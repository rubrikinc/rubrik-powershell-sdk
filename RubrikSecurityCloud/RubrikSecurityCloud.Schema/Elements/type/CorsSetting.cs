// CorsSetting.cs
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
    #region CorsSetting
    public class CorsSetting: BaseType
    {
        #region members

        //      C# -> List<HttpMethod>? AllowedMethods
        // GraphQL -> allowedMethods: [HttpMethod!]! (enum)
        [JsonProperty("allowedMethods")]
        public List<HttpMethod>? AllowedMethods { get; set; }

        //      C# -> List<System.String>? AllowedHeaders
        // GraphQL -> allowedHeaders: [String!]! (scalar)
        [JsonProperty("allowedHeaders")]
        public List<System.String>? AllowedHeaders { get; set; }

        //      C# -> List<System.String>? AllowedOrigins
        // GraphQL -> allowedOrigins: [String!]! (scalar)
        [JsonProperty("allowedOrigins")]
        public List<System.String>? AllowedOrigins { get; set; }

        //      C# -> List<System.String>? AllowedPaths
        // GraphQL -> allowedPaths: [String!]! (scalar)
        [JsonProperty("allowedPaths")]
        public List<System.String>? AllowedPaths { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CorsSetting";
    }

    public CorsSetting Set(
        List<HttpMethod>? AllowedMethods = null,
        List<System.String>? AllowedHeaders = null,
        List<System.String>? AllowedOrigins = null,
        List<System.String>? AllowedPaths = null,
        System.Boolean? IsEnabled = null
    ) 
    {
        if ( AllowedMethods != null ) {
            this.AllowedMethods = AllowedMethods;
        }
        if ( AllowedHeaders != null ) {
            this.AllowedHeaders = AllowedHeaders;
        }
        if ( AllowedOrigins != null ) {
            this.AllowedOrigins = AllowedOrigins;
        }
        if ( AllowedPaths != null ) {
            this.AllowedPaths = AllowedPaths;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
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
        //      C# -> List<HttpMethod>? AllowedMethods
        // GraphQL -> allowedMethods: [HttpMethod!]! (enum)
        if (this.AllowedMethods != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedMethods\n" ;
            } else {
                s += ind + "allowedMethods\n" ;
            }
        }
        //      C# -> List<System.String>? AllowedHeaders
        // GraphQL -> allowedHeaders: [String!]! (scalar)
        if (this.AllowedHeaders != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedHeaders\n" ;
            } else {
                s += ind + "allowedHeaders\n" ;
            }
        }
        //      C# -> List<System.String>? AllowedOrigins
        // GraphQL -> allowedOrigins: [String!]! (scalar)
        if (this.AllowedOrigins != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedOrigins\n" ;
            } else {
                s += ind + "allowedOrigins\n" ;
            }
        }
        //      C# -> List<System.String>? AllowedPaths
        // GraphQL -> allowedPaths: [String!]! (scalar)
        if (this.AllowedPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedPaths\n" ;
            } else {
                s += ind + "allowedPaths\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<HttpMethod>? AllowedMethods
        // GraphQL -> allowedMethods: [HttpMethod!]! (enum)
        if (ec.Includes("allowedMethods",true))
        {
            if(this.AllowedMethods == null) {

                this.AllowedMethods = new List<HttpMethod>();

            } else {


            }
        }
        else if (this.AllowedMethods != null && ec.Excludes("allowedMethods",true))
        {
            this.AllowedMethods = null;
        }
        //      C# -> List<System.String>? AllowedHeaders
        // GraphQL -> allowedHeaders: [String!]! (scalar)
        if (ec.Includes("allowedHeaders",true))
        {
            if(this.AllowedHeaders == null) {

                this.AllowedHeaders = new List<System.String>();

            } else {


            }
        }
        else if (this.AllowedHeaders != null && ec.Excludes("allowedHeaders",true))
        {
            this.AllowedHeaders = null;
        }
        //      C# -> List<System.String>? AllowedOrigins
        // GraphQL -> allowedOrigins: [String!]! (scalar)
        if (ec.Includes("allowedOrigins",true))
        {
            if(this.AllowedOrigins == null) {

                this.AllowedOrigins = new List<System.String>();

            } else {


            }
        }
        else if (this.AllowedOrigins != null && ec.Excludes("allowedOrigins",true))
        {
            this.AllowedOrigins = null;
        }
        //      C# -> List<System.String>? AllowedPaths
        // GraphQL -> allowedPaths: [String!]! (scalar)
        if (ec.Includes("allowedPaths",true))
        {
            if(this.AllowedPaths == null) {

                this.AllowedPaths = new List<System.String>();

            } else {


            }
        }
        else if (this.AllowedPaths != null && ec.Excludes("allowedPaths",true))
        {
            this.AllowedPaths = null;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
        }
    }


    #endregion

    } // class CorsSetting
    
    #endregion

    public static class ListCorsSettingExtensions
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
            this List<CorsSetting> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CorsSetting> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CorsSetting> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CorsSetting());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CorsSetting> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types