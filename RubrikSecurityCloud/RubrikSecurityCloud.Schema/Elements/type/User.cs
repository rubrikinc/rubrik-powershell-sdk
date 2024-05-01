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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> UserDomainEnum? Domain
        // GraphQL -> domain: UserDomainEnum! (enum)
        if (this.Domain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domain\n" ;
            } else {
                s += ind + "domain\n" ;
            }
        }
        //      C# -> UserStatus? Status
        // GraphQL -> status: UserStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            if (conf.Flat) {
                s += conf.Prefix + "email\n" ;
            } else {
                s += ind + "email\n" ;
            }
        }
        //      C# -> List<System.String>? Groups
        // GraphQL -> groups: [String!]! (scalar)
        if (this.Groups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groups\n" ;
            } else {
                s += ind + "groups\n" ;
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
        //      C# -> System.Boolean? IsAccountOwner
        // GraphQL -> isAccountOwner: Boolean! (scalar)
        if (this.IsAccountOwner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAccountOwner\n" ;
            } else {
                s += ind + "isAccountOwner\n" ;
            }
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHidden\n" ;
            } else {
                s += ind + "isHidden\n" ;
            }
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastLogin\n" ;
            } else {
                s += ind + "lastLogin\n" ;
            }
        }
        //      C# -> System.Int64? UnreadCount
        // GraphQL -> unreadCount: Long! (scalar)
        if (this.UnreadCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unreadCount\n" ;
            } else {
                s += ind + "unreadCount\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        if (this.EmailConfig != null) {
            var fspec = this.EmailConfig.AsFieldSpec(conf.Child("emailConfig"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "emailConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> EulaState? EulaState
        // GraphQL -> eulaState: EulaState! (type)
        if (this.EulaState != null) {
            var fspec = this.EulaState.AsFieldSpec(conf.Child("eulaState"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "eulaState" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LockoutState? LockoutState
        // GraphQL -> lockoutState: LockoutState! (type)
        if (this.LockoutState != null) {
            var fspec = this.LockoutState.AsFieldSpec(conf.Child("lockoutState"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lockoutState" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PasskeyMetadata? PasskeyMetadata
        // GraphQL -> passkeyMetadata: PasskeyMetadata! (type)
        if (this.PasskeyMetadata != null) {
            var fspec = this.PasskeyMetadata.AsFieldSpec(conf.Child("passkeyMetadata"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "passkeyMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TotpStatus? TotpStatus
        // GraphQL -> totpStatus: TotpStatus! (type)
        if (this.TotpStatus != null) {
            var fspec = this.TotpStatus.AsFieldSpec(conf.Child("totpStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totpStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UserDomainEnum? Domain
        // GraphQL -> domain: UserDomainEnum! (enum)
        if (ec.Includes("domain",true))
        {
            if(this.Domain == null) {

                this.Domain = new UserDomainEnum();

            } else {


            }
        }
        else if (this.Domain != null && ec.Excludes("domain",true))
        {
            this.Domain = null;
        }
        //      C# -> UserStatus? Status
        // GraphQL -> status: UserStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new UserStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (ec.Includes("email",true))
        {
            if(this.Email == null) {

                this.Email = "FETCH";

            } else {


            }
        }
        else if (this.Email != null && ec.Excludes("email",true))
        {
            this.Email = null;
        }
        //      C# -> List<System.String>? Groups
        // GraphQL -> groups: [String!]! (scalar)
        if (ec.Includes("groups",true))
        {
            if(this.Groups == null) {

                this.Groups = new List<System.String>();

            } else {


            }
        }
        else if (this.Groups != null && ec.Excludes("groups",true))
        {
            this.Groups = null;
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
        //      C# -> System.Boolean? IsAccountOwner
        // GraphQL -> isAccountOwner: Boolean! (scalar)
        if (ec.Includes("isAccountOwner",true))
        {
            if(this.IsAccountOwner == null) {

                this.IsAccountOwner = true;

            } else {


            }
        }
        else if (this.IsAccountOwner != null && ec.Excludes("isAccountOwner",true))
        {
            this.IsAccountOwner = null;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (ec.Includes("isHidden",true))
        {
            if(this.IsHidden == null) {

                this.IsHidden = true;

            } else {


            }
        }
        else if (this.IsHidden != null && ec.Excludes("isHidden",true))
        {
            this.IsHidden = null;
        }
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (ec.Includes("lastLogin",true))
        {
            if(this.LastLogin == null) {

                this.LastLogin = new DateTime();

            } else {


            }
        }
        else if (this.LastLogin != null && ec.Excludes("lastLogin",true))
        {
            this.LastLogin = null;
        }
        //      C# -> System.Int64? UnreadCount
        // GraphQL -> unreadCount: Long! (scalar)
        if (ec.Includes("unreadCount",true))
        {
            if(this.UnreadCount == null) {

                this.UnreadCount = new System.Int64();

            } else {


            }
        }
        else if (this.UnreadCount != null && ec.Excludes("unreadCount",true))
        {
            this.UnreadCount = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (ec.Includes("allOrgs",false))
        {
            if(this.AllOrgs == null) {

                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            } else {

                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            }
        }
        else if (this.AllOrgs != null && ec.Excludes("allOrgs",false))
        {
            this.AllOrgs = null;
        }
        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        if (ec.Includes("emailConfig",false))
        {
            if(this.EmailConfig == null) {

                this.EmailConfig = new List<EventDigest>();
                this.EmailConfig.ApplyExploratoryFieldSpec(ec.NewChild("emailConfig"));

            } else {

                this.EmailConfig.ApplyExploratoryFieldSpec(ec.NewChild("emailConfig"));

            }
        }
        else if (this.EmailConfig != null && ec.Excludes("emailConfig",false))
        {
            this.EmailConfig = null;
        }
        //      C# -> EulaState? EulaState
        // GraphQL -> eulaState: EulaState! (type)
        if (ec.Includes("eulaState",false))
        {
            if(this.EulaState == null) {

                this.EulaState = new EulaState();
                this.EulaState.ApplyExploratoryFieldSpec(ec.NewChild("eulaState"));

            } else {

                this.EulaState.ApplyExploratoryFieldSpec(ec.NewChild("eulaState"));

            }
        }
        else if (this.EulaState != null && ec.Excludes("eulaState",false))
        {
            this.EulaState = null;
        }
        //      C# -> LockoutState? LockoutState
        // GraphQL -> lockoutState: LockoutState! (type)
        if (ec.Includes("lockoutState",false))
        {
            if(this.LockoutState == null) {

                this.LockoutState = new LockoutState();
                this.LockoutState.ApplyExploratoryFieldSpec(ec.NewChild("lockoutState"));

            } else {

                this.LockoutState.ApplyExploratoryFieldSpec(ec.NewChild("lockoutState"));

            }
        }
        else if (this.LockoutState != null && ec.Excludes("lockoutState",false))
        {
            this.LockoutState = null;
        }
        //      C# -> PasskeyMetadata? PasskeyMetadata
        // GraphQL -> passkeyMetadata: PasskeyMetadata! (type)
        if (ec.Includes("passkeyMetadata",false))
        {
            if(this.PasskeyMetadata == null) {

                this.PasskeyMetadata = new PasskeyMetadata();
                this.PasskeyMetadata.ApplyExploratoryFieldSpec(ec.NewChild("passkeyMetadata"));

            } else {

                this.PasskeyMetadata.ApplyExploratoryFieldSpec(ec.NewChild("passkeyMetadata"));

            }
        }
        else if (this.PasskeyMetadata != null && ec.Excludes("passkeyMetadata",false))
        {
            this.PasskeyMetadata = null;
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (ec.Includes("roles",false))
        {
            if(this.Roles == null) {

                this.Roles = new List<Role>();
                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            } else {

                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            }
        }
        else if (this.Roles != null && ec.Excludes("roles",false))
        {
            this.Roles = null;
        }
        //      C# -> TotpStatus? TotpStatus
        // GraphQL -> totpStatus: TotpStatus! (type)
        if (ec.Includes("totpStatus",false))
        {
            if(this.TotpStatus == null) {

                this.TotpStatus = new TotpStatus();
                this.TotpStatus.ApplyExploratoryFieldSpec(ec.NewChild("totpStatus"));

            } else {

                this.TotpStatus.ApplyExploratoryFieldSpec(ec.NewChild("totpStatus"));

            }
        }
        else if (this.TotpStatus != null && ec.Excludes("totpStatus",false))
        {
            this.TotpStatus = null;
        }
    }


    #endregion

    } // class User
    
    #endregion

    public static class ListUserExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<User> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<User> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<User> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types