// DlpConfigVmwareVm.cs
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
    #region DlpConfigVmwareVm
    public class DlpConfigVmwareVm: BaseType
    {
        #region members

        //      C# -> DlpConfigOsType? OsType
        // GraphQL -> osType: DlpConfigOsType! (enum)
        [JsonProperty("osType")]
        public DlpConfigOsType? OsType { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DlpConfigVmwareVm";
    }

    public DlpConfigVmwareVm Set(
        DlpConfigOsType? OsType = null,
        System.String? Path = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( Path != null ) {
            this.Path = Path;
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
        //      C# -> DlpConfigOsType? OsType
        // GraphQL -> osType: DlpConfigOsType! (enum)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
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
        //      C# -> DlpConfigOsType? OsType
        // GraphQL -> osType: DlpConfigOsType! (enum)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = new DlpConfigOsType();
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = "FETCH";
        }
    }


    #endregion

    } // class DlpConfigVmwareVm
    
    #endregion

    public static class ListDlpConfigVmwareVmExtensions
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
            this List<DlpConfigVmwareVm> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DlpConfigVmwareVm> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DlpConfigVmwareVm());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types