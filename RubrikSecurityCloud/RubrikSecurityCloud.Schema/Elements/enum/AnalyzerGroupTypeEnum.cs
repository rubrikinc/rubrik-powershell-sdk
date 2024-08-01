// AnalyzerGroupTypeEnum.cs
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
        US_PII,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AnalyzerGroupTypeEnum

} // namespace RubrikSecurityCloud.Types