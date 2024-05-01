// WorkloadFields.cs
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
    #region WorkloadFields
    public class WorkloadFields: BaseType
    {
        #region members

        //      C# -> O365SnapshotItemInfo? O365Item
        // GraphQL -> o365Item: O365SnapshotItemInfo (type)
        [JsonProperty("o365Item")]
        public O365SnapshotItemInfo? O365Item { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadFields";
    }

    public WorkloadFields Set(
        O365SnapshotItemInfo? O365Item = null
    ) 
    {
        if ( O365Item != null ) {
            this.O365Item = O365Item;
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
        //      C# -> O365SnapshotItemInfo? O365Item
        // GraphQL -> o365Item: O365SnapshotItemInfo (type)
        if (this.O365Item != null) {
            var fspec = this.O365Item.AsFieldSpec(conf.Child("o365Item"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "o365Item" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365SnapshotItemInfo? O365Item
        // GraphQL -> o365Item: O365SnapshotItemInfo (type)
        if (ec.Includes("o365Item",false))
        {
            if(this.O365Item == null) {

                this.O365Item = new O365SnapshotItemInfo();
                this.O365Item.ApplyExploratoryFieldSpec(ec.NewChild("o365Item"));

            } else {

                this.O365Item.ApplyExploratoryFieldSpec(ec.NewChild("o365Item"));

            }
        }
        else if (this.O365Item != null && ec.Excludes("o365Item",false))
        {
            this.O365Item = null;
        }
    }


    #endregion

    } // class WorkloadFields
    
    #endregion

    public static class ListWorkloadFieldsExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<WorkloadFields> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadFields> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadFields> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadFields());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadFields> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types