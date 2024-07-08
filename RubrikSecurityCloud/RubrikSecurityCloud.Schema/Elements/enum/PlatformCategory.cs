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
        [EnumMember(Value = "CLOUD_CATEGORY")]
        CLOUD_CATEGORY,

        [EnumMember(Value = "DATA_CENTRE_CATEGORY")]
        DATA_CENTRE_CATEGORY,

        [EnumMember(Value = "PLATFORM_CATEGORY_UNSPECIFIED")]
        PLATFORM_CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "SAAS_CATEGORY")]
        SAAS_CATEGORY


    } // enum PlatformCategory

} // namespace RubrikSecurityCloud.Types