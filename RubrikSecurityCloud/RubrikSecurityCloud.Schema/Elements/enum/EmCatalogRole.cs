// EmCatalogRole.cs
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
    public enum EmCatalogRole
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EM_CATALOG_ROLE_ACCESS_PACKAGE_ASSIGNMENT_MANAGER")]
        EM_CATALOG_ROLE_ACCESS_PACKAGE_ASSIGNMENT_MANAGER,

        [EnumMember(Value = "EM_CATALOG_ROLE_ACCESS_PACKAGE_MANAGER")]
        EM_CATALOG_ROLE_ACCESS_PACKAGE_MANAGER,

        [EnumMember(Value = "EM_CATALOG_ROLE_CATALOG_CREATOR")]
        EM_CATALOG_ROLE_CATALOG_CREATOR,

        [EnumMember(Value = "EM_CATALOG_ROLE_CATALOG_OWNER")]
        EM_CATALOG_ROLE_CATALOG_OWNER,

        [EnumMember(Value = "EM_CATALOG_ROLE_CATALOG_READER")]
        EM_CATALOG_ROLE_CATALOG_READER,

        [EnumMember(Value = "EM_CATALOG_ROLE_CONNECTED_ORGANIZATION_ADMINISTRATOR")]
        EM_CATALOG_ROLE_CONNECTED_ORGANIZATION_ADMINISTRATOR,

        [EnumMember(Value = "EM_CATALOG_ROLE_UNSPECIFIED")]
        EM_CATALOG_ROLE_UNSPECIFIED


    } // enum EmCatalogRole

} // namespace RubrikSecurityCloud.Types