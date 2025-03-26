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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "status" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeGcpCloudAccountPermissionsWithoutOauthReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeGcpCloudAccountPermissionsWithoutOauthReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types