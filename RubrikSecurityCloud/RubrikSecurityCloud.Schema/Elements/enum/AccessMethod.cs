// AccessMethod.cs
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
    public enum AccessMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_METHOD_UNSPECIFIED")]
        ACCESS_METHOD_UNSPECIFIED,

        [EnumMember(Value = "M365_DIRECT_PERMISSION")]
        M365_DIRECT_PERMISSION,

        [EnumMember(Value = "M365_DRIVE_PERMISSION")]
        M365_DRIVE_PERMISSION,

        [EnumMember(Value = "M365_OD_SITE_PERMISSION")]
        M365_OD_SITE_PERMISSION,

        [EnumMember(Value = "M365_SHARING_LINK")]
        M365_SHARING_LINK,

        [EnumMember(Value = "M365_SITE_COLLECTION_ADMIN")]
        M365_SITE_COLLECTION_ADMIN,

        [EnumMember(Value = "M365_SITE_PERMISSION")]
        M365_SITE_PERMISSION,

        [EnumMember(Value = "WINDOWS_ACL")]
        WINDOWS_ACL


    } // enum AccessMethod

} // namespace RubrikSecurityCloud.Types