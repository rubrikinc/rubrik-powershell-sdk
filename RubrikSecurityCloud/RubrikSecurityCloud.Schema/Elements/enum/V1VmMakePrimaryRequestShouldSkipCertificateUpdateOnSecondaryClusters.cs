// V1VmMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters.cs
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
    public enum V1VmMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "V1_VM_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_ALL")]
        V1_VM_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_ALL,

        [EnumMember(Value = "V1_VM_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_CURRENT_PRIMARY")]
        V1_VM_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_CURRENT_PRIMARY,

        [EnumMember(Value = "V1_VM_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_NONE")]
        V1_VM_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_NONE


    } // enum V1VmMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters

} // namespace RubrikSecurityCloud.Types