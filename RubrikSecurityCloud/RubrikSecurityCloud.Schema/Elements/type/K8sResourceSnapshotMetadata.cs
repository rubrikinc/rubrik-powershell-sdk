// K8sResourceSnapshotMetadata.cs
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
    #region K8sResourceSnapshotMetadata
    public class K8sResourceSnapshotMetadata: BaseType
    {
        #region members

        //      C# -> System.Boolean? NoAppMetadata
        // GraphQL -> noAppMetadata: Boolean! (scalar)
        [JsonProperty("noAppMetadata")]
        public System.Boolean? NoAppMetadata { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<ApiGroupToResourcesObjects>? Groups
        // GraphQL -> groups: [ApiGroupToResourcesObjects!]! (type)
        [JsonProperty("groups")]
        public List<ApiGroupToResourcesObjects>? Groups { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sResourceSnapshotMetadata";
    }

    public K8sResourceSnapshotMetadata Set(
        System.Boolean? NoAppMetadata = null,
        System.String? Version = null,
        List<ApiGroupToResourcesObjects>? Groups = null
    ) 
    {
        if ( NoAppMetadata != null ) {
            this.NoAppMetadata = NoAppMetadata;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
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
        //      C# -> System.Boolean? NoAppMetadata
        // GraphQL -> noAppMetadata: Boolean! (scalar)
        if (this.NoAppMetadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "noAppMetadata\n" ;
            } else {
                s += ind + "noAppMetadata\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<ApiGroupToResourcesObjects>? Groups
        // GraphQL -> groups: [ApiGroupToResourcesObjects!]! (type)
        if (this.Groups != null) {
            var fspec = this.Groups.AsFieldSpec(conf.Child("groups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? NoAppMetadata
        // GraphQL -> noAppMetadata: Boolean! (scalar)
        if (ec.Includes("noAppMetadata",true))
        {
            if(this.NoAppMetadata == null) {

                this.NoAppMetadata = true;

            } else {


            }
        }
        else if (this.NoAppMetadata != null && ec.Excludes("noAppMetadata",true))
        {
            this.NoAppMetadata = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<ApiGroupToResourcesObjects>? Groups
        // GraphQL -> groups: [ApiGroupToResourcesObjects!]! (type)
        if (ec.Includes("groups",false))
        {
            if(this.Groups == null) {

                this.Groups = new List<ApiGroupToResourcesObjects>();
                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            } else {

                this.Groups.ApplyExploratoryFieldSpec(ec.NewChild("groups"));

            }
        }
        else if (this.Groups != null && ec.Excludes("groups",false))
        {
            this.Groups = null;
        }
    }


    #endregion

    } // class K8sResourceSnapshotMetadata
    
    #endregion

    public static class ListK8sResourceSnapshotMetadataExtensions
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
            this List<K8sResourceSnapshotMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sResourceSnapshotMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sResourceSnapshotMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sResourceSnapshotMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sResourceSnapshotMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types