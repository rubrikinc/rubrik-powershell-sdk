// CloudNativeAppDiscoveryMethod.cs
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
    public enum CloudNativeAppDiscoveryMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_NATIVE_APP_AUTO_DISCOVERY")]
        CLOUD_NATIVE_APP_AUTO_DISCOVERY,

        [EnumMember(Value = "CLOUD_NATIVE_APP_DISCOVERY_METHOD_UNSPECIFIED")]
        CLOUD_NATIVE_APP_DISCOVERY_METHOD_UNSPECIFIED,

        [EnumMember(Value = "CLOUD_NATIVE_APP_TAG_BASED")]
        CLOUD_NATIVE_APP_TAG_BASED


    } // enum CloudNativeAppDiscoveryMethod

} // namespace RubrikSecurityCloud.Types