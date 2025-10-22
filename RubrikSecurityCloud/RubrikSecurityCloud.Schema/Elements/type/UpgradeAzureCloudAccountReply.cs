// UpgradeAzureCloudAccountReply.cs
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
    #region UpgradeAzureCloudAccountReply
    public class UpgradeAzureCloudAccountReply: BaseType
    {
        #region members

        //      C# -> AzureEntraIdGroupStatus? EntraIdGroupStatus
        // GraphQL -> entraIdGroupStatus: AzureEntraIdGroupStatus (type)
        [JsonProperty("entraIdGroupStatus")]
        public AzureEntraIdGroupStatus? EntraIdGroupStatus { get; set; }

        //      C# -> List<UpgradeAzureCloudAccountStatus>? Status
        // GraphQL -> status: [UpgradeAzureCloudAccountStatus!]! (type)
        [JsonProperty("status")]
        public List<UpgradeAzureCloudAccountStatus>? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeAzureCloudAccountReply";
    }

    public UpgradeAzureCloudAccountReply Set(
        AzureEntraIdGroupStatus? EntraIdGroupStatus = null,
        List<UpgradeAzureCloudAccountStatus>? Status = null
    ) 
    {
        if ( EntraIdGroupStatus != null ) {
            this.EntraIdGroupStatus = EntraIdGroupStatus;
        }
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
        //      C# -> AzureEntraIdGroupStatus? EntraIdGroupStatus
        // GraphQL -> entraIdGroupStatus: AzureEntraIdGroupStatus (type)
        if (this.EntraIdGroupStatus != null) {
            var fspec = this.EntraIdGroupStatus.AsFieldSpec(conf.Child("entraIdGroupStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entraIdGroupStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<UpgradeAzureCloudAccountStatus>? Status
        // GraphQL -> status: [UpgradeAzureCloudAccountStatus!]! (type)
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
        //      C# -> AzureEntraIdGroupStatus? EntraIdGroupStatus
        // GraphQL -> entraIdGroupStatus: AzureEntraIdGroupStatus (type)
        if (ec.Includes("entraIdGroupStatus",false))
        {
            if(this.EntraIdGroupStatus == null) {

                this.EntraIdGroupStatus = new AzureEntraIdGroupStatus();
                this.EntraIdGroupStatus.ApplyExploratoryFieldSpec(ec.NewChild("entraIdGroupStatus"));

            } else {

                this.EntraIdGroupStatus.ApplyExploratoryFieldSpec(ec.NewChild("entraIdGroupStatus"));

            }
        }
        else if (this.EntraIdGroupStatus != null && ec.Excludes("entraIdGroupStatus",false))
        {
            this.EntraIdGroupStatus = null;
        }
        //      C# -> List<UpgradeAzureCloudAccountStatus>? Status
        // GraphQL -> status: [UpgradeAzureCloudAccountStatus!]! (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new List<UpgradeAzureCloudAccountStatus>();
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

    } // class UpgradeAzureCloudAccountReply
    
    #endregion

    public static class ListUpgradeAzureCloudAccountReplyExtensions
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
            this List<UpgradeAzureCloudAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpgradeAzureCloudAccountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeAzureCloudAccountReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeAzureCloudAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeAzureCloudAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types