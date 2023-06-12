// HypervVirtualMachineUpdate.cs
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
    #region HypervVirtualMachineUpdate
    public class HypervVirtualMachineUpdate: BaseType
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
        // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
        [JsonProperty("virtualDiskIdsExcludedFromSnapshot")]
        public List<System.String>? VirtualDiskIdsExcludedFromSnapshot { get; set; }

        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        [JsonProperty("cloudInstantiationSpec")]
        public CloudInstantiationSpec? CloudInstantiationSpec { get; set; }


        #endregion

    #region methods

    public HypervVirtualMachineUpdate Set(
        System.String? ConfiguredSlaDomainId = null,
        List<System.String>? VirtualDiskIdsExcludedFromSnapshot = null,
        CloudInstantiationSpec? CloudInstantiationSpec = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( VirtualDiskIdsExcludedFromSnapshot != null ) {
            this.VirtualDiskIdsExcludedFromSnapshot = VirtualDiskIdsExcludedFromSnapshot;
        }
        if ( CloudInstantiationSpec != null ) {
            this.CloudInstantiationSpec = CloudInstantiationSpec;
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
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
        // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
        if (this.VirtualDiskIdsExcludedFromSnapshot != null) {
            s += ind + "virtualDiskIdsExcludedFromSnapshot\n" ;
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (this.CloudInstantiationSpec != null) {
            var fspec = this.CloudInstantiationSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudInstantiationSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId", true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
        //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
        // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
        if (this.VirtualDiskIdsExcludedFromSnapshot == null && Exploration.Includes(parent + ".virtualDiskIdsExcludedFromSnapshot", true))
        {
            this.VirtualDiskIdsExcludedFromSnapshot = new List<System.String>();
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (this.CloudInstantiationSpec == null && Exploration.Includes(parent + ".cloudInstantiationSpec"))
        {
            this.CloudInstantiationSpec = new CloudInstantiationSpec();
            this.CloudInstantiationSpec.ApplyExploratoryFieldSpec(parent + ".cloudInstantiationSpec");
        }
    }


    #endregion

    } // class HypervVirtualMachineUpdate
    
    #endregion

    public static class ListHypervVirtualMachineUpdateExtensions
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
            this List<HypervVirtualMachineUpdate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineUpdate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineUpdate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types