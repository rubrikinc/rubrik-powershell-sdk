// TprRequestedChangeEntry.cs
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
    #region TprRequestedChangeEntry
    public class TprRequestedChangeEntry: BaseType
    {
        #region members

        //      C# -> System.String? Attribute
        // GraphQL -> attribute: String! (scalar)
        [JsonProperty("attribute")]
        public System.String? Attribute { get; set; }

        //      C# -> System.String? NewValue
        // GraphQL -> newValue: String! (scalar)
        [JsonProperty("newValue")]
        public System.String? NewValue { get; set; }

        //      C# -> System.String? OldValue
        // GraphQL -> oldValue: String! (scalar)
        [JsonProperty("oldValue")]
        public System.String? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeEntry";
    }

    public TprRequestedChangeEntry Set(
        System.String? Attribute = null,
        System.String? NewValue = null,
        System.String? OldValue = null
    ) 
    {
        if ( Attribute != null ) {
            this.Attribute = Attribute;
        }
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
        //      C# -> System.String? Attribute
        // GraphQL -> attribute: String! (scalar)
        if (this.Attribute != null) {
            s += ind + "attribute\n" ;
        }
        //      C# -> System.String? NewValue
        // GraphQL -> newValue: String! (scalar)
        if (this.NewValue != null) {
            s += ind + "newValue\n" ;
        }
        //      C# -> System.String? OldValue
        // GraphQL -> oldValue: String! (scalar)
        if (this.OldValue != null) {
            s += ind + "oldValue\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Attribute
        // GraphQL -> attribute: String! (scalar)
        if (this.Attribute == null && ec.Includes("attribute",true))
        {
            this.Attribute = "FETCH";
        }
        //      C# -> System.String? NewValue
        // GraphQL -> newValue: String! (scalar)
        if (this.NewValue == null && ec.Includes("newValue",true))
        {
            this.NewValue = "FETCH";
        }
        //      C# -> System.String? OldValue
        // GraphQL -> oldValue: String! (scalar)
        if (this.OldValue == null && ec.Includes("oldValue",true))
        {
            this.OldValue = "FETCH";
        }
    }


    #endregion

    } // class TprRequestedChangeEntry
    
    #endregion

    public static class ListTprRequestedChangeEntryExtensions
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
            this List<TprRequestedChangeEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TprRequestedChangeEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types