// SelectorStepEvent.cs
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
    #region SelectorStepEvent
    public class SelectorStepEvent: BaseType
    {
        #region members

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int (scalar)
        [JsonProperty("failed")]
        public System.Int32? Failed { get; set; }

        //      C# -> System.Int32? InProgress
        // GraphQL -> inProgress: Int (scalar)
        [JsonProperty("inProgress")]
        public System.Int32? InProgress { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        [JsonProperty("objectsWithoutSnapshot")]
        public System.Int32? ObjectsWithoutSnapshot { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        [JsonProperty("total")]
        public System.Int32? Total { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SelectorStepEvent";
    }

    public SelectorStepEvent Set(
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.Int32? Failed = null,
        System.Int32? InProgress = null,
        System.String? Message = null,
        System.Int32? ObjectsWithoutSnapshot = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        System.String? Status = null,
        System.Int32? Total = null
    ) 
    {
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Failed != null ) {
            this.Failed = Failed;
        }
        if ( InProgress != null ) {
            this.InProgress = InProgress;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ObjectsWithoutSnapshot != null ) {
            this.ObjectsWithoutSnapshot = ObjectsWithoutSnapshot;
        }
        if ( Seq != null ) {
            this.Seq = Seq;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Total != null ) {
            this.Total = Total;
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
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "elapsedTime\n" ;
            } else {
                s += ind + "elapsedTime\n" ;
            }
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int (scalar)
        if (this.Failed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failed\n" ;
            } else {
                s += ind + "failed\n" ;
            }
        }
        //      C# -> System.Int32? InProgress
        // GraphQL -> inProgress: Int (scalar)
        if (this.InProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inProgress\n" ;
            } else {
                s += ind + "inProgress\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        if (this.ObjectsWithoutSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectsWithoutSnapshot\n" ;
            } else {
                s += ind + "objectsWithoutSnapshot\n" ;
            }
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq != null) {
            if (conf.Flat) {
                s += conf.Prefix + "seq\n" ;
            } else {
                s += ind + "seq\n" ;
            }
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (ec.Includes("elapsedTime",true))
        {
            if(this.ElapsedTime == null) {

                this.ElapsedTime = new System.Int64();

            } else {


            }
        }
        else if (this.ElapsedTime != null && ec.Excludes("elapsedTime",true))
        {
            this.ElapsedTime = null;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new System.Int64();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int (scalar)
        if (ec.Includes("failed",true))
        {
            if(this.Failed == null) {

                this.Failed = Int32.MinValue;

            } else {


            }
        }
        else if (this.Failed != null && ec.Excludes("failed",true))
        {
            this.Failed = null;
        }
        //      C# -> System.Int32? InProgress
        // GraphQL -> inProgress: Int (scalar)
        if (ec.Includes("inProgress",true))
        {
            if(this.InProgress == null) {

                this.InProgress = Int32.MinValue;

            } else {


            }
        }
        else if (this.InProgress != null && ec.Excludes("inProgress",true))
        {
            this.InProgress = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.Int32? ObjectsWithoutSnapshot
        // GraphQL -> objectsWithoutSnapshot: Int (scalar)
        if (ec.Includes("objectsWithoutSnapshot",true))
        {
            if(this.ObjectsWithoutSnapshot == null) {

                this.ObjectsWithoutSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.ObjectsWithoutSnapshot != null && ec.Excludes("objectsWithoutSnapshot",true))
        {
            this.ObjectsWithoutSnapshot = null;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (ec.Includes("seq",true))
        {
            if(this.Seq == null) {

                this.Seq = Int32.MinValue;

            } else {


            }
        }
        else if (this.Seq != null && ec.Excludes("seq",true))
        {
            this.Seq = null;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new System.Int64();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = Int32.MinValue;

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
    }


    #endregion

    } // class SelectorStepEvent
    
    #endregion

    public static class ListSelectorStepEventExtensions
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
            this List<SelectorStepEvent> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SelectorStepEvent> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SelectorStepEvent> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SelectorStepEvent());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SelectorStepEvent> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types