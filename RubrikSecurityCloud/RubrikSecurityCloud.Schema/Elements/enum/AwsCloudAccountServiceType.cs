// AwsCloudAccountServiceType.cs
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
    public enum AwsCloudAccountServiceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_CLOUD_ACCOUNT_SERVICE_TYPE_BAAS")]
        AWS_CLOUD_ACCOUNT_SERVICE_TYPE_BAAS,

        [EnumMember(Value = "AWS_CLOUD_ACCOUNT_SERVICE_TYPE_NON_BAAS")]
        AWS_CLOUD_ACCOUNT_SERVICE_TYPE_NON_BAAS,

        [EnumMember(Value = "AWS_CLOUD_ACCOUNT_SERVICE_TYPE_UNSPECIFIED")]
        AWS_CLOUD_ACCOUNT_SERVICE_TYPE_UNSPECIFIED


    } // enum AwsCloudAccountServiceType

} // namespace RubrikSecurityCloud.Types