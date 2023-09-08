// MssqlMissedRecoverableRange.cs
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
    #region MssqlMissedRecoverableRange
    public class MssqlMissedRecoverableRange: BaseType
    {
        #region members

        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        [JsonProperty("beginTime")]
        public DateTime? BeginTime { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        [JsonProperty("errorType")]
        public System.String? ErrorType { get; set; }

        //      C# -> MssqlMissedRecoverableRangeError? FirstError
        // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
        [JsonProperty("firstError")]
        public MssqlMissedRecoverableRangeError? FirstError { get; set; }

        //      C# -> MssqlMissedRecoverableRangeError? LastError
        // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
        [JsonProperty("lastError")]
        public MssqlMissedRecoverableRangeError? LastError { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlMissedRecoverableRange";
    }

    public MssqlMissedRecoverableRange Set(
        DateTime? BeginTime = null,
        System.String? Description = null,
        DateTime? EndTime = null,
        System.String? ErrorType = null,
        MssqlMissedRecoverableRangeError? FirstError = null,
        MssqlMissedRecoverableRangeError? LastError = null
    ) 
    {
        if ( BeginTime != null ) {
            this.BeginTime = BeginTime;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( ErrorType != null ) {
            this.ErrorType = ErrorType;
        }
        if ( FirstError != null ) {
            this.FirstError = FirstError;
        }
        if ( LastError != null ) {
            this.LastError = LastError;
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
        // GraphQL -> beginTime: DateTime (scalar)
        if (this.BeginTime != null) {
            s += ind + "beginTime\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (this.ErrorType != null) {
            s += ind + "errorType\n" ;
        }
        //      C# -> MssqlMissedRecoverableRangeError? FirstError
        // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
        if (this.FirstError != null) {
            var fspec = this.FirstError.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "firstError {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlMissedRecoverableRangeError? LastError
        // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
        if (this.LastError != null) {
            var fspec = this.LastError.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lastError {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        if (this.BeginTime == null && ec.Includes("beginTime",true))
        {
            this.BeginTime = new DateTime();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (this.ErrorType == null && ec.Includes("errorType",true))
        {
            this.ErrorType = "FETCH";
        }
        //      C# -> MssqlMissedRecoverableRangeError? FirstError
        // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
        if (this.FirstError == null && ec.Includes("firstError",false))
        {
            this.FirstError = new MssqlMissedRecoverableRangeError();
            this.FirstError.ApplyExploratoryFieldSpec(ec.NewChild("firstError"));
        }
        //      C# -> MssqlMissedRecoverableRangeError? LastError
        // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
        if (this.LastError == null && ec.Includes("lastError",false))
        {
            this.LastError = new MssqlMissedRecoverableRangeError();
            this.LastError.ApplyExploratoryFieldSpec(ec.NewChild("lastError"));
        }
    }


    #endregion

    } // class MssqlMissedRecoverableRange
    
    #endregion

    public static class ListMssqlMissedRecoverableRangeExtensions
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
            this List<MssqlMissedRecoverableRange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlMissedRecoverableRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlMissedRecoverableRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MssqlMissedRecoverableRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types