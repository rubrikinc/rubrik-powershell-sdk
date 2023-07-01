// VmwareDatastoreFreespaceThreshold.cs
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
    #region VmwareDatastoreFreespaceThreshold
    public class VmwareDatastoreFreespaceThreshold: BaseType
    {
        #region members

        //      C# -> System.Single? Threshold
        // GraphQL -> threshold: Float! (scalar)
        [JsonProperty("threshold")]
        public System.Single? Threshold { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareDatastoreFreespaceThreshold";
    }

    public VmwareDatastoreFreespaceThreshold Set(
        System.Single? Threshold = null,
        System.String? VmId = null
    ) 
    {
        if ( Threshold != null ) {
            this.Threshold = Threshold;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
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
        //      C# -> System.Single? Threshold
        // GraphQL -> threshold: Float! (scalar)
        if (this.Threshold != null) {
            s += ind + "threshold\n" ;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String (scalar)
        if (this.VmId != null) {
            s += ind + "vmId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Single? Threshold
        // GraphQL -> threshold: Float! (scalar)
        if (this.Threshold == null && Exploration.Includes(parent + ".threshold", true))
        {
            this.Threshold = new System.Single();
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String (scalar)
        if (this.VmId == null && Exploration.Includes(parent + ".vmId", true))
        {
            this.VmId = "FETCH";
        }
    }


    #endregion

    } // class VmwareDatastoreFreespaceThreshold
    
    #endregion

    public static class ListVmwareDatastoreFreespaceThresholdExtensions
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
            this List<VmwareDatastoreFreespaceThreshold> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareDatastoreFreespaceThreshold> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareDatastoreFreespaceThreshold());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types