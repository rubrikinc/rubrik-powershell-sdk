// ActivityResult.cs
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
    #region ActivityResult
    public class ActivityResult: BaseType
    {
        #region members

        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        [JsonProperty("accessType")]
        public ActivityAccessType? AccessType { get; set; }

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.Int64? CountDelta
        // GraphQL -> countDelta: Long! (scalar)
        [JsonProperty("countDelta")]
        public System.Int64? CountDelta { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivityResult";
    }

    public ActivityResult Set(
        ActivityAccessType? AccessType = null,
        System.Int64? Count = null,
        System.Int64? CountDelta = null
    ) 
    {
        if ( AccessType != null ) {
            this.AccessType = AccessType;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( CountDelta != null ) {
            this.CountDelta = CountDelta;
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
        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        if (this.AccessType != null) {
            s += ind + "accessType\n" ;
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> System.Int64? CountDelta
        // GraphQL -> countDelta: Long! (scalar)
        if (this.CountDelta != null) {
            s += ind + "countDelta\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ActivityAccessType? AccessType
        // GraphQL -> accessType: ActivityAccessType! (enum)
        if (this.AccessType == null && ec.Includes("accessType",true))
        {
            this.AccessType = new ActivityAccessType();
        }
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = new System.Int64();
        }
        //      C# -> System.Int64? CountDelta
        // GraphQL -> countDelta: Long! (scalar)
        if (this.CountDelta == null && ec.Includes("countDelta",true))
        {
            this.CountDelta = new System.Int64();
        }
    }


    #endregion

    } // class ActivityResult
    
    #endregion

    public static class ListActivityResultExtensions
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
            this List<ActivityResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActivityResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ActivityResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types