// VmwareRecoveryPoints.cs
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
    #region VmwareRecoveryPoints
    public class VmwareRecoveryPoints: BaseType
    {
        #region members

        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        [JsonProperty("localRecoveryPoint")]
        public DateTime? LocalRecoveryPoint { get; set; }

        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        [JsonProperty("remoteRecoveryPoint")]
        public DateTime? RemoteRecoveryPoint { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareRecoveryPoints";
    }

    public VmwareRecoveryPoints Set(
        DateTime? LocalRecoveryPoint = null,
        DateTime? RemoteRecoveryPoint = null
    ) 
    {
        if ( LocalRecoveryPoint != null ) {
            this.LocalRecoveryPoint = LocalRecoveryPoint;
        }
        if ( RemoteRecoveryPoint != null ) {
            this.RemoteRecoveryPoint = RemoteRecoveryPoint;
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
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (this.LocalRecoveryPoint != null) {
            s += ind + "localRecoveryPoint\n" ;
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (this.RemoteRecoveryPoint != null) {
            s += ind + "remoteRecoveryPoint\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (this.LocalRecoveryPoint == null && ec.Includes("localRecoveryPoint",true))
        {
            this.LocalRecoveryPoint = new DateTime();
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (this.RemoteRecoveryPoint == null && ec.Includes("remoteRecoveryPoint",true))
        {
            this.RemoteRecoveryPoint = new DateTime();
        }
    }


    #endregion

    } // class VmwareRecoveryPoints
    
    #endregion

    public static class ListVmwareRecoveryPointsExtensions
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
            this List<VmwareRecoveryPoints> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareRecoveryPoints> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareRecoveryPoints());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VmwareRecoveryPoints> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types