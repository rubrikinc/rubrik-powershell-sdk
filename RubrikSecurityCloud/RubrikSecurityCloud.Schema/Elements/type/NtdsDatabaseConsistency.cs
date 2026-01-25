// NtdsDatabaseConsistency.cs
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
    #region NtdsDatabaseConsistency
    public class NtdsDatabaseConsistency: BaseType
    {
        #region members

        //      C# -> System.Boolean? FailedToComputeOpt
        // GraphQL -> failedToComputeOpt: Boolean (scalar)
        [JsonProperty("failedToComputeOpt")]
        public System.Boolean? FailedToComputeOpt { get; set; }

        //      C# -> System.Boolean? NeedsRepairOpt
        // GraphQL -> needsRepairOpt: Boolean (scalar)
        [JsonProperty("needsRepairOpt")]
        public System.Boolean? NeedsRepairOpt { get; set; }

        //      C# -> System.Boolean? RepairFailedOpt
        // GraphQL -> repairFailedOpt: Boolean (scalar)
        [JsonProperty("repairFailedOpt")]
        public System.Boolean? RepairFailedOpt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NtdsDatabaseConsistency";
    }

    public NtdsDatabaseConsistency Set(
        System.Boolean? FailedToComputeOpt = null,
        System.Boolean? NeedsRepairOpt = null,
        System.Boolean? RepairFailedOpt = null
    ) 
    {
        if ( FailedToComputeOpt != null ) {
            this.FailedToComputeOpt = FailedToComputeOpt;
        }
        if ( NeedsRepairOpt != null ) {
            this.NeedsRepairOpt = NeedsRepairOpt;
        }
        if ( RepairFailedOpt != null ) {
            this.RepairFailedOpt = RepairFailedOpt;
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
        //      C# -> System.Boolean? FailedToComputeOpt
        // GraphQL -> failedToComputeOpt: Boolean (scalar)
        if (this.FailedToComputeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedToComputeOpt\n" ;
            } else {
                s += ind + "failedToComputeOpt\n" ;
            }
        }
        //      C# -> System.Boolean? NeedsRepairOpt
        // GraphQL -> needsRepairOpt: Boolean (scalar)
        if (this.NeedsRepairOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "needsRepairOpt\n" ;
            } else {
                s += ind + "needsRepairOpt\n" ;
            }
        }
        //      C# -> System.Boolean? RepairFailedOpt
        // GraphQL -> repairFailedOpt: Boolean (scalar)
        if (this.RepairFailedOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "repairFailedOpt\n" ;
            } else {
                s += ind + "repairFailedOpt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? FailedToComputeOpt
        // GraphQL -> failedToComputeOpt: Boolean (scalar)
        if (ec.Includes("failedToComputeOpt",true))
        {
            if(this.FailedToComputeOpt == null) {

                this.FailedToComputeOpt = true;

            } else {


            }
        }
        else if (this.FailedToComputeOpt != null && ec.Excludes("failedToComputeOpt",true))
        {
            this.FailedToComputeOpt = null;
        }
        //      C# -> System.Boolean? NeedsRepairOpt
        // GraphQL -> needsRepairOpt: Boolean (scalar)
        if (ec.Includes("needsRepairOpt",true))
        {
            if(this.NeedsRepairOpt == null) {

                this.NeedsRepairOpt = true;

            } else {


            }
        }
        else if (this.NeedsRepairOpt != null && ec.Excludes("needsRepairOpt",true))
        {
            this.NeedsRepairOpt = null;
        }
        //      C# -> System.Boolean? RepairFailedOpt
        // GraphQL -> repairFailedOpt: Boolean (scalar)
        if (ec.Includes("repairFailedOpt",true))
        {
            if(this.RepairFailedOpt == null) {

                this.RepairFailedOpt = true;

            } else {


            }
        }
        else if (this.RepairFailedOpt != null && ec.Excludes("repairFailedOpt",true))
        {
            this.RepairFailedOpt = null;
        }
    }


    #endregion

    } // class NtdsDatabaseConsistency
    
    #endregion

    public static class ListNtdsDatabaseConsistencyExtensions
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
            this List<NtdsDatabaseConsistency> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NtdsDatabaseConsistency> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NtdsDatabaseConsistency> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NtdsDatabaseConsistency());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NtdsDatabaseConsistency> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types