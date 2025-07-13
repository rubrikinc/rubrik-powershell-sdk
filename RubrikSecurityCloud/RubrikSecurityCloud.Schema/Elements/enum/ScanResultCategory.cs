// ScanResultCategory.cs
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
    public enum ScanResultCategory
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ERROR_ACTION_REQUIRED")]
        ERROR_ACTION_REQUIRED,

        [EnumMember(Value = "ERROR_CONTACT_SUPPORT")]
        ERROR_CONTACT_SUPPORT,

        [EnumMember(Value = "ERROR_UNSUPPORTED_OBJECT")]
        ERROR_UNSUPPORTED_OBJECT,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "SCAN_RESULT_CATEGORY_UNSPECIFIED")]
        SCAN_RESULT_CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS


    } // enum ScanResultCategory

} // namespace RubrikSecurityCloud.Types