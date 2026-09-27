// LastWorkloadRecoveryInfo.cs
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
    #region LastWorkloadRecoveryInfo
    public class LastWorkloadRecoveryInfo: BaseType
    {
        #region members

        //      C# -> RecoveryOutcome? WorkloadRecoveryOutcome
        // GraphQL -> workloadRecoveryOutcome: RecoveryOutcome! (enum)
        [JsonProperty("workloadRecoveryOutcome")]
        public RecoveryOutcome? WorkloadRecoveryOutcome { get; set; }

        //      C# -> Recovery? Recovery
        // GraphQL -> recovery: Recovery (type)
        [JsonProperty("recovery")]
        public Recovery? Recovery { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LastWorkloadRecoveryInfo";
    }

    public LastWorkloadRecoveryInfo Set(
        RecoveryOutcome? WorkloadRecoveryOutcome = null,
        Recovery? Recovery = null
    ) 
    {
        if ( WorkloadRecoveryOutcome != null ) {
            this.WorkloadRecoveryOutcome = WorkloadRecoveryOutcome;
        }
        if ( Recovery != null ) {
            this.Recovery = Recovery;
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
        //      C# -> RecoveryOutcome? WorkloadRecoveryOutcome
        // GraphQL -> workloadRecoveryOutcome: RecoveryOutcome! (enum)
        if (this.WorkloadRecoveryOutcome != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadRecoveryOutcome\n" ;
            } else {
                s += ind + "workloadRecoveryOutcome\n" ;
            }
        }
        //      C# -> Recovery? Recovery
        // GraphQL -> recovery: Recovery (type)
        if (this.Recovery != null) {
            var fspec = this.Recovery.AsFieldSpec(conf.Child("recovery"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recovery" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryOutcome? WorkloadRecoveryOutcome
        // GraphQL -> workloadRecoveryOutcome: RecoveryOutcome! (enum)
        if (ec.Includes("workloadRecoveryOutcome",true))
        {
            if(this.WorkloadRecoveryOutcome == null) {

                this.WorkloadRecoveryOutcome = new RecoveryOutcome();

            } else {


            }
        }
        else if (this.WorkloadRecoveryOutcome != null && ec.Excludes("workloadRecoveryOutcome",true))
        {
            this.WorkloadRecoveryOutcome = null;
        }
        //      C# -> Recovery? Recovery
        // GraphQL -> recovery: Recovery (type)
        if (ec.Includes("recovery",false))
        {
            if(this.Recovery == null) {

                this.Recovery = new Recovery();
                this.Recovery.ApplyExploratoryFieldSpec(ec.NewChild("recovery"));

            } else {

                this.Recovery.ApplyExploratoryFieldSpec(ec.NewChild("recovery"));

            }
        }
        else if (this.Recovery != null && ec.Excludes("recovery",false))
        {
            this.Recovery = null;
        }
    }


    #endregion

    } // class LastWorkloadRecoveryInfo
    
    #endregion

    public static class ListLastWorkloadRecoveryInfoExtensions
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
            this List<LastWorkloadRecoveryInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LastWorkloadRecoveryInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LastWorkloadRecoveryInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LastWorkloadRecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LastWorkloadRecoveryInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types