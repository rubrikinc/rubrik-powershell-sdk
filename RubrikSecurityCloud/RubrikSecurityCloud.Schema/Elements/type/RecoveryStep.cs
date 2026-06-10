// RecoveryStep.cs
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
    #region RecoveryStep
    public class RecoveryStep: BaseType
    {
        #region members

        //      C# -> RecoveryStepStatus? StepStatus
        // GraphQL -> stepStatus: RecoveryStepStatus! (enum)
        [JsonProperty("stepStatus")]
        public RecoveryStepStatus? StepStatus { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> List<RecoverySubStep>? SubSteps
        // GraphQL -> subSteps: [RecoverySubStep!]! (type)
        [JsonProperty("subSteps")]
        public List<RecoverySubStep>? SubSteps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryStep";
    }

    public RecoveryStep Set(
        RecoveryStepStatus? StepStatus = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.String? Message = null,
        System.Single? Progress = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        List<RecoverySubStep>? SubSteps = null
    ) 
    {
        if ( StepStatus != null ) {
            this.StepStatus = StepStatus;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( Seq != null ) {
            this.Seq = Seq;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( SubSteps != null ) {
            this.SubSteps = SubSteps;
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
        //      C# -> RecoveryStepStatus? StepStatus
        // GraphQL -> stepStatus: RecoveryStepStatus! (enum)
        if (this.StepStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stepStatus\n" ;
            } else {
                s += ind + "stepStatus\n" ;
            }
        }
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
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
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
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
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
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> List<RecoverySubStep>? SubSteps
        // GraphQL -> subSteps: [RecoverySubStep!]! (type)
        if (this.SubSteps != null) {
            var fspec = this.SubSteps.AsFieldSpec(conf.Child("subSteps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subSteps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryStepStatus? StepStatus
        // GraphQL -> stepStatus: RecoveryStepStatus! (enum)
        if (ec.Includes("stepStatus",true))
        {
            if(this.StepStatus == null) {

                this.StepStatus = new RecoveryStepStatus();

            } else {


            }
        }
        else if (this.StepStatus != null && ec.Excludes("stepStatus",true))
        {
            this.StepStatus = null;
        }
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
        // GraphQL -> endTime: Long! (scalar)
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
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Single();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
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
        // GraphQL -> startTime: Long! (scalar)
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
        //      C# -> List<RecoverySubStep>? SubSteps
        // GraphQL -> subSteps: [RecoverySubStep!]! (type)
        if (ec.Includes("subSteps",false))
        {
            if(this.SubSteps == null) {

                this.SubSteps = new List<RecoverySubStep>();
                this.SubSteps.ApplyExploratoryFieldSpec(ec.NewChild("subSteps"));

            } else {

                this.SubSteps.ApplyExploratoryFieldSpec(ec.NewChild("subSteps"));

            }
        }
        else if (this.SubSteps != null && ec.Excludes("subSteps",false))
        {
            this.SubSteps = null;
        }
    }


    #endregion

    } // class RecoveryStep
    
    #endregion

    public static class ListRecoveryStepExtensions
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
            this List<RecoveryStep> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryStep> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryStep> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryStep());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryStep> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types