// JobStateCounts.cs
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
    #region JobStateCounts
    public class JobStateCounts: BaseType
    {
        #region members

        //      C# -> SaasWorkloadType? SnappableType
        // GraphQL -> snappableType: SaasWorkloadType! (enum)
        [JsonProperty("snappableType")]
        public SaasWorkloadType? SnappableType { get; set; }

        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int! (scalar)
        [JsonProperty("failed")]
        public System.Int32? Failed { get; set; }

        //      C# -> System.Int32? Success
        // GraphQL -> success: Int! (scalar)
        [JsonProperty("success")]
        public System.Int32? Success { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "JobStateCounts";
    }

    public JobStateCounts Set(
        SaasWorkloadType? SnappableType = null,
        System.Int32? Failed = null,
        System.Int32? Success = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( Failed != null ) {
            this.Failed = Failed;
        }
        if ( Success != null ) {
            this.Success = Success;
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
        //      C# -> SaasWorkloadType? SnappableType
        // GraphQL -> snappableType: SaasWorkloadType! (enum)
        if (this.SnappableType != null) {
            s += ind + "snappableType\n" ;
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int! (scalar)
        if (this.Failed != null) {
            s += ind + "failed\n" ;
        }
        //      C# -> System.Int32? Success
        // GraphQL -> success: Int! (scalar)
        if (this.Success != null) {
            s += ind + "success\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SaasWorkloadType? SnappableType
        // GraphQL -> snappableType: SaasWorkloadType! (enum)
        if (this.SnappableType == null && Exploration.Includes(parent + ".snappableType", true))
        {
            this.SnappableType = new SaasWorkloadType();
        }
        //      C# -> System.Int32? Failed
        // GraphQL -> failed: Int! (scalar)
        if (this.Failed == null && Exploration.Includes(parent + ".failed", true))
        {
            this.Failed = Int32.MinValue;
        }
        //      C# -> System.Int32? Success
        // GraphQL -> success: Int! (scalar)
        if (this.Success == null && Exploration.Includes(parent + ".success", true))
        {
            this.Success = Int32.MinValue;
        }
    }


    #endregion

    } // class JobStateCounts
    
    #endregion

    public static class ListJobStateCountsExtensions
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
            this List<JobStateCounts> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<JobStateCounts> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new JobStateCounts());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types