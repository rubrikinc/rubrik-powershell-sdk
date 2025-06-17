// ProcessorType.cs
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
    public enum ProcessorType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AMD")]
        AMD,

        [EnumMember(Value = "INTEL")]
        INTEL,

        [EnumMember(Value = "PROCESSOR_TYPE_UNSPECIFIED")]
        PROCESSOR_TYPE_UNSPECIFIED


    } // enum ProcessorType

} // namespace RubrikSecurityCloud.Types