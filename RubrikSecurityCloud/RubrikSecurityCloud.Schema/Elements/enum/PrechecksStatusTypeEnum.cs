// PrechecksStatusTypeEnum.cs
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
    public enum PrechecksStatusTypeEnum
    {
        [EnumMember(Value = "PrechecksFailureError")]
        PRECHECKS_FAILURE_ERROR,

        [EnumMember(Value = "PrechecksFailureWarning")]
        PRECHECKS_FAILURE_WARNING,

        [EnumMember(Value = "PrechecksRunning")]
        PRECHECKS_RUNNING,

        [EnumMember(Value = "PrechecksSuccess")]
        PRECHECKS_SUCCESS,

        [EnumMember(Value = "Unknown")]
        UNKNOWN


    } // enum PrechecksStatusTypeEnum

} // namespace RubrikSecurityCloud.Types