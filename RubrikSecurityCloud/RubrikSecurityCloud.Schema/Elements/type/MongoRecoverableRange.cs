// MongoRecoverableRange.cs
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
    #region MongoRecoverableRange
    public class MongoRecoverableRange: BaseType
    {
        #region members

        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime! (scalar)
        [JsonProperty("beginTime")]
        public DateTime? BeginTime { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MongoRecoverableRange";
    }

    public MongoRecoverableRange Set(
        DateTime? BeginTime = null,
        DateTime? EndTime = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
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
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime! (scalar)
        if (this.BeginTime != null) {
            s += ind + "beginTime\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime! (scalar)
        if (this.BeginTime == null && ec.Includes("beginTime",true))
        {
            this.BeginTime = new DateTime();
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new DateTime();
        }
    }


    #endregion

    } // class MongoRecoverableRange
    
    #endregion

    public static class ListMongoRecoverableRangeExtensions
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
            this List<MongoRecoverableRange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongoRecoverableRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoRecoverableRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MongoRecoverableRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types