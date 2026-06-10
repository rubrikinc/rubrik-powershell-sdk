// HostConfigurationPropertyEnabled.cs
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
    public enum HostConfigurationPropertyEnabled
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HOST_CONFIGURATION_PROPERTY_ENABLED_DEFAULT")]
        HOST_CONFIGURATION_PROPERTY_ENABLED_DEFAULT,

        [EnumMember(Value = "HOST_CONFIGURATION_PROPERTY_ENABLED_DISABLED")]
        HOST_CONFIGURATION_PROPERTY_ENABLED_DISABLED,

        [EnumMember(Value = "HOST_CONFIGURATION_PROPERTY_ENABLED_ENABLED")]
        HOST_CONFIGURATION_PROPERTY_ENABLED_ENABLED


    } // enum HostConfigurationPropertyEnabled

} // namespace RubrikSecurityCloud.Types