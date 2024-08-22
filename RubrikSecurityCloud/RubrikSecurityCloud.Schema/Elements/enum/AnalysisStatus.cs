// AnalysisStatus.cs
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
    public enum AnalysisStatus
    {
        [EnumMember(Value = "INITIAL_ANALYSIS")]
        INITIAL_ANALYSIS,

        [EnumMember(Value = "OUT_OF_DATE")]
        OUT_OF_DATE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED,

        [EnumMember(Value = "UP_TO_DATE")]
        UP_TO_DATE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AnalysisStatus

} // namespace RubrikSecurityCloud.Types