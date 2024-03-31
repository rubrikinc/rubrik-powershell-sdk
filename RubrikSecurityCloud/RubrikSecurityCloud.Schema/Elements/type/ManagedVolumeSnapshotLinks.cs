// ManagedVolumeSnapshotLinks.cs
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
    #region ManagedVolumeSnapshotLinks
    public class ManagedVolumeSnapshotLinks: BaseType
    {
        #region members

        //      C# -> Link? ExportLink
        // GraphQL -> exportLink: Link (type)
        [JsonProperty("exportLink")]
        public Link? ExportLink { get; set; }

        //      C# -> Link? Self
        // GraphQL -> self: Link (type)
        [JsonProperty("self")]
        public Link? Self { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeSnapshotLinks";
    }

    public ManagedVolumeSnapshotLinks Set(
        Link? ExportLink = null,
        Link? Self = null
    ) 
    {
        if ( ExportLink != null ) {
            this.ExportLink = ExportLink;
        }
        if ( Self != null ) {
            this.Self = Self;
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
        //      C# -> Link? ExportLink
        // GraphQL -> exportLink: Link (type)
        if (this.ExportLink != null) {
            var fspec = this.ExportLink.AsFieldSpec(conf.Child("exportLink"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exportLink {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Link? Self
        // GraphQL -> self: Link (type)
        if (this.Self != null) {
            var fspec = this.Self.AsFieldSpec(conf.Child("self"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "self {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Link? ExportLink
        // GraphQL -> exportLink: Link (type)
        if (ec.Includes("exportLink",false))
        {
            if(this.ExportLink == null) {

                this.ExportLink = new Link();
                this.ExportLink.ApplyExploratoryFieldSpec(ec.NewChild("exportLink"));

            } else {

                this.ExportLink.ApplyExploratoryFieldSpec(ec.NewChild("exportLink"));

            }
        }
        else if (this.ExportLink != null && ec.Excludes("exportLink",false))
        {
            this.ExportLink = null;
        }
        //      C# -> Link? Self
        // GraphQL -> self: Link (type)
        if (ec.Includes("self",false))
        {
            if(this.Self == null) {

                this.Self = new Link();
                this.Self.ApplyExploratoryFieldSpec(ec.NewChild("self"));

            } else {

                this.Self.ApplyExploratoryFieldSpec(ec.NewChild("self"));

            }
        }
        else if (this.Self != null && ec.Excludes("self",false))
        {
            this.Self = null;
        }
    }


    #endregion

    } // class ManagedVolumeSnapshotLinks
    
    #endregion

    public static class ListManagedVolumeSnapshotLinksExtensions
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
            this List<ManagedVolumeSnapshotLinks> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeSnapshotLinks> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeSnapshotLinks> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeSnapshotLinks());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeSnapshotLinks> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types