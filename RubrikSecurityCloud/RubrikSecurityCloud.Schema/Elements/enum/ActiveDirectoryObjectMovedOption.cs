// ActiveDirectoryObjectMovedOption.cs
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
    public enum ActiveDirectoryObjectMovedOption
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_MOVED_OPTION_MOVE_BACK_AND_RESTORE_ATTRIBUTES")]
        ACTIVE_DIRECTORY_OBJECT_MOVED_OPTION_MOVE_BACK_AND_RESTORE_ATTRIBUTES,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_MOVED_OPTION_RESTORE_ATTRIBUTES")]
        ACTIVE_DIRECTORY_OBJECT_MOVED_OPTION_RESTORE_ATTRIBUTES,

        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_MOVED_OPTION_SKIP")]
        ACTIVE_DIRECTORY_OBJECT_MOVED_OPTION_SKIP


    } // enum ActiveDirectoryObjectMovedOption

} // namespace RubrikSecurityCloud.Types