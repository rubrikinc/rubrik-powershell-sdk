// PlatformCategory.cs
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
    public enum PlatformCategory
    {
        [EnumMember(Value = "PLATFORM_CATEGORY_CLOUD")]
        PLATFORM_CATEGORY_CLOUD,

        [EnumMember(Value = "PLATFORM_CATEGORY_DATA_CENTER")]
        PLATFORM_CATEGORY_DATA_CENTER,

        [EnumMember(Value = "PLATFORM_CATEGORY_SAAS")]
        PLATFORM_CATEGORY_SAAS,

        [EnumMember(Value = "PLATFORM_CATEGORY_UNSPECIFIED")]
        PLATFORM_CATEGORY_UNSPECIFIED


    } // enum PlatformCategory

} // namespace RubrikSecurityCloud.Types