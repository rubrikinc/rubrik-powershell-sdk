// CloudNativeApplicationRefreshStatus.cs
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
    public enum CloudNativeApplicationRefreshStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APP_REFRESHING")]
        APP_REFRESHING,

        [EnumMember(Value = "APP_REFRESH_FAILED")]
        APP_REFRESH_FAILED,

        [EnumMember(Value = "APP_REFRESH_STATUS_UNSPECIFIED")]
        APP_REFRESH_STATUS_UNSPECIFIED,

        [EnumMember(Value = "APP_REFRESH_SUCCESS")]
        APP_REFRESH_SUCCESS


    } // enum CloudNativeApplicationRefreshStatus

} // namespace RubrikSecurityCloud.Types