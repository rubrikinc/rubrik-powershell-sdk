// OracleLastValidationResult.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region OracleLastValidationResult
    public class OracleLastValidationResult: BaseType
    {
        #region members

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }

        //      C# -> DateTime? ValidationTime
        // GraphQL -> validationTime: DateTime (scalar)
        [JsonProperty("validationTime")]
        public DateTime? ValidationTime { get; set; }


        #endregion

    #region methods

    public OracleLastValidationResult Set(
        System.String? EventSeriesId = null,
        System.Boolean? IsSuccess = null,
        DateTime? ValidationTime = null
    ) 
    {
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
        }
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
        }
        if ( ValidationTime != null ) {
            this.ValidationTime = ValidationTime;
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
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (this.EventSeriesId != null) {
            s += ind + "eventSeriesId\n" ;
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            s += ind + "isSuccess\n" ;
        }
        //      C# -> DateTime? ValidationTime
        // GraphQL -> validationTime: DateTime (scalar)
        if (this.ValidationTime != null) {
            s += ind + "validationTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (this.EventSeriesId == null && Exploration.Includes(parent + ".eventSeriesId", true))
        {
            this.EventSeriesId = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess == null && Exploration.Includes(parent + ".isSuccess", true))
        {
            this.IsSuccess = true;
        }
        //      C# -> DateTime? ValidationTime
        // GraphQL -> validationTime: DateTime (scalar)
        if (this.ValidationTime == null && Exploration.Includes(parent + ".validationTime", true))
        {
            this.ValidationTime = new DateTime();
        }
    }


    #endregion

    } // class OracleLastValidationResult
    
    #endregion

    public static class ListOracleLastValidationResultExtensions
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
            this List<OracleLastValidationResult> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleLastValidationResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleLastValidationResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types