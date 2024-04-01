// LdapIntegration.cs
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
    #region LdapIntegration
    public class LdapIntegration: BaseType
    {
        #region members

        //      C# -> System.String? BaseDn
        // GraphQL -> baseDn: String! (scalar)
        [JsonProperty("baseDn")]
        public System.String? BaseDn { get; set; }

        //      C# -> System.String? BindUserName
        // GraphQL -> bindUserName: String! (scalar)
        [JsonProperty("bindUserName")]
        public System.String? BindUserName { get; set; }

        //      C# -> System.String? DynamicDnsName
        // GraphQL -> dynamicDnsName: String! (scalar)
        [JsonProperty("dynamicDnsName")]
        public System.String? DynamicDnsName { get; set; }

        //      C# -> System.String? GroupMemberAttr
        // GraphQL -> groupMemberAttr: String (scalar)
        [JsonProperty("groupMemberAttr")]
        public System.String? GroupMemberAttr { get; set; }

        //      C# -> System.String? GroupMembershipAttr
        // GraphQL -> groupMembershipAttr: String (scalar)
        [JsonProperty("groupMembershipAttr")]
        public System.String? GroupMembershipAttr { get; set; }

        //      C# -> System.String? GroupSearchFilter
        // GraphQL -> groupSearchFilter: String (scalar)
        [JsonProperty("groupSearchFilter")]
        public System.String? GroupSearchFilter { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsTotpEnforced
        // GraphQL -> isTotpEnforced: Boolean! (scalar)
        [JsonProperty("isTotpEnforced")]
        public System.Boolean? IsTotpEnforced { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String (scalar)
        [JsonProperty("trustedCerts")]
        public System.String? TrustedCerts { get; set; }

        //      C# -> System.String? UserNameAttr
        // GraphQL -> userNameAttr: String (scalar)
        [JsonProperty("userNameAttr")]
        public System.String? UserNameAttr { get; set; }

        //      C# -> System.String? UserSearchFilter
        // GraphQL -> userSearchFilter: String (scalar)
        [JsonProperty("userSearchFilter")]
        public System.String? UserSearchFilter { get; set; }

        //      C# -> List<LdapServer>? LdapServers
        // GraphQL -> ldapServers: [LdapServer!]! (type)
        [JsonProperty("ldapServers")]
        public List<LdapServer>? LdapServers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LdapIntegration";
    }

    public LdapIntegration Set(
        System.String? BaseDn = null,
        System.String? BindUserName = null,
        System.String? DynamicDnsName = null,
        System.String? GroupMemberAttr = null,
        System.String? GroupMembershipAttr = null,
        System.String? GroupSearchFilter = null,
        System.String? Id = null,
        System.Boolean? IsTotpEnforced = null,
        System.String? Name = null,
        System.String? TrustedCerts = null,
        System.String? UserNameAttr = null,
        System.String? UserSearchFilter = null,
        List<LdapServer>? LdapServers = null
    ) 
    {
        if ( BaseDn != null ) {
            this.BaseDn = BaseDn;
        }
        if ( BindUserName != null ) {
            this.BindUserName = BindUserName;
        }
        if ( DynamicDnsName != null ) {
            this.DynamicDnsName = DynamicDnsName;
        }
        if ( GroupMemberAttr != null ) {
            this.GroupMemberAttr = GroupMemberAttr;
        }
        if ( GroupMembershipAttr != null ) {
            this.GroupMembershipAttr = GroupMembershipAttr;
        }
        if ( GroupSearchFilter != null ) {
            this.GroupSearchFilter = GroupSearchFilter;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsTotpEnforced != null ) {
            this.IsTotpEnforced = IsTotpEnforced;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( TrustedCerts != null ) {
            this.TrustedCerts = TrustedCerts;
        }
        if ( UserNameAttr != null ) {
            this.UserNameAttr = UserNameAttr;
        }
        if ( UserSearchFilter != null ) {
            this.UserSearchFilter = UserSearchFilter;
        }
        if ( LdapServers != null ) {
            this.LdapServers = LdapServers;
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
        //      C# -> System.String? BaseDn
        // GraphQL -> baseDn: String! (scalar)
        if (this.BaseDn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "baseDn\n" ;
            } else {
                s += ind + "baseDn\n" ;
            }
        }
        //      C# -> System.String? BindUserName
        // GraphQL -> bindUserName: String! (scalar)
        if (this.BindUserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bindUserName\n" ;
            } else {
                s += ind + "bindUserName\n" ;
            }
        }
        //      C# -> System.String? DynamicDnsName
        // GraphQL -> dynamicDnsName: String! (scalar)
        if (this.DynamicDnsName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dynamicDnsName\n" ;
            } else {
                s += ind + "dynamicDnsName\n" ;
            }
        }
        //      C# -> System.String? GroupMemberAttr
        // GraphQL -> groupMemberAttr: String (scalar)
        if (this.GroupMemberAttr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupMemberAttr\n" ;
            } else {
                s += ind + "groupMemberAttr\n" ;
            }
        }
        //      C# -> System.String? GroupMembershipAttr
        // GraphQL -> groupMembershipAttr: String (scalar)
        if (this.GroupMembershipAttr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupMembershipAttr\n" ;
            } else {
                s += ind + "groupMembershipAttr\n" ;
            }
        }
        //      C# -> System.String? GroupSearchFilter
        // GraphQL -> groupSearchFilter: String (scalar)
        if (this.GroupSearchFilter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupSearchFilter\n" ;
            } else {
                s += ind + "groupSearchFilter\n" ;
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
        //      C# -> System.Boolean? IsTotpEnforced
        // GraphQL -> isTotpEnforced: Boolean! (scalar)
        if (this.IsTotpEnforced != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTotpEnforced\n" ;
            } else {
                s += ind + "isTotpEnforced\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String (scalar)
        if (this.TrustedCerts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "trustedCerts\n" ;
            } else {
                s += ind + "trustedCerts\n" ;
            }
        }
        //      C# -> System.String? UserNameAttr
        // GraphQL -> userNameAttr: String (scalar)
        if (this.UserNameAttr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userNameAttr\n" ;
            } else {
                s += ind + "userNameAttr\n" ;
            }
        }
        //      C# -> System.String? UserSearchFilter
        // GraphQL -> userSearchFilter: String (scalar)
        if (this.UserSearchFilter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userSearchFilter\n" ;
            } else {
                s += ind + "userSearchFilter\n" ;
            }
        }
        //      C# -> List<LdapServer>? LdapServers
        // GraphQL -> ldapServers: [LdapServer!]! (type)
        if (this.LdapServers != null) {
            var fspec = this.LdapServers.AsFieldSpec(conf.Child("ldapServers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ldapServers {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BaseDn
        // GraphQL -> baseDn: String! (scalar)
        if (ec.Includes("baseDn",true))
        {
            if(this.BaseDn == null) {

                this.BaseDn = "FETCH";

            } else {


            }
        }
        else if (this.BaseDn != null && ec.Excludes("baseDn",true))
        {
            this.BaseDn = null;
        }
        //      C# -> System.String? BindUserName
        // GraphQL -> bindUserName: String! (scalar)
        if (ec.Includes("bindUserName",true))
        {
            if(this.BindUserName == null) {

                this.BindUserName = "FETCH";

            } else {


            }
        }
        else if (this.BindUserName != null && ec.Excludes("bindUserName",true))
        {
            this.BindUserName = null;
        }
        //      C# -> System.String? DynamicDnsName
        // GraphQL -> dynamicDnsName: String! (scalar)
        if (ec.Includes("dynamicDnsName",true))
        {
            if(this.DynamicDnsName == null) {

                this.DynamicDnsName = "FETCH";

            } else {


            }
        }
        else if (this.DynamicDnsName != null && ec.Excludes("dynamicDnsName",true))
        {
            this.DynamicDnsName = null;
        }
        //      C# -> System.String? GroupMemberAttr
        // GraphQL -> groupMemberAttr: String (scalar)
        if (ec.Includes("groupMemberAttr",true))
        {
            if(this.GroupMemberAttr == null) {

                this.GroupMemberAttr = "FETCH";

            } else {


            }
        }
        else if (this.GroupMemberAttr != null && ec.Excludes("groupMemberAttr",true))
        {
            this.GroupMemberAttr = null;
        }
        //      C# -> System.String? GroupMembershipAttr
        // GraphQL -> groupMembershipAttr: String (scalar)
        if (ec.Includes("groupMembershipAttr",true))
        {
            if(this.GroupMembershipAttr == null) {

                this.GroupMembershipAttr = "FETCH";

            } else {


            }
        }
        else if (this.GroupMembershipAttr != null && ec.Excludes("groupMembershipAttr",true))
        {
            this.GroupMembershipAttr = null;
        }
        //      C# -> System.String? GroupSearchFilter
        // GraphQL -> groupSearchFilter: String (scalar)
        if (ec.Includes("groupSearchFilter",true))
        {
            if(this.GroupSearchFilter == null) {

                this.GroupSearchFilter = "FETCH";

            } else {


            }
        }
        else if (this.GroupSearchFilter != null && ec.Excludes("groupSearchFilter",true))
        {
            this.GroupSearchFilter = null;
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
        //      C# -> System.Boolean? IsTotpEnforced
        // GraphQL -> isTotpEnforced: Boolean! (scalar)
        if (ec.Includes("isTotpEnforced",true))
        {
            if(this.IsTotpEnforced == null) {

                this.IsTotpEnforced = true;

            } else {


            }
        }
        else if (this.IsTotpEnforced != null && ec.Excludes("isTotpEnforced",true))
        {
            this.IsTotpEnforced = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String (scalar)
        if (ec.Includes("trustedCerts",true))
        {
            if(this.TrustedCerts == null) {

                this.TrustedCerts = "FETCH";

            } else {


            }
        }
        else if (this.TrustedCerts != null && ec.Excludes("trustedCerts",true))
        {
            this.TrustedCerts = null;
        }
        //      C# -> System.String? UserNameAttr
        // GraphQL -> userNameAttr: String (scalar)
        if (ec.Includes("userNameAttr",true))
        {
            if(this.UserNameAttr == null) {

                this.UserNameAttr = "FETCH";

            } else {


            }
        }
        else if (this.UserNameAttr != null && ec.Excludes("userNameAttr",true))
        {
            this.UserNameAttr = null;
        }
        //      C# -> System.String? UserSearchFilter
        // GraphQL -> userSearchFilter: String (scalar)
        if (ec.Includes("userSearchFilter",true))
        {
            if(this.UserSearchFilter == null) {

                this.UserSearchFilter = "FETCH";

            } else {


            }
        }
        else if (this.UserSearchFilter != null && ec.Excludes("userSearchFilter",true))
        {
            this.UserSearchFilter = null;
        }
        //      C# -> List<LdapServer>? LdapServers
        // GraphQL -> ldapServers: [LdapServer!]! (type)
        if (ec.Includes("ldapServers",false))
        {
            if(this.LdapServers == null) {

                this.LdapServers = new List<LdapServer>();
                this.LdapServers.ApplyExploratoryFieldSpec(ec.NewChild("ldapServers"));

            } else {

                this.LdapServers.ApplyExploratoryFieldSpec(ec.NewChild("ldapServers"));

            }
        }
        else if (this.LdapServers != null && ec.Excludes("ldapServers",false))
        {
            this.LdapServers = null;
        }
    }


    #endregion

    } // class LdapIntegration
    
    #endregion

    public static class ListLdapIntegrationExtensions
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
            this List<LdapIntegration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LdapIntegration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LdapIntegration> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LdapIntegration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LdapIntegration> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types