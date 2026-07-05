// AwsServiceType.cs
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
    public enum AwsServiceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_SERVICE_TYPE_BAAS")]
        AWS_SERVICE_TYPE_BAAS,

        [EnumMember(Value = "AWS_SERVICE_TYPE_NON_BAAS")]
        AWS_SERVICE_TYPE_NON_BAAS,

        [EnumMember(Value = "AWS_SERVICE_TYPE_UNSPECIFIED")]
        AWS_SERVICE_TYPE_UNSPECIFIED


    } // enum AwsServiceType

} // namespace RubrikSecurityCloud.Types