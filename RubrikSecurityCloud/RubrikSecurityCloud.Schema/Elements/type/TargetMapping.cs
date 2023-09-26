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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ArchivalGroupType? GroupType
        // GraphQL -> groupType: ArchivalGroupType! (enum)
        if (this.GroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupType\n" ;
            } else {
                s += ind + "groupType\n" ;
            }
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> List<ArchivalGroupTieringStatus>? TieringStatus
        // GraphQL -> tieringStatus: [ArchivalGroupTieringStatus!] (enum)
        if (this.TieringStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tieringStatus\n" ;
            } else {
                s += ind + "tieringStatus\n" ;
            }
        }
        //      C# -> TargetTemplate? TargetTemplate
        // GraphQL -> targetTemplate: TargetTemplate (interface)
        if (this.TargetTemplate != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.TargetTemplate).AsFieldSpec(conf.Child("targetTemplate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetTemplate {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<Target>? Targets
        // GraphQL -> targets: [Target!] (interface)
        if (this.Targets != null) {
                var fspec = this.Targets.AsFieldSpec(conf.Child("targets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targets {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> ArchivalGroupConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: ArchivalGroupConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ArchivalGroupType? GroupType
        // GraphQL -> groupType: ArchivalGroupType! (enum)
        if (ec.Includes("groupType",true))
        {
            if(this.GroupType == null) {

                this.GroupType = new ArchivalGroupType();

            } else {


            }
        }
        else if (this.GroupType != null && ec.Excludes("groupType",true))
        {
            this.GroupType = null;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new TargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> List<ArchivalGroupTieringStatus>? TieringStatus
        // GraphQL -> tieringStatus: [ArchivalGroupTieringStatus!] (enum)
        if (ec.Includes("tieringStatus",true))
        {
            if(this.TieringStatus == null) {

                this.TieringStatus = new List<ArchivalGroupTieringStatus>();

            } else {


            }
        }
        else if (this.TieringStatus != null && ec.Excludes("tieringStatus",true))
        {
            this.TieringStatus = null;
        }
        //      C# -> TargetTemplate? TargetTemplate
        // GraphQL -> targetTemplate: TargetTemplate (interface)
        if (ec.Includes("targetTemplate",false))
        {
            if(this.TargetTemplate == null) {

                var impls = new List<TargetTemplate>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("targetTemplate"));
                this.TargetTemplate = (TargetTemplate)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<TargetTemplate>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("targetTemplate"));
                this.TargetTemplate = (TargetTemplate)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.TargetTemplate != null && ec.Excludes("targetTemplate",false))
        {
            this.TargetTemplate = null;
        }
        //      C# -> List<Target>? Targets
        // GraphQL -> targets: [Target!] (interface)
        if (ec.Includes("targets",false))
        {
            if(this.Targets == null) {

                this.Targets = new List<Target>();
                this.Targets.ApplyExploratoryFieldSpec(ec.NewChild("targets"));

            } else {

                this.Targets.ApplyExploratoryFieldSpec(ec.NewChild("targets"));

            }
        }
        else if (this.Targets != null && ec.Excludes("targets",false))
        {
            this.Targets = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> ArchivalGroupConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: ArchivalGroupConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new ArchivalGroupConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TargetMapping> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TargetMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TargetMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types