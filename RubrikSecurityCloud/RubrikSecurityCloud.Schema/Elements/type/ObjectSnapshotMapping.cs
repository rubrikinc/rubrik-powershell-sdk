// ObjectSnapshotMapping.cs
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
    #region ObjectSnapshotMapping
    public class ObjectSnapshotMapping: BaseType
    {
        #region members

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> List<System.String>? SnapshotFid
        // GraphQL -> snapshotFid: [String!]! (scalar)
        [JsonProperty("snapshotFid")]
        public List<System.String>? SnapshotFid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectSnapshotMapping";
    }

    public ObjectSnapshotMapping Set(
        System.String? ObjectFid = null,
        List<System.String>? SnapshotFid = null
    ) 
    {
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
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
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        if (this.ObjectFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFid\n" ;
            } else {
                s += ind + "objectFid\n" ;
            }
        }
        //      C# -> List<System.String>? SnapshotFid
        // GraphQL -> snapshotFid: [String!]! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        if (ec.Includes("objectFid",true))
        {
            if(this.ObjectFid == null) {

                this.ObjectFid = "FETCH";

            } else {


            }
        }
        else if (this.ObjectFid != null && ec.Excludes("objectFid",true))
        {
            this.ObjectFid = null;
        }
        //      C# -> List<System.String>? SnapshotFid
        // GraphQL -> snapshotFid: [String!]! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = new List<System.String>();

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
        }
    }


    #endregion

    } // class ObjectSnapshotMapping
    
    #endregion

    public static class ListObjectSnapshotMappingExtensions
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
            this List<ObjectSnapshotMapping> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectSnapshotMapping> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectSnapshotMapping> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectSnapshotMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectSnapshotMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types