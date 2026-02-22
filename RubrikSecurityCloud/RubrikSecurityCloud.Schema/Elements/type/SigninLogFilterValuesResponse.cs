// SigninLogFilterValuesResponse.cs
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
    #region SigninLogFilterValuesResponse
    public class SigninLogFilterValuesResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean! (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> List<SigninLogFilterValue>? Values
        // GraphQL -> values: [SigninLogFilterValue!]! (type)
        [JsonProperty("values")]
        public List<SigninLogFilterValue>? Values { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SigninLogFilterValuesResponse";
    }

    public SigninLogFilterValuesResponse Set(
        System.Boolean? HasMore = null,
        List<SigninLogFilterValue>? Values = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
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
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean! (scalar)
        if (this.HasMore != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasMore\n" ;
            } else {
                s += ind + "hasMore\n" ;
            }
        }
        //      C# -> List<SigninLogFilterValue>? Values
        // GraphQL -> values: [SigninLogFilterValue!]! (type)
        if (this.Values != null) {
            var fspec = this.Values.AsFieldSpec(conf.Child("values"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "values" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean! (scalar)
        if (ec.Includes("hasMore",true))
        {
            if(this.HasMore == null) {

                this.HasMore = true;

            } else {


            }
        }
        else if (this.HasMore != null && ec.Excludes("hasMore",true))
        {
            this.HasMore = null;
        }
        //      C# -> List<SigninLogFilterValue>? Values
        // GraphQL -> values: [SigninLogFilterValue!]! (type)
        if (ec.Includes("values",false))
        {
            if(this.Values == null) {

                this.Values = new List<SigninLogFilterValue>();
                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            } else {

                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            }
        }
        else if (this.Values != null && ec.Excludes("values",false))
        {
            this.Values = null;
        }
    }


    #endregion

    } // class SigninLogFilterValuesResponse
    
    #endregion

    public static class ListSigninLogFilterValuesResponseExtensions
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
            this List<SigninLogFilterValuesResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SigninLogFilterValuesResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SigninLogFilterValuesResponse> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SigninLogFilterValuesResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SigninLogFilterValuesResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types