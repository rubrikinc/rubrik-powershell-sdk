// VsphereVmPowerOnOffLiveMountReply.cs
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
    #region VsphereVmPowerOnOffLiveMountReply
    public class VsphereVmPowerOnOffLiveMountReply: BaseType
    {
        #region members

        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        [JsonProperty("nasIp")]
        public System.String? NasIp { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
        // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
        [JsonProperty("vmwareVmMountSummaryV1")]
        public VmwareVmMountSummaryV1? VmwareVmMountSummaryV1 { get; set; }


        #endregion

    #region methods

    public VsphereVmPowerOnOffLiveMountReply Set(
        System.String? NasIp = null,
        System.String? PowerStatus = null,
        VmwareVmMountSummaryV1? VmwareVmMountSummaryV1 = null
    ) 
    {
        if ( NasIp != null ) {
            this.NasIp = NasIp;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( VmwareVmMountSummaryV1 != null ) {
            this.VmwareVmMountSummaryV1 = VmwareVmMountSummaryV1;
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
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        if (this.NasIp != null) {
            s += ind + "nasIp\n" ;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus != null) {
            s += ind + "powerStatus\n" ;
        }
        //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
        // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
        if (this.VmwareVmMountSummaryV1 != null) {
            s += ind + "vmwareVmMountSummaryV1 {\n" + this.VmwareVmMountSummaryV1.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        if (this.NasIp == null && Exploration.Includes(parent + ".nasIp", true))
        {
            this.NasIp = "FETCH";
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus", true))
        {
            this.PowerStatus = "FETCH";
        }
        //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
        // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
        if (this.VmwareVmMountSummaryV1 == null && Exploration.Includes(parent + ".vmwareVmMountSummaryV1"))
        {
            this.VmwareVmMountSummaryV1 = new VmwareVmMountSummaryV1();
            this.VmwareVmMountSummaryV1.ApplyExploratoryFieldSpec(parent + ".vmwareVmMountSummaryV1");
        }
    }


    #endregion

    } // class VsphereVmPowerOnOffLiveMountReply
    
    #endregion

    public static class ListVsphereVmPowerOnOffLiveMountReplyExtensions
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
            this List<VsphereVmPowerOnOffLiveMountReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmPowerOnOffLiveMountReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmPowerOnOffLiveMountReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types