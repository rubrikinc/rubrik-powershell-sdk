// AuthorizedPrincipal.cs
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
    #region AuthorizedPrincipal
    public class AuthorizedPrincipal: BaseType
    {
        #region members

        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        [JsonProperty("principalType")]
        public PrincipalTypeEnum? PrincipalType { get; set; }

        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        [JsonProperty("authDomainId")]
        public System.String? AuthDomainId { get; set; }

        //      C# -> System.String? AuthDomainName
        // GraphQL -> authDomainName: String! (scalar)
        [JsonProperty("authDomainName")]
        public System.String? AuthDomainName { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        [JsonProperty("lastLogin")]
        public DateTime? LastLogin { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        [JsonProperty("emailConfig")]
        public List<EventDigest>? EmailConfig { get; set; }

        //      C# -> LdapLockoutStatus? LockoutStatus
        // GraphQL -> lockoutStatus: LdapLockoutStatus (type)
        [JsonProperty("lockoutStatus")]
        public LdapLockoutStatus? LockoutStatus { get; set; }

        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        [JsonProperty("roles")]
        public List<Role>? Roles { get; set; }

        //      C# -> LdapTotpStatus? TotpStatus
        // GraphQL -> totpStatus: LdapTotpStatus (type)
        [JsonProperty("totpStatus")]
        public LdapTotpStatus? TotpStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AuthorizedPrincipal";
    }

    public AuthorizedPrincipal Set(
        PrincipalTypeEnum? PrincipalType = null,
        System.String? AuthDomainId = null,
        System.String? AuthDomainName = null,
        System.String? Email = null,
        System.String? Id = null,
        DateTime? LastLogin = null,
        System.String? Name = null,
        List<EventDigest>? EmailConfig = null,
        LdapLockoutStatus? LockoutStatus = null,
        List<Role>? Roles = null,
        LdapTotpStatus? TotpStatus = null
    ) 
    {
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( AuthDomainId != null ) {
            this.AuthDomainId = AuthDomainId;
        }
        if ( AuthDomainName != null ) {
            this.AuthDomainName = AuthDomainName;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastLogin != null ) {
            this.LastLogin = LastLogin;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( EmailConfig != null ) {
            this.EmailConfig = EmailConfig;
        }
        if ( LockoutStatus != null ) {
            this.LockoutStatus = LockoutStatus;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        if (this.AuthDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authDomainId\n" ;
            } else {
                s += ind + "authDomainId\n" ;
            }
        }
        //      C# -> System.String? AuthDomainName
        // GraphQL -> authDomainName: String! (scalar)
        if (this.AuthDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authDomainName\n" ;
            } else {
                s += ind + "authDomainName\n" ;
            }
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        if (this.Email != null) {
            if (conf.Flat) {
                s += conf.Prefix + "email\n" ;
            } else {
                s += ind + "email\n" ;
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
        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        if (this.LastLogin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastLogin\n" ;
            } else {
                s += ind + "lastLogin\n" ;
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
        //      C# -> List<EventDigest>? EmailConfig
        // GraphQL -> emailConfig: [EventDigest!]! (type)
        if (this.EmailConfig != null) {
            var fspec = this.EmailConfig.AsFieldSpec(conf.Child("emailConfig"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "emailConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LdapLockoutStatus? LockoutStatus
        // GraphQL -> lockoutStatus: LdapLockoutStatus (type)
        if (this.LockoutStatus != null) {
            var fspec = this.LockoutStatus.AsFieldSpec(conf.Child("lockoutStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lockoutStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Role>? Roles
        // GraphQL -> roles: [Role!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LdapTotpStatus? TotpStatus
        // GraphQL -> totpStatus: LdapTotpStatus (type)
        if (this.TotpStatus != null) {
            var fspec = this.TotpStatus.AsFieldSpec(conf.Child("totpStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
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
        //      C# -> PrincipalTypeEnum? PrincipalType
        // GraphQL -> principalType: PrincipalTypeEnum! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new PrincipalTypeEnum();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        if (ec.Includes("authDomainId",true))
        {
            if(this.AuthDomainId == null) {

                this.AuthDomainId = "FETCH";

            } else {


            }
        }
        else if (this.AuthDomainId != null && ec.Excludes("authDomainId",true))
        {
            this.AuthDomainId = null;
        }
        //      C# -> System.String? AuthDomainName
        // GraphQL -> authDomainName: String! (scalar)
        if (ec.Includes("authDomainName",true))
        {
            if(this.AuthDomainName == null) {

                this.AuthDomainName = "FETCH";

            } else {


            }
        }
        else if (this.AuthDomainName != null && ec.Excludes("authDomainName",true))
        {
            this.AuthDomainName = null;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
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
        //      C# -> LdapLockoutStatus? LockoutStatus
        // GraphQL -> lockoutStatus: LdapLockoutStatus (type)
        if (ec.Includes("lockoutStatus",false))
        {
            if(this.LockoutStatus == null) {

                this.LockoutStatus = new LdapLockoutStatus();
                this.LockoutStatus.ApplyExploratoryFieldSpec(ec.NewChild("lockoutStatus"));

            } else {

                this.LockoutStatus.ApplyExploratoryFieldSpec(ec.NewChild("lockoutStatus"));

            }
        }
        else if (this.LockoutStatus != null && ec.Excludes("lockoutStatus",false))
        {
            this.LockoutStatus = null;
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
        //      C# -> LdapTotpStatus? TotpStatus
        // GraphQL -> totpStatus: LdapTotpStatus (type)
        if (ec.Includes("totpStatus",false))
        {
            if(this.TotpStatus == null) {

                this.TotpStatus = new LdapTotpStatus();
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

    } // class AuthorizedPrincipal
    
    #endregion

    public static class ListAuthorizedPrincipalExtensions
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
            this List<AuthorizedPrincipal> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AuthorizedPrincipal> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AuthorizedPrincipal> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthorizedPrincipal());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AuthorizedPrincipal> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types