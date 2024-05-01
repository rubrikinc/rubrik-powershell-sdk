// ManagedVolumeMountSpec.cs
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
    #region ManagedVolumeMountSpec
    public class ManagedVolumeMountSpec: BaseType
    {
        #region members

        //      C# -> System.Int64? ImageSizeOpt
        // GraphQL -> imageSizeOpt: Long (scalar)
        [JsonProperty("imageSizeOpt")]
        public System.Int64? ImageSizeOpt { get; set; }

        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        [JsonProperty("mountDir")]
        public System.String? MountDir { get; set; }

        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        [JsonProperty("node")]
        public ClusterNode? Node { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeMountSpec";
    }

    public ManagedVolumeMountSpec Set(
        System.Int64? ImageSizeOpt = null,
        System.String? MountDir = null,
        ClusterNode? Node = null
    ) 
    {
        if ( ImageSizeOpt != null ) {
            this.ImageSizeOpt = ImageSizeOpt;
        }
        if ( MountDir != null ) {
            this.MountDir = MountDir;
        }
        if ( Node != null ) {
            this.Node = Node;
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
        //      C# -> System.Int64? ImageSizeOpt
        // GraphQL -> imageSizeOpt: Long (scalar)
        if (this.ImageSizeOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "imageSizeOpt\n" ;
            } else {
                s += ind + "imageSizeOpt\n" ;
            }
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (this.MountDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountDir\n" ;
            } else {
                s += ind + "mountDir\n" ;
            }
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (this.Node != null) {
            var fspec = this.Node.AsFieldSpec(conf.Child("node"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "node" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ImageSizeOpt
        // GraphQL -> imageSizeOpt: Long (scalar)
        if (ec.Includes("imageSizeOpt",true))
        {
            if(this.ImageSizeOpt == null) {

                this.ImageSizeOpt = new System.Int64();

            } else {


            }
        }
        else if (this.ImageSizeOpt != null && ec.Excludes("imageSizeOpt",true))
        {
            this.ImageSizeOpt = null;
        }
        //      C# -> System.String? MountDir
        // GraphQL -> mountDir: String! (scalar)
        if (ec.Includes("mountDir",true))
        {
            if(this.MountDir == null) {

                this.MountDir = "FETCH";

            } else {


            }
        }
        else if (this.MountDir != null && ec.Excludes("mountDir",true))
        {
            this.MountDir = null;
        }
        //      C# -> ClusterNode? Node
        // GraphQL -> node: ClusterNode (type)
        if (ec.Includes("node",false))
        {
            if(this.Node == null) {

                this.Node = new ClusterNode();
                this.Node.ApplyExploratoryFieldSpec(ec.NewChild("node"));

            } else {

                this.Node.ApplyExploratoryFieldSpec(ec.NewChild("node"));

            }
        }
        else if (this.Node != null && ec.Excludes("node",false))
        {
            this.Node = null;
        }
    }


    #endregion

    } // class ManagedVolumeMountSpec
    
    #endregion

    public static class ListManagedVolumeMountSpecExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ManagedVolumeMountSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeMountSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeMountSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeMountSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeMountSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types