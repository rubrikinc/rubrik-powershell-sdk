// MicrosoftDefenderStatusCode.cs
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
    public enum MicrosoftDefenderStatusCode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREDENTIAL_EXPIRED")]
        CREDENTIAL_EXPIRED,

        [EnumMember(Value = "CREDENTIAL_EXPIRING_SOON")]
        CREDENTIAL_EXPIRING_SOON,

        [EnumMember(Value = "INTEGRATION_STATUS_UNSPECIFIED")]
        INTEGRATION_STATUS_UNSPECIFIED,

        [EnumMember(Value = "OK")]
        OK


    } // enum MicrosoftDefenderStatusCode

} // namespace RubrikSecurityCloud.Types