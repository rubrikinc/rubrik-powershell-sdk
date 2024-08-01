// FileTypeEnum.cs
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
    public enum FileTypeEnum
    {
        [EnumMember(Value = "CSV")]
        CSV,

        [EnumMember(Value = "PDF")]
        PDF,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FileTypeEnum

} // namespace RubrikSecurityCloud.Types