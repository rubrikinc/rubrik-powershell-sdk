// AzureAdAdministrativeUnit.cs
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
    #region AzureAdAdministrativeUnit
    public class AzureAdAdministrativeUnit: BaseType
    {
        #region members

        //      C# -> AzureAdAdminUnitMembershipEnumType? MembershipType
        // GraphQL -> membershipType: AzureAdAdminUnitMembershipEnumType! (enum)
        [JsonProperty("membershipType")]
        public AzureAdAdminUnitMembershipEnumType? MembershipType { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? RestrictedManagement
        // GraphQL -> restrictedManagement: Boolean! (scalar)
        [JsonProperty("restrictedManagement")]
        public System.Boolean? RestrictedManagement { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdAdministrativeUnit";
    }

    public AzureAdAdministrativeUnit Set(
        AzureAdAdminUnitMembershipEnumType? MembershipType = null,
        System.String? Description = null,
        System.String? DisplayName = null,
        System.Boolean? RestrictedManagement = null
    ) 
    {
        if ( MembershipType != null ) {
            this.MembershipType = MembershipType;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( RestrictedManagement != null ) {
            this.RestrictedManagement = RestrictedManagement;
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
        //      C# -> AzureAdAdminUnitMembershipEnumType? MembershipType
        // GraphQL -> membershipType: AzureAdAdminUnitMembershipEnumType! (enum)
        if (this.MembershipType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "membershipType\n" ;
            } else {
                s += ind + "membershipType\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
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
        //      C# -> System.Boolean? RestrictedManagement
        // GraphQL -> restrictedManagement: Boolean! (scalar)
        if (this.RestrictedManagement != null) {
            if (conf.Flat) {
                s += conf.Prefix + "restrictedManagement\n" ;
            } else {
                s += ind + "restrictedManagement\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdAdminUnitMembershipEnumType? MembershipType
        // GraphQL -> membershipType: AzureAdAdminUnitMembershipEnumType! (enum)
        if (ec.Includes("membershipType",true))
        {
            if(this.MembershipType == null) {

                this.MembershipType = new AzureAdAdminUnitMembershipEnumType();

            } else {


            }
        }
        else if (this.MembershipType != null && ec.Excludes("membershipType",true))
        {
            this.MembershipType = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
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
        //      C# -> System.Boolean? RestrictedManagement
        // GraphQL -> restrictedManagement: Boolean! (scalar)
        if (ec.Includes("restrictedManagement",true))
        {
            if(this.RestrictedManagement == null) {

                this.RestrictedManagement = true;

            } else {


            }
        }
        else if (this.RestrictedManagement != null && ec.Excludes("restrictedManagement",true))
        {
            this.RestrictedManagement = null;
        }
    }


    #endregion

    } // class AzureAdAdministrativeUnit
    
    #endregion

    public static class ListAzureAdAdministrativeUnitExtensions
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
            this List<AzureAdAdministrativeUnit> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdAdministrativeUnit> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdAdministrativeUnit> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdAdministrativeUnit());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdAdministrativeUnit> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types