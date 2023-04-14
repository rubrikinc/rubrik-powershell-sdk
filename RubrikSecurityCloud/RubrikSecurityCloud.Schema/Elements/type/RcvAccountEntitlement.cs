// RcvAccountEntitlement.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region RcvAccountEntitlement
    public class RcvAccountEntitlement: IFragment
    {
        #region members
        //      C# -> RcvEntitlement? ArchiveEntitlement
        // GraphQL -> archiveEntitlement: RcvEntitlement (type)
        [JsonProperty("archiveEntitlement")]
        public RcvEntitlement? ArchiveEntitlement { get; set; }

        //      C# -> RcvEntitlement? BackupEntitlement
        // GraphQL -> backupEntitlement: RcvEntitlement (type)
        [JsonProperty("backupEntitlement")]
        public RcvEntitlement? BackupEntitlement { get; set; }

        //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
        [JsonProperty("entitlements")]
        public List<RcvEntitlementsUsageDetails>? Entitlements { get; set; }

        #endregion

    #region methods

    public RcvAccountEntitlement Set(
        RcvEntitlement? ArchiveEntitlement = null,
        RcvEntitlement? BackupEntitlement = null,
        List<RcvEntitlementsUsageDetails>? Entitlements = null
    ) 
    {
        if ( ArchiveEntitlement != null ) {
            this.ArchiveEntitlement = ArchiveEntitlement;
        }
        if ( BackupEntitlement != null ) {
            this.BackupEntitlement = BackupEntitlement;
        }
        if ( Entitlements != null ) {
            this.Entitlements = Entitlements;
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
            //      C# -> RcvEntitlement? ArchiveEntitlement
            // GraphQL -> archiveEntitlement: RcvEntitlement (type)
            if (this.ArchiveEntitlement != null)
            {
                 s += ind + "archiveEntitlement\n";

                 s += ind + "{\n" + 
                 this.ArchiveEntitlement.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RcvEntitlement? BackupEntitlement
            // GraphQL -> backupEntitlement: RcvEntitlement (type)
            if (this.BackupEntitlement != null)
            {
                 s += ind + "backupEntitlement\n";

                 s += ind + "{\n" + 
                 this.BackupEntitlement.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
            // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
            if (this.Entitlements != null)
            {
                 s += ind + "entitlements\n";

                 s += ind + "{\n" + 
                 this.Entitlements.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> RcvEntitlement? ArchiveEntitlement
            // GraphQL -> archiveEntitlement: RcvEntitlement (type)
            if (this.ArchiveEntitlement == null && Exploration.Includes(parent + ".archiveEntitlement"))
            {
                this.ArchiveEntitlement = new RcvEntitlement();
                this.ArchiveEntitlement.ApplyExploratoryFragment(parent + ".archiveEntitlement");
            }
            //      C# -> RcvEntitlement? BackupEntitlement
            // GraphQL -> backupEntitlement: RcvEntitlement (type)
            if (this.BackupEntitlement == null && Exploration.Includes(parent + ".backupEntitlement"))
            {
                this.BackupEntitlement = new RcvEntitlement();
                this.BackupEntitlement.ApplyExploratoryFragment(parent + ".backupEntitlement");
            }
            //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
            // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
            if (this.Entitlements == null && Exploration.Includes(parent + ".entitlements"))
            {
                this.Entitlements = new List<RcvEntitlementsUsageDetails>();
                this.Entitlements.ApplyExploratoryFragment(parent + ".entitlements");
            }
        }


    #endregion

    } // class RcvAccountEntitlement
    #endregion

    public static class ListRcvAccountEntitlementExtensions
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
            this List<RcvAccountEntitlement> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RcvAccountEntitlement> list, 
            String parent = "")
        {
            var item = new RcvAccountEntitlement();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types