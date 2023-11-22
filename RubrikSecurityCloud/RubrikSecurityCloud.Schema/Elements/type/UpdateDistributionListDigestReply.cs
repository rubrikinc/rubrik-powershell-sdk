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
                    s += ind + "eventDigests {\n" + fspec + ind + "}\n" ;
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
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<UpdateDistributionListDigestReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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