// VmwareVmConfig.cs
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
    #region VmwareVmConfig
    public class VmwareVmConfig: BaseType
    {
        #region members

        //      C# -> System.Int64? LogRetentionSeconds
        // GraphQL -> logRetentionSeconds: Long! (scalar)
        [JsonProperty("logRetentionSeconds")]
        public System.Int64? LogRetentionSeconds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareVmConfig";
    }

    public VmwareVmConfig Set(
        System.Int64? LogRetentionSeconds = null
    ) 
    {
        if ( LogRetentionSeconds != null ) {
            this.LogRetentionSeconds = LogRetentionSeconds;
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
        //      C# -> System.Int64? LogRetentionSeconds
        // GraphQL -> logRetentionSeconds: Long! (scalar)
        if (this.LogRetentionSeconds != null) {
            s += ind + "logRetentionSeconds\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? LogRetentionSeconds
        // GraphQL -> logRetentionSeconds: Long! (scalar)
        if (this.LogRetentionSeconds == null && Exploration.Includes(parent + ".logRetentionSeconds", true))
        {
            this.LogRetentionSeconds = new System.Int64();
        }
    }


    #endregion

    } // class VmwareVmConfig
    
    #endregion

    public static class ListVmwareVmConfigExtensions
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
            this List<VmwareVmConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types