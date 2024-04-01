// VappNetworkSummary.cs
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
    #region VappNetworkSummary
    public class VappNetworkSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDeployed
        // GraphQL -> isDeployed: Boolean! (scalar)
        [JsonProperty("isDeployed")]
        public System.Boolean? IsDeployed { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentNetworkId
        // GraphQL -> parentNetworkId: String (scalar)
        [JsonProperty("parentNetworkId")]
        public System.String? ParentNetworkId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappNetworkSummary";
    }

    public VappNetworkSummary Set(
        System.Boolean? IsDeployed = null,
        System.String? Name = null,
        System.String? ParentNetworkId = null
    ) 
    {
        if ( IsDeployed != null ) {
            this.IsDeployed = IsDeployed;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentNetworkId != null ) {
            this.ParentNetworkId = ParentNetworkId;
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
        //      C# -> System.Boolean? IsDeployed
        // GraphQL -> isDeployed: Boolean! (scalar)
        if (this.IsDeployed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeployed\n" ;
            } else {
                s += ind + "isDeployed\n" ;
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
        //      C# -> System.String? ParentNetworkId
        // GraphQL -> parentNetworkId: String (scalar)
        if (this.ParentNetworkId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentNetworkId\n" ;
            } else {
                s += ind + "parentNetworkId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsDeployed
        // GraphQL -> isDeployed: Boolean! (scalar)
        if (ec.Includes("isDeployed",true))
        {
            if(this.IsDeployed == null) {

                this.IsDeployed = true;

            } else {


            }
        }
        else if (this.IsDeployed != null && ec.Excludes("isDeployed",true))
        {
            this.IsDeployed = null;
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
        //      C# -> System.String? ParentNetworkId
        // GraphQL -> parentNetworkId: String (scalar)
        if (ec.Includes("parentNetworkId",true))
        {
            if(this.ParentNetworkId == null) {

                this.ParentNetworkId = "FETCH";

            } else {


            }
        }
        else if (this.ParentNetworkId != null && ec.Excludes("parentNetworkId",true))
        {
            this.ParentNetworkId = null;
        }
    }


    #endregion

    } // class VappNetworkSummary
    
    #endregion

    public static class ListVappNetworkSummaryExtensions
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
            this List<VappNetworkSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VappNetworkSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappNetworkSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappNetworkSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappNetworkSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types