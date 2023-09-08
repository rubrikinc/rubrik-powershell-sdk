// TprRequestedChangeManagedObjectEntry.cs
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
    #region TprRequestedChangeManagedObjectEntry
    public class TprRequestedChangeManagedObjectEntry: BaseType
    {
        #region members

        //      C# -> List<TprPolicyObject>? NewValue
        // GraphQL -> newValue: [TprPolicyObject!]! (type)
        [JsonProperty("newValue")]
        public List<TprPolicyObject>? NewValue { get; set; }

        //      C# -> List<TprPolicyObject>? OldValue
        // GraphQL -> oldValue: [TprPolicyObject!]! (type)
        [JsonProperty("oldValue")]
        public List<TprPolicyObject>? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeManagedObjectEntry";
    }

    public TprRequestedChangeManagedObjectEntry Set(
        List<TprPolicyObject>? NewValue = null,
        List<TprPolicyObject>? OldValue = null
    ) 
    {
        if ( NewValue != null ) {
            this.NewValue = NewValue;
        }
        if ( OldValue != null ) {
            this.OldValue = OldValue;
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
        //      C# -> List<TprPolicyObject>? NewValue
        // GraphQL -> newValue: [TprPolicyObject!]! (type)
        if (this.NewValue != null) {
            var fspec = this.NewValue.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newValue {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TprPolicyObject>? OldValue
        // GraphQL -> oldValue: [TprPolicyObject!]! (type)
        if (this.OldValue != null) {
            var fspec = this.OldValue.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldValue {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<TprPolicyObject>? NewValue
        // GraphQL -> newValue: [TprPolicyObject!]! (type)
        if (this.NewValue == null && ec.Includes("newValue",false))
        {
            this.NewValue = new List<TprPolicyObject>();
            this.NewValue.ApplyExploratoryFieldSpec(ec.NewChild("newValue"));
        }
        //      C# -> List<TprPolicyObject>? OldValue
        // GraphQL -> oldValue: [TprPolicyObject!]! (type)
        if (this.OldValue == null && ec.Includes("oldValue",false))
        {
            this.OldValue = new List<TprPolicyObject>();
            this.OldValue.ApplyExploratoryFieldSpec(ec.NewChild("oldValue"));
        }
    }


    #endregion

    } // class TprRequestedChangeManagedObjectEntry
    
    #endregion

    public static class ListTprRequestedChangeManagedObjectEntryExtensions
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
            this List<TprRequestedChangeManagedObjectEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeManagedObjectEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeManagedObjectEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TprRequestedChangeManagedObjectEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types