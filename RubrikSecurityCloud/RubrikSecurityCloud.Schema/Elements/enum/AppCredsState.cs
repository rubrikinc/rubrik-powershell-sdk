// AppCredsState.cs
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
    public enum AppCredsState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREDS_STATE_ACTIVE")]
        CREDS_STATE_ACTIVE,

        [EnumMember(Value = "CREDS_STATE_CERT_EXPIRED")]
        CREDS_STATE_CERT_EXPIRED,

        [EnumMember(Value = "CREDS_STATE_SECRET_EXPIRED")]
        CREDS_STATE_SECRET_EXPIRED,

        [EnumMember(Value = "CREDS_STATE_UNSPECIFIED")]
        CREDS_STATE_UNSPECIFIED


    } // enum AppCredsState

} // namespace RubrikSecurityCloud.Types