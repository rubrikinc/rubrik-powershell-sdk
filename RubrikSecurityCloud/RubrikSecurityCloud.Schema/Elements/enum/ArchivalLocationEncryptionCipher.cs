// ArchivalLocationEncryptionCipher.cs
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
    public enum ArchivalLocationEncryptionCipher
    {
        [EnumMember(Value = "AES_256_ARCHIVAL_ENCRYPTION_CIPHER")]
        AES_256_ARCHIVAL_ENCRYPTION_CIPHER,

        [EnumMember(Value = "UNKNOWN_ARCHIVAL_ENCRYPTION_CIPHER")]
        UNKNOWN_ARCHIVAL_ENCRYPTION_CIPHER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalLocationEncryptionCipher

} // namespace RubrikSecurityCloud.Types