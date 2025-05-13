// ObjectPausedSourceDetails.cs
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
    #region ObjectPausedSourceDetails
    public class ObjectPausedSourceDetails: BaseType
    {
        #region members

        //      C# -> HierarchyObjectTypeEnum? PausedSourceType
        // GraphQL -> pausedSourceType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("pausedSourceType")]
        public HierarchyObjectTypeEnum? PausedSourceType { get; set; }

        //      C# -> System.String? PausedSourceId
        // GraphQL -> pausedSourceId: String! (scalar)
        [JsonProperty("pausedSourceId")]
        public System.String? PausedSourceId { get; set; }

        //      C# -> System.String? PausedSourceObjectName
        // GraphQL -> pausedSourceObjectName: String! (scalar)
        [JsonProperty("pausedSourceObjectName")]
        public System.String? PausedSourceObjectName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectPausedSourceDetails";
    }

    public ObjectPausedSourceDetails Set(
        HierarchyObjectTypeEnum? PausedSourceType = null,
        System.String? PausedSourceId = null,
        System.String? PausedSourceObjectName = null
    ) 
    {
        if ( PausedSourceType != null ) {
            this.PausedSourceType = PausedSourceType;
        }
        if ( PausedSourceId != null ) {
            this.PausedSourceId = PausedSourceId;
        }
        if ( PausedSourceObjectName != null ) {
            this.PausedSourceObjectName = PausedSourceObjectName;
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
        //      C# -> HierarchyObjectTypeEnum? PausedSourceType
        // GraphQL -> pausedSourceType: HierarchyObjectTypeEnum! (enum)
        if (this.PausedSourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pausedSourceType\n" ;
            } else {
                s += ind + "pausedSourceType\n" ;
            }
        }
        //      C# -> System.String? PausedSourceId
        // GraphQL -> pausedSourceId: String! (scalar)
        if (this.PausedSourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pausedSourceId\n" ;
            } else {
                s += ind + "pausedSourceId\n" ;
            }
        }
        //      C# -> System.String? PausedSourceObjectName
        // GraphQL -> pausedSourceObjectName: String! (scalar)
        if (this.PausedSourceObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pausedSourceObjectName\n" ;
            } else {
                s += ind + "pausedSourceObjectName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HierarchyObjectTypeEnum? PausedSourceType
        // GraphQL -> pausedSourceType: HierarchyObjectTypeEnum! (enum)
        if (ec.Includes("pausedSourceType",true))
        {
            if(this.PausedSourceType == null) {

                this.PausedSourceType = new HierarchyObjectTypeEnum();

            } else {


            }
        }
        else if (this.PausedSourceType != null && ec.Excludes("pausedSourceType",true))
        {
            this.PausedSourceType = null;
        }
        //      C# -> System.String? PausedSourceId
        // GraphQL -> pausedSourceId: String! (scalar)
        if (ec.Includes("pausedSourceId",true))
        {
            if(this.PausedSourceId == null) {

                this.PausedSourceId = "FETCH";

            } else {


            }
        }
        else if (this.PausedSourceId != null && ec.Excludes("pausedSourceId",true))
        {
            this.PausedSourceId = null;
        }
        //      C# -> System.String? PausedSourceObjectName
        // GraphQL -> pausedSourceObjectName: String! (scalar)
        if (ec.Includes("pausedSourceObjectName",true))
        {
            if(this.PausedSourceObjectName == null) {

                this.PausedSourceObjectName = "FETCH";

            } else {


            }
        }
        else if (this.PausedSourceObjectName != null && ec.Excludes("pausedSourceObjectName",true))
        {
            this.PausedSourceObjectName = null;
        }
    }


    #endregion

    } // class ObjectPausedSourceDetails
    
    #endregion

    public static class ListObjectPausedSourceDetailsExtensions
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
            this List<ObjectPausedSourceDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectPausedSourceDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectPausedSourceDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectPausedSourceDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectPausedSourceDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types