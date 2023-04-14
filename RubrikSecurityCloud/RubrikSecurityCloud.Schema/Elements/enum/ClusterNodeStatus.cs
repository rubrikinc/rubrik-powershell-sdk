// ClusterNodeStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum ClusterNodeStatus
    {
        [EnumMember(Value = "BAD")]
        BAD,

        [EnumMember(Value = "BOOTSTRAPPING")]
        BOOTSTRAPPING,

        [EnumMember(Value = "JOINING")]
        JOINING,

        [EnumMember(Value = "MAINTENANCE")]
        MAINTENANCE,

        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "PRE_MAINTENANCE")]
        PRE_MAINTENANCE,

        [EnumMember(Value = "REMOVED")]
        REMOVED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UPGRADE")]
        UPGRADE


    } // enum ClusterNodeStatus

} // namespace Rubrik.SecurityCloud.Types