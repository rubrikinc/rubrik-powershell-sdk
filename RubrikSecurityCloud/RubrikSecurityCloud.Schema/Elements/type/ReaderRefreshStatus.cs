// ReaderRefreshStatus.cs
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
    #region ReaderRefreshStatus
    public class ReaderRefreshStatus: BaseType
    {
        #region members

        //      C# -> ReaderLocationRefreshState? State
        // GraphQL -> state: ReaderLocationRefreshState! (enum)
        [JsonProperty("state")]
        public ReaderLocationRefreshState? State { get; set; }

        //      C# -> DateTime? RefreshCompletedTimeOpt
        // GraphQL -> refreshCompletedTimeOpt: DateTime (scalar)
        [JsonProperty("refreshCompletedTimeOpt")]
        public DateTime? RefreshCompletedTimeOpt { get; set; }

        //      C# -> DateTime? RefreshStartedTimeOpt
        // GraphQL -> refreshStartedTimeOpt: DateTime (scalar)
        [JsonProperty("refreshStartedTimeOpt")]
        public DateTime? RefreshStartedTimeOpt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReaderRefreshStatus";
    }

    public ReaderRefreshStatus Set(
        ReaderLocationRefreshState? State = null,
        DateTime? RefreshCompletedTimeOpt = null,
        DateTime? RefreshStartedTimeOpt = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( RefreshCompletedTimeOpt != null ) {
            this.RefreshCompletedTimeOpt = RefreshCompletedTimeOpt;
        }
        if ( RefreshStartedTimeOpt != null ) {
            this.RefreshStartedTimeOpt = RefreshStartedTimeOpt;
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
        //      C# -> ReaderLocationRefreshState? State
        // GraphQL -> state: ReaderLocationRefreshState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> DateTime? RefreshCompletedTimeOpt
        // GraphQL -> refreshCompletedTimeOpt: DateTime (scalar)
        if (this.RefreshCompletedTimeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "refreshCompletedTimeOpt\n" ;
            } else {
                s += ind + "refreshCompletedTimeOpt\n" ;
            }
        }
        //      C# -> DateTime? RefreshStartedTimeOpt
        // GraphQL -> refreshStartedTimeOpt: DateTime (scalar)
        if (this.RefreshStartedTimeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "refreshStartedTimeOpt\n" ;
            } else {
                s += ind + "refreshStartedTimeOpt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ReaderLocationRefreshState? State
        // GraphQL -> state: ReaderLocationRefreshState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new ReaderLocationRefreshState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> DateTime? RefreshCompletedTimeOpt
        // GraphQL -> refreshCompletedTimeOpt: DateTime (scalar)
        if (ec.Includes("refreshCompletedTimeOpt",true))
        {
            if(this.RefreshCompletedTimeOpt == null) {

                this.RefreshCompletedTimeOpt = new DateTime();

            } else {


            }
        }
        else if (this.RefreshCompletedTimeOpt != null && ec.Excludes("refreshCompletedTimeOpt",true))
        {
            this.RefreshCompletedTimeOpt = null;
        }
        //      C# -> DateTime? RefreshStartedTimeOpt
        // GraphQL -> refreshStartedTimeOpt: DateTime (scalar)
        if (ec.Includes("refreshStartedTimeOpt",true))
        {
            if(this.RefreshStartedTimeOpt == null) {

                this.RefreshStartedTimeOpt = new DateTime();

            } else {


            }
        }
        else if (this.RefreshStartedTimeOpt != null && ec.Excludes("refreshStartedTimeOpt",true))
        {
            this.RefreshStartedTimeOpt = null;
        }
    }


    #endregion

    } // class ReaderRefreshStatus
    
    #endregion

    public static class ListReaderRefreshStatusExtensions
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
            this List<ReaderRefreshStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReaderRefreshStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReaderRefreshStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReaderRefreshStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReaderRefreshStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types