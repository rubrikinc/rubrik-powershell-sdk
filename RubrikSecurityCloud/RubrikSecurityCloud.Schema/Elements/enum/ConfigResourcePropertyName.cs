// ConfigResourcePropertyName.cs
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
    public enum ConfigResourcePropertyName
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFIG_RESOURCE_PROPERTY_NAME_LOAD_BALANCER_STATE")]
        CONFIG_RESOURCE_PROPERTY_NAME_LOAD_BALANCER_STATE,

        [EnumMember(Value = "CONFIG_RESOURCE_PROPERTY_NAME_LOAD_BALANCER_TYPE")]
        CONFIG_RESOURCE_PROPERTY_NAME_LOAD_BALANCER_TYPE,

        [EnumMember(Value = "CONFIG_RESOURCE_PROPERTY_NAME_VPC_ID")]
        CONFIG_RESOURCE_PROPERTY_NAME_VPC_ID,

        [EnumMember(Value = "CONFIG_RESOURCE_PROPERTY_NAME_VPC_STATUS")]
        CONFIG_RESOURCE_PROPERTY_NAME_VPC_STATUS


    } // enum ConfigResourcePropertyName

} // namespace RubrikSecurityCloud.Types