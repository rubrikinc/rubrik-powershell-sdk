// AwsLambdaPackageType.cs
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
    public enum AwsLambdaPackageType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_LAMBDA_PACKAGE_TYPE_IMAGE")]
        AWS_LAMBDA_PACKAGE_TYPE_IMAGE,

        [EnumMember(Value = "AWS_LAMBDA_PACKAGE_TYPE_ZIP")]
        AWS_LAMBDA_PACKAGE_TYPE_ZIP


    } // enum AwsLambdaPackageType

} // namespace RubrikSecurityCloud.Types