// EntraIdGroupMetadataProperties.cs
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
    #region EntraIdGroupMetadataProperties
 
    public class EntraIdGroupMetadataProperties: BaseType, PrincipalMetadata
    {
        #region members

        //      C# -> EntraIdGroupType? GroupType
        // GraphQL -> groupType: EntraIDGroupType! (enum)
        [JsonProperty("groupType")]
        public EntraIdGroupType? GroupType { get; set; }

        //      C# -> System.Boolean? ContainsGuestMember
        // GraphQL -> containsGuestMember: Boolean! (scalar)
        [JsonProperty("containsGuestMember")]
        public System.Boolean? ContainsGuestMember { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<System.String>? RoleNames
        // GraphQL -> roleNames: [String!]! (scalar)
        [JsonProperty("roleNames")]
        public List<System.String>? RoleNames { get; set; }

        //      C# -> List<System.String>? UnprivilegedOwners
        // GraphQL -> unprivilegedOwners: [String!]! (scalar)
        [JsonProperty("unprivilegedOwners")]
        public List<System.String>? UnprivilegedOwners { get; set; }

        //      C# -> List<System.String>? UnprivilegedOwnersNames
        // GraphQL -> unprivilegedOwnersNames: [String!]! (scalar)
        [JsonProperty("unprivilegedOwnersNames")]
        public List<System.String>? UnprivilegedOwnersNames { get; set; }

        //      C# -> List<EntraIdOwner>? Owners
        // GraphQL -> owners: [EntraIDOwner!]! (type)
        [JsonProperty("owners")]
        public List<EntraIdOwner>? Owners { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDGroupMetadataProperties";
    }

    public EntraIdGroupMetadataProperties Set(
        EntraIdGroupType? GroupType = null,
        System.Boolean? ContainsGuestMember = null,
        System.String? Description = null,
        List<System.String>? RoleNames = null,
        List<System.String>? UnprivilegedOwners = null,
        List<System.String>? UnprivilegedOwnersNames = null,
        List<EntraIdOwner>? Owners = null
    ) 
    {
        if ( GroupType != null ) {
            this.GroupType = GroupType;
        }
        if ( ContainsGuestMember != null ) {
            this.ContainsGuestMember = ContainsGuestMember;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( RoleNames != null ) {
            this.RoleNames = RoleNames;
        }
        if ( UnprivilegedOwners != null ) {
            this.UnprivilegedOwners = UnprivilegedOwners;
        }
        if ( UnprivilegedOwnersNames != null ) {
            this.UnprivilegedOwnersNames = UnprivilegedOwnersNames;
        }
        if ( Owners != null ) {
            this.Owners = Owners;
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
        //      C# -> EntraIdGroupType? GroupType
        // GraphQL -> groupType: EntraIDGroupType! (enum)
        if (this.GroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupType\n" ;
            } else {
                s += ind + "groupType\n" ;
            }
        }
        //      C# -> System.Boolean? ContainsGuestMember
        // GraphQL -> containsGuestMember: Boolean! (scalar)
        if (this.ContainsGuestMember != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containsGuestMember\n" ;
            } else {
                s += ind + "containsGuestMember\n" ;
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
        //      C# -> List<System.String>? RoleNames
        // GraphQL -> roleNames: [String!]! (scalar)
        if (this.RoleNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleNames\n" ;
            } else {
                s += ind + "roleNames\n" ;
            }
        }
        //      C# -> List<System.String>? UnprivilegedOwners
        // GraphQL -> unprivilegedOwners: [String!]! (scalar)
        if (this.UnprivilegedOwners != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprivilegedOwners\n" ;
            } else {
                s += ind + "unprivilegedOwners\n" ;
            }
        }
        //      C# -> List<System.String>? UnprivilegedOwnersNames
        // GraphQL -> unprivilegedOwnersNames: [String!]! (scalar)
        if (this.UnprivilegedOwnersNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprivilegedOwnersNames\n" ;
            } else {
                s += ind + "unprivilegedOwnersNames\n" ;
            }
        }
        //      C# -> List<EntraIdOwner>? Owners
        // GraphQL -> owners: [EntraIDOwner!]! (type)
        if (this.Owners != null) {
            var fspec = this.Owners.AsFieldSpec(conf.Child("owners"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "owners" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EntraIdGroupType? GroupType
        // GraphQL -> groupType: EntraIDGroupType! (enum)
        if (ec.Includes("groupType",true))
        {
            if(this.GroupType == null) {

                this.GroupType = new EntraIdGroupType();

            } else {


            }
        }
        else if (this.GroupType != null && ec.Excludes("groupType",true))
        {
            this.GroupType = null;
        }
        //      C# -> System.Boolean? ContainsGuestMember
        // GraphQL -> containsGuestMember: Boolean! (scalar)
        if (ec.Includes("containsGuestMember",true))
        {
            if(this.ContainsGuestMember == null) {

                this.ContainsGuestMember = true;

            } else {


            }
        }
        else if (this.ContainsGuestMember != null && ec.Excludes("containsGuestMember",true))
        {
            this.ContainsGuestMember = null;
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
        //      C# -> List<System.String>? RoleNames
        // GraphQL -> roleNames: [String!]! (scalar)
        if (ec.Includes("roleNames",true))
        {
            if(this.RoleNames == null) {

                this.RoleNames = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleNames != null && ec.Excludes("roleNames",true))
        {
            this.RoleNames = null;
        }
        //      C# -> List<System.String>? UnprivilegedOwners
        // GraphQL -> unprivilegedOwners: [String!]! (scalar)
        if (ec.Includes("unprivilegedOwners",true))
        {
            if(this.UnprivilegedOwners == null) {

                this.UnprivilegedOwners = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprivilegedOwners != null && ec.Excludes("unprivilegedOwners",true))
        {
            this.UnprivilegedOwners = null;
        }
        //      C# -> List<System.String>? UnprivilegedOwnersNames
        // GraphQL -> unprivilegedOwnersNames: [String!]! (scalar)
        if (ec.Includes("unprivilegedOwnersNames",true))
        {
            if(this.UnprivilegedOwnersNames == null) {

                this.UnprivilegedOwnersNames = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprivilegedOwnersNames != null && ec.Excludes("unprivilegedOwnersNames",true))
        {
            this.UnprivilegedOwnersNames = null;
        }
        //      C# -> List<EntraIdOwner>? Owners
        // GraphQL -> owners: [EntraIDOwner!]! (type)
        if (ec.Includes("owners",false))
        {
            if(this.Owners == null) {

                this.Owners = new List<EntraIdOwner>();
                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            } else {

                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            }
        }
        else if (this.Owners != null && ec.Excludes("owners",false))
        {
            this.Owners = null;
        }
    }


    #endregion

    } // class EntraIdGroupMetadataProperties
    
    #endregion

    public static class ListEntraIdGroupMetadataPropertiesExtensions
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
            this List<EntraIdGroupMetadataProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdGroupMetadataProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdGroupMetadataProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdGroupMetadataProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdGroupMetadataProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types