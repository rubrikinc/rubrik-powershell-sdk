// RbacObject.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region RbacObject
    public class RbacObject: BaseType
    {
        #region members

        //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
        // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy! (enum)
        [JsonProperty("workloadHierarchy")]
        public WorkloadLevelHierarchy? WorkloadHierarchy { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }


        #endregion

    #region methods

    public RbacObject Set(
        WorkloadLevelHierarchy? WorkloadHierarchy = null,
        System.String? ClusterId = null,
        System.String? ObjectId = null
    ) 
    {
        if ( WorkloadHierarchy != null ) {
            this.WorkloadHierarchy = WorkloadHierarchy;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
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
        //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
        // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy! (enum)
        if (this.WorkloadHierarchy != null) {
            s += ind + "workloadHierarchy\n" ;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
        // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy! (enum)
        if (this.WorkloadHierarchy == null && Exploration.Includes(parent + ".workloadHierarchy", true))
        {
            this.WorkloadHierarchy = new WorkloadLevelHierarchy();
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = new System.String("FETCH");
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = new System.String("FETCH");
        }
    }


    #endregion

    } // class RbacObject
    
    #endregion

    public static class ListRbacObjectExtensions
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
            this List<RbacObject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RbacObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RbacObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types