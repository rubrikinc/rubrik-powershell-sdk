// DataTransferType.cs
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
    public enum DataTransferType
    {
        [EnumMember(Value = "EMPTY_VALUE")]
        EMPTY_VALUE,

        [EnumMember(Value = "EXPORT")]
        EXPORT,

        [EnumMember(Value = "HYDRATION")]
        HYDRATION,

        [EnumMember(Value = "INPLACE")]
        INPLACE,

        [EnumMember(Value = "LIVEMOUNT")]
        LIVEMOUNT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DataTransferType

} // namespace RubrikSecurityCloud.Types