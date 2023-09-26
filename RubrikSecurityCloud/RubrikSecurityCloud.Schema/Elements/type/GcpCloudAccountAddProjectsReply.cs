// GcpCloudAccountAddProjectsReply.cs
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
    #region GcpCloudAccountAddProjectsReply
    public class GcpCloudAccountAddProjectsReply: BaseType
    {
        #region members

        //      C# -> List<GcpCloudAccountAddProjectDetail>? Details
        // GraphQL -> details: [GcpCloudAccountAddProjectDetail!]! (type)
        [JsonProperty("details")]
        public List<GcpCloudAccountAddProjectDetail>? Details { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountAddProjectsReply";
    }

    public GcpCloudAccountAddProjectsReply Set(
        List<GcpCloudAccountAddProjectDetail>? Details = null
    ) 
    {
        if ( Details != null ) {
            this.Details = Details;
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
        //      C# -> List<GcpCloudAccountAddProjectDetail>? Details
        // GraphQL -> details: [GcpCloudAccountAddProjectDetail!]! (type)
        if (this.Details != null) {
            var fspec = this.Details.AsFieldSpec(conf.Child("details"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "details {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<GcpCloudAccountAddProjectDetail>? Details
        // GraphQL -> details: [GcpCloudAccountAddProjectDetail!]! (type)
        if (ec.Includes("details",false))
        {
            if(this.Details == null) {

                this.Details = new List<GcpCloudAccountAddProjectDetail>();
                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            } else {

                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            }
        }
        else if (this.Details != null && ec.Excludes("details",false))
        {
            this.Details = null;
        }
    }


    #endregion

    } // class GcpCloudAccountAddProjectsReply
    
    #endregion

    public static class ListGcpCloudAccountAddProjectsReplyExtensions
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
            this List<GcpCloudAccountAddProjectsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountAddProjectsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountAddProjectsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountAddProjectsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types