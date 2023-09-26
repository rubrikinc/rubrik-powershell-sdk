// GcpCloudAccountDeleteProjectsReply.cs
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
    #region GcpCloudAccountDeleteProjectsReply
    public class GcpCloudAccountDeleteProjectsReply: BaseType
    {
        #region members

        //      C# -> List<GcpCloudAccountProjectDeleteStatus>? GcpProjectDeleteStatuses
        // GraphQL -> gcpProjectDeleteStatuses: [GcpCloudAccountProjectDeleteStatus!]! (type)
        [JsonProperty("gcpProjectDeleteStatuses")]
        public List<GcpCloudAccountProjectDeleteStatus>? GcpProjectDeleteStatuses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountDeleteProjectsReply";
    }

    public GcpCloudAccountDeleteProjectsReply Set(
        List<GcpCloudAccountProjectDeleteStatus>? GcpProjectDeleteStatuses = null
    ) 
    {
        if ( GcpProjectDeleteStatuses != null ) {
            this.GcpProjectDeleteStatuses = GcpProjectDeleteStatuses;
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
        //      C# -> List<GcpCloudAccountProjectDeleteStatus>? GcpProjectDeleteStatuses
        // GraphQL -> gcpProjectDeleteStatuses: [GcpCloudAccountProjectDeleteStatus!]! (type)
        if (this.GcpProjectDeleteStatuses != null) {
            var fspec = this.GcpProjectDeleteStatuses.AsFieldSpec(conf.Child("gcpProjectDeleteStatuses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "gcpProjectDeleteStatuses {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<GcpCloudAccountProjectDeleteStatus>? GcpProjectDeleteStatuses
        // GraphQL -> gcpProjectDeleteStatuses: [GcpCloudAccountProjectDeleteStatus!]! (type)
        if (ec.Includes("gcpProjectDeleteStatuses",false))
        {
            if(this.GcpProjectDeleteStatuses == null) {

                this.GcpProjectDeleteStatuses = new List<GcpCloudAccountProjectDeleteStatus>();
                this.GcpProjectDeleteStatuses.ApplyExploratoryFieldSpec(ec.NewChild("gcpProjectDeleteStatuses"));

            } else {

                this.GcpProjectDeleteStatuses.ApplyExploratoryFieldSpec(ec.NewChild("gcpProjectDeleteStatuses"));

            }
        }
        else if (this.GcpProjectDeleteStatuses != null && ec.Excludes("gcpProjectDeleteStatuses",false))
        {
            this.GcpProjectDeleteStatuses = null;
        }
    }


    #endregion

    } // class GcpCloudAccountDeleteProjectsReply
    
    #endregion

    public static class ListGcpCloudAccountDeleteProjectsReplyExtensions
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
            this List<GcpCloudAccountDeleteProjectsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountDeleteProjectsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountDeleteProjectsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountDeleteProjectsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types