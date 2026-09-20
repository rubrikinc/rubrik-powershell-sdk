// RegistryHiveRoot.cs
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
    public enum RegistryHiveRoot
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HIVE_ROOT_HKEY_CLASSES_ROOT")]
        HIVE_ROOT_HKEY_CLASSES_ROOT,

        [EnumMember(Value = "HIVE_ROOT_HKEY_CURRENT_CONFIG")]
        HIVE_ROOT_HKEY_CURRENT_CONFIG,

        [EnumMember(Value = "HIVE_ROOT_HKEY_CURRENT_USER")]
        HIVE_ROOT_HKEY_CURRENT_USER,

        [EnumMember(Value = "HIVE_ROOT_HKEY_LOCAL_MACHINE")]
        HIVE_ROOT_HKEY_LOCAL_MACHINE,

        [EnumMember(Value = "HIVE_ROOT_HKEY_USERS")]
        HIVE_ROOT_HKEY_USERS


    } // enum RegistryHiveRoot

} // namespace RubrikSecurityCloud.Types