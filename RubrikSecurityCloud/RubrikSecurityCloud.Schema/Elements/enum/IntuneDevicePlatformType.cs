// IntuneDevicePlatformType.cs
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
    public enum IntuneDevicePlatformType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_ANDROID")]
        INTUNE_DEVICE_PLATFORM_TYPE_ANDROID,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_AOSP")]
        INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_AOSP,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_FOR_WORK")]
        INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_FOR_WORK,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_MOBILE_APPLICATION_MANAGEMENT")]
        INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_MOBILE_APPLICATION_MANAGEMENT,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_WORK_PROFILE")]
        INTUNE_DEVICE_PLATFORM_TYPE_ANDROID_WORK_PROFILE,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_IOS")]
        INTUNE_DEVICE_PLATFORM_TYPE_IOS,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_IOS_MOBILE_APPLICATION_MANAGEMENT")]
        INTUNE_DEVICE_PLATFORM_TYPE_IOS_MOBILE_APPLICATION_MANAGEMENT,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_MACOS")]
        INTUNE_DEVICE_PLATFORM_TYPE_MACOS,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_UNKNOWN")]
        INTUNE_DEVICE_PLATFORM_TYPE_UNKNOWN,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_10_AND_LATER")]
        INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_10_AND_LATER,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_81_AND_LATER")]
        INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_81_AND_LATER,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_MOBILE_APPLICATION_MANAGEMENT")]
        INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_MOBILE_APPLICATION_MANAGEMENT,

        [EnumMember(Value = "INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_PHONE_81")]
        INTUNE_DEVICE_PLATFORM_TYPE_WINDOWS_PHONE_81


    } // enum IntuneDevicePlatformType

} // namespace RubrikSecurityCloud.Types