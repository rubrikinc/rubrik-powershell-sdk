// MongoSourceAppMetadata.cs
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
    #region MongoSourceAppMetadata
    public class MongoSourceAppMetadata: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsFullSnapshot
        // GraphQL -> isFullSnapshot: Boolean (scalar)
        [JsonProperty("isFullSnapshot")]
        public System.Boolean? IsFullSnapshot { get; set; }

        //      C# -> System.Int64? SnapshotSize
        // GraphQL -> snapshotSize: Long (scalar)
        [JsonProperty("snapshotSize")]
        public System.Int64? SnapshotSize { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MongoSourceAppMetadata";
    }

    public MongoSourceAppMetadata Set(
        System.Boolean? IsFullSnapshot = null,
        System.Int64? SnapshotSize = null
    ) 
    {
        if ( IsFullSnapshot != null ) {
            this.IsFullSnapshot = IsFullSnapshot;
        }
        if ( SnapshotSize != null ) {
            this.SnapshotSize = SnapshotSize;
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
        //      C# -> System.Boolean? IsFullSnapshot
        // GraphQL -> isFullSnapshot: Boolean (scalar)
        if (this.IsFullSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFullSnapshot\n" ;
            } else {
                s += ind + "isFullSnapshot\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotSize
        // GraphQL -> snapshotSize: Long (scalar)
        if (this.SnapshotSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotSize\n" ;
            } else {
                s += ind + "snapshotSize\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsFullSnapshot
        // GraphQL -> isFullSnapshot: Boolean (scalar)
        if (ec.Includes("isFullSnapshot",true))
        {
            if(this.IsFullSnapshot == null) {

                this.IsFullSnapshot = true;

            } else {


            }
        }
        else if (this.IsFullSnapshot != null && ec.Excludes("isFullSnapshot",true))
        {
            this.IsFullSnapshot = null;
        }
        //      C# -> System.Int64? SnapshotSize
        // GraphQL -> snapshotSize: Long (scalar)
        if (ec.Includes("snapshotSize",true))
        {
            if(this.SnapshotSize == null) {

                this.SnapshotSize = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotSize != null && ec.Excludes("snapshotSize",true))
        {
            this.SnapshotSize = null;
        }
    }


    #endregion

    } // class MongoSourceAppMetadata
    
    #endregion

    public static class ListMongoSourceAppMetadataExtensions
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
            this List<MongoSourceAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MongoSourceAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MongoSourceAppMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoSourceAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MongoSourceAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types