// WorkloadTypeToBackupSetupSpecs.cs
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
    #region WorkloadTypeToBackupSetupSpecs
    public class WorkloadTypeToBackupSetupSpecs: BaseType
    {
        #region members

        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("snappableType")]
        public WorkloadLevelHierarchy? SnappableType { get; set; }

        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        [JsonProperty("setupSourceObject")]
        public PathNode? SetupSourceObject { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadTypeToBackupSetupSpecs";
    }

    public WorkloadTypeToBackupSetupSpecs Set(
        WorkloadLevelHierarchy? SnappableType = null,
        PathNode? SetupSourceObject = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( SetupSourceObject != null ) {
            this.SetupSourceObject = SetupSourceObject;
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
        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        if (this.SnappableType != null) {
            s += ind + "snappableType\n" ;
        }
        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        if (this.SetupSourceObject != null) {
            var fspec = this.SetupSourceObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "setupSourceObject {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLevelHierarchy? SnappableType
        // GraphQL -> snappableType: WorkloadLevelHierarchy! (enum)
        if (this.SnappableType == null && ec.Includes("snappableType",true))
        {
            this.SnappableType = new WorkloadLevelHierarchy();
        }
        //      C# -> PathNode? SetupSourceObject
        // GraphQL -> setupSourceObject: PathNode! (type)
        if (this.SetupSourceObject == null && ec.Includes("setupSourceObject",false))
        {
            this.SetupSourceObject = new PathNode();
            this.SetupSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("setupSourceObject"));
        }
    }


    #endregion

    } // class WorkloadTypeToBackupSetupSpecs
    
    #endregion

    public static class ListWorkloadTypeToBackupSetupSpecsExtensions
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
            this List<WorkloadTypeToBackupSetupSpecs> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadTypeToBackupSetupSpecs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadTypeToBackupSetupSpecs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<WorkloadTypeToBackupSetupSpecs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types