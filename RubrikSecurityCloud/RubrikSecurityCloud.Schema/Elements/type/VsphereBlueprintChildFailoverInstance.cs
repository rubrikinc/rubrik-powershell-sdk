// VsphereBlueprintChildFailoverInstance.cs
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
    #region VsphereBlueprintChildFailoverInstance
 
    public class VsphereBlueprintChildFailoverInstance: BaseType, BlueprintFailoverInstance
    {
        #region members

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> AwsEc2Instance? FailoverInstance
        // GraphQL -> failoverInstance: AwsEc2Instance! (type)
        [JsonProperty("failoverInstance")]
        public AwsEc2Instance? FailoverInstance { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereBlueprintChildFailoverInstance";
    }

    public VsphereBlueprintChildFailoverInstance Set(
        System.String? SnappableId = null,
        AwsEc2Instance? FailoverInstance = null
    ) 
    {
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( FailoverInstance != null ) {
            this.FailoverInstance = FailoverInstance;
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
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> AwsEc2Instance? FailoverInstance
        // GraphQL -> failoverInstance: AwsEc2Instance! (type)
        if (this.FailoverInstance != null) {
            var fspec = this.FailoverInstance.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failoverInstance {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && ec.Includes("snappableId",true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> AwsEc2Instance? FailoverInstance
        // GraphQL -> failoverInstance: AwsEc2Instance! (type)
        if (this.FailoverInstance == null && ec.Includes("failoverInstance",false))
        {
            this.FailoverInstance = new AwsEc2Instance();
            this.FailoverInstance.ApplyExploratoryFieldSpec(ec.NewChild("failoverInstance"));
        }
    }


    #endregion

    } // class VsphereBlueprintChildFailoverInstance
    
    #endregion

    public static class ListVsphereBlueprintChildFailoverInstanceExtensions
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
            this List<VsphereBlueprintChildFailoverInstance> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereBlueprintChildFailoverInstance> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereBlueprintChildFailoverInstance());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VsphereBlueprintChildFailoverInstance> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types