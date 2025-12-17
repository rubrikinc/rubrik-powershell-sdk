// WindowsDiskLayoutDetails.cs
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
    #region WindowsDiskLayoutDetails
    public class WindowsDiskLayoutDetails: BaseType
    {
        #region members

        //      C# -> List<WindowsDiskInfo>? Disks
        // GraphQL -> disks: [WindowsDiskInfo!]! (type)
        [JsonProperty("disks")]
        public List<WindowsDiskInfo>? Disks { get; set; }

        //      C# -> List<WindowsVolumeInfo>? Volumes
        // GraphQL -> volumes: [WindowsVolumeInfo!]! (type)
        [JsonProperty("volumes")]
        public List<WindowsVolumeInfo>? Volumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WindowsDiskLayoutDetails";
    }

    public WindowsDiskLayoutDetails Set(
        List<WindowsDiskInfo>? Disks = null,
        List<WindowsVolumeInfo>? Volumes = null
    ) 
    {
        if ( Disks != null ) {
            this.Disks = Disks;
        }
        if ( Volumes != null ) {
            this.Volumes = Volumes;
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
        //      C# -> List<WindowsDiskInfo>? Disks
        // GraphQL -> disks: [WindowsDiskInfo!]! (type)
        if (this.Disks != null) {
            var fspec = this.Disks.AsFieldSpec(conf.Child("disks"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "disks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WindowsVolumeInfo>? Volumes
        // GraphQL -> volumes: [WindowsVolumeInfo!]! (type)
        if (this.Volumes != null) {
            var fspec = this.Volumes.AsFieldSpec(conf.Child("volumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<WindowsDiskInfo>? Disks
        // GraphQL -> disks: [WindowsDiskInfo!]! (type)
        if (ec.Includes("disks",false))
        {
            if(this.Disks == null) {

                this.Disks = new List<WindowsDiskInfo>();
                this.Disks.ApplyExploratoryFieldSpec(ec.NewChild("disks"));

            } else {

                this.Disks.ApplyExploratoryFieldSpec(ec.NewChild("disks"));

            }
        }
        else if (this.Disks != null && ec.Excludes("disks",false))
        {
            this.Disks = null;
        }
        //      C# -> List<WindowsVolumeInfo>? Volumes
        // GraphQL -> volumes: [WindowsVolumeInfo!]! (type)
        if (ec.Includes("volumes",false))
        {
            if(this.Volumes == null) {

                this.Volumes = new List<WindowsVolumeInfo>();
                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            } else {

                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            }
        }
        else if (this.Volumes != null && ec.Excludes("volumes",false))
        {
            this.Volumes = null;
        }
    }


    #endregion

    } // class WindowsDiskLayoutDetails
    
    #endregion

    public static class ListWindowsDiskLayoutDetailsExtensions
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
            this List<WindowsDiskLayoutDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WindowsDiskLayoutDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WindowsDiskLayoutDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WindowsDiskLayoutDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WindowsDiskLayoutDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types