// RemoveNodeDetailsReply.cs
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
    #region RemoveNodeDetailsReply
    public class RemoveNodeDetailsReply: BaseType
    {
        #region members

        //      C# -> List<RemovedNodeDetail>? RemoveNodeDetails
        // GraphQL -> removeNodeDetails: [RemovedNodeDetail!]! (type)
        [JsonProperty("removeNodeDetails")]
        public List<RemovedNodeDetail>? RemoveNodeDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RemoveNodeDetailsReply";
    }

    public RemoveNodeDetailsReply Set(
        List<RemovedNodeDetail>? RemoveNodeDetails = null
    ) 
    {
        if ( RemoveNodeDetails != null ) {
            this.RemoveNodeDetails = RemoveNodeDetails;
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
        //      C# -> List<RemovedNodeDetail>? RemoveNodeDetails
        // GraphQL -> removeNodeDetails: [RemovedNodeDetail!]! (type)
        if (this.RemoveNodeDetails != null) {
            var fspec = this.RemoveNodeDetails.AsFieldSpec(conf.Child("removeNodeDetails"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "removeNodeDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RemovedNodeDetail>? RemoveNodeDetails
        // GraphQL -> removeNodeDetails: [RemovedNodeDetail!]! (type)
        if (ec.Includes("removeNodeDetails",false))
        {
            if(this.RemoveNodeDetails == null) {

                this.RemoveNodeDetails = new List<RemovedNodeDetail>();
                this.RemoveNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("removeNodeDetails"));

            } else {

                this.RemoveNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("removeNodeDetails"));

            }
        }
        else if (this.RemoveNodeDetails != null && ec.Excludes("removeNodeDetails",false))
        {
            this.RemoveNodeDetails = null;
        }
    }


    #endregion

    } // class RemoveNodeDetailsReply
    
    #endregion

    public static class ListRemoveNodeDetailsReplyExtensions
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
            this List<RemoveNodeDetailsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RemoveNodeDetailsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RemoveNodeDetailsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RemoveNodeDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RemoveNodeDetailsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types