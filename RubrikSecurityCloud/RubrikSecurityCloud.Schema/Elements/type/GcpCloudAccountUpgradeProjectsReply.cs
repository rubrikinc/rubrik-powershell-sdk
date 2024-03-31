// GcpCloudAccountUpgradeProjectsReply.cs
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
    #region GcpCloudAccountUpgradeProjectsReply
    public class GcpCloudAccountUpgradeProjectsReply: BaseType
    {
        #region members

        //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
        // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
        [JsonProperty("gcpProjectUpgradeStatuses")]
        public List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountUpgradeProjectsReply";
    }

    public GcpCloudAccountUpgradeProjectsReply Set(
        List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses = null
    ) 
    {
        if ( GcpProjectUpgradeStatuses != null ) {
            this.GcpProjectUpgradeStatuses = GcpProjectUpgradeStatuses;
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
        //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
        // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
        if (this.GcpProjectUpgradeStatuses != null) {
            var fspec = this.GcpProjectUpgradeStatuses.AsFieldSpec(conf.Child("gcpProjectUpgradeStatuses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "gcpProjectUpgradeStatuses {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<GcpCloudAccountProjectUpgradeStatus>? GcpProjectUpgradeStatuses
        // GraphQL -> gcpProjectUpgradeStatuses: [GcpCloudAccountProjectUpgradeStatus!]! (type)
        if (ec.Includes("gcpProjectUpgradeStatuses",false))
        {
            if(this.GcpProjectUpgradeStatuses == null) {

                this.GcpProjectUpgradeStatuses = new List<GcpCloudAccountProjectUpgradeStatus>();
                this.GcpProjectUpgradeStatuses.ApplyExploratoryFieldSpec(ec.NewChild("gcpProjectUpgradeStatuses"));

            } else {

                this.GcpProjectUpgradeStatuses.ApplyExploratoryFieldSpec(ec.NewChild("gcpProjectUpgradeStatuses"));

            }
        }
        else if (this.GcpProjectUpgradeStatuses != null && ec.Excludes("gcpProjectUpgradeStatuses",false))
        {
            this.GcpProjectUpgradeStatuses = null;
        }
    }


    #endregion

    } // class GcpCloudAccountUpgradeProjectsReply
    
    #endregion

    public static class ListGcpCloudAccountUpgradeProjectsReplyExtensions
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
            this List<GcpCloudAccountUpgradeProjectsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountUpgradeProjectsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountUpgradeProjectsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountUpgradeProjectsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountUpgradeProjectsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types