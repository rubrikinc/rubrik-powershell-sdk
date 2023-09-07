// TprRequestedChangeServiceAccountEntry.cs
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
    #region TprRequestedChangeServiceAccountEntry
    public class TprRequestedChangeServiceAccountEntry: BaseType
    {
        #region members

        //      C# -> List<ServiceAccountClient>? NewValue
        // GraphQL -> newValue: [ServiceAccountClient!]! (type)
        [JsonProperty("newValue")]
        public List<ServiceAccountClient>? NewValue { get; set; }

        //      C# -> List<ServiceAccountClient>? OldValue
        // GraphQL -> oldValue: [ServiceAccountClient!]! (type)
        [JsonProperty("oldValue")]
        public List<ServiceAccountClient>? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeServiceAccountEntry";
    }

    public TprRequestedChangeServiceAccountEntry Set(
        List<ServiceAccountClient>? NewValue = null,
        List<ServiceAccountClient>? OldValue = null
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
        //      C# -> List<ServiceAccountClient>? NewValue
        // GraphQL -> newValue: [ServiceAccountClient!]! (type)
        if (this.NewValue != null) {
            var fspec = this.NewValue.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newValue {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ServiceAccountClient>? OldValue
        // GraphQL -> oldValue: [ServiceAccountClient!]! (type)
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
        //      C# -> List<ServiceAccountClient>? NewValue
        // GraphQL -> newValue: [ServiceAccountClient!]! (type)
        if (this.NewValue == null && ec.Includes("newValue",false))
        {
            this.NewValue = new List<ServiceAccountClient>();
            this.NewValue.ApplyExploratoryFieldSpec(ec.NewChild("newValue"));
        }
        //      C# -> List<ServiceAccountClient>? OldValue
        // GraphQL -> oldValue: [ServiceAccountClient!]! (type)
        if (this.OldValue == null && ec.Includes("oldValue",false))
        {
            this.OldValue = new List<ServiceAccountClient>();
            this.OldValue.ApplyExploratoryFieldSpec(ec.NewChild("oldValue"));
        }
    }


    #endregion

    } // class TprRequestedChangeServiceAccountEntry
    
    #endregion

    public static class ListTprRequestedChangeServiceAccountEntryExtensions
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
            this List<TprRequestedChangeServiceAccountEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeServiceAccountEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeServiceAccountEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TprRequestedChangeServiceAccountEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types