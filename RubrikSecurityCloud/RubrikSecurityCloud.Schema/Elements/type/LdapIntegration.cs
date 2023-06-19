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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? BaseDn
        // GraphQL -> baseDn: String! (scalar)
        if (this.BaseDn != null) {
            s += ind + "baseDn\n" ;
        }
        //      C# -> System.String? BindUserName
        // GraphQL -> bindUserName: String! (scalar)
        if (this.BindUserName != null) {
            s += ind + "bindUserName\n" ;
        }
        //      C# -> System.String? DynamicDnsName
        // GraphQL -> dynamicDnsName: String! (scalar)
        if (this.DynamicDnsName != null) {
            s += ind + "dynamicDnsName\n" ;
        }
        //      C# -> System.String? GroupMemberAttr
        // GraphQL -> groupMemberAttr: String (scalar)
        if (this.GroupMemberAttr != null) {
            s += ind + "groupMemberAttr\n" ;
        }
        //      C# -> System.String? GroupMembershipAttr
        // GraphQL -> groupMembershipAttr: String (scalar)
        if (this.GroupMembershipAttr != null) {
            s += ind + "groupMembershipAttr\n" ;
        }
        //      C# -> System.String? GroupSearchFilter
        // GraphQL -> groupSearchFilter: String (scalar)
        if (this.GroupSearchFilter != null) {
            s += ind + "groupSearchFilter\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsTotpEnforced
        // GraphQL -> isTotpEnforced: Boolean! (scalar)
        if (this.IsTotpEnforced != null) {
            s += ind + "isTotpEnforced\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String (scalar)
        if (this.TrustedCerts != null) {
            s += ind + "trustedCerts\n" ;
        }
        //      C# -> System.String? UserNameAttr
        // GraphQL -> userNameAttr: String (scalar)
        if (this.UserNameAttr != null) {
            s += ind + "userNameAttr\n" ;
        }
        //      C# -> System.String? UserSearchFilter
        // GraphQL -> userSearchFilter: String (scalar)
        if (this.UserSearchFilter != null) {
            s += ind + "userSearchFilter\n" ;
        }
        //      C# -> List<LdapServer>? LdapServers
        // GraphQL -> ldapServers: [LdapServer!]! (type)
        if (this.LdapServers != null) {
            var fspec = this.LdapServers.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ldapServers {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? BaseDn
        // GraphQL -> baseDn: String! (scalar)
        if (this.BaseDn == null && Exploration.Includes(parent + ".baseDn", true))
        {
            this.BaseDn = "FETCH";
        }
        //      C# -> System.String? BindUserName
        // GraphQL -> bindUserName: String! (scalar)
        if (this.BindUserName == null && Exploration.Includes(parent + ".bindUserName", true))
        {
            this.BindUserName = "FETCH";
        }
        //      C# -> System.String? DynamicDnsName
        // GraphQL -> dynamicDnsName: String! (scalar)
        if (this.DynamicDnsName == null && Exploration.Includes(parent + ".dynamicDnsName", true))
        {
            this.DynamicDnsName = "FETCH";
        }
        //      C# -> System.String? GroupMemberAttr
        // GraphQL -> groupMemberAttr: String (scalar)
        if (this.GroupMemberAttr == null && Exploration.Includes(parent + ".groupMemberAttr", true))
        {
            this.GroupMemberAttr = "FETCH";
        }
        //      C# -> System.String? GroupMembershipAttr
        // GraphQL -> groupMembershipAttr: String (scalar)
        if (this.GroupMembershipAttr == null && Exploration.Includes(parent + ".groupMembershipAttr", true))
        {
            this.GroupMembershipAttr = "FETCH";
        }
        //      C# -> System.String? GroupSearchFilter
        // GraphQL -> groupSearchFilter: String (scalar)
        if (this.GroupSearchFilter == null && Exploration.Includes(parent + ".groupSearchFilter", true))
        {
            this.GroupSearchFilter = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsTotpEnforced
        // GraphQL -> isTotpEnforced: Boolean! (scalar)
        if (this.IsTotpEnforced == null && Exploration.Includes(parent + ".isTotpEnforced", true))
        {
            this.IsTotpEnforced = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String (scalar)
        if (this.TrustedCerts == null && Exploration.Includes(parent + ".trustedCerts", true))
        {
            this.TrustedCerts = "FETCH";
        }
        //      C# -> System.String? UserNameAttr
        // GraphQL -> userNameAttr: String (scalar)
        if (this.UserNameAttr == null && Exploration.Includes(parent + ".userNameAttr", true))
        {
            this.UserNameAttr = "FETCH";
        }
        //      C# -> System.String? UserSearchFilter
        // GraphQL -> userSearchFilter: String (scalar)
        if (this.UserSearchFilter == null && Exploration.Includes(parent + ".userSearchFilter", true))
        {
            this.UserSearchFilter = "FETCH";
        }
        //      C# -> List<LdapServer>? LdapServers
        // GraphQL -> ldapServers: [LdapServer!]! (type)
        if (this.LdapServers == null && Exploration.Includes(parent + ".ldapServers"))
        {
            this.LdapServers = new List<LdapServer>();
            this.LdapServers.ApplyExploratoryFieldSpec(parent + ".ldapServers");
        }
    }


    #endregion

    } // class LdapIntegration
    
    #endregion

    public static class ListLdapIntegrationExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<LdapIntegration> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LdapIntegration> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LdapIntegration());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types