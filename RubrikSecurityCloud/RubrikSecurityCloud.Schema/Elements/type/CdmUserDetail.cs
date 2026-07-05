// CdmUserDetail.cs
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
    #region CdmUserDetail
    public class CdmUserDetail: BaseType
    {
        #region members

        //      C# -> CdmUserType? UserType
        // GraphQL -> userType: CdmUserType (enum)
        [JsonProperty("userType")]
        public CdmUserType? UserType { get; set; }

        //      C# -> System.String? AuthDomainId
        // GraphQL -> authDomainId: String! (scalar)
        [JsonProperty("authDomainId")]
        public System.String? AuthDomainId { get; set; }

        //      C# -> System.String? ContactNumber
        // GraphQL -> contactNumber: String (scalar)
        [JsonProperty("contactNumber")]
        public System.String? ContactNumber { get; set; }

        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        [JsonProperty("createTime")]
        public System.String? CreateTime { get; set; }

        //      C# -> System.String? CreatedById
        // GraphQL -> createdById: String! (scalar)
        [JsonProperty("createdById")]
        public System.String? CreatedById { get; set; }

        //      C# -> System.String? EmailAddress
        // GraphQL -> emailAddress: String (scalar)
        [JsonProperty("emailAddress")]
        public System.String? EmailAddress { get; set; }

        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String (scalar)
        [JsonProperty("firstName")]
        public System.String? FirstName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? LastLoginTimeUtc
        // GraphQL -> lastLoginTimeUtc: String (scalar)
        [JsonProperty("lastLoginTimeUtc")]
        public System.String? LastLoginTimeUtc { get; set; }

        //      C# -> System.String? LastName
        // GraphQL -> lastName: String (scalar)
        [JsonProperty("lastName")]
        public System.String? LastName { get; set; }

        //      C# -> System.String? LastPasswordResetTimeUtc
        // GraphQL -> lastPasswordResetTimeUtc: String (scalar)
        [JsonProperty("lastPasswordResetTimeUtc")]
        public System.String? LastPasswordResetTimeUtc { get; set; }

        //      C# -> System.String? LastSshKeyUpdateTimeUtc
        // GraphQL -> lastSshKeyUpdateTimeUtc: String (scalar)
        [JsonProperty("lastSshKeyUpdateTimeUtc")]
        public System.String? LastSshKeyUpdateTimeUtc { get; set; }

        //      C# -> System.String? MfaServerId
        // GraphQL -> mfaServerId: String (scalar)
        [JsonProperty("mfaServerId")]
        public System.String? MfaServerId { get; set; }

        //      C# -> System.String? SshKey
        // GraphQL -> sshKey: String (scalar)
        [JsonProperty("sshKey")]
        public System.String? SshKey { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> CdmUserAccountStatus? Status
        // GraphQL -> status: CdmUserAccountStatus (type)
        [JsonProperty("status")]
        public CdmUserAccountStatus? Status { get; set; }

        //      C# -> CdmTotpStatusInternal? TotpStatus
        // GraphQL -> totpStatus: CdmTotpStatusInternal (type)
        [JsonProperty("totpStatus")]
        public CdmTotpStatusInternal? TotpStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmUserDetail";
    }

    public CdmUserDetail Set(
        CdmUserType? UserType = null,
        System.String? AuthDomainId = null,
        System.String? ContactNumber = null,
        System.String? CreateTime = null,
        System.String? CreatedById = null,
        System.String? EmailAddress = null,
        System.String? FirstName = null,
        System.String? Id = null,
        System.String? LastLoginTimeUtc = null,
        System.String? LastName = null,
        System.String? LastPasswordResetTimeUtc = null,
        System.String? LastSshKeyUpdateTimeUtc = null,
        System.String? MfaServerId = null,
        System.String? SshKey = null,
        System.String? Username = null,
        CdmUserAccountStatus? Status = null,
        CdmTotpStatusInternal? TotpStatus = null
    ) 
    {
        if ( UserType != null ) {
            this.UserType = UserType;
        }
        if ( AuthDomainId != null ) {
            this.AuthDomainId = AuthDomainId;
        }
        if ( ContactNumber != null ) {
            this.ContactNumber = ContactNumber;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( CreatedById != null ) {
            this.CreatedById = CreatedById;
        }
        if ( EmailAddress != null ) {
            this.EmailAddress = EmailAddress;
        }
        if ( FirstName != null ) {
            this.FirstName = FirstName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastLoginTimeUtc != null ) {
            this.LastLoginTimeUtc = LastLoginTimeUtc;
        }
        if ( LastName != null ) {
            this.LastName = LastName;
        }
        if ( LastPasswordResetTimeUtc != null ) {
            this.LastPasswordResetTimeUtc = LastPasswordResetTimeUtc;
        }
        if ( LastSshKeyUpdateTimeUtc != null ) {
            this.LastSshKeyUpdateTimeUtc = LastSshKeyUpdateTimeUtc;
        }
        if ( MfaServerId != null ) {
            this.MfaServerId = MfaServerId;
        }
        if ( SshKey != null ) {
            this.SshKey = SshKey;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> CdmUserType? UserType
        // GraphQL -> userType: CdmUserType (enum)
        if (this.UserType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userType\n" ;
            } else {
                s += ind + "userType\n" ;
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
        //      C# -> System.String? ContactNumber
        // GraphQL -> contactNumber: String (scalar)
        if (this.ContactNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contactNumber\n" ;
            } else {
                s += ind + "contactNumber\n" ;
            }
        }
        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        if (this.CreateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createTime\n" ;
            } else {
                s += ind + "createTime\n" ;
            }
        }
        //      C# -> System.String? CreatedById
        // GraphQL -> createdById: String! (scalar)
        if (this.CreatedById != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdById\n" ;
            } else {
                s += ind + "createdById\n" ;
            }
        }
        //      C# -> System.String? EmailAddress
        // GraphQL -> emailAddress: String (scalar)
        if (this.EmailAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "emailAddress\n" ;
            } else {
                s += ind + "emailAddress\n" ;
            }
        }
        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String (scalar)
        if (this.FirstName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstName\n" ;
            } else {
                s += ind + "firstName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? LastLoginTimeUtc
        // GraphQL -> lastLoginTimeUtc: String (scalar)
        if (this.LastLoginTimeUtc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastLoginTimeUtc\n" ;
            } else {
                s += ind + "lastLoginTimeUtc\n" ;
            }
        }
        //      C# -> System.String? LastName
        // GraphQL -> lastName: String (scalar)
        if (this.LastName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastName\n" ;
            } else {
                s += ind + "lastName\n" ;
            }
        }
        //      C# -> System.String? LastPasswordResetTimeUtc
        // GraphQL -> lastPasswordResetTimeUtc: String (scalar)
        if (this.LastPasswordResetTimeUtc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastPasswordResetTimeUtc\n" ;
            } else {
                s += ind + "lastPasswordResetTimeUtc\n" ;
            }
        }
        //      C# -> System.String? LastSshKeyUpdateTimeUtc
        // GraphQL -> lastSshKeyUpdateTimeUtc: String (scalar)
        if (this.LastSshKeyUpdateTimeUtc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSshKeyUpdateTimeUtc\n" ;
            } else {
                s += ind + "lastSshKeyUpdateTimeUtc\n" ;
            }
        }
        //      C# -> System.String? MfaServerId
        // GraphQL -> mfaServerId: String (scalar)
        if (this.MfaServerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mfaServerId\n" ;
            } else {
                s += ind + "mfaServerId\n" ;
            }
        }
        //      C# -> System.String? SshKey
        // GraphQL -> sshKey: String (scalar)
        if (this.SshKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sshKey\n" ;
            } else {
                s += ind + "sshKey\n" ;
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
        //      C# -> CdmUserAccountStatus? Status
        // GraphQL -> status: CdmUserAccountStatus (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmTotpStatusInternal? TotpStatus
        // GraphQL -> totpStatus: CdmTotpStatusInternal (type)
        if (this.TotpStatus != null) {
            var fspec = this.TotpStatus.AsFieldSpec(conf.Child("totpStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totpStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CdmUserType? UserType
        // GraphQL -> userType: CdmUserType (enum)
        if (ec.Includes("userType",true))
        {
            if(this.UserType == null) {

                this.UserType = new CdmUserType();

            } else {


            }
        }
        else if (this.UserType != null && ec.Excludes("userType",true))
        {
            this.UserType = null;
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
        //      C# -> System.String? ContactNumber
        // GraphQL -> contactNumber: String (scalar)
        if (ec.Includes("contactNumber",true))
        {
            if(this.ContactNumber == null) {

                this.ContactNumber = "FETCH";

            } else {


            }
        }
        else if (this.ContactNumber != null && ec.Excludes("contactNumber",true))
        {
            this.ContactNumber = null;
        }
        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        if (ec.Includes("createTime",true))
        {
            if(this.CreateTime == null) {

                this.CreateTime = "FETCH";

            } else {


            }
        }
        else if (this.CreateTime != null && ec.Excludes("createTime",true))
        {
            this.CreateTime = null;
        }
        //      C# -> System.String? CreatedById
        // GraphQL -> createdById: String! (scalar)
        if (ec.Includes("createdById",true))
        {
            if(this.CreatedById == null) {

                this.CreatedById = "FETCH";

            } else {


            }
        }
        else if (this.CreatedById != null && ec.Excludes("createdById",true))
        {
            this.CreatedById = null;
        }
        //      C# -> System.String? EmailAddress
        // GraphQL -> emailAddress: String (scalar)
        if (ec.Includes("emailAddress",true))
        {
            if(this.EmailAddress == null) {

                this.EmailAddress = "FETCH";

            } else {


            }
        }
        else if (this.EmailAddress != null && ec.Excludes("emailAddress",true))
        {
            this.EmailAddress = null;
        }
        //      C# -> System.String? FirstName
        // GraphQL -> firstName: String (scalar)
        if (ec.Includes("firstName",true))
        {
            if(this.FirstName == null) {

                this.FirstName = "FETCH";

            } else {


            }
        }
        else if (this.FirstName != null && ec.Excludes("firstName",true))
        {
            this.FirstName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.String? LastLoginTimeUtc
        // GraphQL -> lastLoginTimeUtc: String (scalar)
        if (ec.Includes("lastLoginTimeUtc",true))
        {
            if(this.LastLoginTimeUtc == null) {

                this.LastLoginTimeUtc = "FETCH";

            } else {


            }
        }
        else if (this.LastLoginTimeUtc != null && ec.Excludes("lastLoginTimeUtc",true))
        {
            this.LastLoginTimeUtc = null;
        }
        //      C# -> System.String? LastName
        // GraphQL -> lastName: String (scalar)
        if (ec.Includes("lastName",true))
        {
            if(this.LastName == null) {

                this.LastName = "FETCH";

            } else {


            }
        }
        else if (this.LastName != null && ec.Excludes("lastName",true))
        {
            this.LastName = null;
        }
        //      C# -> System.String? LastPasswordResetTimeUtc
        // GraphQL -> lastPasswordResetTimeUtc: String (scalar)
        if (ec.Includes("lastPasswordResetTimeUtc",true))
        {
            if(this.LastPasswordResetTimeUtc == null) {

                this.LastPasswordResetTimeUtc = "FETCH";

            } else {


            }
        }
        else if (this.LastPasswordResetTimeUtc != null && ec.Excludes("lastPasswordResetTimeUtc",true))
        {
            this.LastPasswordResetTimeUtc = null;
        }
        //      C# -> System.String? LastSshKeyUpdateTimeUtc
        // GraphQL -> lastSshKeyUpdateTimeUtc: String (scalar)
        if (ec.Includes("lastSshKeyUpdateTimeUtc",true))
        {
            if(this.LastSshKeyUpdateTimeUtc == null) {

                this.LastSshKeyUpdateTimeUtc = "FETCH";

            } else {


            }
        }
        else if (this.LastSshKeyUpdateTimeUtc != null && ec.Excludes("lastSshKeyUpdateTimeUtc",true))
        {
            this.LastSshKeyUpdateTimeUtc = null;
        }
        //      C# -> System.String? MfaServerId
        // GraphQL -> mfaServerId: String (scalar)
        if (ec.Includes("mfaServerId",true))
        {
            if(this.MfaServerId == null) {

                this.MfaServerId = "FETCH";

            } else {


            }
        }
        else if (this.MfaServerId != null && ec.Excludes("mfaServerId",true))
        {
            this.MfaServerId = null;
        }
        //      C# -> System.String? SshKey
        // GraphQL -> sshKey: String (scalar)
        if (ec.Includes("sshKey",true))
        {
            if(this.SshKey == null) {

                this.SshKey = "FETCH";

            } else {


            }
        }
        else if (this.SshKey != null && ec.Excludes("sshKey",true))
        {
            this.SshKey = null;
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
        //      C# -> CdmUserAccountStatus? Status
        // GraphQL -> status: CdmUserAccountStatus (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new CdmUserAccountStatus();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
        //      C# -> CdmTotpStatusInternal? TotpStatus
        // GraphQL -> totpStatus: CdmTotpStatusInternal (type)
        if (ec.Includes("totpStatus",false))
        {
            if(this.TotpStatus == null) {

                this.TotpStatus = new CdmTotpStatusInternal();
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

    } // class CdmUserDetail
    
    #endregion

    public static class ListCdmUserDetailExtensions
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
            this List<CdmUserDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmUserDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmUserDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUserDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmUserDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types