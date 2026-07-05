// CdmUserMetadata.cs
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
    #region CdmUserMetadata
    public class CdmUserMetadata: BaseType
    {
        #region members

        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastLoginTimestamp
        // GraphQL -> lastLoginTimestamp: DateTime (scalar)
        [JsonProperty("lastLoginTimestamp")]
        public DateTime? LastLoginTimestamp { get; set; }

        //      C# -> DateTime? LastMfaConfigUpdateTime
        // GraphQL -> lastMfaConfigUpdateTime: DateTime (scalar)
        [JsonProperty("lastMfaConfigUpdateTime")]
        public DateTime? LastMfaConfigUpdateTime { get; set; }

        //      C# -> DateTime? LastPasswordResetTimestamp
        // GraphQL -> lastPasswordResetTimestamp: DateTime (scalar)
        [JsonProperty("lastPasswordResetTimestamp")]
        public DateTime? LastPasswordResetTimestamp { get; set; }

        //      C# -> System.Boolean? MfaEnabled
        // GraphQL -> mfaEnabled: Boolean! (scalar)
        [JsonProperty("mfaEnabled")]
        public System.Boolean? MfaEnabled { get; set; }

        //      C# -> System.String? SshKey
        // GraphQL -> sshKey: String (scalar)
        [JsonProperty("sshKey")]
        public System.String? SshKey { get; set; }

        //      C# -> DateTime? SshKeyChangeTimestamp
        // GraphQL -> sshKeyChangeTimestamp: DateTime (scalar)
        [JsonProperty("sshKeyChangeTimestamp")]
        public DateTime? SshKeyChangeTimestamp { get; set; }

        //      C# -> System.Boolean? SshLoginEnabled
        // GraphQL -> sshLoginEnabled: Boolean! (scalar)
        [JsonProperty("sshLoginEnabled")]
        public System.Boolean? SshLoginEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmUserMetadata";
    }

    public CdmUserMetadata Set(
        System.String? Email = null,
        System.String? Id = null,
        DateTime? LastLoginTimestamp = null,
        DateTime? LastMfaConfigUpdateTime = null,
        DateTime? LastPasswordResetTimestamp = null,
        System.Boolean? MfaEnabled = null,
        System.String? SshKey = null,
        DateTime? SshKeyChangeTimestamp = null,
        System.Boolean? SshLoginEnabled = null
    ) 
    {
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastLoginTimestamp != null ) {
            this.LastLoginTimestamp = LastLoginTimestamp;
        }
        if ( LastMfaConfigUpdateTime != null ) {
            this.LastMfaConfigUpdateTime = LastMfaConfigUpdateTime;
        }
        if ( LastPasswordResetTimestamp != null ) {
            this.LastPasswordResetTimestamp = LastPasswordResetTimestamp;
        }
        if ( MfaEnabled != null ) {
            this.MfaEnabled = MfaEnabled;
        }
        if ( SshKey != null ) {
            this.SshKey = SshKey;
        }
        if ( SshKeyChangeTimestamp != null ) {
            this.SshKeyChangeTimestamp = SshKeyChangeTimestamp;
        }
        if ( SshLoginEnabled != null ) {
            this.SshLoginEnabled = SshLoginEnabled;
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
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            if (conf.Flat) {
                s += conf.Prefix + "email\n" ;
            } else {
                s += ind + "email\n" ;
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
        //      C# -> DateTime? LastLoginTimestamp
        // GraphQL -> lastLoginTimestamp: DateTime (scalar)
        if (this.LastLoginTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastLoginTimestamp\n" ;
            } else {
                s += ind + "lastLoginTimestamp\n" ;
            }
        }
        //      C# -> DateTime? LastMfaConfigUpdateTime
        // GraphQL -> lastMfaConfigUpdateTime: DateTime (scalar)
        if (this.LastMfaConfigUpdateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastMfaConfigUpdateTime\n" ;
            } else {
                s += ind + "lastMfaConfigUpdateTime\n" ;
            }
        }
        //      C# -> DateTime? LastPasswordResetTimestamp
        // GraphQL -> lastPasswordResetTimestamp: DateTime (scalar)
        if (this.LastPasswordResetTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastPasswordResetTimestamp\n" ;
            } else {
                s += ind + "lastPasswordResetTimestamp\n" ;
            }
        }
        //      C# -> System.Boolean? MfaEnabled
        // GraphQL -> mfaEnabled: Boolean! (scalar)
        if (this.MfaEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mfaEnabled\n" ;
            } else {
                s += ind + "mfaEnabled\n" ;
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
        //      C# -> DateTime? SshKeyChangeTimestamp
        // GraphQL -> sshKeyChangeTimestamp: DateTime (scalar)
        if (this.SshKeyChangeTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sshKeyChangeTimestamp\n" ;
            } else {
                s += ind + "sshKeyChangeTimestamp\n" ;
            }
        }
        //      C# -> System.Boolean? SshLoginEnabled
        // GraphQL -> sshLoginEnabled: Boolean! (scalar)
        if (this.SshLoginEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sshLoginEnabled\n" ;
            } else {
                s += ind + "sshLoginEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> DateTime? LastLoginTimestamp
        // GraphQL -> lastLoginTimestamp: DateTime (scalar)
        if (ec.Includes("lastLoginTimestamp",true))
        {
            if(this.LastLoginTimestamp == null) {

                this.LastLoginTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.LastLoginTimestamp != null && ec.Excludes("lastLoginTimestamp",true))
        {
            this.LastLoginTimestamp = null;
        }
        //      C# -> DateTime? LastMfaConfigUpdateTime
        // GraphQL -> lastMfaConfigUpdateTime: DateTime (scalar)
        if (ec.Includes("lastMfaConfigUpdateTime",true))
        {
            if(this.LastMfaConfigUpdateTime == null) {

                this.LastMfaConfigUpdateTime = new DateTime();

            } else {


            }
        }
        else if (this.LastMfaConfigUpdateTime != null && ec.Excludes("lastMfaConfigUpdateTime",true))
        {
            this.LastMfaConfigUpdateTime = null;
        }
        //      C# -> DateTime? LastPasswordResetTimestamp
        // GraphQL -> lastPasswordResetTimestamp: DateTime (scalar)
        if (ec.Includes("lastPasswordResetTimestamp",true))
        {
            if(this.LastPasswordResetTimestamp == null) {

                this.LastPasswordResetTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.LastPasswordResetTimestamp != null && ec.Excludes("lastPasswordResetTimestamp",true))
        {
            this.LastPasswordResetTimestamp = null;
        }
        //      C# -> System.Boolean? MfaEnabled
        // GraphQL -> mfaEnabled: Boolean! (scalar)
        if (ec.Includes("mfaEnabled",true))
        {
            if(this.MfaEnabled == null) {

                this.MfaEnabled = true;

            } else {


            }
        }
        else if (this.MfaEnabled != null && ec.Excludes("mfaEnabled",true))
        {
            this.MfaEnabled = null;
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
        //      C# -> DateTime? SshKeyChangeTimestamp
        // GraphQL -> sshKeyChangeTimestamp: DateTime (scalar)
        if (ec.Includes("sshKeyChangeTimestamp",true))
        {
            if(this.SshKeyChangeTimestamp == null) {

                this.SshKeyChangeTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.SshKeyChangeTimestamp != null && ec.Excludes("sshKeyChangeTimestamp",true))
        {
            this.SshKeyChangeTimestamp = null;
        }
        //      C# -> System.Boolean? SshLoginEnabled
        // GraphQL -> sshLoginEnabled: Boolean! (scalar)
        if (ec.Includes("sshLoginEnabled",true))
        {
            if(this.SshLoginEnabled == null) {

                this.SshLoginEnabled = true;

            } else {


            }
        }
        else if (this.SshLoginEnabled != null && ec.Excludes("sshLoginEnabled",true))
        {
            this.SshLoginEnabled = null;
        }
    }


    #endregion

    } // class CdmUserMetadata
    
    #endregion

    public static class ListCdmUserMetadataExtensions
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
            this List<CdmUserMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmUserMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmUserMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUserMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmUserMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types