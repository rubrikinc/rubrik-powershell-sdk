// TableFilters.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region TableFilters
    public class TableFilters: BaseType
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

    public override string GetGqlTypeName() {
        return "TableFilters";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable
        // GraphQL -> ProtectionTaskDetailsTable: ProtectionTaskDetailsTableFilter! (type)
        if (this.ProtectionTaskDetailsTable != null) {
            var fspec = this.ProtectionTaskDetailsTable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ProtectionTaskDetailsTable {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable
        // GraphQL -> RecoveryTaskDetailsTable: RecoveryTaskDetailsTableFilter! (type)
        if (this.RecoveryTaskDetailsTable != null) {
            var fspec = this.RecoveryTaskDetailsTable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "RecoveryTaskDetailsTable {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable
        // GraphQL -> ProtectionTaskDetailsTable: ProtectionTaskDetailsTableFilter! (type)
        if (this.ProtectionTaskDetailsTable == null && Exploration.Includes(parent + ".ProtectionTaskDetailsTable"))
        {
            this.ProtectionTaskDetailsTable = new ProtectionTaskDetailsTableFilter();
            this.ProtectionTaskDetailsTable.ApplyExploratoryFieldSpec(parent + ".ProtectionTaskDetailsTable");
        }
        //      C# -> RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable
        // GraphQL -> RecoveryTaskDetailsTable: RecoveryTaskDetailsTableFilter! (type)
        if (this.RecoveryTaskDetailsTable == null && Exploration.Includes(parent + ".RecoveryTaskDetailsTable"))
        {
            this.RecoveryTaskDetailsTable = new RecoveryTaskDetailsTableFilter();
            this.RecoveryTaskDetailsTable.ApplyExploratoryFieldSpec(parent + ".RecoveryTaskDetailsTable");
        }
    }


    #endregion

    } // class TableFilters
    
    #endregion

    public static class ListTableFiltersExtensions
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
            this List<TableFilters> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TableFilters> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TableFilters());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types