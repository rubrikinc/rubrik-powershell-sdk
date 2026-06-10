// TaxiiConfigType.cs
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
    #region TaxiiConfigType
    public class TaxiiConfigType: BaseType
    {
        #region members

        //      C# -> List<System.String>? CollectionIds
        // GraphQL -> collectionIds: [String!]! (scalar)
        [JsonProperty("collectionIds")]
        public List<System.String>? CollectionIds { get; set; }

        //      C# -> System.Int32? MaxIocAgeDays
        // GraphQL -> maxIocAgeDays: Int! (scalar)
        [JsonProperty("maxIocAgeDays")]
        public System.Int32? MaxIocAgeDays { get; set; }

        //      C# -> System.Int32? MinConfidenceScore
        // GraphQL -> minConfidenceScore: Int! (scalar)
        [JsonProperty("minConfidenceScore")]
        public System.Int32? MinConfidenceScore { get; set; }

        //      C# -> System.String? ServerUrl
        // GraphQL -> serverUrl: String! (scalar)
        [JsonProperty("serverUrl")]
        public System.String? ServerUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaxiiConfigType";
    }

    public TaxiiConfigType Set(
        List<System.String>? CollectionIds = null,
        System.Int32? MaxIocAgeDays = null,
        System.Int32? MinConfidenceScore = null,
        System.String? ServerUrl = null
    ) 
    {
        if ( CollectionIds != null ) {
            this.CollectionIds = CollectionIds;
        }
        if ( MaxIocAgeDays != null ) {
            this.MaxIocAgeDays = MaxIocAgeDays;
        }
        if ( MinConfidenceScore != null ) {
            this.MinConfidenceScore = MinConfidenceScore;
        }
        if ( ServerUrl != null ) {
            this.ServerUrl = ServerUrl;
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
        //      C# -> List<System.String>? CollectionIds
        // GraphQL -> collectionIds: [String!]! (scalar)
        if (this.CollectionIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "collectionIds\n" ;
            } else {
                s += ind + "collectionIds\n" ;
            }
        }
        //      C# -> System.Int32? MaxIocAgeDays
        // GraphQL -> maxIocAgeDays: Int! (scalar)
        if (this.MaxIocAgeDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxIocAgeDays\n" ;
            } else {
                s += ind + "maxIocAgeDays\n" ;
            }
        }
        //      C# -> System.Int32? MinConfidenceScore
        // GraphQL -> minConfidenceScore: Int! (scalar)
        if (this.MinConfidenceScore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minConfidenceScore\n" ;
            } else {
                s += ind + "minConfidenceScore\n" ;
            }
        }
        //      C# -> System.String? ServerUrl
        // GraphQL -> serverUrl: String! (scalar)
        if (this.ServerUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverUrl\n" ;
            } else {
                s += ind + "serverUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? CollectionIds
        // GraphQL -> collectionIds: [String!]! (scalar)
        if (ec.Includes("collectionIds",true))
        {
            if(this.CollectionIds == null) {

                this.CollectionIds = new List<System.String>();

            } else {


            }
        }
        else if (this.CollectionIds != null && ec.Excludes("collectionIds",true))
        {
            this.CollectionIds = null;
        }
        //      C# -> System.Int32? MaxIocAgeDays
        // GraphQL -> maxIocAgeDays: Int! (scalar)
        if (ec.Includes("maxIocAgeDays",true))
        {
            if(this.MaxIocAgeDays == null) {

                this.MaxIocAgeDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxIocAgeDays != null && ec.Excludes("maxIocAgeDays",true))
        {
            this.MaxIocAgeDays = null;
        }
        //      C# -> System.Int32? MinConfidenceScore
        // GraphQL -> minConfidenceScore: Int! (scalar)
        if (ec.Includes("minConfidenceScore",true))
        {
            if(this.MinConfidenceScore == null) {

                this.MinConfidenceScore = Int32.MinValue;

            } else {


            }
        }
        else if (this.MinConfidenceScore != null && ec.Excludes("minConfidenceScore",true))
        {
            this.MinConfidenceScore = null;
        }
        //      C# -> System.String? ServerUrl
        // GraphQL -> serverUrl: String! (scalar)
        if (ec.Includes("serverUrl",true))
        {
            if(this.ServerUrl == null) {

                this.ServerUrl = "FETCH";

            } else {


            }
        }
        else if (this.ServerUrl != null && ec.Excludes("serverUrl",true))
        {
            this.ServerUrl = null;
        }
    }


    #endregion

    } // class TaxiiConfigType
    
    #endregion

    public static class ListTaxiiConfigTypeExtensions
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
            this List<TaxiiConfigType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TaxiiConfigType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TaxiiConfigType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TaxiiConfigType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TaxiiConfigType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types