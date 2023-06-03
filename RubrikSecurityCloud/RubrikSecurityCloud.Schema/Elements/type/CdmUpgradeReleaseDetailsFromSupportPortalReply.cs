// CdmUpgradeReleaseDetailsFromSupportPortalReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CdmUpgradeReleaseDetailsFromSupportPortalReply
    public class CdmUpgradeReleaseDetailsFromSupportPortalReply: BaseType
    {
        #region members

        //      C# -> System.String? CompatibilityMatrixLink
        // GraphQL -> compatibilityMatrixLink: String! (scalar)
        [JsonProperty("compatibilityMatrixLink")]
        public System.String? CompatibilityMatrixLink { get; set; }

        //      C# -> System.String? SupportSoftwareLink
        // GraphQL -> supportSoftwareLink: String! (scalar)
        [JsonProperty("supportSoftwareLink")]
        public System.String? SupportSoftwareLink { get; set; }

        //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
        // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
        [JsonProperty("releaseDetails")]
        public List<CdmUpgradeReleaseDetail>? ReleaseDetails { get; set; }


        #endregion

    #region methods

    public CdmUpgradeReleaseDetailsFromSupportPortalReply Set(
        System.String? CompatibilityMatrixLink = null,
        System.String? SupportSoftwareLink = null,
        List<CdmUpgradeReleaseDetail>? ReleaseDetails = null
    ) 
    {
        if ( CompatibilityMatrixLink != null ) {
            this.CompatibilityMatrixLink = CompatibilityMatrixLink;
        }
        if ( SupportSoftwareLink != null ) {
            this.SupportSoftwareLink = SupportSoftwareLink;
        }
        if ( ReleaseDetails != null ) {
            this.ReleaseDetails = ReleaseDetails;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CompatibilityMatrixLink
        // GraphQL -> compatibilityMatrixLink: String! (scalar)
        if (this.CompatibilityMatrixLink != null) {
            s += ind + "compatibilityMatrixLink\n" ;
        }
        //      C# -> System.String? SupportSoftwareLink
        // GraphQL -> supportSoftwareLink: String! (scalar)
        if (this.SupportSoftwareLink != null) {
            s += ind + "supportSoftwareLink\n" ;
        }
        //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
        // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
        if (this.ReleaseDetails != null) {
            s += ind + "releaseDetails {\n" + this.ReleaseDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CompatibilityMatrixLink
        // GraphQL -> compatibilityMatrixLink: String! (scalar)
        if (this.CompatibilityMatrixLink == null && Exploration.Includes(parent + ".compatibilityMatrixLink", true))
        {
            this.CompatibilityMatrixLink = new System.String("FETCH");
        }
        //      C# -> System.String? SupportSoftwareLink
        // GraphQL -> supportSoftwareLink: String! (scalar)
        if (this.SupportSoftwareLink == null && Exploration.Includes(parent + ".supportSoftwareLink", true))
        {
            this.SupportSoftwareLink = new System.String("FETCH");
        }
        //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
        // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
        if (this.ReleaseDetails == null && Exploration.Includes(parent + ".releaseDetails"))
        {
            this.ReleaseDetails = new List<CdmUpgradeReleaseDetail>();
            this.ReleaseDetails.ApplyExploratoryFieldSpec(parent + ".releaseDetails");
        }
    }


    #endregion

    } // class CdmUpgradeReleaseDetailsFromSupportPortalReply
    
    #endregion

    public static class ListCdmUpgradeReleaseDetailsFromSupportPortalReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUpgradeReleaseDetailsFromSupportPortalReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types