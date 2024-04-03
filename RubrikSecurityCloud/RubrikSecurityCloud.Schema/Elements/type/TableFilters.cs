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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "ProtectionTaskDetailsTable" + " " + "{\n" + fspec + ind + "}\n" ;
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
                    s += ind + "RecoveryTaskDetailsTable" + " " + "{\n" + fspec + ind + "}\n" ;
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<TableFilters> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TableFilters> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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