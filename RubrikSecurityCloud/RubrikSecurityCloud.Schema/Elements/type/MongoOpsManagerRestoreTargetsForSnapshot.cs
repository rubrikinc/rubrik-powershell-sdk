// MongoOpsManagerRestoreTargetsForSnapshot.cs
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
    #region MongoOpsManagerRestoreTargetsForSnapshot
    public class MongoOpsManagerRestoreTargetsForSnapshot: BaseType
    {
        #region members

        //      C# -> System.String? SourceId
        // GraphQL -> sourceId: String! (scalar)
        [JsonProperty("sourceId")]
        public System.String? SourceId { get; set; }

        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String! (scalar)
        [JsonProperty("sourceName")]
        public System.String? SourceName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MongoOpsManagerRestoreTargetsForSnapshot";
    }

    public MongoOpsManagerRestoreTargetsForSnapshot Set(
        System.String? SourceId = null,
        System.String? SourceName = null
    ) 
    {
        if ( SourceId != null ) {
            this.SourceId = SourceId;
        }
        if ( SourceName != null ) {
            this.SourceName = SourceName;
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
        //      C# -> System.String? SourceId
        // GraphQL -> sourceId: String! (scalar)
        if (this.SourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceId\n" ;
            } else {
                s += ind + "sourceId\n" ;
            }
        }
        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String! (scalar)
        if (this.SourceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceName\n" ;
            } else {
                s += ind + "sourceName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? SourceId
        // GraphQL -> sourceId: String! (scalar)
        if (ec.Includes("sourceId",true))
        {
            if(this.SourceId == null) {

                this.SourceId = "FETCH";

            } else {


            }
        }
        else if (this.SourceId != null && ec.Excludes("sourceId",true))
        {
            this.SourceId = null;
        }
        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String! (scalar)
        if (ec.Includes("sourceName",true))
        {
            if(this.SourceName == null) {

                this.SourceName = "FETCH";

            } else {


            }
        }
        else if (this.SourceName != null && ec.Excludes("sourceName",true))
        {
            this.SourceName = null;
        }
    }


    #endregion

    } // class MongoOpsManagerRestoreTargetsForSnapshot
    
    #endregion

    public static class ListMongoOpsManagerRestoreTargetsForSnapshotExtensions
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
            this List<MongoOpsManagerRestoreTargetsForSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MongoOpsManagerRestoreTargetsForSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MongoOpsManagerRestoreTargetsForSnapshot> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoOpsManagerRestoreTargetsForSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MongoOpsManagerRestoreTargetsForSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types