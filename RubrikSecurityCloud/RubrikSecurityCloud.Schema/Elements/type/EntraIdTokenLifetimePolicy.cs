// EntraIdTokenLifetimePolicy.cs
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
    #region EntraIdTokenLifetimePolicy
    public class EntraIdTokenLifetimePolicy: BaseType
    {
        #region members

        //      C# -> System.String? AccessTokenLifetime
        // GraphQL -> accessTokenLifetime: String! (scalar)
        [JsonProperty("accessTokenLifetime")]
        public System.String? AccessTokenLifetime { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsOrganizationDefault
        // GraphQL -> isOrganizationDefault: Boolean! (scalar)
        [JsonProperty("isOrganizationDefault")]
        public System.Boolean? IsOrganizationDefault { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIdTokenLifetimePolicy";
    }

    public EntraIdTokenLifetimePolicy Set(
        System.String? AccessTokenLifetime = null,
        System.String? DisplayName = null,
        System.String? Id = null,
        System.Boolean? IsOrganizationDefault = null
    ) 
    {
        if ( AccessTokenLifetime != null ) {
            this.AccessTokenLifetime = AccessTokenLifetime;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsOrganizationDefault != null ) {
            this.IsOrganizationDefault = IsOrganizationDefault;
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
        //      C# -> System.String? AccessTokenLifetime
        // GraphQL -> accessTokenLifetime: String! (scalar)
        if (this.AccessTokenLifetime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessTokenLifetime\n" ;
            } else {
                s += ind + "accessTokenLifetime\n" ;
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
        //      C# -> System.Boolean? IsOrganizationDefault
        // GraphQL -> isOrganizationDefault: Boolean! (scalar)
        if (this.IsOrganizationDefault != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOrganizationDefault\n" ;
            } else {
                s += ind + "isOrganizationDefault\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AccessTokenLifetime
        // GraphQL -> accessTokenLifetime: String! (scalar)
        if (ec.Includes("accessTokenLifetime",true))
        {
            if(this.AccessTokenLifetime == null) {

                this.AccessTokenLifetime = "FETCH";

            } else {


            }
        }
        else if (this.AccessTokenLifetime != null && ec.Excludes("accessTokenLifetime",true))
        {
            this.AccessTokenLifetime = null;
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
        //      C# -> System.Boolean? IsOrganizationDefault
        // GraphQL -> isOrganizationDefault: Boolean! (scalar)
        if (ec.Includes("isOrganizationDefault",true))
        {
            if(this.IsOrganizationDefault == null) {

                this.IsOrganizationDefault = true;

            } else {


            }
        }
        else if (this.IsOrganizationDefault != null && ec.Excludes("isOrganizationDefault",true))
        {
            this.IsOrganizationDefault = null;
        }
    }


    #endregion

    } // class EntraIdTokenLifetimePolicy
    
    #endregion

    public static class ListEntraIdTokenLifetimePolicyExtensions
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
            this List<EntraIdTokenLifetimePolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdTokenLifetimePolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdTokenLifetimePolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdTokenLifetimePolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdTokenLifetimePolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types