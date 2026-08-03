// ExposureType.cs
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
    public enum ExposureType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EXPOSURE_TYPE_EXTERNAL")]
        EXPOSURE_TYPE_EXTERNAL,

        [EnumMember(Value = "EXPOSURE_TYPE_ORG_WIDE")]
        EXPOSURE_TYPE_ORG_WIDE,

        [EnumMember(Value = "EXPOSURE_TYPE_PUBLIC")]
        EXPOSURE_TYPE_PUBLIC,

        [EnumMember(Value = "EXPOSURE_TYPE_UNSPECIFIED")]
        EXPOSURE_TYPE_UNSPECIFIED


    } // enum ExposureType

} // namespace RubrikSecurityCloud.Types