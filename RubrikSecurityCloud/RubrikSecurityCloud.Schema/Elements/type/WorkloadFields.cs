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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "o365Item {\n" + fspec + ind + "}\n" ;
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
            this List<WorkloadFields> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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