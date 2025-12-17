// AzureAdDevice.cs
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
    #region AzureAdDevice
    public class AzureAdDevice: BaseType
    {
        #region members

        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        [JsonProperty("onPremSyncStatus")]
        public AzureAdOnPremSyncStatus? OnPremSyncStatus { get; set; }

        //      C# -> AzureAdDeviceTrustType? TrustType
        // GraphQL -> trustType: AzureAdDeviceTrustType! (enum)
        [JsonProperty("trustType")]
        public AzureAdDeviceTrustType? TrustType { get; set; }

        //      C# -> System.Boolean? AccountEnabled
        // GraphQL -> accountEnabled: Boolean! (scalar)
        [JsonProperty("accountEnabled")]
        public System.Boolean? AccountEnabled { get; set; }

        //      C# -> System.String? DeviceId
        // GraphQL -> deviceId: String! (scalar)
        [JsonProperty("deviceId")]
        public System.String? DeviceId { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Boolean? IsCompliant
        // GraphQL -> isCompliant: Boolean (scalar)
        [JsonProperty("isCompliant")]
        public System.Boolean? IsCompliant { get; set; }

        //      C# -> DateTime? LastSignInDateTime
        // GraphQL -> lastSignInDateTime: DateTime (scalar)
        [JsonProperty("lastSignInDateTime")]
        public DateTime? LastSignInDateTime { get; set; }

        //      C# -> System.String? Mdm
        // GraphQL -> mdm: String! (scalar)
        [JsonProperty("mdm")]
        public System.String? Mdm { get; set; }

        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String! (scalar)
        [JsonProperty("operatingSystem")]
        public System.String? OperatingSystem { get; set; }

        //      C# -> System.String? OperatingSystemVersion
        // GraphQL -> operatingSystemVersion: String! (scalar)
        [JsonProperty("operatingSystemVersion")]
        public System.String? OperatingSystemVersion { get; set; }

        //      C# -> System.String? RegisteredOwner
        // GraphQL -> registeredOwner: String! (scalar)
        [JsonProperty("registeredOwner")]
        public System.String? RegisteredOwner { get; set; }

        //      C# -> DateTime? RegistrationDateTime
        // GraphQL -> registrationDateTime: DateTime (scalar)
        [JsonProperty("registrationDateTime")]
        public DateTime? RegistrationDateTime { get; set; }

        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        [JsonProperty("userPrincipalName")]
        public System.String? UserPrincipalName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdDevice";
    }

    public AzureAdDevice Set(
        AzureAdOnPremSyncStatus? OnPremSyncStatus = null,
        AzureAdDeviceTrustType? TrustType = null,
        System.Boolean? AccountEnabled = null,
        System.String? DeviceId = null,
        System.String? DisplayName = null,
        System.Boolean? IsCompliant = null,
        DateTime? LastSignInDateTime = null,
        System.String? Mdm = null,
        System.String? OperatingSystem = null,
        System.String? OperatingSystemVersion = null,
        System.String? RegisteredOwner = null,
        DateTime? RegistrationDateTime = null,
        System.String? UserPrincipalName = null
    ) 
    {
        if ( OnPremSyncStatus != null ) {
            this.OnPremSyncStatus = OnPremSyncStatus;
        }
        if ( TrustType != null ) {
            this.TrustType = TrustType;
        }
        if ( AccountEnabled != null ) {
            this.AccountEnabled = AccountEnabled;
        }
        if ( DeviceId != null ) {
            this.DeviceId = DeviceId;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( IsCompliant != null ) {
            this.IsCompliant = IsCompliant;
        }
        if ( LastSignInDateTime != null ) {
            this.LastSignInDateTime = LastSignInDateTime;
        }
        if ( Mdm != null ) {
            this.Mdm = Mdm;
        }
        if ( OperatingSystem != null ) {
            this.OperatingSystem = OperatingSystem;
        }
        if ( OperatingSystemVersion != null ) {
            this.OperatingSystemVersion = OperatingSystemVersion;
        }
        if ( RegisteredOwner != null ) {
            this.RegisteredOwner = RegisteredOwner;
        }
        if ( RegistrationDateTime != null ) {
            this.RegistrationDateTime = RegistrationDateTime;
        }
        if ( UserPrincipalName != null ) {
            this.UserPrincipalName = UserPrincipalName;
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
        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        if (this.OnPremSyncStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremSyncStatus\n" ;
            } else {
                s += ind + "onPremSyncStatus\n" ;
            }
        }
        //      C# -> AzureAdDeviceTrustType? TrustType
        // GraphQL -> trustType: AzureAdDeviceTrustType! (enum)
        if (this.TrustType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "trustType\n" ;
            } else {
                s += ind + "trustType\n" ;
            }
        }
        //      C# -> System.Boolean? AccountEnabled
        // GraphQL -> accountEnabled: Boolean! (scalar)
        if (this.AccountEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountEnabled\n" ;
            } else {
                s += ind + "accountEnabled\n" ;
            }
        }
        //      C# -> System.String? DeviceId
        // GraphQL -> deviceId: String! (scalar)
        if (this.DeviceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceId\n" ;
            } else {
                s += ind + "deviceId\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.Boolean? IsCompliant
        // GraphQL -> isCompliant: Boolean (scalar)
        if (this.IsCompliant != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCompliant\n" ;
            } else {
                s += ind + "isCompliant\n" ;
            }
        }
        //      C# -> DateTime? LastSignInDateTime
        // GraphQL -> lastSignInDateTime: DateTime (scalar)
        if (this.LastSignInDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSignInDateTime\n" ;
            } else {
                s += ind + "lastSignInDateTime\n" ;
            }
        }
        //      C# -> System.String? Mdm
        // GraphQL -> mdm: String! (scalar)
        if (this.Mdm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mdm\n" ;
            } else {
                s += ind + "mdm\n" ;
            }
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String! (scalar)
        if (this.OperatingSystem != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystem\n" ;
            } else {
                s += ind + "operatingSystem\n" ;
            }
        }
        //      C# -> System.String? OperatingSystemVersion
        // GraphQL -> operatingSystemVersion: String! (scalar)
        if (this.OperatingSystemVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystemVersion\n" ;
            } else {
                s += ind + "operatingSystemVersion\n" ;
            }
        }
        //      C# -> System.String? RegisteredOwner
        // GraphQL -> registeredOwner: String! (scalar)
        if (this.RegisteredOwner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registeredOwner\n" ;
            } else {
                s += ind + "registeredOwner\n" ;
            }
        }
        //      C# -> DateTime? RegistrationDateTime
        // GraphQL -> registrationDateTime: DateTime (scalar)
        if (this.RegistrationDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registrationDateTime\n" ;
            } else {
                s += ind + "registrationDateTime\n" ;
            }
        }
        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        if (this.UserPrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userPrincipalName\n" ;
            } else {
                s += ind + "userPrincipalName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        if (ec.Includes("onPremSyncStatus",true))
        {
            if(this.OnPremSyncStatus == null) {

                this.OnPremSyncStatus = new AzureAdOnPremSyncStatus();

            } else {


            }
        }
        else if (this.OnPremSyncStatus != null && ec.Excludes("onPremSyncStatus",true))
        {
            this.OnPremSyncStatus = null;
        }
        //      C# -> AzureAdDeviceTrustType? TrustType
        // GraphQL -> trustType: AzureAdDeviceTrustType! (enum)
        if (ec.Includes("trustType",true))
        {
            if(this.TrustType == null) {

                this.TrustType = new AzureAdDeviceTrustType();

            } else {


            }
        }
        else if (this.TrustType != null && ec.Excludes("trustType",true))
        {
            this.TrustType = null;
        }
        //      C# -> System.Boolean? AccountEnabled
        // GraphQL -> accountEnabled: Boolean! (scalar)
        if (ec.Includes("accountEnabled",true))
        {
            if(this.AccountEnabled == null) {

                this.AccountEnabled = true;

            } else {


            }
        }
        else if (this.AccountEnabled != null && ec.Excludes("accountEnabled",true))
        {
            this.AccountEnabled = null;
        }
        //      C# -> System.String? DeviceId
        // GraphQL -> deviceId: String! (scalar)
        if (ec.Includes("deviceId",true))
        {
            if(this.DeviceId == null) {

                this.DeviceId = "FETCH";

            } else {


            }
        }
        else if (this.DeviceId != null && ec.Excludes("deviceId",true))
        {
            this.DeviceId = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.Boolean? IsCompliant
        // GraphQL -> isCompliant: Boolean (scalar)
        if (ec.Includes("isCompliant",true))
        {
            if(this.IsCompliant == null) {

                this.IsCompliant = true;

            } else {


            }
        }
        else if (this.IsCompliant != null && ec.Excludes("isCompliant",true))
        {
            this.IsCompliant = null;
        }
        //      C# -> DateTime? LastSignInDateTime
        // GraphQL -> lastSignInDateTime: DateTime (scalar)
        if (ec.Includes("lastSignInDateTime",true))
        {
            if(this.LastSignInDateTime == null) {

                this.LastSignInDateTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSignInDateTime != null && ec.Excludes("lastSignInDateTime",true))
        {
            this.LastSignInDateTime = null;
        }
        //      C# -> System.String? Mdm
        // GraphQL -> mdm: String! (scalar)
        if (ec.Includes("mdm",true))
        {
            if(this.Mdm == null) {

                this.Mdm = "FETCH";

            } else {


            }
        }
        else if (this.Mdm != null && ec.Excludes("mdm",true))
        {
            this.Mdm = null;
        }
        //      C# -> System.String? OperatingSystem
        // GraphQL -> operatingSystem: String! (scalar)
        if (ec.Includes("operatingSystem",true))
        {
            if(this.OperatingSystem == null) {

                this.OperatingSystem = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystem != null && ec.Excludes("operatingSystem",true))
        {
            this.OperatingSystem = null;
        }
        //      C# -> System.String? OperatingSystemVersion
        // GraphQL -> operatingSystemVersion: String! (scalar)
        if (ec.Includes("operatingSystemVersion",true))
        {
            if(this.OperatingSystemVersion == null) {

                this.OperatingSystemVersion = "FETCH";

            } else {


            }
        }
        else if (this.OperatingSystemVersion != null && ec.Excludes("operatingSystemVersion",true))
        {
            this.OperatingSystemVersion = null;
        }
        //      C# -> System.String? RegisteredOwner
        // GraphQL -> registeredOwner: String! (scalar)
        if (ec.Includes("registeredOwner",true))
        {
            if(this.RegisteredOwner == null) {

                this.RegisteredOwner = "FETCH";

            } else {


            }
        }
        else if (this.RegisteredOwner != null && ec.Excludes("registeredOwner",true))
        {
            this.RegisteredOwner = null;
        }
        //      C# -> DateTime? RegistrationDateTime
        // GraphQL -> registrationDateTime: DateTime (scalar)
        if (ec.Includes("registrationDateTime",true))
        {
            if(this.RegistrationDateTime == null) {

                this.RegistrationDateTime = new DateTime();

            } else {


            }
        }
        else if (this.RegistrationDateTime != null && ec.Excludes("registrationDateTime",true))
        {
            this.RegistrationDateTime = null;
        }
        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        if (ec.Includes("userPrincipalName",true))
        {
            if(this.UserPrincipalName == null) {

                this.UserPrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.UserPrincipalName != null && ec.Excludes("userPrincipalName",true))
        {
            this.UserPrincipalName = null;
        }
    }


    #endregion

    } // class AzureAdDevice
    
    #endregion

    public static class ListAzureAdDeviceExtensions
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
            this List<AzureAdDevice> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdDevice> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdDevice> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdDevice());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdDevice> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types