// AnalysisStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
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
        UP_TO_DATE


    } // enum AnalysisStatus

} // namespace Rubrik.SecurityCloud.Types