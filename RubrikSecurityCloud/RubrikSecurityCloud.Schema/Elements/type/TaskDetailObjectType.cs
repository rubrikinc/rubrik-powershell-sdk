// TaskDetailObjectType.cs
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
    #region TaskDetailObjectType
 
    public class TaskDetailObjectType: BaseType, TaskDetailGroupByInfo
    {
        #region members

        //      C# -> System.String? StringValue
        // GraphQL -> stringValue: String! (scalar)
        [JsonProperty("stringValue")]
        public System.String? StringValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TaskDetailObjectType";
    }

    public TaskDetailObjectType Set(
        System.String? StringValue = null
    ) 
    {
        if ( StringValue != null ) {
            this.StringValue = StringValue;
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
        //      C# -> System.String? StringValue
        // GraphQL -> stringValue: String! (scalar)
        if (this.StringValue != null) {
            s += ind + "stringValue\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? StringValue
        // GraphQL -> stringValue: String! (scalar)
        if (this.StringValue == null && ec.Includes("stringValue",true))
        {
            this.StringValue = "FETCH";
        }
    }


    #endregion

    } // class TaskDetailObjectType
    
    #endregion

    public static class ListTaskDetailObjectTypeExtensions
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
            this List<TaskDetailObjectType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskDetailObjectType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskDetailObjectType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TaskDetailObjectType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types