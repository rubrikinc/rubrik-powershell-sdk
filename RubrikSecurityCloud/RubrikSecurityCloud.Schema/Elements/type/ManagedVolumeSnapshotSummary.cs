// ManagedVolumeSnapshotSummary.cs
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
    #region ManagedVolumeSnapshotSummary
    public class ManagedVolumeSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsQueuedSnapshot
        // GraphQL -> isQueuedSnapshot: Boolean (scalar)
        [JsonProperty("isQueuedSnapshot")]
        public System.Boolean? IsQueuedSnapshot { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }

        //      C# -> ManagedVolumeSnapshotLinks? Links
        // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
        [JsonProperty("links")]
        public ManagedVolumeSnapshotLinks? Links { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeSnapshotSummary";
    }

    public ManagedVolumeSnapshotSummary Set(
        System.Boolean? IsQueuedSnapshot = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null,
        ManagedVolumeSnapshotLinks? Links = null
    ) 
    {
        if ( IsQueuedSnapshot != null ) {
            this.IsQueuedSnapshot = IsQueuedSnapshot;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
        }
        if ( Links != null ) {
            this.Links = Links;
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
        //      C# -> System.Boolean? IsQueuedSnapshot
        // GraphQL -> isQueuedSnapshot: Boolean (scalar)
        if (this.IsQueuedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQueuedSnapshot\n" ;
            } else {
                s += ind + "isQueuedSnapshot\n" ;
            }
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(conf.Child("baseSnapshotSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseSnapshotSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeSnapshotLinks? Links
        // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
        if (this.Links != null) {
            var fspec = this.Links.AsFieldSpec(conf.Child("links"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "links" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsQueuedSnapshot
        // GraphQL -> isQueuedSnapshot: Boolean (scalar)
        if (ec.Includes("isQueuedSnapshot",true))
        {
            if(this.IsQueuedSnapshot == null) {

                this.IsQueuedSnapshot = true;

            } else {


            }
        }
        else if (this.IsQueuedSnapshot != null && ec.Excludes("isQueuedSnapshot",true))
        {
            this.IsQueuedSnapshot = null;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (ec.Includes("baseSnapshotSummary",false))
        {
            if(this.BaseSnapshotSummary == null) {

                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            } else {

                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            }
        }
        else if (this.BaseSnapshotSummary != null && ec.Excludes("baseSnapshotSummary",false))
        {
            this.BaseSnapshotSummary = null;
        }
        //      C# -> ManagedVolumeSnapshotLinks? Links
        // GraphQL -> links: ManagedVolumeSnapshotLinks (type)
        if (ec.Includes("links",false))
        {
            if(this.Links == null) {

                this.Links = new ManagedVolumeSnapshotLinks();
                this.Links.ApplyExploratoryFieldSpec(ec.NewChild("links"));

            } else {

                this.Links.ApplyExploratoryFieldSpec(ec.NewChild("links"));

            }
        }
        else if (this.Links != null && ec.Excludes("links",false))
        {
            this.Links = null;
        }
    }


    #endregion

    } // class ManagedVolumeSnapshotSummary
    
    #endregion

    public static class ListManagedVolumeSnapshotSummaryExtensions
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
            this List<ManagedVolumeSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types