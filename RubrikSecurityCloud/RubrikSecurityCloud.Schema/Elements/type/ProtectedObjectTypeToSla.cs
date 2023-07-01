// ProtectedObjectTypeToSla.cs
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
    #region ProtectedObjectTypeToSla
    public class ProtectedObjectTypeToSla: BaseType
    {
        #region members

        //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
        // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("protectedObjectType")]
        public WorkloadLevelHierarchy? ProtectedObjectType { get; set; }

        //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
        [JsonProperty("slaAssignment")]
        public AzureNativeResourceGroupSlaAssignment? SlaAssignment { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProtectedObjectTypeToSla";
    }

    public ProtectedObjectTypeToSla Set(
        WorkloadLevelHierarchy? ProtectedObjectType = null,
        AzureNativeResourceGroupSlaAssignment? SlaAssignment = null
    ) 
    {
        if ( ProtectedObjectType != null ) {
            this.ProtectedObjectType = ProtectedObjectType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
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
        //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
        // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
        if (this.ProtectedObjectType != null) {
            s += ind + "protectedObjectType\n" ;
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
        if (this.SlaAssignment != null) {
            var fspec = this.SlaAssignment.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaAssignment {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
        // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
        if (this.ProtectedObjectType == null && Exploration.Includes(parent + ".protectedObjectType", true))
        {
            this.ProtectedObjectType = new WorkloadLevelHierarchy();
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment"))
        {
            this.SlaAssignment = new AzureNativeResourceGroupSlaAssignment();
            this.SlaAssignment.ApplyExploratoryFieldSpec(parent + ".slaAssignment");
        }
    }


    #endregion

    } // class ProtectedObjectTypeToSla
    
    #endregion

    public static class ListProtectedObjectTypeToSlaExtensions
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
            this List<ProtectedObjectTypeToSla> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ProtectedObjectTypeToSla> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ProtectedObjectTypeToSla());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types