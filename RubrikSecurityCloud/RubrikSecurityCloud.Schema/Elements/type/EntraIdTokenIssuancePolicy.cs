// EntraIdTokenIssuancePolicy.cs
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
    #region EntraIdTokenIssuancePolicy
    public class EntraIdTokenIssuancePolicy: BaseType
    {
        #region members

        //      C# -> EntraIdTokenIssuanceSigningAlgorithm? SigningAlgorithm
        // GraphQL -> signingAlgorithm: EntraIdTokenIssuanceSigningAlgorithm! (enum)
        [JsonProperty("signingAlgorithm")]
        public EntraIdTokenIssuanceSigningAlgorithm? SigningAlgorithm { get; set; }

        //      C# -> EntraIdTokenResponseSigningPolicy? TokenResponseSigningPolicy
        // GraphQL -> tokenResponseSigningPolicy: EntraIdTokenResponseSigningPolicy! (enum)
        [JsonProperty("tokenResponseSigningPolicy")]
        public EntraIdTokenResponseSigningPolicy? TokenResponseSigningPolicy { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? SamlTokenVersion
        // GraphQL -> samlTokenVersion: String! (scalar)
        [JsonProperty("samlTokenVersion")]
        public System.String? SamlTokenVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIdTokenIssuancePolicy";
    }

    public EntraIdTokenIssuancePolicy Set(
        EntraIdTokenIssuanceSigningAlgorithm? SigningAlgorithm = null,
        EntraIdTokenResponseSigningPolicy? TokenResponseSigningPolicy = null,
        System.String? DisplayName = null,
        System.String? Id = null,
        System.String? SamlTokenVersion = null
    ) 
    {
        if ( SigningAlgorithm != null ) {
            this.SigningAlgorithm = SigningAlgorithm;
        }
        if ( TokenResponseSigningPolicy != null ) {
            this.TokenResponseSigningPolicy = TokenResponseSigningPolicy;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SamlTokenVersion != null ) {
            this.SamlTokenVersion = SamlTokenVersion;
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
        //      C# -> EntraIdTokenIssuanceSigningAlgorithm? SigningAlgorithm
        // GraphQL -> signingAlgorithm: EntraIdTokenIssuanceSigningAlgorithm! (enum)
        if (this.SigningAlgorithm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "signingAlgorithm\n" ;
            } else {
                s += ind + "signingAlgorithm\n" ;
            }
        }
        //      C# -> EntraIdTokenResponseSigningPolicy? TokenResponseSigningPolicy
        // GraphQL -> tokenResponseSigningPolicy: EntraIdTokenResponseSigningPolicy! (enum)
        if (this.TokenResponseSigningPolicy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tokenResponseSigningPolicy\n" ;
            } else {
                s += ind + "tokenResponseSigningPolicy\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? SamlTokenVersion
        // GraphQL -> samlTokenVersion: String! (scalar)
        if (this.SamlTokenVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "samlTokenVersion\n" ;
            } else {
                s += ind + "samlTokenVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EntraIdTokenIssuanceSigningAlgorithm? SigningAlgorithm
        // GraphQL -> signingAlgorithm: EntraIdTokenIssuanceSigningAlgorithm! (enum)
        if (ec.Includes("signingAlgorithm",true))
        {
            if(this.SigningAlgorithm == null) {

                this.SigningAlgorithm = new EntraIdTokenIssuanceSigningAlgorithm();

            } else {


            }
        }
        else if (this.SigningAlgorithm != null && ec.Excludes("signingAlgorithm",true))
        {
            this.SigningAlgorithm = null;
        }
        //      C# -> EntraIdTokenResponseSigningPolicy? TokenResponseSigningPolicy
        // GraphQL -> tokenResponseSigningPolicy: EntraIdTokenResponseSigningPolicy! (enum)
        if (ec.Includes("tokenResponseSigningPolicy",true))
        {
            if(this.TokenResponseSigningPolicy == null) {

                this.TokenResponseSigningPolicy = new EntraIdTokenResponseSigningPolicy();

            } else {


            }
        }
        else if (this.TokenResponseSigningPolicy != null && ec.Excludes("tokenResponseSigningPolicy",true))
        {
            this.TokenResponseSigningPolicy = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? SamlTokenVersion
        // GraphQL -> samlTokenVersion: String! (scalar)
        if (ec.Includes("samlTokenVersion",true))
        {
            if(this.SamlTokenVersion == null) {

                this.SamlTokenVersion = "FETCH";

            } else {


            }
        }
        else if (this.SamlTokenVersion != null && ec.Excludes("samlTokenVersion",true))
        {
            this.SamlTokenVersion = null;
        }
    }


    #endregion

    } // class EntraIdTokenIssuancePolicy
    
    #endregion

    public static class ListEntraIdTokenIssuancePolicyExtensions
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
            this List<EntraIdTokenIssuancePolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdTokenIssuancePolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdTokenIssuancePolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdTokenIssuancePolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdTokenIssuancePolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types