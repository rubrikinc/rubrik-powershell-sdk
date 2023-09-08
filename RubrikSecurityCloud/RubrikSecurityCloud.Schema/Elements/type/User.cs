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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> PasskeyMetadata? PasskeyMetadata
        // GraphQL -> passkeyMetadata: PasskeyMetadata! (type)
        [JsonProperty("passkeyMetadata")]
        public PasskeyMetadata? PasskeyMetadata { get; set; }

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

    public override string GetGqlTypeName() {
        return "User";
    }

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
        PasskeyMetadata? PasskeyMetadata = null,
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
        if ( PasskeyMetadata != null ) {
            this.PasskeyMetadata = PasskeyMetadata;
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
        //      C# -> PasskeyMetadata? PasskeyMetadata
        // GraphQL -> passkeyMetadata: PasskeyMetadata! (type)
        if (this.PasskeyMetadata != null) {
            var fspec = this.PasskeyMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "passkeyMetadata {\n" + fspec + ind + "}\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserDomainEnum? Domain
        // GraphQL -> domain: UserDomainEnum! (enum)
        if (this.Domain == null && ec.Includes("domain",true))
        {
            this.Domain = new UserDomainEnum();
        }
        //      C# -> UserStatus? Status
        // GraphQL -> status: UserStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new UserStatus();
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email == null && ec.Includes("email",true))
        {
            this.Email = "FETCH";
        }
        //      C# -> List<System.String>? Groups
        // GraphQL -> groups: [String!]! (scalar)
        if (this.Groups == null && ec.Includes("groups",true))
        {
            this.Groups = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsAccountOwner
        // GraphQL -> isAccountOwner: Boolean! (scalar)
        if (this.IsAccountOwner == null && ec.Includes("isAccountOwner",true))
        {
            this.IsAccountOwner = true;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden == null && ec.Includes("isHidden",true))
        {
            this.IsHidden = true;
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin == null && ec.Includes("lastLogin",true))
        {
            this.LastLogin = new DateTime();
        }
        //      C# -> System.Int64? UnreadCount
        // GraphQL -> unreadCount: Long! (scalar)
        if (this.UnreadCount == null && ec.Includes("unreadCount",true))
        {
            this.UnreadCount = new System.Int64();
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && ec.Includes("username",true))
        {
            this.Username = "FETCH";
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && ec.Includes("allOrgs",false))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));
        }
        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        if (this.EmailConfig == null && ec.Includes("emailConfig",false))
        {
            this.EmailConfig = new List<EventDigest>();
            this.EmailConfig.ApplyExploratoryFieldSpec(ec.NewChild("emailConfig"));
        }
        //      C# -> EulaState? EulaState
        // GraphQL -> eulaState: EulaState! (type)
        if (this.EulaState == null && ec.Includes("eulaState",false))
        {
            this.EulaState = new EulaState();
            this.EulaState.ApplyExploratoryFieldSpec(ec.NewChild("eulaState"));
        }
        //      C# -> LockoutState? LockoutState
        // GraphQL -> lockoutState: LockoutState! (type)
        if (this.LockoutState == null && ec.Includes("lockoutState",false))
        {
            this.LockoutState = new LockoutState();
            this.LockoutState.ApplyExploratoryFieldSpec(ec.NewChild("lockoutState"));
        }
        //      C# -> PasskeyMetadata? PasskeyMetadata
        // GraphQL -> passkeyMetadata: PasskeyMetadata! (type)
        if (this.PasskeyMetadata == null && ec.Includes("passkeyMetadata",false))
        {
            this.PasskeyMetadata = new PasskeyMetadata();
            this.PasskeyMetadata.ApplyExploratoryFieldSpec(ec.NewChild("passkeyMetadata"));
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles == null && ec.Includes("roles",false))
        {
            this.Roles = new List<Role>();
            this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));
        }
        //      C# -> TotpStatus? TotpStatus
        // GraphQL -> totpStatus: TotpStatus! (type)
        if (this.TotpStatus == null && ec.Includes("totpStatus",false))
        {
            this.TotpStatus = new TotpStatus();
            this.TotpStatus.ApplyExploratoryFieldSpec(ec.NewChild("totpStatus"));
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
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new User());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<User> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types