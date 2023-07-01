// TargetEncryptionTypeEnum.cs
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
    public enum TargetEncryptionTypeEnum
    {
        [EnumMember(Value = "ENCRYPTION_PASSWORD_BASED")]
        ENCRYPTION_PASSWORD_BASED,

        [EnumMember(Value = "KMS_MASTER_KEY_BASED")]
        KMS_MASTER_KEY_BASED,

        [EnumMember(Value = "RSA_KEY_BASED")]
        RSA_KEY_BASED,

        [EnumMember(Value = "UNKNOWN_ENCRYPTION_TYPE")]
        UNKNOWN_ENCRYPTION_TYPE


    } // enum TargetEncryptionTypeEnum

} // namespace RubrikSecurityCloud.Types