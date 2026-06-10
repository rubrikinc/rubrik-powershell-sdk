// ComplexRecoveryStep.cs
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
    #region ComplexRecoveryStep
    public class ComplexRecoveryStep: BaseType
    {
        #region members

        //      C# -> RecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: RecoveryOutcome! (enum)
        [JsonProperty("recoveryOutcome")]
        public RecoveryOutcome? RecoveryOutcome { get; set; }

        //      C# -> RecoveryStatus? Status
        // GraphQL -> status: RecoveryStatus! (enum)
        [JsonProperty("status")]
        public RecoveryStatus? Status { get; set; }

        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        [JsonProperty("workloadType")]
        public ManagedObjectType? WorkloadType { get; set; }

        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: UUID! (scalar)
        [JsonProperty("recoveryId")]
        public System.String? RecoveryId { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> RecoverySteps? SimpleSteps
        // GraphQL -> simpleSteps: RecoverySteps (type)
        [JsonProperty("simpleSteps")]
        public RecoverySteps? SimpleSteps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ComplexRecoveryStep";
    }

    public ComplexRecoveryStep Set(
        RecoveryOutcome? RecoveryOutcome = null,
        RecoveryStatus? Status = null,
        ManagedObjectType? WorkloadType = null,
        System.String? RecoveryId = null,
        System.String? RecoveryName = null,
        RecoverySteps? SimpleSteps = null
    ) 
    {
        if ( RecoveryOutcome != null ) {
            this.RecoveryOutcome = RecoveryOutcome;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( RecoveryId != null ) {
            this.RecoveryId = RecoveryId;
        }
        if ( RecoveryName != null ) {
            this.RecoveryName = RecoveryName;
        }
        if ( SimpleSteps != null ) {
            this.SimpleSteps = SimpleSteps;
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
        //      C# -> RecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: RecoveryOutcome! (enum)
        if (this.RecoveryOutcome != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryOutcome\n" ;
            } else {
                s += ind + "recoveryOutcome\n" ;
            }
        }
        //      C# -> RecoveryStatus? Status
        // GraphQL -> status: RecoveryStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: UUID! (scalar)
        if (this.RecoveryId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryId\n" ;
            } else {
                s += ind + "recoveryId\n" ;
            }
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (this.RecoveryName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryName\n" ;
            } else {
                s += ind + "recoveryName\n" ;
            }
        }
        //      C# -> RecoverySteps? SimpleSteps
        // GraphQL -> simpleSteps: RecoverySteps (type)
        if (this.SimpleSteps != null) {
            var fspec = this.SimpleSteps.AsFieldSpec(conf.Child("simpleSteps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "simpleSteps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryOutcome? RecoveryOutcome
        // GraphQL -> recoveryOutcome: RecoveryOutcome! (enum)
        if (ec.Includes("recoveryOutcome",true))
        {
            if(this.RecoveryOutcome == null) {

                this.RecoveryOutcome = new RecoveryOutcome();

            } else {


            }
        }
        else if (this.RecoveryOutcome != null && ec.Excludes("recoveryOutcome",true))
        {
            this.RecoveryOutcome = null;
        }
        //      C# -> RecoveryStatus? Status
        // GraphQL -> status: RecoveryStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new RecoveryStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: UUID! (scalar)
        if (ec.Includes("recoveryId",true))
        {
            if(this.RecoveryId == null) {

                this.RecoveryId = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryId != null && ec.Excludes("recoveryId",true))
        {
            this.RecoveryId = null;
        }
        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        if (ec.Includes("recoveryName",true))
        {
            if(this.RecoveryName == null) {

                this.RecoveryName = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryName != null && ec.Excludes("recoveryName",true))
        {
            this.RecoveryName = null;
        }
        //      C# -> RecoverySteps? SimpleSteps
        // GraphQL -> simpleSteps: RecoverySteps (type)
        if (ec.Includes("simpleSteps",false))
        {
            if(this.SimpleSteps == null) {

                this.SimpleSteps = new RecoverySteps();
                this.SimpleSteps.ApplyExploratoryFieldSpec(ec.NewChild("simpleSteps"));

            } else {

                this.SimpleSteps.ApplyExploratoryFieldSpec(ec.NewChild("simpleSteps"));

            }
        }
        else if (this.SimpleSteps != null && ec.Excludes("simpleSteps",false))
        {
            this.SimpleSteps = null;
        }
    }


    #endregion

    } // class ComplexRecoveryStep
    
    #endregion

    public static class ListComplexRecoveryStepExtensions
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
            this List<ComplexRecoveryStep> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ComplexRecoveryStep> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ComplexRecoveryStep> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ComplexRecoveryStep());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ComplexRecoveryStep> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types