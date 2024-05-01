// ComplianceState.cs
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
    #region ComplianceState
    public class ComplianceState: BaseType
    {
        #region members

        //      C# -> System.Int32? CompliancePercentage
        // GraphQL -> compliancePercentage: Int! (scalar)
        [JsonProperty("compliancePercentage")]
        public System.Int32? CompliancePercentage { get; set; }

        //      C# -> System.String? LowComplianceReason
        // GraphQL -> lowComplianceReason: String! (scalar)
        [JsonProperty("lowComplianceReason")]
        public System.String? LowComplianceReason { get; set; }

        //      C# -> System.Boolean? ShouldAllowSwitchToOnboardingMode
        // GraphQL -> shouldAllowSwitchToOnboardingMode: Boolean! (scalar)
        [JsonProperty("shouldAllowSwitchToOnboardingMode")]
        public System.Boolean? ShouldAllowSwitchToOnboardingMode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ComplianceState";
    }

    public ComplianceState Set(
        System.Int32? CompliancePercentage = null,
        System.String? LowComplianceReason = null,
        System.Boolean? ShouldAllowSwitchToOnboardingMode = null
    ) 
    {
        if ( CompliancePercentage != null ) {
            this.CompliancePercentage = CompliancePercentage;
        }
        if ( LowComplianceReason != null ) {
            this.LowComplianceReason = LowComplianceReason;
        }
        if ( ShouldAllowSwitchToOnboardingMode != null ) {
            this.ShouldAllowSwitchToOnboardingMode = ShouldAllowSwitchToOnboardingMode;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? CompliancePercentage
        // GraphQL -> compliancePercentage: Int! (scalar)
        if (this.CompliancePercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "compliancePercentage\n" ;
            } else {
                s += ind + "compliancePercentage\n" ;
            }
        }
        //      C# -> System.String? LowComplianceReason
        // GraphQL -> lowComplianceReason: String! (scalar)
        if (this.LowComplianceReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lowComplianceReason\n" ;
            } else {
                s += ind + "lowComplianceReason\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldAllowSwitchToOnboardingMode
        // GraphQL -> shouldAllowSwitchToOnboardingMode: Boolean! (scalar)
        if (this.ShouldAllowSwitchToOnboardingMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldAllowSwitchToOnboardingMode\n" ;
            } else {
                s += ind + "shouldAllowSwitchToOnboardingMode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? CompliancePercentage
        // GraphQL -> compliancePercentage: Int! (scalar)
        if (ec.Includes("compliancePercentage",true))
        {
            if(this.CompliancePercentage == null) {

                this.CompliancePercentage = Int32.MinValue;

            } else {


            }
        }
        else if (this.CompliancePercentage != null && ec.Excludes("compliancePercentage",true))
        {
            this.CompliancePercentage = null;
        }
        //      C# -> System.String? LowComplianceReason
        // GraphQL -> lowComplianceReason: String! (scalar)
        if (ec.Includes("lowComplianceReason",true))
        {
            if(this.LowComplianceReason == null) {

                this.LowComplianceReason = "FETCH";

            } else {


            }
        }
        else if (this.LowComplianceReason != null && ec.Excludes("lowComplianceReason",true))
        {
            this.LowComplianceReason = null;
        }
        //      C# -> System.Boolean? ShouldAllowSwitchToOnboardingMode
        // GraphQL -> shouldAllowSwitchToOnboardingMode: Boolean! (scalar)
        if (ec.Includes("shouldAllowSwitchToOnboardingMode",true))
        {
            if(this.ShouldAllowSwitchToOnboardingMode == null) {

                this.ShouldAllowSwitchToOnboardingMode = true;

            } else {


            }
        }
        else if (this.ShouldAllowSwitchToOnboardingMode != null && ec.Excludes("shouldAllowSwitchToOnboardingMode",true))
        {
            this.ShouldAllowSwitchToOnboardingMode = null;
        }
    }


    #endregion

    } // class ComplianceState
    
    #endregion

    public static class ListComplianceStateExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ComplianceState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ComplianceState> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ComplianceState> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ComplianceState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ComplianceState> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types