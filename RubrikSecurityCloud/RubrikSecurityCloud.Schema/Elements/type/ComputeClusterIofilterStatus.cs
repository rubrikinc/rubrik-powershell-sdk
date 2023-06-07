// ComputeClusterIofilterStatus.cs
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
    #region ComputeClusterIofilterStatus
    public class ComputeClusterIofilterStatus: BaseType
    {
        #region members

        //      C# -> System.String? ComputeClusterFid
        // GraphQL -> computeClusterFid: String! (scalar)
        [JsonProperty("computeClusterFid")]
        public System.String? ComputeClusterFid { get; set; }

        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        [JsonProperty("computeClusterName")]
        public System.String? ComputeClusterName { get; set; }

        //      C# -> System.String? IofilterStatus
        // GraphQL -> iofilterStatus: String! (scalar)
        [JsonProperty("iofilterStatus")]
        public System.String? IofilterStatus { get; set; }


        #endregion

    #region methods

    public ComputeClusterIofilterStatus Set(
        System.String? ComputeClusterFid = null,
        System.String? ComputeClusterName = null,
        System.String? IofilterStatus = null
    ) 
    {
        if ( ComputeClusterFid != null ) {
            this.ComputeClusterFid = ComputeClusterFid;
        }
        if ( ComputeClusterName != null ) {
            this.ComputeClusterName = ComputeClusterName;
        }
        if ( IofilterStatus != null ) {
            this.IofilterStatus = IofilterStatus;
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
        //      C# -> System.String? ComputeClusterFid
        // GraphQL -> computeClusterFid: String! (scalar)
        if (this.ComputeClusterFid != null) {
            s += ind + "computeClusterFid\n" ;
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (this.ComputeClusterName != null) {
            s += ind + "computeClusterName\n" ;
        }
        //      C# -> System.String? IofilterStatus
        // GraphQL -> iofilterStatus: String! (scalar)
        if (this.IofilterStatus != null) {
            s += ind + "iofilterStatus\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ComputeClusterFid
        // GraphQL -> computeClusterFid: String! (scalar)
        if (this.ComputeClusterFid == null && Exploration.Includes(parent + ".computeClusterFid", true))
        {
            this.ComputeClusterFid = "FETCH";
        }
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String! (scalar)
        if (this.ComputeClusterName == null && Exploration.Includes(parent + ".computeClusterName", true))
        {
            this.ComputeClusterName = "FETCH";
        }
        //      C# -> System.String? IofilterStatus
        // GraphQL -> iofilterStatus: String! (scalar)
        if (this.IofilterStatus == null && Exploration.Includes(parent + ".iofilterStatus", true))
        {
            this.IofilterStatus = "FETCH";
        }
    }


    #endregion

    } // class ComputeClusterIofilterStatus
    
    #endregion

    public static class ListComputeClusterIofilterStatusExtensions
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
            this List<ComputeClusterIofilterStatus> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ComputeClusterIofilterStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ComputeClusterIofilterStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types