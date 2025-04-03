// HostMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters.cs
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
    public enum HostMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HOST_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_ALL")]
        HOST_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_ALL,

        [EnumMember(Value = "HOST_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_CURRENT_PRIMARY")]
        HOST_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_CURRENT_PRIMARY,

        [EnumMember(Value = "HOST_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_NONE")]
        HOST_MAKE_PRIMARY_REQUEST_SHOULD_SKIP_CERTIFICATE_UPDATE_ON_SECONDARY_CLUSTERS_SKIP_NONE


    } // enum HostMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters

} // namespace RubrikSecurityCloud.Types