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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        if (this.SecurityType != null) {
            s += ind + "securityType\n" ;
        }
        //      C# -> System.String? DefaultFromEmail
        // GraphQL -> defaultFromEmail: String! (scalar)
        if (this.DefaultFromEmail != null) {
            s += ind + "defaultFromEmail\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        if (this.IsValid != null) {
            s += ind + "isValid\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        //      C# -> System.Int64? TrustedCertId
        // GraphQL -> trustedCertId: Long! (scalar)
        if (this.TrustedCertId != null) {
            s += ind + "trustedCertId\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        if (this.SecurityType == null && Exploration.Includes(parent + ".securityType", true))
        {
            this.SecurityType = new SmtpSecurityTypeEnum();
        }
        //      C# -> System.String? DefaultFromEmail
        // GraphQL -> defaultFromEmail: String! (scalar)
        if (this.DefaultFromEmail == null && Exploration.Includes(parent + ".defaultFromEmail", true))
        {
            this.DefaultFromEmail = "FETCH";
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        if (this.IsValid == null && Exploration.Includes(parent + ".isValid", true))
        {
            this.IsValid = true;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port == null && Exploration.Includes(parent + ".port", true))
        {
            this.Port = Int32.MinValue;
        }
        //      C# -> System.Int64? TrustedCertId
        // GraphQL -> trustedCertId: Long! (scalar)
        if (this.TrustedCertId == null && Exploration.Includes(parent + ".trustedCertId", true))
        {
            this.TrustedCertId = new System.Int64();
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = "FETCH";
        }
    }


    #endregion

    } // class GetSmtpConfigurationReply
    
    #endregion

    public static class ListGetSmtpConfigurationReplyExtensions
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
            this List<GetSmtpConfigurationReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetSmtpConfigurationReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetSmtpConfigurationReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types