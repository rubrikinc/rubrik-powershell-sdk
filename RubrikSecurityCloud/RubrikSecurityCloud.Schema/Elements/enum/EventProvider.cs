// EventProvider.cs
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
    public enum EventProvider
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ENTRA_ID_AUDIT_LOG")]
        ENTRA_ID_AUDIT_LOG,

        [EnumMember(Value = "ENTRA_ID_SIGNIN_LOG")]
        ENTRA_ID_SIGNIN_LOG,

        [EnumMember(Value = "EVENT_PROVIDER_UNSPECIFIED")]
        EVENT_PROVIDER_UNSPECIFIED,

        [EnumMember(Value = "OKTA_SIGNIN_LOG")]
        OKTA_SIGNIN_LOG,

        [EnumMember(Value = "ON_PREM_AD_ACTOR_LOG")]
        ON_PREM_AD_ACTOR_LOG,

        [EnumMember(Value = "ON_PREM_AD_EVENT")]
        ON_PREM_AD_EVENT,

        [EnumMember(Value = "ON_PREM_AD_SIGNIN_LOG")]
        ON_PREM_AD_SIGNIN_LOG


    } // enum EventProvider

} // namespace RubrikSecurityCloud.Types