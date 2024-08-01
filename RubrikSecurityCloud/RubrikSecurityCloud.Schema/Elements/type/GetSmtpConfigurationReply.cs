// GetSmtpConfigurationReply.cs
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
    #region GetSmtpConfigurationReply
    public class GetSmtpConfigurationReply: BaseType
    {
        #region members

        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        [JsonProperty("securityType")]
        public SmtpSecurityTypeEnum? SecurityType { get; set; }

        //      C# -> System.String? DefaultFromEmail
        // GraphQL -> defaultFromEmail: String! (scalar)
        [JsonProperty("defaultFromEmail")]
        public System.String? DefaultFromEmail { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        [JsonProperty("isValid")]
        public System.Boolean? IsValid { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.Int64? TrustedCertId
        // GraphQL -> trustedCertId: Long! (scalar)
        [JsonProperty("trustedCertId")]
        public System.Int64? TrustedCertId { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetSMTPConfigurationReply";
    }

    public GetSmtpConfigurationReply Set(
        SmtpSecurityTypeEnum? SecurityType = null,
        System.String? DefaultFromEmail = null,
        System.String? Hostname = null,
        System.Boolean? IsValid = null,
        System.Int32? Port = null,
        System.Int64? TrustedCertId = null,
        System.String? Username = null
    ) 
    {
        if ( SecurityType != null ) {
            this.SecurityType = SecurityType;
        }
        if ( DefaultFromEmail != null ) {
            this.DefaultFromEmail = DefaultFromEmail;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( IsValid != null ) {
            this.IsValid = IsValid;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( TrustedCertId != null ) {
            this.TrustedCertId = TrustedCertId;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        if (this.SecurityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "securityType\n" ;
            } else {
                s += ind + "securityType\n" ;
            }
        }
        //      C# -> System.String? DefaultFromEmail
        // GraphQL -> defaultFromEmail: String! (scalar)
        if (this.DefaultFromEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultFromEmail\n" ;
            } else {
                s += ind + "defaultFromEmail\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        if (this.IsValid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isValid\n" ;
            } else {
                s += ind + "isValid\n" ;
            }
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
            }
        }
        //      C# -> System.Int64? TrustedCertId
        // GraphQL -> trustedCertId: Long! (scalar)
        if (this.TrustedCertId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "trustedCertId\n" ;
            } else {
                s += ind + "trustedCertId\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        if (ec.Includes("securityType",true))
        {
            if(this.SecurityType == null) {

                this.SecurityType = new SmtpSecurityTypeEnum();

            } else {


            }
        }
        else if (this.SecurityType != null && ec.Excludes("securityType",true))
        {
            this.SecurityType = null;
        }
        //      C# -> System.String? DefaultFromEmail
        // GraphQL -> defaultFromEmail: String! (scalar)
        if (ec.Includes("defaultFromEmail",true))
        {
            if(this.DefaultFromEmail == null) {

                this.DefaultFromEmail = "FETCH";

            } else {


            }
        }
        else if (this.DefaultFromEmail != null && ec.Excludes("defaultFromEmail",true))
        {
            this.DefaultFromEmail = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        if (ec.Includes("isValid",true))
        {
            if(this.IsValid == null) {

                this.IsValid = true;

            } else {


            }
        }
        else if (this.IsValid != null && ec.Excludes("isValid",true))
        {
            this.IsValid = null;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (ec.Includes("port",true))
        {
            if(this.Port == null) {

                this.Port = Int32.MinValue;

            } else {


            }
        }
        else if (this.Port != null && ec.Excludes("port",true))
        {
            this.Port = null;
        }
        //      C# -> System.Int64? TrustedCertId
        // GraphQL -> trustedCertId: Long! (scalar)
        if (ec.Includes("trustedCertId",true))
        {
            if(this.TrustedCertId == null) {

                this.TrustedCertId = new System.Int64();

            } else {


            }
        }
        else if (this.TrustedCertId != null && ec.Excludes("trustedCertId",true))
        {
            this.TrustedCertId = null;
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
    }


    #endregion

    } // class GetSmtpConfigurationReply
    
    #endregion

    public static class ListGetSmtpConfigurationReplyExtensions
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
            this List<GetSmtpConfigurationReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetSmtpConfigurationReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetSmtpConfigurationReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSmtpConfigurationReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetSmtpConfigurationReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types