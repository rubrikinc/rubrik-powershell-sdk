// ValidateFailureReason.cs
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
    #region ValidateFailureReason
    public class ValidateFailureReason: BaseType
    {
        #region members

        //      C# -> PlanName? PlanName
        // GraphQL -> planName: PlanName! (enum)
        [JsonProperty("planName")]
        public PlanName? PlanName { get; set; }

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateFailureReason";
    }

    public ValidateFailureReason Set(
        PlanName? PlanName = null,
        System.String? FailureReason = null,
        System.String? SnappableId = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( PlanName != null ) {
            this.PlanName = PlanName;
        }
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> PlanName? PlanName
        // GraphQL -> planName: PlanName! (enum)
        if (this.PlanName != null) {
            s += ind + "planName\n" ;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        if (this.FailureReason != null) {
            s += ind + "failureReason\n" ;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PlanName? PlanName
        // GraphQL -> planName: PlanName! (enum)
        if (this.PlanName == null && ec.Includes("planName",true))
        {
            this.PlanName = new PlanName();
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        if (this.FailureReason == null && ec.Includes("failureReason",true))
        {
            this.FailureReason = "FETCH";
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && ec.Includes("snappableId",true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
    }


    #endregion

    } // class ValidateFailureReason
    
    #endregion

    public static class ListValidateFailureReasonExtensions
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
            this List<ValidateFailureReason> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateFailureReason> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateFailureReason());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ValidateFailureReason> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types