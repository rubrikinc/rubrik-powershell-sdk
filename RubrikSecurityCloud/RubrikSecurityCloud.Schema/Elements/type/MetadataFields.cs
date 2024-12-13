// MetadataFields.cs
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
    #region MetadataFields
    public class MetadataFields: BaseType
    {
        #region members

        //      C# -> M365ObjectType? ObjectType
        // GraphQL -> objectType: M365ObjectType! (enum)
        [JsonProperty("objectType")]
        public M365ObjectType? ObjectType { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? SnappableType
        // GraphQL -> snappableType: String! (scalar)
        [JsonProperty("snappableType")]
        public System.String? SnappableType { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int! (scalar)
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MetadataFields";
    }

    public MetadataFields Set(
        M365ObjectType? ObjectType = null,
        System.String? ObjectName = null,
        System.String? SnappableId = null,
        System.String? SnappableType = null,
        System.Int32? SnapshotNum = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( SnapshotNum != null ) {
            this.SnapshotNum = SnapshotNum;
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
        //      C# -> M365ObjectType? ObjectType
        // GraphQL -> objectType: M365ObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
            }
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> System.String? SnappableType
        // GraphQL -> snappableType: String! (scalar)
        if (this.SnappableType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableType\n" ;
            } else {
                s += ind + "snappableType\n" ;
            }
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int! (scalar)
        if (this.SnapshotNum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotNum\n" ;
            } else {
                s += ind + "snapshotNum\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> M365ObjectType? ObjectType
        // GraphQL -> objectType: M365ObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new M365ObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> System.String? SnappableType
        // GraphQL -> snappableType: String! (scalar)
        if (ec.Includes("snappableType",true))
        {
            if(this.SnappableType == null) {

                this.SnappableType = "FETCH";

            } else {


            }
        }
        else if (this.SnappableType != null && ec.Excludes("snappableType",true))
        {
            this.SnappableType = null;
        }
        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int! (scalar)
        if (ec.Includes("snapshotNum",true))
        {
            if(this.SnapshotNum == null) {

                this.SnapshotNum = Int32.MinValue;

            } else {


            }
        }
        else if (this.SnapshotNum != null && ec.Excludes("snapshotNum",true))
        {
            this.SnapshotNum = null;
        }
    }


    #endregion

    } // class MetadataFields
    
    #endregion

    public static class ListMetadataFieldsExtensions
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
            this List<MetadataFields> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MetadataFields> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MetadataFields> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MetadataFields());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MetadataFields> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types