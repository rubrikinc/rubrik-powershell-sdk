// CdmUpgradeReleaseDetailsFromSupportPortalReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region CdmUpgradeReleaseDetailsFromSupportPortalReply
    public class CdmUpgradeReleaseDetailsFromSupportPortalReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CompatibilityMatrixLink
            // GraphQL -> compatibilityMatrixLink: String! (scalar)
            if (this.CompatibilityMatrixLink != null)
            {
                 s += ind + "compatibilityMatrixLink\n";

            }
            //      C# -> System.String? SupportSoftwareLink
            // GraphQL -> supportSoftwareLink: String! (scalar)
            if (this.SupportSoftwareLink != null)
            {
                 s += ind + "supportSoftwareLink\n";

            }
            //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
            // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
            if (this.ReleaseDetails != null)
            {
                 s += ind + "releaseDetails\n";

                 s += ind + "{\n" + 
                 this.ReleaseDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CompatibilityMatrixLink
            // GraphQL -> compatibilityMatrixLink: String! (scalar)
            if (this.CompatibilityMatrixLink == null && Exploration.Includes(parent + ".compatibilityMatrixLink$"))
            {
                this.CompatibilityMatrixLink = new System.String("FETCH");
            }
            //      C# -> System.String? SupportSoftwareLink
            // GraphQL -> supportSoftwareLink: String! (scalar)
            if (this.SupportSoftwareLink == null && Exploration.Includes(parent + ".supportSoftwareLink$"))
            {
                this.SupportSoftwareLink = new System.String("FETCH");
            }
            //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
            // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
            if (this.ReleaseDetails == null && Exploration.Includes(parent + ".releaseDetails"))
            {
                this.ReleaseDetails = new List<CdmUpgradeReleaseDetail>();
                this.ReleaseDetails.ApplyExploratoryFragment(parent + ".releaseDetails");
            }
        }


    #endregion

    } // class CdmUpgradeReleaseDetailsFromSupportPortalReply
    #endregion

    public static class ListCdmUpgradeReleaseDetailsFromSupportPortalReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list, 
            String parent = "")
        {
            var item = new CdmUpgradeReleaseDetailsFromSupportPortalReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types