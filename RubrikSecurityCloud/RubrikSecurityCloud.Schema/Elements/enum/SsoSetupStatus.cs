// SsoSetupStatus.cs
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
    public enum SsoSetupStatus
    {
        [EnumMember(Value = "SSO_SETUP_STATUS_COMPLETED")]
        SSO_SETUP_STATUS_COMPLETED,

        [EnumMember(Value = "SSO_SETUP_STATUS_NOT_STARTED")]
        SSO_SETUP_STATUS_NOT_STARTED,

        [EnumMember(Value = "SSO_SETUP_STATUS_UNSPECIFIED")]
        SSO_SETUP_STATUS_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SsoSetupStatus

} // namespace RubrikSecurityCloud.Types