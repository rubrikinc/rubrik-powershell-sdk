// AuthCounts.cs
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
    #region AuthCounts
    public class AuthCounts: BaseType
    {
        #region members

        //      C# -> System.Int32? Authenticated
        // GraphQL -> authenticated: Int! (scalar)
        [JsonProperty("authenticated")]
        public System.Int32? Authenticated { get; set; }

        //      C# -> System.Int32? PartiallyAuthenticated
        // GraphQL -> partiallyAuthenticated: Int! (scalar)
        [JsonProperty("partiallyAuthenticated")]
        public System.Int32? PartiallyAuthenticated { get; set; }

        //      C# -> System.Int32? Unauthenticated
        // GraphQL -> unauthenticated: Int! (scalar)
        [JsonProperty("unauthenticated")]
        public System.Int32? Unauthenticated { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AuthCounts";
    }

    public AuthCounts Set(
        System.Int32? Authenticated = null,
        System.Int32? PartiallyAuthenticated = null,
        System.Int32? Unauthenticated = null
    ) 
    {
        if ( Authenticated != null ) {
            this.Authenticated = Authenticated;
        }
        if ( PartiallyAuthenticated != null ) {
            this.PartiallyAuthenticated = PartiallyAuthenticated;
        }
        if ( Unauthenticated != null ) {
            this.Unauthenticated = Unauthenticated;
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
        //      C# -> System.Int32? Authenticated
        // GraphQL -> authenticated: Int! (scalar)
        if (this.Authenticated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authenticated\n" ;
            } else {
                s += ind + "authenticated\n" ;
            }
        }
        //      C# -> System.Int32? PartiallyAuthenticated
        // GraphQL -> partiallyAuthenticated: Int! (scalar)
        if (this.PartiallyAuthenticated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partiallyAuthenticated\n" ;
            } else {
                s += ind + "partiallyAuthenticated\n" ;
            }
        }
        //      C# -> System.Int32? Unauthenticated
        // GraphQL -> unauthenticated: Int! (scalar)
        if (this.Unauthenticated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unauthenticated\n" ;
            } else {
                s += ind + "unauthenticated\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? Authenticated
        // GraphQL -> authenticated: Int! (scalar)
        if (ec.Includes("authenticated",true))
        {
            if(this.Authenticated == null) {

                this.Authenticated = Int32.MinValue;

            } else {


            }
        }
        else if (this.Authenticated != null && ec.Excludes("authenticated",true))
        {
            this.Authenticated = null;
        }
        //      C# -> System.Int32? PartiallyAuthenticated
        // GraphQL -> partiallyAuthenticated: Int! (scalar)
        if (ec.Includes("partiallyAuthenticated",true))
        {
            if(this.PartiallyAuthenticated == null) {

                this.PartiallyAuthenticated = Int32.MinValue;

            } else {


            }
        }
        else if (this.PartiallyAuthenticated != null && ec.Excludes("partiallyAuthenticated",true))
        {
            this.PartiallyAuthenticated = null;
        }
        //      C# -> System.Int32? Unauthenticated
        // GraphQL -> unauthenticated: Int! (scalar)
        if (ec.Includes("unauthenticated",true))
        {
            if(this.Unauthenticated == null) {

                this.Unauthenticated = Int32.MinValue;

            } else {


            }
        }
        else if (this.Unauthenticated != null && ec.Excludes("unauthenticated",true))
        {
            this.Unauthenticated = null;
        }
    }


    #endregion

    } // class AuthCounts
    
    #endregion

    public static class ListAuthCountsExtensions
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
            this List<AuthCounts> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AuthCounts> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AuthCounts> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthCounts());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AuthCounts> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types