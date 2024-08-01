// ManagedVolumeApplicationTag.cs
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
    public enum ManagedVolumeApplicationTag
    {
        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_DB_TRANSACTION_LOG")]
        MANAGED_VOLUME_APPLICATION_TAG_DB_TRANSACTION_LOG,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_MS_SQL")]
        MANAGED_VOLUME_APPLICATION_TAG_MS_SQL,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_MY_SQL")]
        MANAGED_VOLUME_APPLICATION_TAG_MY_SQL,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_ORACLE")]
        MANAGED_VOLUME_APPLICATION_TAG_ORACLE,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_ORACLE_INCREMENTAL")]
        MANAGED_VOLUME_APPLICATION_TAG_ORACLE_INCREMENTAL,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_POSTGRE_SQL")]
        MANAGED_VOLUME_APPLICATION_TAG_POSTGRE_SQL,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_RECOVER_X")]
        MANAGED_VOLUME_APPLICATION_TAG_RECOVER_X,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_SAP_HANA")]
        MANAGED_VOLUME_APPLICATION_TAG_SAP_HANA,

        [EnumMember(Value = "MANAGED_VOLUME_APPLICATION_TAG_SAP_HANA_LOG")]
        MANAGED_VOLUME_APPLICATION_TAG_SAP_HANA_LOG,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ManagedVolumeApplicationTag

} // namespace RubrikSecurityCloud.Types