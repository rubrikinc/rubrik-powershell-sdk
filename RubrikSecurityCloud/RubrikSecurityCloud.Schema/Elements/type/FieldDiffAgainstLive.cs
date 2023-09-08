// FieldDiffAgainstLive.cs
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
    #region FieldDiffAgainstLive
    public class FieldDiffAgainstLive: BaseType
    {
        #region members

        //      C# -> System.String? FieldName
        // GraphQL -> fieldName: String! (scalar)
        [JsonProperty("fieldName")]
        public System.String? FieldName { get; set; }

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
        return "FieldDiffAgainstLive";
    }

    public FieldDiffAgainstLive Set(
        System.String? FieldName = null,
        System.String? NewValue = null,
        System.String? OldValue = null
    ) 
    {
        if ( FieldName != null ) {
            this.FieldName = FieldName;
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
        //      C# -> System.String? FieldName
        // GraphQL -> fieldName: String! (scalar)
        if (this.FieldName != null) {
            s += ind + "fieldName\n" ;
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
        //      C# -> System.String? FieldName
        // GraphQL -> fieldName: String! (scalar)
        if (this.FieldName == null && ec.Includes("fieldName",true))
        {
            this.FieldName = "FETCH";
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

    } // class FieldDiffAgainstLive
    
    #endregion

    public static class ListFieldDiffAgainstLiveExtensions
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
            this List<FieldDiffAgainstLive> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FieldDiffAgainstLive> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FieldDiffAgainstLive());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FieldDiffAgainstLive> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types