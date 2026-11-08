// AwsParameterGroupType.cs
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
    public enum AwsParameterGroupType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_PARAMETER_GROUP_TYPE_CLUSTER")]
        AWS_PARAMETER_GROUP_TYPE_CLUSTER,

        [EnumMember(Value = "AWS_PARAMETER_GROUP_TYPE_INSTANCE")]
        AWS_PARAMETER_GROUP_TYPE_INSTANCE


    } // enum AwsParameterGroupType

} // namespace RubrikSecurityCloud.Types