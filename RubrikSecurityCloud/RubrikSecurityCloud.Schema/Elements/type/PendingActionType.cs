// PendingActionType.cs
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
    #region PendingActionType
    public class PendingActionType: IFragment
    {
        #region members
        //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
        // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
        [JsonProperty("pendingActionGroupType")]
        public PendingActionGroupTypeEnum? PendingActionGroupType { get; set; }

        //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
        // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
        [JsonProperty("pendingActionSubGroupType")]
        public PendingActionSubGroupTypeEnum? PendingActionSubGroupType { get; set; }

        //      C# -> PendingActionSyncType? PendingActionSyncType
        // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
        [JsonProperty("pendingActionSyncType")]
        public PendingActionSyncType? PendingActionSyncType { get; set; }

        #endregion

    #region methods

    public PendingActionType Set(
        PendingActionGroupTypeEnum? PendingActionGroupType = null,
        PendingActionSubGroupTypeEnum? PendingActionSubGroupType = null,
        PendingActionSyncType? PendingActionSyncType = null
    ) 
    {
        if ( PendingActionGroupType != null ) {
            this.PendingActionGroupType = PendingActionGroupType;
        }
        if ( PendingActionSubGroupType != null ) {
            this.PendingActionSubGroupType = PendingActionSubGroupType;
        }
        if ( PendingActionSyncType != null ) {
            this.PendingActionSyncType = PendingActionSyncType;
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
            //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
            // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
            if (this.PendingActionGroupType != null)
            {
                 s += ind + "pendingActionGroupType\n";

            }
            //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
            // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
            if (this.PendingActionSubGroupType != null)
            {
                 s += ind + "pendingActionSubGroupType\n";

            }
            //      C# -> PendingActionSyncType? PendingActionSyncType
            // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
            if (this.PendingActionSyncType != null)
            {
                 s += ind + "pendingActionSyncType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
            // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
            if (this.PendingActionGroupType == null && Exploration.Includes(parent + ".pendingActionGroupType$"))
            {
                this.PendingActionGroupType = new PendingActionGroupTypeEnum();
            }
            //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
            // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
            if (this.PendingActionSubGroupType == null && Exploration.Includes(parent + ".pendingActionSubGroupType$"))
            {
                this.PendingActionSubGroupType = new PendingActionSubGroupTypeEnum();
            }
            //      C# -> PendingActionSyncType? PendingActionSyncType
            // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
            if (this.PendingActionSyncType == null && Exploration.Includes(parent + ".pendingActionSyncType$"))
            {
                this.PendingActionSyncType = new PendingActionSyncType();
            }
        }


    #endregion

    } // class PendingActionType
    #endregion

    public static class ListPendingActionTypeExtensions
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
            this List<PendingActionType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PendingActionType> list, 
            String parent = "")
        {
            var item = new PendingActionType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types