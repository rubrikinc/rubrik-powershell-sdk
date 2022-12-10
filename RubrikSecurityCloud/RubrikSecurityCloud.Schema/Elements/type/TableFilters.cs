// TableFilters.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:33.
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
    #region TableFilters
    public class TableFilters: IFragment
    {
        #region members
        //      C# -> ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable
        // GraphQL -> ProtectionTaskDetailsTable: ProtectionTaskDetailsTableFilter! (type)
        [JsonProperty("ProtectionTaskDetailsTable")]
        public ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable { get; set; }

        //      C# -> RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable
        // GraphQL -> RecoveryTaskDetailsTable: RecoveryTaskDetailsTableFilter! (type)
        [JsonProperty("RecoveryTaskDetailsTable")]
        public RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable { get; set; }

        #endregion

    #region methods

    public TableFilters Set(
        ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable = null,
        RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable = null
    ) 
    {
        if ( ProtectionTaskDetailsTable != null ) {
            this.ProtectionTaskDetailsTable = ProtectionTaskDetailsTable;
        }
        if ( RecoveryTaskDetailsTable != null ) {
            this.RecoveryTaskDetailsTable = RecoveryTaskDetailsTable;
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
            //      C# -> ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable
            // GraphQL -> ProtectionTaskDetailsTable: ProtectionTaskDetailsTableFilter! (type)
            if (this.ProtectionTaskDetailsTable != null)
            {
                 s += ind + "ProtectionTaskDetailsTable\n";

                 s += ind + "{\n" + 
                 this.ProtectionTaskDetailsTable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable
            // GraphQL -> RecoveryTaskDetailsTable: RecoveryTaskDetailsTableFilter! (type)
            if (this.RecoveryTaskDetailsTable != null)
            {
                 s += ind + "RecoveryTaskDetailsTable\n";

                 s += ind + "{\n" + 
                 this.RecoveryTaskDetailsTable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable
            // GraphQL -> ProtectionTaskDetailsTable: ProtectionTaskDetailsTableFilter! (type)
            if (this.ProtectionTaskDetailsTable == null && Exploration.Includes(parent + ".ProtectionTaskDetailsTable"))
            {
                this.ProtectionTaskDetailsTable = new ProtectionTaskDetailsTableFilter();
                this.ProtectionTaskDetailsTable.ApplyExploratoryFragment(parent + ".ProtectionTaskDetailsTable");
            }
            //      C# -> RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable
            // GraphQL -> RecoveryTaskDetailsTable: RecoveryTaskDetailsTableFilter! (type)
            if (this.RecoveryTaskDetailsTable == null && Exploration.Includes(parent + ".RecoveryTaskDetailsTable"))
            {
                this.RecoveryTaskDetailsTable = new RecoveryTaskDetailsTableFilter();
                this.RecoveryTaskDetailsTable.ApplyExploratoryFragment(parent + ".RecoveryTaskDetailsTable");
            }
        }


    #endregion

    } // class TableFilters
    #endregion

    public static class ListTableFiltersExtensions
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
            this List<TableFilters> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TableFilters> list, 
            String parent = "")
        {
            var item = new TableFilters();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types