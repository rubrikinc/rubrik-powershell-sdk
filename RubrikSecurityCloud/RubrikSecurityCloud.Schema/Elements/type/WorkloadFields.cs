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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> O365SnapshotItemInfo? O365Item
        // GraphQL -> o365Item: O365SnapshotItemInfo (type)
        if (this.O365Item != null) {
            var fspec = this.O365Item.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "o365Item {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> O365SnapshotItemInfo? O365Item
        // GraphQL -> o365Item: O365SnapshotItemInfo (type)
        if (this.O365Item == null && Exploration.Includes(parent + ".o365Item"))
        {
            this.O365Item = new O365SnapshotItemInfo();
            this.O365Item.ApplyExploratoryFieldSpec(parent + ".o365Item");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadFields> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadFields());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types