// GetLicenseNotificationRequest.cs
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
    public enum GetLicenseNotificationRequest
    {
        [EnumMember(Value = "NOTIFICATION_DEPROVISIONING")]
        NOTIFICATION_DEPROVISIONING,

        [EnumMember(Value = "NOTIFICATION_LICENSING")]
        NOTIFICATION_LICENSING,

        [EnumMember(Value = "NOTIFICATION_UNSPECIFIED")]
        NOTIFICATION_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum GetLicenseNotificationRequest

} // namespace RubrikSecurityCloud.Types