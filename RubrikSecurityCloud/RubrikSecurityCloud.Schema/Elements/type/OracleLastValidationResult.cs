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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "OracleLastValidationResult";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (this.EventSeriesId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventSeriesId\n" ;
            } else {
                s += ind + "eventSeriesId\n" ;
            }
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (this.IsSuccess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSuccess\n" ;
            } else {
                s += ind + "isSuccess\n" ;
            }
        }
        //      C# -> DateTime? ValidationTime
        // GraphQL -> validationTime: DateTime (scalar)
        if (this.ValidationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "validationTime\n" ;
            } else {
                s += ind + "validationTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (ec.Includes("eventSeriesId",true))
        {
            if(this.EventSeriesId == null) {

                this.EventSeriesId = "FETCH";

            } else {


            }
        }
        else if (this.EventSeriesId != null && ec.Excludes("eventSeriesId",true))
        {
            this.EventSeriesId = null;
        }
        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        if (ec.Includes("isSuccess",true))
        {
            if(this.IsSuccess == null) {

                this.IsSuccess = true;

            } else {


            }
        }
        else if (this.IsSuccess != null && ec.Excludes("isSuccess",true))
        {
            this.IsSuccess = null;
        }
        //      C# -> DateTime? ValidationTime
        // GraphQL -> validationTime: DateTime (scalar)
        if (ec.Includes("validationTime",true))
        {
            if(this.ValidationTime == null) {

                this.ValidationTime = new DateTime();

            } else {


            }
        }
        else if (this.ValidationTime != null && ec.Excludes("validationTime",true))
        {
            this.ValidationTime = null;
        }
    }


    #endregion

    } // class OracleLastValidationResult
    
    #endregion

    public static class ListOracleLastValidationResultExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OracleLastValidationResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleLastValidationResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleLastValidationResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleLastValidationResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleLastValidationResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types