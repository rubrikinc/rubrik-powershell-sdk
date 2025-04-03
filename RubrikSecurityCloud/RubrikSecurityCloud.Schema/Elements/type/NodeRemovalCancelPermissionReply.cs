// NodeRemovalCancelPermissionReply.cs
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
    #region NodeRemovalCancelPermissionReply
    public class NodeRemovalCancelPermissionReply: BaseType
    {
        #region members

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean! (scalar)
        [JsonProperty("isCancelable")]
        public System.Boolean? IsCancelable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeRemovalCancelPermissionReply";
    }

    public NodeRemovalCancelPermissionReply Set(
        System.String? EventSeriesId = null,
        System.Boolean? IsCancelable = null
    ) 
    {
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
        }
        if ( IsCancelable != null ) {
            this.IsCancelable = IsCancelable;
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
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (this.EventSeriesId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventSeriesId\n" ;
            } else {
                s += ind + "eventSeriesId\n" ;
            }
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean! (scalar)
        if (this.IsCancelable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCancelable\n" ;
            } else {
                s += ind + "isCancelable\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (ec.Includes("eventSeriesId",true))
        {
            if(this.EventSeriesId == null) {

                this.EventSeriesId = "FETCH";

            } else {


            }
        }
        else if (this.EventSeriesId != null && ec.Excludes("eventSeriesId",true))
        {
            this.EventSeriesId = null;
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean! (scalar)
        if (ec.Includes("isCancelable",true))
        {
            if(this.IsCancelable == null) {

                this.IsCancelable = true;

            } else {


            }
        }
        else if (this.IsCancelable != null && ec.Excludes("isCancelable",true))
        {
            this.IsCancelable = null;
        }
    }


    #endregion

    } // class NodeRemovalCancelPermissionReply
    
    #endregion

    public static class ListNodeRemovalCancelPermissionReplyExtensions
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
            this List<NodeRemovalCancelPermissionReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NodeRemovalCancelPermissionReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NodeRemovalCancelPermissionReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeRemovalCancelPermissionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NodeRemovalCancelPermissionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types