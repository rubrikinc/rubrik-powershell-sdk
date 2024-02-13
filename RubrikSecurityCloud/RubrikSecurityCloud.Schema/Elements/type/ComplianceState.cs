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
            this List<ComplianceState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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