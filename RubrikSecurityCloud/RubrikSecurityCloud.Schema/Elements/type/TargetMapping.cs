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
        public RscInterface<TargetTemplate> TargetTemplate { get; set; }

        //      C# -> List<Target>? Targets
        // GraphQL -> targets: [Target!] (interface)
        [JsonProperty("targets")]
        public RscInterface<Target> Targets { get; set; }

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
        RscInterface<TargetTemplate> TargetTemplate = null,
        RscInterface<Target> Targets = null,
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
            var fspec = this.TargetTemplate.AsFieldSpec(conf.Child("targetTemplate"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetTemplate" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<Target>? Targets
        // GraphQL -> targets: [Target!] (interface)
        if (this.Targets != null) {
            var fspec = this.Targets.AsFieldSpec(conf.Child("targets"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targets" + " " + "{\n" + fspec + ind + "}\n";
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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
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

                this.TargetTemplate = new RscInterface<TargetTemplate>();
                this.TargetTemplate.ApplyExploratoryFieldSpec(ec.NewChild("targetTemplate"));

            } else {

                this.TargetTemplate.ApplyExploratoryFieldSpec(ec.NewChild("targetTemplate"));

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

                this.Targets = new RscInterface<Target>();
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<TargetMapping> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TargetMapping> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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