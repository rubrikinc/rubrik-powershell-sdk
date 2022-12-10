// TargetMapping.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    #region TargetMapping
    public class TargetMapping: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> ArchivalGroupConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: ArchivalGroupConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public ArchivalGroupConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> ArchivalGroupType? GroupType
        // GraphQL -> groupType: ArchivalGroupType! (enum)
        [JsonProperty("groupType")]
        public ArchivalGroupType? GroupType { get; set; }

        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        [JsonProperty("targetType")]
        public TargetType? TargetType { get; set; }

        //      C# -> List<ArchivalGroupTieringStatus>? TieringStatus
        // GraphQL -> tieringStatus: [ArchivalGroupTieringStatus!] (enum)
        [JsonProperty("tieringStatus")]
        public List<ArchivalGroupTieringStatus>? TieringStatus { get; set; }

        //      C# -> TargetTemplate? TargetTemplate
        // GraphQL -> targetTemplate: TargetTemplate (interface)
        [JsonProperty("targetTemplate")]
        public TargetTemplate? TargetTemplate { get; set; }

        //      C# -> List<Target>? Targets
        // GraphQL -> targets: [Target!] (interface)
        [JsonProperty("targets")]
        public List<Target>? Targets { get; set; }

        #endregion

    #region methods

    public TargetMapping Set(
        System.String? Id = null,
        System.String? Name = null,
        ArchivalGroupConnectionStatus? ConnectionStatus = null,
        ArchivalGroupType? GroupType = null,
        TargetType? TargetType = null,
        List<ArchivalGroupTieringStatus>? TieringStatus = null,
        TargetTemplate? TargetTemplate = null,
        List<Target>? Targets = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( GroupType != null ) {
            this.GroupType = GroupType;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( TieringStatus != null ) {
            this.TieringStatus = TieringStatus;
        }
        if ( TargetTemplate != null ) {
            this.TargetTemplate = TargetTemplate;
        }
        if ( Targets != null ) {
            this.Targets = Targets;
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
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> ArchivalGroupConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: ArchivalGroupConnectionStatus (type)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

                 s += ind + "{\n" + 
                 this.ConnectionStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ArchivalGroupType? GroupType
            // GraphQL -> groupType: ArchivalGroupType! (enum)
            if (this.GroupType != null)
            {
                 s += ind + "groupType\n";

            }
            //      C# -> TargetType? TargetType
            // GraphQL -> targetType: TargetType! (enum)
            if (this.TargetType != null)
            {
                 s += ind + "targetType\n";

            }
            //      C# -> List<ArchivalGroupTieringStatus>? TieringStatus
            // GraphQL -> tieringStatus: [ArchivalGroupTieringStatus!] (enum)
            if (this.TieringStatus != null)
            {
                 s += ind + "tieringStatus\n";

            }
                        //      C# -> TargetTemplate? TargetTemplate
            // GraphQL -> targetTemplate: TargetTemplate (interface)
            if (this.TargetTemplate != null)
            {
                s += ind + "targetTemplate\n";
                s += ind + "{\n";

                string typename = this.TargetTemplate.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.TargetTemplate.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> List<Target>? Targets
            // GraphQL -> targets: [Target!] (interface)
            if (this.Targets != null)
            {
                s += ind + "targets\n";
                s += ind + "{\n";

                s += this.Targets.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> ArchivalGroupConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: ArchivalGroupConnectionStatus (type)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
            {
                this.ConnectionStatus = new ArchivalGroupConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFragment(parent + ".connectionStatus");
            }
            //      C# -> ArchivalGroupType? GroupType
            // GraphQL -> groupType: ArchivalGroupType! (enum)
            if (this.GroupType == null && Exploration.Includes(parent + ".groupType$"))
            {
                this.GroupType = new ArchivalGroupType();
            }
            //      C# -> TargetType? TargetType
            // GraphQL -> targetType: TargetType! (enum)
            if (this.TargetType == null && Exploration.Includes(parent + ".targetType$"))
            {
                this.TargetType = new TargetType();
            }
            //      C# -> List<ArchivalGroupTieringStatus>? TieringStatus
            // GraphQL -> tieringStatus: [ArchivalGroupTieringStatus!] (enum)
            if (this.TieringStatus == null && Exploration.Includes(parent + ".tieringStatus$"))
            {
                this.TieringStatus = new List<ArchivalGroupTieringStatus>();
            }
            //      C# -> TargetTemplate? TargetTemplate
            // GraphQL -> targetTemplate: TargetTemplate (interface)
            if (this.TargetTemplate == null && Exploration.Includes(parent + ".targetTemplate"))
            {
                this.TargetTemplate = (TargetTemplate)InterfaceHelper.CreateInstanceOfFirstType(typeof(TargetTemplate));
                this.TargetTemplate.ApplyExploratoryFragment(parent + ".targetTemplate");
            }
            //      C# -> List<Target>? Targets
            // GraphQL -> targets: [Target!] (interface)
            if (this.Targets == null && Exploration.Includes(parent + ".targets"))
            {
                this.Targets = new List<Target>();
                this.Targets.ApplyExploratoryFragment(parent + ".targets");
            }
        }


    #endregion

    } // class TargetMapping
    #endregion

    public static class ListTargetMappingExtensions
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
            this List<TargetMapping> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TargetMapping> list, 
            String parent = "")
        {
            var item = new TargetMapping();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types