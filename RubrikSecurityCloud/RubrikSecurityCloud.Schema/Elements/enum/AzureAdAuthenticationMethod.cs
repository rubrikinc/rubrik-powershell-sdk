// AzureAdAuthenticationMethod.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum AzureAdAuthenticationMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_AD_AUTHENTICATION_METHODS_UNKNOWN")]
        AZURE_AD_AUTHENTICATION_METHODS_UNKNOWN,

        [EnumMember(Value = "DEVICE_BASED_PUSH")]
        DEVICE_BASED_PUSH,

        [EnumMember(Value = "FEDERATED_MULTI_FACTOR")]
        FEDERATED_MULTI_FACTOR,

        [EnumMember(Value = "FEDERATED_SINGLE_FACTOR")]
        FEDERATED_SINGLE_FACTOR,

        [EnumMember(Value = "FIDO2")]
        FID_O2,

        [EnumMember(Value = "HARDWARE_OATH_FEDERATED_SINGLE_FACTOR")]
        HARDWARE_OATH_FEDERATED_SINGLE_FACTOR,

        [EnumMember(Value = "MICROSOFT_AUTHENTICATOR_PUSH_FEDERATED_SINGLE_FACTOR")]
        MICROSOFT_AUTHENTICATOR_PUSH_FEDERATED_SINGLE_FACTOR,

        [EnumMember(Value = "PASSWORD")]
        PASSWORD,

        [EnumMember(Value = "PASSWORD_HARDWARE_OATH")]
        PASSWORD_HARDWARE_OATH,

        [EnumMember(Value = "PASSWORD_MICROSOFT_AUTHENTICATOR_PUSH")]
        PASSWORD_MICROSOFT_AUTHENTICATOR_PUSH,

        [EnumMember(Value = "PASSWORD_SMS")]
        PASSWORD_SMS,

        [EnumMember(Value = "PASSWORD_SOFTWARE_OATH")]
        PASSWORD_SOFTWARE_OATH,

        [EnumMember(Value = "PASSWORD_VOICE")]
        PASSWORD_VOICE,

        [EnumMember(Value = "QR_CODE_PIN")]
        QR_CODE_PIN,

        [EnumMember(Value = "SMS")]
        SMS,

        [EnumMember(Value = "SMS_FEDERATED_SINGLE_FACTOR")]
        SMS_FEDERATED_SINGLE_FACTOR,

        [EnumMember(Value = "SOFTWARE_OATH_FEDERATED_SINGLE_FACTOR")]
        SOFTWARE_OATH_FEDERATED_SINGLE_FACTOR,

        [EnumMember(Value = "TEMPORARY_ACCESS_PASS_MULTI_USE")]
        TEMPORARY_ACCESS_PASS_MULTI_USE,

        [EnumMember(Value = "TEMPORARY_ACCESS_PASS_ONE_TIME")]
        TEMPORARY_ACCESS_PASS_ONE_TIME,

        [EnumMember(Value = "VOICE_FEDERATED_SINGLE_FACTOR")]
        VOICE_FEDERATED_SINGLE_FACTOR,

        [EnumMember(Value = "WINDOWS_HELLO_FOR_BUSINESS")]
        WINDOWS_HELLO_FOR_BUSINESS,

        [EnumMember(Value = "X509_CERTIFICATE_MULTI_FACTOR")]
        X509_CERTIFICATE_MULTI_FACTOR,

        [EnumMember(Value = "X509_CERTIFICATE_SINGLE_FACTOR")]
        X509_CERTIFICATE_SINGLE_FACTOR


    } // enum AzureAdAuthenticationMethod

} // namespace RubrikSecurityCloud.Types