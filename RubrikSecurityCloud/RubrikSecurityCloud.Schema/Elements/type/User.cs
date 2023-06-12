// User.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region User
    public class User: BaseType
    {
        #region members

        //      C# -> UserDomainEnum? Domain
        // GraphQL -> domain: UserDomainEnum! (enum)
        [JsonProperty("domain")]
        public UserDomainEnum? Domain { get; set; }

        //      C# -> UserStatus? Status
        // GraphQL -> status: UserStatus! (enum)
        [JsonProperty("status")]
        public UserStatus? Status { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> List<System.String>? Groups
        // GraphQL -> groups: [String!]! (scalar)
        [JsonProperty("groups")]
        public List<System.String>? Groups { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsAccountOwner
        // GraphQL -> isAccountOwner: Boolean! (scalar)
        [JsonProperty("isAccountOwner")]
        public System.Boolean? IsAccountOwner { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }

        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        [JsonProperty("lastLogin")]
        public DateTime? LastLogin { get; set; }

        //      C# -> System.Int64? UnreadCount
        // GraphQL -> unreadCount: Long! (scalar)
        [JsonProperty("unreadCount")]
        public System.Int64? UnreadCount { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        [JsonProperty("emailConfig")]
        public List<EventDigest>? EmailConfig { get; set; }

        //      C# -> EulaState? EulaState
        // GraphQL -> eulaState: EulaState! (type)
        [JsonProperty("eulaState")]
        public EulaState? EulaState { get; set; }

        //      C# -> LockoutState? LockoutState
        // GraphQL -> lockoutState: LockoutState! (type)
        [JsonProperty("lockoutState")]
        public LockoutState? LockoutState { get; set; }

        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        [JsonProperty("roles")]
        public List<Role>? Roles { get; set; }

        //      C# -> TotpStatus? TotpStatus
        // GraphQL -> totpStatus: TotpStatus! (type)
        [JsonProperty("totpStatus")]
        public TotpStatus? TotpStatus { get; set; }


        #endregion

    #region methods

    public User Set(
        UserDomainEnum? Domain = null,
        UserStatus? Status = null,
        System.String? Email = null,
        List<System.String>? Groups = null,
        System.String? Id = null,
        System.Boolean? IsAccountOwner = null,
        System.Boolean? IsHidden = null,
        DateTime? LastLogin = null,
        System.Int64? UnreadCount = null,
        System.String? Username = null,
        List<Org>? AllOrgs = null,
        List<EventDigest>? EmailConfig = null,
        EulaState? EulaState = null,
        LockoutState? LockoutState = null,
        List<Role>? Roles = null,
        TotpStatus? TotpStatus = null
    ) 
    {
        if ( Domain != null ) {
            this.Domain = Domain;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsAccountOwner != null ) {
            this.IsAccountOwner = IsAccountOwner;
        }
        if ( IsHidden != null ) {
            this.IsHidden = IsHidden;
        }
        if ( LastLogin != null ) {
            this.LastLogin = LastLogin;
        }
        if ( UnreadCount != null ) {
            this.UnreadCount = UnreadCount;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( EmailConfig != null ) {
            this.EmailConfig = EmailConfig;
        }
        if ( EulaState != null ) {
            this.EulaState = EulaState;
        }
        if ( LockoutState != null ) {
            this.LockoutState = LockoutState;
        }
        if ( Roles != null ) {
            this.Roles = Roles;
        }
        if ( TotpStatus != null ) {
            this.TotpStatus = TotpStatus;
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
        //      C# -> UserDomainEnum? Domain
        // GraphQL -> domain: UserDomainEnum! (enum)
        if (this.Domain != null) {
            s += ind + "domain\n" ;
        }
        //      C# -> UserStatus? Status
        // GraphQL -> status: UserStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            s += ind + "email\n" ;
        }
        //      C# -> List<System.String>? Groups
        // GraphQL -> groups: [String!]! (scalar)
        if (this.Groups != null) {
            s += ind + "groups\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsAccountOwner
        // GraphQL -> isAccountOwner: Boolean! (scalar)
        if (this.IsAccountOwner != null) {
            s += ind + "isAccountOwner\n" ;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden != null) {
            s += ind + "isHidden\n" ;
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin != null) {
            s += ind + "lastLogin\n" ;
        }
        //      C# -> System.Int64? UnreadCount
        // GraphQL -> unreadCount: Long! (scalar)
        if (this.UnreadCount != null) {
            s += ind + "unreadCount\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        if (this.EmailConfig != null) {
            var fspec = this.EmailConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "emailConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> EulaState? EulaState
        // GraphQL -> eulaState: EulaState! (type)
        if (this.EulaState != null) {
            var fspec = this.EulaState.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "eulaState {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LockoutState? LockoutState
        // GraphQL -> lockoutState: LockoutState! (type)
        if (this.LockoutState != null) {
            var fspec = this.LockoutState.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lockoutState {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "roles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TotpStatus? TotpStatus
        // GraphQL -> totpStatus: TotpStatus! (type)
        if (this.TotpStatus != null) {
            var fspec = this.TotpStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totpStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> UserDomainEnum? Domain
        // GraphQL -> domain: UserDomainEnum! (enum)
        if (this.Domain == null && Exploration.Includes(parent + ".domain", true))
        {
            this.Domain = new UserDomainEnum();
        }
        //      C# -> UserStatus? Status
        // GraphQL -> status: UserStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new UserStatus();
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email == null && Exploration.Includes(parent + ".email", true))
        {
            this.Email = "FETCH";
        }
        //      C# -> List<System.String>? Groups
        // GraphQL -> groups: [String!]! (scalar)
        if (this.Groups == null && Exploration.Includes(parent + ".groups", true))
        {
            this.Groups = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsAccountOwner
        // GraphQL -> isAccountOwner: Boolean! (scalar)
        if (this.IsAccountOwner == null && Exploration.Includes(parent + ".isAccountOwner", true))
        {
            this.IsAccountOwner = true;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden == null && Exploration.Includes(parent + ".isHidden", true))
        {
            this.IsHidden = true;
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin == null && Exploration.Includes(parent + ".lastLogin", true))
        {
            this.LastLogin = new DateTime();
        }
        //      C# -> System.Int64? UnreadCount
        // GraphQL -> unreadCount: Long! (scalar)
        if (this.UnreadCount == null && Exploration.Includes(parent + ".unreadCount", true))
        {
            this.UnreadCount = new System.Int64();
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = "FETCH";
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        if (this.EmailConfig == null && Exploration.Includes(parent + ".emailConfig"))
        {
            this.EmailConfig = new List<EventDigest>();
            this.EmailConfig.ApplyExploratoryFieldSpec(parent + ".emailConfig");
        }
        //      C# -> EulaState? EulaState
        // GraphQL -> eulaState: EulaState! (type)
        if (this.EulaState == null && Exploration.Includes(parent + ".eulaState"))
        {
            this.EulaState = new EulaState();
            this.EulaState.ApplyExploratoryFieldSpec(parent + ".eulaState");
        }
        //      C# -> LockoutState? LockoutState
        // GraphQL -> lockoutState: LockoutState! (type)
        if (this.LockoutState == null && Exploration.Includes(parent + ".lockoutState"))
        {
            this.LockoutState = new LockoutState();
            this.LockoutState.ApplyExploratoryFieldSpec(parent + ".lockoutState");
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles == null && Exploration.Includes(parent + ".roles"))
        {
            this.Roles = new List<Role>();
            this.Roles.ApplyExploratoryFieldSpec(parent + ".roles");
        }
        //      C# -> TotpStatus? TotpStatus
        // GraphQL -> totpStatus: TotpStatus! (type)
        if (this.TotpStatus == null && Exploration.Includes(parent + ".totpStatus"))
        {
            this.TotpStatus = new TotpStatus();
            this.TotpStatus.ApplyExploratoryFieldSpec(parent + ".totpStatus");
        }
    }


    #endregion

    } // class User
    
    #endregion

    public static class ListUserExtensions
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
            this List<User> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<User> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new User());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types