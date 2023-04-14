// ClusterLicenseInfoType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum ClusterLicenseInfoType
    {
        [EnumMember(Value = "EXPIRED_TERM")]
        EXPIRED_TERM,

        [EnumMember(Value = "INFO_TYPE_UNSPECIFIED")]
        INFO_TYPE_UNSPECIFIED,

        [EnumMember(Value = "INSUFFICIENT_CAPACITY")]
        INSUFFICIENT_CAPACITY,

        [EnumMember(Value = "LICENSE_NOT_FOUND")]
        LICENSE_NOT_FOUND,

        [EnumMember(Value = "VALID_LICENSE")]
        VALID_LICENSE


    } // enum ClusterLicenseInfoType

} // namespace Rubrik.SecurityCloud.Types