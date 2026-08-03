// AppAccessEdge.cs
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
    #region AppAccessEdge
    public class AppAccessEdge: BaseType
    {
        #region members

        //      C# -> AppAccessEdgeAnnotation? Annotation
        // GraphQL -> annotation: AppAccessEdgeAnnotation! (enum)
        [JsonProperty("annotation")]
        public AppAccessEdgeAnnotation? Annotation { get; set; }

        //      C# -> AppAccessNodeId? DestinationNodeId
        // GraphQL -> destinationNodeId: AppAccessNodeId! (enum)
        [JsonProperty("destinationNodeId")]
        public AppAccessNodeId? DestinationNodeId { get; set; }

        //      C# -> AccessPathType? PathType
        // GraphQL -> pathType: AccessPathType! (enum)
        [JsonProperty("pathType")]
        public AccessPathType? PathType { get; set; }

        //      C# -> AppAccessNodeId? SourceNodeId
        // GraphQL -> sourceNodeId: AppAccessNodeId! (enum)
        [JsonProperty("sourceNodeId")]
        public AppAccessNodeId? SourceNodeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppAccessEdge";
    }

    public AppAccessEdge Set(
        AppAccessEdgeAnnotation? Annotation = null,
        AppAccessNodeId? DestinationNodeId = null,
        AccessPathType? PathType = null,
        AppAccessNodeId? SourceNodeId = null
    ) 
    {
        if ( Annotation != null ) {
            this.Annotation = Annotation;
        }
        if ( DestinationNodeId != null ) {
            this.DestinationNodeId = DestinationNodeId;
        }
        if ( PathType != null ) {
            this.PathType = PathType;
        }
        if ( SourceNodeId != null ) {
            this.SourceNodeId = SourceNodeId;
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
        //      C# -> AppAccessEdgeAnnotation? Annotation
        // GraphQL -> annotation: AppAccessEdgeAnnotation! (enum)
        if (this.Annotation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "annotation\n" ;
            } else {
                s += ind + "annotation\n" ;
            }
        }
        //      C# -> AppAccessNodeId? DestinationNodeId
        // GraphQL -> destinationNodeId: AppAccessNodeId! (enum)
        if (this.DestinationNodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "destinationNodeId\n" ;
            } else {
                s += ind + "destinationNodeId\n" ;
            }
        }
        //      C# -> AccessPathType? PathType
        // GraphQL -> pathType: AccessPathType! (enum)
        if (this.PathType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pathType\n" ;
            } else {
                s += ind + "pathType\n" ;
            }
        }
        //      C# -> AppAccessNodeId? SourceNodeId
        // GraphQL -> sourceNodeId: AppAccessNodeId! (enum)
        if (this.SourceNodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceNodeId\n" ;
            } else {
                s += ind + "sourceNodeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AppAccessEdgeAnnotation? Annotation
        // GraphQL -> annotation: AppAccessEdgeAnnotation! (enum)
        if (ec.Includes("annotation",true))
        {
            if(this.Annotation == null) {

                this.Annotation = new AppAccessEdgeAnnotation();

            } else {


            }
        }
        else if (this.Annotation != null && ec.Excludes("annotation",true))
        {
            this.Annotation = null;
        }
        //      C# -> AppAccessNodeId? DestinationNodeId
        // GraphQL -> destinationNodeId: AppAccessNodeId! (enum)
        if (ec.Includes("destinationNodeId",true))
        {
            if(this.DestinationNodeId == null) {

                this.DestinationNodeId = new AppAccessNodeId();

            } else {


            }
        }
        else if (this.DestinationNodeId != null && ec.Excludes("destinationNodeId",true))
        {
            this.DestinationNodeId = null;
        }
        //      C# -> AccessPathType? PathType
        // GraphQL -> pathType: AccessPathType! (enum)
        if (ec.Includes("pathType",true))
        {
            if(this.PathType == null) {

                this.PathType = new AccessPathType();

            } else {


            }
        }
        else if (this.PathType != null && ec.Excludes("pathType",true))
        {
            this.PathType = null;
        }
        //      C# -> AppAccessNodeId? SourceNodeId
        // GraphQL -> sourceNodeId: AppAccessNodeId! (enum)
        if (ec.Includes("sourceNodeId",true))
        {
            if(this.SourceNodeId == null) {

                this.SourceNodeId = new AppAccessNodeId();

            } else {


            }
        }
        else if (this.SourceNodeId != null && ec.Excludes("sourceNodeId",true))
        {
            this.SourceNodeId = null;
        }
    }


    #endregion

    } // class AppAccessEdge
    
    #endregion

    public static class ListAppAccessEdgeExtensions
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
            this List<AppAccessEdge> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppAccessEdge> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppAccessEdge> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppAccessEdge());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppAccessEdge> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types