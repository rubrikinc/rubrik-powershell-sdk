// NutanixVmDetail.cs
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
    #region NutanixVmDetail
    public class NutanixVmDetail: BaseType
    {
        #region members

        //      C# -> List<System.String>? ExcludedDiskIds
        // GraphQL -> excludedDiskIds: [String!]! (scalar)
        [JsonProperty("excludedDiskIds")]
        public List<System.String>? ExcludedDiskIds { get; set; }

        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        [JsonProperty("isAgentRegistered")]
        public System.Boolean? IsAgentRegistered { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        [JsonProperty("blackoutWindowResponseInfo")]
        public BlackoutWindowResponseInfo? BlackoutWindowResponseInfo { get; set; }

        //      C# -> NutanixVmPatch? NutanixVmPatch
        // GraphQL -> nutanixVmPatch: NutanixVmPatch (type)
        [JsonProperty("nutanixVmPatch")]
        public NutanixVmPatch? NutanixVmPatch { get; set; }

        //      C# -> NutanixVmSummary? NutanixVmSummary
        // GraphQL -> nutanixVmSummary: NutanixVmSummary (type)
        [JsonProperty("nutanixVmSummary")]
        public NutanixVmSummary? NutanixVmSummary { get; set; }

        //      C# -> List<NutanixVirtualDiskSummary>? VirtualDisks
        // GraphQL -> virtualDisks: [NutanixVirtualDiskSummary!]! (type)
        [JsonProperty("virtualDisks")]
        public List<NutanixVirtualDiskSummary>? VirtualDisks { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmDetail";
    }

    public NutanixVmDetail Set(
        List<System.String>? ExcludedDiskIds = null,
        System.Boolean? IsAgentRegistered = null,
        System.Boolean? IsPaused = null,
        BlackoutWindowResponseInfo? BlackoutWindowResponseInfo = null,
        NutanixVmPatch? NutanixVmPatch = null,
        NutanixVmSummary? NutanixVmSummary = null,
        List<NutanixVirtualDiskSummary>? VirtualDisks = null
    ) 
    {
        if ( ExcludedDiskIds != null ) {
            this.ExcludedDiskIds = ExcludedDiskIds;
        }
        if ( IsAgentRegistered != null ) {
            this.IsAgentRegistered = IsAgentRegistered;
        }
        if ( IsPaused != null ) {
            this.IsPaused = IsPaused;
        }
        if ( BlackoutWindowResponseInfo != null ) {
            this.BlackoutWindowResponseInfo = BlackoutWindowResponseInfo;
        }
        if ( NutanixVmPatch != null ) {
            this.NutanixVmPatch = NutanixVmPatch;
        }
        if ( NutanixVmSummary != null ) {
            this.NutanixVmSummary = NutanixVmSummary;
        }
        if ( VirtualDisks != null ) {
            this.VirtualDisks = VirtualDisks;
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
        //      C# -> List<System.String>? ExcludedDiskIds
        // GraphQL -> excludedDiskIds: [String!]! (scalar)
        if (this.ExcludedDiskIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedDiskIds\n" ;
            } else {
                s += ind + "excludedDiskIds\n" ;
            }
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        if (this.IsAgentRegistered != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAgentRegistered\n" ;
            } else {
                s += ind + "isAgentRegistered\n" ;
            }
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (this.IsPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPaused\n" ;
            } else {
                s += ind + "isPaused\n" ;
            }
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (this.BlackoutWindowResponseInfo != null) {
            var fspec = this.BlackoutWindowResponseInfo.AsFieldSpec(conf.Child("blackoutWindowResponseInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blackoutWindowResponseInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixVmPatch? NutanixVmPatch
        // GraphQL -> nutanixVmPatch: NutanixVmPatch (type)
        if (this.NutanixVmPatch != null) {
            var fspec = this.NutanixVmPatch.AsFieldSpec(conf.Child("nutanixVmPatch"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixVmPatch" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixVmSummary? NutanixVmSummary
        // GraphQL -> nutanixVmSummary: NutanixVmSummary (type)
        if (this.NutanixVmSummary != null) {
            var fspec = this.NutanixVmSummary.AsFieldSpec(conf.Child("nutanixVmSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixVmSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<NutanixVirtualDiskSummary>? VirtualDisks
        // GraphQL -> virtualDisks: [NutanixVirtualDiskSummary!]! (type)
        if (this.VirtualDisks != null) {
            var fspec = this.VirtualDisks.AsFieldSpec(conf.Child("virtualDisks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "virtualDisks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ExcludedDiskIds
        // GraphQL -> excludedDiskIds: [String!]! (scalar)
        if (ec.Includes("excludedDiskIds",true))
        {
            if(this.ExcludedDiskIds == null) {

                this.ExcludedDiskIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcludedDiskIds != null && ec.Excludes("excludedDiskIds",true))
        {
            this.ExcludedDiskIds = null;
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        if (ec.Includes("isAgentRegistered",true))
        {
            if(this.IsAgentRegistered == null) {

                this.IsAgentRegistered = true;

            } else {


            }
        }
        else if (this.IsAgentRegistered != null && ec.Excludes("isAgentRegistered",true))
        {
            this.IsAgentRegistered = null;
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (ec.Includes("isPaused",true))
        {
            if(this.IsPaused == null) {

                this.IsPaused = true;

            } else {


            }
        }
        else if (this.IsPaused != null && ec.Excludes("isPaused",true))
        {
            this.IsPaused = null;
        }
        //      C# -> BlackoutWindowResponseInfo? BlackoutWindowResponseInfo
        // GraphQL -> blackoutWindowResponseInfo: BlackoutWindowResponseInfo (type)
        if (ec.Includes("blackoutWindowResponseInfo",false))
        {
            if(this.BlackoutWindowResponseInfo == null) {

                this.BlackoutWindowResponseInfo = new BlackoutWindowResponseInfo();
                this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowResponseInfo"));

            } else {

                this.BlackoutWindowResponseInfo.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowResponseInfo"));

            }
        }
        else if (this.BlackoutWindowResponseInfo != null && ec.Excludes("blackoutWindowResponseInfo",false))
        {
            this.BlackoutWindowResponseInfo = null;
        }
        //      C# -> NutanixVmPatch? NutanixVmPatch
        // GraphQL -> nutanixVmPatch: NutanixVmPatch (type)
        if (ec.Includes("nutanixVmPatch",false))
        {
            if(this.NutanixVmPatch == null) {

                this.NutanixVmPatch = new NutanixVmPatch();
                this.NutanixVmPatch.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmPatch"));

            } else {

                this.NutanixVmPatch.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmPatch"));

            }
        }
        else if (this.NutanixVmPatch != null && ec.Excludes("nutanixVmPatch",false))
        {
            this.NutanixVmPatch = null;
        }
        //      C# -> NutanixVmSummary? NutanixVmSummary
        // GraphQL -> nutanixVmSummary: NutanixVmSummary (type)
        if (ec.Includes("nutanixVmSummary",false))
        {
            if(this.NutanixVmSummary == null) {

                this.NutanixVmSummary = new NutanixVmSummary();
                this.NutanixVmSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmSummary"));

            } else {

                this.NutanixVmSummary.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmSummary"));

            }
        }
        else if (this.NutanixVmSummary != null && ec.Excludes("nutanixVmSummary",false))
        {
            this.NutanixVmSummary = null;
        }
        //      C# -> List<NutanixVirtualDiskSummary>? VirtualDisks
        // GraphQL -> virtualDisks: [NutanixVirtualDiskSummary!]! (type)
        if (ec.Includes("virtualDisks",false))
        {
            if(this.VirtualDisks == null) {

                this.VirtualDisks = new List<NutanixVirtualDiskSummary>();
                this.VirtualDisks.ApplyExploratoryFieldSpec(ec.NewChild("virtualDisks"));

            } else {

                this.VirtualDisks.ApplyExploratoryFieldSpec(ec.NewChild("virtualDisks"));

            }
        }
        else if (this.VirtualDisks != null && ec.Excludes("virtualDisks",false))
        {
            this.VirtualDisks = null;
        }
    }


    #endregion

    } // class NutanixVmDetail
    
    #endregion

    public static class ListNutanixVmDetailExtensions
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
            this List<NutanixVmDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVmDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types