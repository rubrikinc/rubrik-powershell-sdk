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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        if (this.BeginTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "beginTime\n" ;
            } else {
                s += ind + "beginTime\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (this.ErrorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorType\n" ;
            } else {
                s += ind + "errorType\n" ;
            }
        }
        //      C# -> MssqlMissedRecoverableRangeError? FirstError
        // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
        if (this.FirstError != null) {
            var fspec = this.FirstError.AsFieldSpec(conf.Child("firstError"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "firstError" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlMissedRecoverableRangeError? LastError
        // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
        if (this.LastError != null) {
            var fspec = this.LastError.AsFieldSpec(conf.Child("lastError"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastError" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? BeginTime
        // GraphQL -> beginTime: DateTime (scalar)
        if (ec.Includes("beginTime",true))
        {
            if(this.BeginTime == null) {

                this.BeginTime = new DateTime();

            } else {


            }
        }
        else if (this.BeginTime != null && ec.Excludes("beginTime",true))
        {
            this.BeginTime = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.String? ErrorType
        // GraphQL -> errorType: String! (scalar)
        if (ec.Includes("errorType",true))
        {
            if(this.ErrorType == null) {

                this.ErrorType = "FETCH";

            } else {


            }
        }
        else if (this.ErrorType != null && ec.Excludes("errorType",true))
        {
            this.ErrorType = null;
        }
        //      C# -> MssqlMissedRecoverableRangeError? FirstError
        // GraphQL -> firstError: MssqlMissedRecoverableRangeError (type)
        if (ec.Includes("firstError",false))
        {
            if(this.FirstError == null) {

                this.FirstError = new MssqlMissedRecoverableRangeError();
                this.FirstError.ApplyExploratoryFieldSpec(ec.NewChild("firstError"));

            } else {

                this.FirstError.ApplyExploratoryFieldSpec(ec.NewChild("firstError"));

            }
        }
        else if (this.FirstError != null && ec.Excludes("firstError",false))
        {
            this.FirstError = null;
        }
        //      C# -> MssqlMissedRecoverableRangeError? LastError
        // GraphQL -> lastError: MssqlMissedRecoverableRangeError (type)
        if (ec.Includes("lastError",false))
        {
            if(this.LastError == null) {

                this.LastError = new MssqlMissedRecoverableRangeError();
                this.LastError.ApplyExploratoryFieldSpec(ec.NewChild("lastError"));

            } else {

                this.LastError.ApplyExploratoryFieldSpec(ec.NewChild("lastError"));

            }
        }
        else if (this.LastError != null && ec.Excludes("lastError",false))
        {
            this.LastError = null;
        }
    }


    #endregion

    } // class MssqlMissedRecoverableRange
    
    #endregion

    public static class ListMssqlMissedRecoverableRangeExtensions
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
            this List<MssqlMissedRecoverableRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlMissedRecoverableRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<MssqlMissedRecoverableRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types