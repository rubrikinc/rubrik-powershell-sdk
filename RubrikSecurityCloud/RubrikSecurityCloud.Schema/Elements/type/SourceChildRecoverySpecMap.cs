// SourceChildRecoverySpecMap.cs
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
    #region SourceChildRecoverySpecMap
    public class SourceChildRecoverySpecMap: BaseType
    {
        #region members

        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        [JsonProperty("recoverySpec")]
        public RecoverySpec? RecoverySpec { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SourceChildRecoverySpecMap";
    }

    public SourceChildRecoverySpecMap Set(
        RecoverySpec? RecoverySpec = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( RecoverySpec != null ) {
            this.RecoverySpec = RecoverySpec;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        if (this.RecoverySpec != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.RecoverySpec).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoverySpec {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        if (this.RecoverySpec == null && Exploration.Includes(parent + ".recoverySpec"))
        {
            var impls = new List<RecoverySpec>();
            impls.ApplyExploratoryFieldSpec(parent + ".recoverySpec");
            this.RecoverySpec = (RecoverySpec)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = "FETCH";
        }
    }


    #endregion

    } // class SourceChildRecoverySpecMap
    
    #endregion

    public static class ListSourceChildRecoverySpecMapExtensions
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
            this List<SourceChildRecoverySpecMap> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SourceChildRecoverySpecMap> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SourceChildRecoverySpecMap());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types