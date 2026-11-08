// PropertyFilterField.cs
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
    public enum PropertyFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_LOAD_BALANCER_STATUS")]
        AWS_LOAD_BALANCER_STATUS,

        [EnumMember(Value = "AWS_LOAD_BALANCER_TYPE")]
        AWS_LOAD_BALANCER_TYPE,

        [EnumMember(Value = "AWS_LOAD_BALANCER_VPC")]
        AWS_LOAD_BALANCER_VPC,

        [EnumMember(Value = "AWS_VPC_STATUS")]
        AWS_VPC_STATUS,

        [EnumMember(Value = "NATIVE_NAME_OR_URI")]
        NATIVE_NAME_OR_URI


    } // enum PropertyFilterField

} // namespace RubrikSecurityCloud.Types