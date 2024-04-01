// FailoverClusterSummary.cs
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
    #region FailoverClusterSummary
    public class FailoverClusterSummary: BaseType
    {
        #region members

        //      C# -> FailoverClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public FailoverClusterConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        [JsonProperty("operatingSystemType")]
        public FailoverClusterOsType? OperatingSystemType { get; set; }

        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignment? SlaAssignment { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> List<FailoverClusterNode>? Nodes
        // GraphQL -> nodes: [FailoverClusterNode!]! (type)
        [JsonProperty("nodes")]
        public List<FailoverClusterNode>? Nodes { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailoverClusterSummary";
    }

    public FailoverClusterSummary Set(
        FailoverClusterConnectionStatus? ConnectionStatus = null,
        FailoverClusterOsType? OperatingSystemType = null,
        SlaAssignment? SlaAssignment = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        List<FailoverClusterNode>? Nodes = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> FailoverClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        if (this.OperatingSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystemType\n" ;
            } else {
                s += ind + "operatingSystemType\n" ;
            }
        }
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder != null) {
            var fspec = this.EffectiveSlaHolder.AsFieldSpec(conf.Child("effectiveSlaHolder"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaHolder {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FailoverClusterNode>? Nodes
        // GraphQL -> nodes: [FailoverClusterNode!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodes {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FailoverClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: FailoverClusterConnectionStatus! (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new FailoverClusterConnectionStatus();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> FailoverClusterOsType? OperatingSystemType
        // GraphQL -> operatingSystemType: FailoverClusterOsType (enum)
        if (ec.Includes("operatingSystemType",true))
        {
            if(this.OperatingSystemType == null) {

                this.OperatingSystemType = new FailoverClusterOsType();

            } else {


            }
        }
        else if (this.OperatingSystemType != null && ec.Excludes("operatingSystemType",true))
        {
            this.OperatingSystemType = null;
        }
        //      C# -> SlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignment (enum)
        if (ec.Includes("slaAssignment",true))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new SlaAssignment();

            } else {


            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",true))
        {
            this.SlaAssignment = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (ec.Includes("effectiveSlaHolder",false))
        {
            if(this.EffectiveSlaHolder == null) {

                this.EffectiveSlaHolder = new EffectiveSlaHolder();
                this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaHolder"));

            } else {

                this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaHolder"));

            }
        }
        else if (this.EffectiveSlaHolder != null && ec.Excludes("effectiveSlaHolder",false))
        {
            this.EffectiveSlaHolder = null;
        }
        //      C# -> List<FailoverClusterNode>? Nodes
        // GraphQL -> nodes: [FailoverClusterNode!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<FailoverClusterNode>();
                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            } else {

                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            }
        }
        else if (this.Nodes != null && ec.Excludes("nodes",false))
        {
            this.Nodes = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class FailoverClusterSummary
    
    #endregion

    public static class ListFailoverClusterSummaryExtensions
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
            this List<FailoverClusterSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailoverClusterSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverClusterSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverClusterSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types