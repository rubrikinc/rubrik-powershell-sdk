// CloudNativeTagPairOutput.cs
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
    #region CloudNativeTagPairOutput
    public class CloudNativeTagPairOutput: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.Boolean? MatchAllTagValues
        // GraphQL -> matchAllTagValues: Boolean! (scalar)
        [JsonProperty("matchAllTagValues")]
        public System.Boolean? MatchAllTagValues { get; set; }

        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!]! (scalar)
        [JsonProperty("values")]
        public List<System.String>? Values { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeTagPairOutput";
    }

    public CloudNativeTagPairOutput Set(
        System.String? Key = null,
        System.Boolean? MatchAllTagValues = null,
        List<System.String>? Values = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( MatchAllTagValues != null ) {
            this.MatchAllTagValues = MatchAllTagValues;
        }
        if ( Values != null ) {
            this.Values = Values;
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
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> System.Boolean? MatchAllTagValues
        // GraphQL -> matchAllTagValues: Boolean! (scalar)
        if (this.MatchAllTagValues != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchAllTagValues\n" ;
            } else {
                s += ind + "matchAllTagValues\n" ;
            }
        }
        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!]! (scalar)
        if (this.Values != null) {
            if (conf.Flat) {
                s += conf.Prefix + "values\n" ;
            } else {
                s += ind + "values\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> System.Boolean? MatchAllTagValues
        // GraphQL -> matchAllTagValues: Boolean! (scalar)
        if (ec.Includes("matchAllTagValues",true))
        {
            if(this.MatchAllTagValues == null) {

                this.MatchAllTagValues = true;

            } else {


            }
        }
        else if (this.MatchAllTagValues != null && ec.Excludes("matchAllTagValues",true))
        {
            this.MatchAllTagValues = null;
        }
        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!]! (scalar)
        if (ec.Includes("values",true))
        {
            if(this.Values == null) {

                this.Values = new List<System.String>();

            } else {


            }
        }
        else if (this.Values != null && ec.Excludes("values",true))
        {
            this.Values = null;
        }
    }


    #endregion

    } // class CloudNativeTagPairOutput
    
    #endregion

    public static class ListCloudNativeTagPairOutputExtensions
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
            this List<CloudNativeTagPairOutput> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeTagPairOutput> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeTagPairOutput> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeTagPairOutput());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeTagPairOutput> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types