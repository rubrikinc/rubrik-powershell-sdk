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

namespace Rubrik.SecurityCloud.Types
{
    #region HypervVirtualMachineUpdate
    public class HypervVirtualMachineUpdate: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId != null)
            {
                 s += ind + "configuredSlaDomainId\n";

            }
            //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
            // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
            if (this.VirtualDiskIdsExcludedFromSnapshot != null)
            {
                 s += ind + "virtualDiskIdsExcludedFromSnapshot\n";

            }
            //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
            // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
            if (this.CloudInstantiationSpec != null)
            {
                 s += ind + "cloudInstantiationSpec\n";

                 s += ind + "{\n" + 
                 this.CloudInstantiationSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId$"))
            {
                this.ConfiguredSlaDomainId = new System.String("FETCH");
            }
            //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
            // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!]! (scalar)
            if (this.VirtualDiskIdsExcludedFromSnapshot == null && Exploration.Includes(parent + ".virtualDiskIdsExcludedFromSnapshot$"))
            {
                this.VirtualDiskIdsExcludedFromSnapshot = new List<System.String>();
            }
            //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
            // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
            if (this.CloudInstantiationSpec == null && Exploration.Includes(parent + ".cloudInstantiationSpec"))
            {
                this.CloudInstantiationSpec = new CloudInstantiationSpec();
                this.CloudInstantiationSpec.ApplyExploratoryFragment(parent + ".cloudInstantiationSpec");
            }
        }


    #endregion

    } // class HypervVirtualMachineUpdate
    #endregion

    public static class ListHypervVirtualMachineUpdateExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<HypervVirtualMachineUpdate> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HypervVirtualMachineUpdate> list, 
            String parent = "")
        {
            var item = new HypervVirtualMachineUpdate();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types