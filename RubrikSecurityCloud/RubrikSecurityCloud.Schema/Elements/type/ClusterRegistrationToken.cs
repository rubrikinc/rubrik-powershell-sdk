// ClusterRegistrationToken.cs
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
    #region ClusterRegistrationToken
    public class ClusterRegistrationToken: BaseType
    {
        #region members

        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        [JsonProperty("productType")]
        public System.String? ProductType { get; set; }

        //      C# -> System.String? Pubkey
        // GraphQL -> pubkey: String! (scalar)
        [JsonProperty("pubkey")]
        public System.String? Pubkey { get; set; }

        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        [JsonProperty("token")]
        public System.String? Token { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterRegistrationToken";
    }

    public ClusterRegistrationToken Set(
        System.String? ProductType = null,
        System.String? Pubkey = null,
        System.String? Token = null
    ) 
    {
        if ( ProductType != null ) {
            this.ProductType = ProductType;
        }
        if ( Pubkey != null ) {
            this.Pubkey = Pubkey;
        }
        if ( Token != null ) {
            this.Token = Token;
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
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (this.ProductType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productType\n" ;
            } else {
                s += ind + "productType\n" ;
            }
        }
        //      C# -> System.String? Pubkey
        // GraphQL -> pubkey: String! (scalar)
        if (this.Pubkey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pubkey\n" ;
            } else {
                s += ind + "pubkey\n" ;
            }
        }
        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        if (this.Token != null) {
            if (conf.Flat) {
                s += conf.Prefix + "token\n" ;
            } else {
                s += ind + "token\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (ec.Includes("productType",true))
        {
            if(this.ProductType == null) {

                this.ProductType = "FETCH";

            } else {


            }
        }
        else if (this.ProductType != null && ec.Excludes("productType",true))
        {
            this.ProductType = null;
        }
        //      C# -> System.String? Pubkey
        // GraphQL -> pubkey: String! (scalar)
        if (ec.Includes("pubkey",true))
        {
            if(this.Pubkey == null) {

                this.Pubkey = "FETCH";

            } else {


            }
        }
        else if (this.Pubkey != null && ec.Excludes("pubkey",true))
        {
            this.Pubkey = null;
        }
        //      C# -> System.String? Token
        // GraphQL -> token: String! (scalar)
        if (ec.Includes("token",true))
        {
            if(this.Token == null) {

                this.Token = "FETCH";

            } else {


            }
        }
        else if (this.Token != null && ec.Excludes("token",true))
        {
            this.Token = null;
        }
    }


    #endregion

    } // class ClusterRegistrationToken
    
    #endregion

    public static class ListClusterRegistrationTokenExtensions
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
            this List<ClusterRegistrationToken> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterRegistrationToken> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterRegistrationToken> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterRegistrationToken());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterRegistrationToken> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types