// TargetMapping.cs
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
    #region TargetMapping
    public class TargetMapping: BaseType
    {
        #region members

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TargetMapping";
    }

    public TargetMapping Set(
        ArchivalGroupType? GroupType = null,
        TargetType? TargetType = null,
        List<ArchivalGroupTieringStatus>? TieringStatus = null,
        TargetTemplate? TargetTemplate = null,
        List<Target>? Targets = null,
        System.String? Id = null,
        System.String? Name = null,
        ArchivalGroupConnectionStatus? ConnectionStatus = null
    ) 
    {
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
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
        //      C# -> ArchivalGroupType? GroupType
        // GraphQL -> groupType: ArchivalGroupType! (enum)
        if (this.GroupType != null) {
            s += ind + "groupType\n" ;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            s += ind + "targetType\n" ;
        }
        //      C# -> List<ArchivalGroupTieringStatus>? TieringStatus
        // GraphQL -> tieringStatus: [ArchivalGroupTieringStatus!] (enum)
        if (this.TieringStatus != null) {
            s += ind + "tieringStatus\n" ;
        }
        //      C# -> TargetTemplate? TargetTemplate
        // GraphQL -> targetTemplate: TargetTemplate (interface)
        if (this.TargetTemplate != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.TargetTemplate).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetTemplate {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> List<Target>? Targets
        // GraphQL -> targets: [Target!] (interface)
        if (this.Targets != null) {
                var fspec = this.Targets.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targets {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> ArchivalGroupConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: ArchivalGroupConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ArchivalGroupType? GroupType
        // GraphQL -> groupType: ArchivalGroupType! (enum)
        if (this.GroupType == null && Exploration.Includes(parent + ".groupType", true))
        {
            this.GroupType = new ArchivalGroupType();
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType == null && Exploration.Includes(parent + ".targetType", true))
        {
            this.TargetType = new TargetType();
        }
        //      C# -> List<ArchivalGroupTieringStatus>? TieringStatus
        // GraphQL -> tieringStatus: [ArchivalGroupTieringStatus!] (enum)
        if (this.TieringStatus == null && Exploration.Includes(parent + ".tieringStatus", true))
        {
            this.TieringStatus = new List<ArchivalGroupTieringStatus>();
        }
        //      C# -> TargetTemplate? TargetTemplate
        // GraphQL -> targetTemplate: TargetTemplate (interface)
        if (this.TargetTemplate == null && Exploration.Includes(parent + ".targetTemplate"))
        {
            var impls = new List<TargetTemplate>();
            impls.ApplyExploratoryFieldSpec(parent + ".targetTemplate");
            this.TargetTemplate = (TargetTemplate)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> List<Target>? Targets
        // GraphQL -> targets: [Target!] (interface)
        if (this.Targets == null && Exploration.Includes(parent + ".targets"))
        {
            this.Targets = new List<Target>();
            this.Targets.ApplyExploratoryFieldSpec(parent + ".targets");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> ArchivalGroupConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: ArchivalGroupConnectionStatus (type)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
        {
            this.ConnectionStatus = new ArchivalGroupConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(parent + ".connectionStatus");
        }
    }


    #endregion

    } // class TargetMapping
    
    #endregion

    public static class ListTargetMappingExtensions
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
            this List<TargetMapping> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TargetMapping> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TargetMapping());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types