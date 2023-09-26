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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable
        // GraphQL -> ProtectionTaskDetailsTable: ProtectionTaskDetailsTableFilter! (type)
        if (this.ProtectionTaskDetailsTable != null) {
            var fspec = this.ProtectionTaskDetailsTable.AsFieldSpec(conf.Child("ProtectionTaskDetailsTable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ProtectionTaskDetailsTable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable
        // GraphQL -> RecoveryTaskDetailsTable: RecoveryTaskDetailsTableFilter! (type)
        if (this.RecoveryTaskDetailsTable != null) {
            var fspec = this.RecoveryTaskDetailsTable.AsFieldSpec(conf.Child("RecoveryTaskDetailsTable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "RecoveryTaskDetailsTable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ProtectionTaskDetailsTableFilter? ProtectionTaskDetailsTable
        // GraphQL -> ProtectionTaskDetailsTable: ProtectionTaskDetailsTableFilter! (type)
        if (ec.Includes("ProtectionTaskDetailsTable",false))
        {
            if(this.ProtectionTaskDetailsTable == null) {

                this.ProtectionTaskDetailsTable = new ProtectionTaskDetailsTableFilter();
                this.ProtectionTaskDetailsTable.ApplyExploratoryFieldSpec(ec.NewChild("ProtectionTaskDetailsTable"));

            } else {

                this.ProtectionTaskDetailsTable.ApplyExploratoryFieldSpec(ec.NewChild("ProtectionTaskDetailsTable"));

            }
        }
        else if (this.ProtectionTaskDetailsTable != null && ec.Excludes("ProtectionTaskDetailsTable",false))
        {
            this.ProtectionTaskDetailsTable = null;
        }
        //      C# -> RecoveryTaskDetailsTableFilter? RecoveryTaskDetailsTable
        // GraphQL -> RecoveryTaskDetailsTable: RecoveryTaskDetailsTableFilter! (type)
        if (ec.Includes("RecoveryTaskDetailsTable",false))
        {
            if(this.RecoveryTaskDetailsTable == null) {

                this.RecoveryTaskDetailsTable = new RecoveryTaskDetailsTableFilter();
                this.RecoveryTaskDetailsTable.ApplyExploratoryFieldSpec(ec.NewChild("RecoveryTaskDetailsTable"));

            } else {

                this.RecoveryTaskDetailsTable.ApplyExploratoryFieldSpec(ec.NewChild("RecoveryTaskDetailsTable"));

            }
        }
        else if (this.RecoveryTaskDetailsTable != null && ec.Excludes("RecoveryTaskDetailsTable",false))
        {
            this.RecoveryTaskDetailsTable = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TableFilters> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TableFilters());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TableFilters> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types