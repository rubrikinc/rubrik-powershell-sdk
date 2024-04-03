// UpdateDistributionListDigestReply.cs
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
    #region UpdateDistributionListDigestReply
    public class UpdateDistributionListDigestReply: BaseType
    {
        #region members

        //      C# -> List<EventDigest>? EventDigests
        // GraphQL -> eventDigests: [EventDigest!]! (type)
        [JsonProperty("eventDigests")]
        public List<EventDigest>? EventDigests { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateDistributionListDigestReply";
    }

    public UpdateDistributionListDigestReply Set(
        List<EventDigest>? EventDigests = null
    ) 
    {
        if ( EventDigests != null ) {
            this.EventDigests = EventDigests;
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
        //      C# -> List<EventDigest>? EventDigests
        // GraphQL -> eventDigests: [EventDigest!]! (type)
        if (this.EventDigests != null) {
            var fspec = this.EventDigests.AsFieldSpec(conf.Child("eventDigests"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "eventDigests" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<EventDigest>? EventDigests
        // GraphQL -> eventDigests: [EventDigest!]! (type)
        if (ec.Includes("eventDigests",false))
        {
            if(this.EventDigests == null) {

                this.EventDigests = new List<EventDigest>();
                this.EventDigests.ApplyExploratoryFieldSpec(ec.NewChild("eventDigests"));

            } else {

                this.EventDigests.ApplyExploratoryFieldSpec(ec.NewChild("eventDigests"));

            }
        }
        else if (this.EventDigests != null && ec.Excludes("eventDigests",false))
        {
            this.EventDigests = null;
        }
    }


    #endregion

    } // class UpdateDistributionListDigestReply
    
    #endregion

    public static class ListUpdateDistributionListDigestReplyExtensions
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
            this List<UpdateDistributionListDigestReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateDistributionListDigestReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateDistributionListDigestReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateDistributionListDigestReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateDistributionListDigestReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types