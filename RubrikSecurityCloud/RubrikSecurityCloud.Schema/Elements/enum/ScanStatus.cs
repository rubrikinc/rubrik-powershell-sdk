// ScanStatus.cs
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
    public enum ScanStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLASSIFIED")]
        CLASSIFIED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "SCAN_STATUS_UNKNOWN")]
        SCAN_STATUS_UNKNOWN,

        [EnumMember(Value = "UNSCANNED")]
        UNSCANNED


    } // enum ScanStatus

} // namespace RubrikSecurityCloud.Types