// RegistryPatternSpec.cs
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
    #region RegistryPatternSpec
    public class RegistryPatternSpec: BaseType
    {
        #region members

        //      C# -> System.String? KeyPattern
        // GraphQL -> keyPattern: String! (scalar)
        [JsonProperty("keyPattern")]
        public System.String? KeyPattern { get; set; }

        //      C# -> System.String? PatternId
        // GraphQL -> patternId: String! (scalar)
        [JsonProperty("patternId")]
        public System.String? PatternId { get; set; }

        //      C# -> System.String? ValueDataContains
        // GraphQL -> valueDataContains: String! (scalar)
        [JsonProperty("valueDataContains")]
        public System.String? ValueDataContains { get; set; }

        //      C# -> System.String? ValueDataEq
        // GraphQL -> valueDataEq: String! (scalar)
        [JsonProperty("valueDataEq")]
        public System.String? ValueDataEq { get; set; }

        //      C# -> System.String? ValueDataNotContains
        // GraphQL -> valueDataNotContains: String! (scalar)
        [JsonProperty("valueDataNotContains")]
        public System.String? ValueDataNotContains { get; set; }

        //      C# -> System.String? ValueDataNotEq
        // GraphQL -> valueDataNotEq: String! (scalar)
        [JsonProperty("valueDataNotEq")]
        public System.String? ValueDataNotEq { get; set; }

        //      C# -> List<System.String>? ValueNames
        // GraphQL -> valueNames: [String!]! (scalar)
        [JsonProperty("valueNames")]
        public List<System.String>? ValueNames { get; set; }

        //      C# -> List<System.String>? ValueTypes
        // GraphQL -> valueTypes: [String!]! (scalar)
        [JsonProperty("valueTypes")]
        public List<System.String>? ValueTypes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegistryPatternSpec";
    }

    public RegistryPatternSpec Set(
        System.String? KeyPattern = null,
        System.String? PatternId = null,
        System.String? ValueDataContains = null,
        System.String? ValueDataEq = null,
        System.String? ValueDataNotContains = null,
        System.String? ValueDataNotEq = null,
        List<System.String>? ValueNames = null,
        List<System.String>? ValueTypes = null
    ) 
    {
        if ( KeyPattern != null ) {
            this.KeyPattern = KeyPattern;
        }
        if ( PatternId != null ) {
            this.PatternId = PatternId;
        }
        if ( ValueDataContains != null ) {
            this.ValueDataContains = ValueDataContains;
        }
        if ( ValueDataEq != null ) {
            this.ValueDataEq = ValueDataEq;
        }
        if ( ValueDataNotContains != null ) {
            this.ValueDataNotContains = ValueDataNotContains;
        }
        if ( ValueDataNotEq != null ) {
            this.ValueDataNotEq = ValueDataNotEq;
        }
        if ( ValueNames != null ) {
            this.ValueNames = ValueNames;
        }
        if ( ValueTypes != null ) {
            this.ValueTypes = ValueTypes;
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
        //      C# -> System.String? KeyPattern
        // GraphQL -> keyPattern: String! (scalar)
        if (this.KeyPattern != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyPattern\n" ;
            } else {
                s += ind + "keyPattern\n" ;
            }
        }
        //      C# -> System.String? PatternId
        // GraphQL -> patternId: String! (scalar)
        if (this.PatternId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "patternId\n" ;
            } else {
                s += ind + "patternId\n" ;
            }
        }
        //      C# -> System.String? ValueDataContains
        // GraphQL -> valueDataContains: String! (scalar)
        if (this.ValueDataContains != null) {
            if (conf.Flat) {
                s += conf.Prefix + "valueDataContains\n" ;
            } else {
                s += ind + "valueDataContains\n" ;
            }
        }
        //      C# -> System.String? ValueDataEq
        // GraphQL -> valueDataEq: String! (scalar)
        if (this.ValueDataEq != null) {
            if (conf.Flat) {
                s += conf.Prefix + "valueDataEq\n" ;
            } else {
                s += ind + "valueDataEq\n" ;
            }
        }
        //      C# -> System.String? ValueDataNotContains
        // GraphQL -> valueDataNotContains: String! (scalar)
        if (this.ValueDataNotContains != null) {
            if (conf.Flat) {
                s += conf.Prefix + "valueDataNotContains\n" ;
            } else {
                s += ind + "valueDataNotContains\n" ;
            }
        }
        //      C# -> System.String? ValueDataNotEq
        // GraphQL -> valueDataNotEq: String! (scalar)
        if (this.ValueDataNotEq != null) {
            if (conf.Flat) {
                s += conf.Prefix + "valueDataNotEq\n" ;
            } else {
                s += ind + "valueDataNotEq\n" ;
            }
        }
        //      C# -> List<System.String>? ValueNames
        // GraphQL -> valueNames: [String!]! (scalar)
        if (this.ValueNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "valueNames\n" ;
            } else {
                s += ind + "valueNames\n" ;
            }
        }
        //      C# -> List<System.String>? ValueTypes
        // GraphQL -> valueTypes: [String!]! (scalar)
        if (this.ValueTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "valueTypes\n" ;
            } else {
                s += ind + "valueTypes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? KeyPattern
        // GraphQL -> keyPattern: String! (scalar)
        if (ec.Includes("keyPattern",true))
        {
            if(this.KeyPattern == null) {

                this.KeyPattern = "FETCH";

            } else {


            }
        }
        else if (this.KeyPattern != null && ec.Excludes("keyPattern",true))
        {
            this.KeyPattern = null;
        }
        //      C# -> System.String? PatternId
        // GraphQL -> patternId: String! (scalar)
        if (ec.Includes("patternId",true))
        {
            if(this.PatternId == null) {

                this.PatternId = "FETCH";

            } else {


            }
        }
        else if (this.PatternId != null && ec.Excludes("patternId",true))
        {
            this.PatternId = null;
        }
        //      C# -> System.String? ValueDataContains
        // GraphQL -> valueDataContains: String! (scalar)
        if (ec.Includes("valueDataContains",true))
        {
            if(this.ValueDataContains == null) {

                this.ValueDataContains = "FETCH";

            } else {


            }
        }
        else if (this.ValueDataContains != null && ec.Excludes("valueDataContains",true))
        {
            this.ValueDataContains = null;
        }
        //      C# -> System.String? ValueDataEq
        // GraphQL -> valueDataEq: String! (scalar)
        if (ec.Includes("valueDataEq",true))
        {
            if(this.ValueDataEq == null) {

                this.ValueDataEq = "FETCH";

            } else {


            }
        }
        else if (this.ValueDataEq != null && ec.Excludes("valueDataEq",true))
        {
            this.ValueDataEq = null;
        }
        //      C# -> System.String? ValueDataNotContains
        // GraphQL -> valueDataNotContains: String! (scalar)
        if (ec.Includes("valueDataNotContains",true))
        {
            if(this.ValueDataNotContains == null) {

                this.ValueDataNotContains = "FETCH";

            } else {


            }
        }
        else if (this.ValueDataNotContains != null && ec.Excludes("valueDataNotContains",true))
        {
            this.ValueDataNotContains = null;
        }
        //      C# -> System.String? ValueDataNotEq
        // GraphQL -> valueDataNotEq: String! (scalar)
        if (ec.Includes("valueDataNotEq",true))
        {
            if(this.ValueDataNotEq == null) {

                this.ValueDataNotEq = "FETCH";

            } else {


            }
        }
        else if (this.ValueDataNotEq != null && ec.Excludes("valueDataNotEq",true))
        {
            this.ValueDataNotEq = null;
        }
        //      C# -> List<System.String>? ValueNames
        // GraphQL -> valueNames: [String!]! (scalar)
        if (ec.Includes("valueNames",true))
        {
            if(this.ValueNames == null) {

                this.ValueNames = new List<System.String>();

            } else {


            }
        }
        else if (this.ValueNames != null && ec.Excludes("valueNames",true))
        {
            this.ValueNames = null;
        }
        //      C# -> List<System.String>? ValueTypes
        // GraphQL -> valueTypes: [String!]! (scalar)
        if (ec.Includes("valueTypes",true))
        {
            if(this.ValueTypes == null) {

                this.ValueTypes = new List<System.String>();

            } else {


            }
        }
        else if (this.ValueTypes != null && ec.Excludes("valueTypes",true))
        {
            this.ValueTypes = null;
        }
    }


    #endregion

    } // class RegistryPatternSpec
    
    #endregion

    public static class ListRegistryPatternSpecExtensions
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
            this List<RegistryPatternSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RegistryPatternSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RegistryPatternSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegistryPatternSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RegistryPatternSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types