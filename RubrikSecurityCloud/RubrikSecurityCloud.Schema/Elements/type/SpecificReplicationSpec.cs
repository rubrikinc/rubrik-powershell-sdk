// SpecificReplicationSpec.cs
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
    #region SpecificReplicationSpec
    public class SpecificReplicationSpec: IFragment
    {
        #region members
        //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
        // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
        [JsonProperty("bidirectionalSpec")]
        public BidirectionalReplicationSpec? BidirectionalSpec { get; set; }

        //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
        // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
        [JsonProperty("cloudLocationSpec")]
        public ReplicationToCloudLocationSpec? CloudLocationSpec { get; set; }

        //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
        // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
        [JsonProperty("cloudRegionSpec")]
        public ReplicationToCloudRegionSpec? CloudRegionSpec { get; set; }

        //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
        // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
        [JsonProperty("unidirectionalSpec")]
        public UnidirectionalReplicationSpec? UnidirectionalSpec { get; set; }

        #endregion

    #region methods

    public SpecificReplicationSpec Set(
        BidirectionalReplicationSpec? BidirectionalSpec = null,
        ReplicationToCloudLocationSpec? CloudLocationSpec = null,
        ReplicationToCloudRegionSpec? CloudRegionSpec = null,
        UnidirectionalReplicationSpec? UnidirectionalSpec = null
    ) 
    {
        if ( BidirectionalSpec != null ) {
            this.BidirectionalSpec = BidirectionalSpec;
        }
        if ( CloudLocationSpec != null ) {
            this.CloudLocationSpec = CloudLocationSpec;
        }
        if ( CloudRegionSpec != null ) {
            this.CloudRegionSpec = CloudRegionSpec;
        }
        if ( UnidirectionalSpec != null ) {
            this.UnidirectionalSpec = UnidirectionalSpec;
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
            //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
            // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
            if (this.BidirectionalSpec != null)
            {
                 s += ind + "bidirectionalSpec\n";

                 s += ind + "{\n" + 
                 this.BidirectionalSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
            // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
            if (this.CloudLocationSpec != null)
            {
                 s += ind + "cloudLocationSpec\n";

                 s += ind + "{\n" + 
                 this.CloudLocationSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
            // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
            if (this.CloudRegionSpec != null)
            {
                 s += ind + "cloudRegionSpec\n";

                 s += ind + "{\n" + 
                 this.CloudRegionSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
            // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
            if (this.UnidirectionalSpec != null)
            {
                 s += ind + "unidirectionalSpec\n";

                 s += ind + "{\n" + 
                 this.UnidirectionalSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> BidirectionalReplicationSpec? BidirectionalSpec
            // GraphQL -> bidirectionalSpec: BidirectionalReplicationSpec (type)
            if (this.BidirectionalSpec == null && Exploration.Includes(parent + ".bidirectionalSpec"))
            {
                this.BidirectionalSpec = new BidirectionalReplicationSpec();
                this.BidirectionalSpec.ApplyExploratoryFragment(parent + ".bidirectionalSpec");
            }
            //      C# -> ReplicationToCloudLocationSpec? CloudLocationSpec
            // GraphQL -> cloudLocationSpec: ReplicationToCloudLocationSpec (type)
            if (this.CloudLocationSpec == null && Exploration.Includes(parent + ".cloudLocationSpec"))
            {
                this.CloudLocationSpec = new ReplicationToCloudLocationSpec();
                this.CloudLocationSpec.ApplyExploratoryFragment(parent + ".cloudLocationSpec");
            }
            //      C# -> ReplicationToCloudRegionSpec? CloudRegionSpec
            // GraphQL -> cloudRegionSpec: ReplicationToCloudRegionSpec (type)
            if (this.CloudRegionSpec == null && Exploration.Includes(parent + ".cloudRegionSpec"))
            {
                this.CloudRegionSpec = new ReplicationToCloudRegionSpec();
                this.CloudRegionSpec.ApplyExploratoryFragment(parent + ".cloudRegionSpec");
            }
            //      C# -> UnidirectionalReplicationSpec? UnidirectionalSpec
            // GraphQL -> unidirectionalSpec: UnidirectionalReplicationSpec (type)
            if (this.UnidirectionalSpec == null && Exploration.Includes(parent + ".unidirectionalSpec"))
            {
                this.UnidirectionalSpec = new UnidirectionalReplicationSpec();
                this.UnidirectionalSpec.ApplyExploratoryFragment(parent + ".unidirectionalSpec");
            }
        }


    #endregion

    } // class SpecificReplicationSpec
    #endregion

    public static class ListSpecificReplicationSpecExtensions
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
            this List<SpecificReplicationSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SpecificReplicationSpec> list, 
            String parent = "")
        {
            var item = new SpecificReplicationSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types