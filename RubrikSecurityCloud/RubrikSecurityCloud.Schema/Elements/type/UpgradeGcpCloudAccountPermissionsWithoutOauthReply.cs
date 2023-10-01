// UpgradeGcpCloudAccountPermissionsWithoutOauthReply.cs
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
    #region UpgradeGcpCloudAccountPermissionsWithoutOauthReply
    public class UpgradeGcpCloudAccountPermissionsWithoutOauthReply: BaseType
    {
        #region members

        //      C# -> GcpCloudAccountProjectUpgradeStatus? Status
        // GraphQL -> status: GcpCloudAccountProjectUpgradeStatus (type)
        [JsonProperty("status")]
        public GcpCloudAccountProjectUpgradeStatus? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeGcpCloudAccountPermissionsWithoutOauthReply";
    }

    public UpgradeGcpCloudAccountPermissionsWithoutOauthReply Set(
        GcpCloudAccountProjectUpgradeStatus? Status = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> GcpCloudAccountProjectUpgradeStatus? Status
        // GraphQL -> status: GcpCloudAccountProjectUpgradeStatus (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> GcpCloudAccountProjectUpgradeStatus? Status
        // GraphQL -> status: GcpCloudAccountProjectUpgradeStatus (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new GcpCloudAccountProjectUpgradeStatus();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class UpgradeGcpCloudAccountPermissionsWithoutOauthReply
    
    #endregion

    public static class ListUpgradeGcpCloudAccountPermissionsWithoutOauthReplyExtensions
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
            this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeGcpCloudAccountPermissionsWithoutOauthReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types