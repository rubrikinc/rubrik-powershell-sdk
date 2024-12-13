// WebhookStatus.cs
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
    public enum WebhookStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTO_DISABLED")]
        AUTO_DISABLED,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "ENABLED")]
        ENABLED,

        [EnumMember(Value = "WEBHOOK_STATUS_UNSPECIFIED")]
        WEBHOOK_STATUS_UNSPECIFIED


    } // enum WebhookStatus

} // namespace RubrikSecurityCloud.Types