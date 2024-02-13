// AwsStorageClass.cs
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
    public enum AwsStorageClass
    {
        [EnumMember(Value = "GLACIER_DEEP_ARCHIVE")]
        GLACIER_DEEP_ARCHIVE,

        [EnumMember(Value = "GLACIER_FLEXIBLE_RETRIEVAL")]
        GLACIER_FLEXIBLE_RETRIEVAL,

        [EnumMember(Value = "GLACIER_INSTANT_RETRIEVAL")]
        GLACIER_INSTANT_RETRIEVAL,

        [EnumMember(Value = "ONEZONE_IA")]
        ONEZONE_IA,

        [EnumMember(Value = "STANDARD")]
        STANDARD,

        [EnumMember(Value = "STANDARD_IA")]
        STANDARD_IA,

        [EnumMember(Value = "UNKNOWN_STORAGE_CLASS")]
        UNKNOWN_STORAGE_CLASS


    } // enum AwsStorageClass

} // namespace RubrikSecurityCloud.Types