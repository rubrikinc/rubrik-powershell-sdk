// CommonNotificationConfig.cs
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
    #region CommonNotificationConfig
    public class CommonNotificationConfig: BaseType
    {
        #region members

        //      C# -> NetworkProtocolTypeEnum? NetworkType
        // GraphQL -> networkType: NetworkProtocolTypeEnum! (enum)
        [JsonProperty("networkType")]
        public NetworkProtocolTypeEnum? NetworkType { get; set; }

        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        [JsonProperty("securityType")]
        public SmtpSecurityTypeEnum? SecurityType { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String! (scalar)
        [JsonProperty("trustedCerts")]
        public System.String? TrustedCerts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CommonNotificationConfig";
    }

    public CommonNotificationConfig Set(
        NetworkProtocolTypeEnum? NetworkType = null,
        SmtpSecurityTypeEnum? SecurityType = null,
        System.String? Hostname = null,
        System.Int32? Port = null,
        System.String? TrustedCerts = null
    ) 
    {
        if ( NetworkType != null ) {
            this.NetworkType = NetworkType;
        }
        if ( SecurityType != null ) {
            this.SecurityType = SecurityType;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( TrustedCerts != null ) {
            this.TrustedCerts = TrustedCerts;
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
        //      C# -> NetworkProtocolTypeEnum? NetworkType
        // GraphQL -> networkType: NetworkProtocolTypeEnum! (enum)
        if (this.NetworkType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkType\n" ;
            } else {
                s += ind + "networkType\n" ;
            }
        }
        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        if (this.SecurityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "securityType\n" ;
            } else {
                s += ind + "securityType\n" ;
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
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
            }
        }
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String! (scalar)
        if (this.TrustedCerts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "trustedCerts\n" ;
            } else {
                s += ind + "trustedCerts\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NetworkProtocolTypeEnum? NetworkType
        // GraphQL -> networkType: NetworkProtocolTypeEnum! (enum)
        if (ec.Includes("networkType",true))
        {
            if(this.NetworkType == null) {

                this.NetworkType = new NetworkProtocolTypeEnum();

            } else {


            }
        }
        else if (this.NetworkType != null && ec.Excludes("networkType",true))
        {
            this.NetworkType = null;
        }
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
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String! (scalar)
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
    }


    #endregion

    } // class CommonNotificationConfig
    
    #endregion

    public static class ListCommonNotificationConfigExtensions
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
            this List<CommonNotificationConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CommonNotificationConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CommonNotificationConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CommonNotificationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CommonNotificationConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types