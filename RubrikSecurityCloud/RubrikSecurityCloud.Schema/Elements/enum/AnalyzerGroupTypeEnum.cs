// AnalyzerGroupTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    public enum AnalyzerGroupTypeEnum
    {
        [EnumMember(Value = "CCPA")]
        CCPA,

        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "GLBA")]
        GLBA,

        [EnumMember(Value = "HIPAA")]
        HIPAA,

        [EnumMember(Value = "PCI_DSS")]
        PCI_DSS,

        [EnumMember(Value = "UK_PII")]
        UK_PII,

        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED,

        [EnumMember(Value = "US_FINANCE")]
        US_FINANCE,

        [EnumMember(Value = "US_PII")]
        US_PII


    } // enum AnalyzerGroupTypeEnum

} // namespace Rubrik.SecurityCloud.Types