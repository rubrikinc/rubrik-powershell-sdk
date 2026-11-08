// AddcRecoverySpecType.cs
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
    #region AddcRecoverySpecType
 
    public class AddcRecoverySpecType: BaseType, RecoverySpec
    {
        #region members

        //      C# -> DnsRecoveryType? DnsRecoveryType
        // GraphQL -> dnsRecoveryType: DnsRecoveryType! (enum)
        [JsonProperty("dnsRecoveryType")]
        public DnsRecoveryType? DnsRecoveryType { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: UUID! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> List<System.String>? CustomDnsIps
        // GraphQL -> customDnsIps: [String!]! (scalar)
        [JsonProperty("customDnsIps")]
        public List<System.String>? CustomDnsIps { get; set; }

        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        [JsonProperty("domainId")]
        public System.String? DomainId { get; set; }

        //      C# -> System.String? DomainSid
        // GraphQL -> domainSid: String! (scalar)
        [JsonProperty("domainSid")]
        public System.String? DomainSid { get; set; }

        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        [JsonProperty("recoveryPointOpt")]
        public System.Int64? RecoveryPointOpt { get; set; }

        //      C# -> System.Boolean? ShouldRebuildGc
        // GraphQL -> shouldRebuildGc: Boolean! (scalar)
        [JsonProperty("shouldRebuildGc")]
        public System.Boolean? ShouldRebuildGc { get; set; }

        //      C# -> System.Boolean? ShouldResetKerberos
        // GraphQL -> shouldResetKerberos: Boolean! (scalar)
        [JsonProperty("shouldResetKerberos")]
        public System.Boolean? ShouldResetKerberos { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> List<System.String>? WinTimeServers
        // GraphQL -> winTimeServers: [String!]! (scalar)
        [JsonProperty("winTimeServers")]
        public List<System.String>? WinTimeServers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddcRecoverySpecType";
    }

    public AddcRecoverySpecType Set(
        DnsRecoveryType? DnsRecoveryType = null,
        System.String? AppId = null,
        List<System.String>? CustomDnsIps = null,
        System.String? DomainId = null,
        System.String? DomainSid = null,
        System.Int64? RecoveryPointOpt = null,
        System.Boolean? ShouldRebuildGc = null,
        System.Boolean? ShouldResetKerberos = null,
        System.String? SnappableId = null,
        System.String? UserData = null,
        System.Int64? Version = null,
        List<System.String>? WinTimeServers = null
    ) 
    {
        if ( DnsRecoveryType != null ) {
            this.DnsRecoveryType = DnsRecoveryType;
        }
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( CustomDnsIps != null ) {
            this.CustomDnsIps = CustomDnsIps;
        }
        if ( DomainId != null ) {
            this.DomainId = DomainId;
        }
        if ( DomainSid != null ) {
            this.DomainSid = DomainSid;
        }
        if ( RecoveryPointOpt != null ) {
            this.RecoveryPointOpt = RecoveryPointOpt;
        }
        if ( ShouldRebuildGc != null ) {
            this.ShouldRebuildGc = ShouldRebuildGc;
        }
        if ( ShouldResetKerberos != null ) {
            this.ShouldResetKerberos = ShouldResetKerberos;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( UserData != null ) {
            this.UserData = UserData;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( WinTimeServers != null ) {
            this.WinTimeServers = WinTimeServers;
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
        //      C# -> DnsRecoveryType? DnsRecoveryType
        // GraphQL -> dnsRecoveryType: DnsRecoveryType! (enum)
        if (this.DnsRecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnsRecoveryType\n" ;
            } else {
                s += ind + "dnsRecoveryType\n" ;
            }
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: UUID! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> List<System.String>? CustomDnsIps
        // GraphQL -> customDnsIps: [String!]! (scalar)
        if (this.CustomDnsIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customDnsIps\n" ;
            } else {
                s += ind + "customDnsIps\n" ;
            }
        }
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (this.DomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainId\n" ;
            } else {
                s += ind + "domainId\n" ;
            }
        }
        //      C# -> System.String? DomainSid
        // GraphQL -> domainSid: String! (scalar)
        if (this.DomainSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainSid\n" ;
            } else {
                s += ind + "domainSid\n" ;
            }
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPointOpt\n" ;
            } else {
                s += ind + "recoveryPointOpt\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldRebuildGc
        // GraphQL -> shouldRebuildGc: Boolean! (scalar)
        if (this.ShouldRebuildGc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldRebuildGc\n" ;
            } else {
                s += ind + "shouldRebuildGc\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldResetKerberos
        // GraphQL -> shouldResetKerberos: Boolean! (scalar)
        if (this.ShouldResetKerberos != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldResetKerberos\n" ;
            } else {
                s += ind + "shouldResetKerberos\n" ;
            }
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (this.UserData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userData\n" ;
            } else {
                s += ind + "userData\n" ;
            }
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<System.String>? WinTimeServers
        // GraphQL -> winTimeServers: [String!]! (scalar)
        if (this.WinTimeServers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "winTimeServers\n" ;
            } else {
                s += ind + "winTimeServers\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DnsRecoveryType? DnsRecoveryType
        // GraphQL -> dnsRecoveryType: DnsRecoveryType! (enum)
        if (ec.Includes("dnsRecoveryType",true))
        {
            if(this.DnsRecoveryType == null) {

                this.DnsRecoveryType = new DnsRecoveryType();

            } else {


            }
        }
        else if (this.DnsRecoveryType != null && ec.Excludes("dnsRecoveryType",true))
        {
            this.DnsRecoveryType = null;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: UUID! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> List<System.String>? CustomDnsIps
        // GraphQL -> customDnsIps: [String!]! (scalar)
        if (ec.Includes("customDnsIps",true))
        {
            if(this.CustomDnsIps == null) {

                this.CustomDnsIps = new List<System.String>();

            } else {


            }
        }
        else if (this.CustomDnsIps != null && ec.Excludes("customDnsIps",true))
        {
            this.CustomDnsIps = null;
        }
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (ec.Includes("domainId",true))
        {
            if(this.DomainId == null) {

                this.DomainId = "FETCH";

            } else {


            }
        }
        else if (this.DomainId != null && ec.Excludes("domainId",true))
        {
            this.DomainId = null;
        }
        //      C# -> System.String? DomainSid
        // GraphQL -> domainSid: String! (scalar)
        if (ec.Includes("domainSid",true))
        {
            if(this.DomainSid == null) {

                this.DomainSid = "FETCH";

            } else {


            }
        }
        else if (this.DomainSid != null && ec.Excludes("domainSid",true))
        {
            this.DomainSid = null;
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (ec.Includes("recoveryPointOpt",true))
        {
            if(this.RecoveryPointOpt == null) {

                this.RecoveryPointOpt = new System.Int64();

            } else {


            }
        }
        else if (this.RecoveryPointOpt != null && ec.Excludes("recoveryPointOpt",true))
        {
            this.RecoveryPointOpt = null;
        }
        //      C# -> System.Boolean? ShouldRebuildGc
        // GraphQL -> shouldRebuildGc: Boolean! (scalar)
        if (ec.Includes("shouldRebuildGc",true))
        {
            if(this.ShouldRebuildGc == null) {

                this.ShouldRebuildGc = true;

            } else {


            }
        }
        else if (this.ShouldRebuildGc != null && ec.Excludes("shouldRebuildGc",true))
        {
            this.ShouldRebuildGc = null;
        }
        //      C# -> System.Boolean? ShouldResetKerberos
        // GraphQL -> shouldResetKerberos: Boolean! (scalar)
        if (ec.Includes("shouldResetKerberos",true))
        {
            if(this.ShouldResetKerberos == null) {

                this.ShouldResetKerberos = true;

            } else {


            }
        }
        else if (this.ShouldResetKerberos != null && ec.Excludes("shouldResetKerberos",true))
        {
            this.ShouldResetKerberos = null;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (ec.Includes("userData",true))
        {
            if(this.UserData == null) {

                this.UserData = "FETCH";

            } else {


            }
        }
        else if (this.UserData != null && ec.Excludes("userData",true))
        {
            this.UserData = null;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<System.String>? WinTimeServers
        // GraphQL -> winTimeServers: [String!]! (scalar)
        if (ec.Includes("winTimeServers",true))
        {
            if(this.WinTimeServers == null) {

                this.WinTimeServers = new List<System.String>();

            } else {


            }
        }
        else if (this.WinTimeServers != null && ec.Excludes("winTimeServers",true))
        {
            this.WinTimeServers = null;
        }
    }


    #endregion

    } // class AddcRecoverySpecType
    
    #endregion

    public static class ListAddcRecoverySpecTypeExtensions
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
            this List<AddcRecoverySpecType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AddcRecoverySpecType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddcRecoverySpecType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddcRecoverySpecType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddcRecoverySpecType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types