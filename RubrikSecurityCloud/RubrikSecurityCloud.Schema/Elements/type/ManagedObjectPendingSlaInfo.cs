// ManagedObjectPendingSlaInfo.cs
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
    #region ManagedObjectPendingSlaInfo
    public class ManagedObjectPendingSlaInfo: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
        // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isPendingSlaDomainRetentionLocked")]
        public System.Boolean? IsPendingSlaDomainRetentionLocked { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? PendingSlaDomainId
        // GraphQL -> pendingSlaDomainId: String! (scalar)
        [JsonProperty("pendingSlaDomainId")]
        public System.String? PendingSlaDomainId { get; set; }

        //      C# -> System.String? PendingSlaDomainName
        // GraphQL -> pendingSlaDomainName: String! (scalar)
        [JsonProperty("pendingSlaDomainName")]
        public System.String? PendingSlaDomainName { get; set; }

        #endregion

    #region methods

    public ManagedObjectPendingSlaInfo Set(
        System.Boolean? IsPendingSlaDomainRetentionLocked = null,
        System.String? ObjectId = null,
        System.String? PendingSlaDomainId = null,
        System.String? PendingSlaDomainName = null
    ) 
    {
        if ( IsPendingSlaDomainRetentionLocked != null ) {
            this.IsPendingSlaDomainRetentionLocked = IsPendingSlaDomainRetentionLocked;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( PendingSlaDomainId != null ) {
            this.PendingSlaDomainId = PendingSlaDomainId;
        }
        if ( PendingSlaDomainName != null ) {
            this.PendingSlaDomainName = PendingSlaDomainName;
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
            //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
            // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
            if (this.IsPendingSlaDomainRetentionLocked != null)
            {
                 s += ind + "isPendingSlaDomainRetentionLocked\n";

            }
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId != null)
            {
                 s += ind + "objectId\n";

            }
            //      C# -> System.String? PendingSlaDomainId
            // GraphQL -> pendingSlaDomainId: String! (scalar)
            if (this.PendingSlaDomainId != null)
            {
                 s += ind + "pendingSlaDomainId\n";

            }
            //      C# -> System.String? PendingSlaDomainName
            // GraphQL -> pendingSlaDomainName: String! (scalar)
            if (this.PendingSlaDomainName != null)
            {
                 s += ind + "pendingSlaDomainName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
            // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
            if (this.IsPendingSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isPendingSlaDomainRetentionLocked$"))
            {
                this.IsPendingSlaDomainRetentionLocked = new System.Boolean();
            }
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId == null && Exploration.Includes(parent + ".objectId$"))
            {
                this.ObjectId = new System.String("FETCH");
            }
            //      C# -> System.String? PendingSlaDomainId
            // GraphQL -> pendingSlaDomainId: String! (scalar)
            if (this.PendingSlaDomainId == null && Exploration.Includes(parent + ".pendingSlaDomainId$"))
            {
                this.PendingSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? PendingSlaDomainName
            // GraphQL -> pendingSlaDomainName: String! (scalar)
            if (this.PendingSlaDomainName == null && Exploration.Includes(parent + ".pendingSlaDomainName$"))
            {
                this.PendingSlaDomainName = new System.String("FETCH");
            }
        }


    #endregion

    } // class ManagedObjectPendingSlaInfo
    #endregion

    public static class ListManagedObjectPendingSlaInfoExtensions
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
            this List<ManagedObjectPendingSlaInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedObjectPendingSlaInfo> list, 
            String parent = "")
        {
            var item = new ManagedObjectPendingSlaInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types