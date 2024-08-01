// UpdateCyberEventLockdownResponse.cs
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
    #region UpdateCyberEventLockdownResponse
    public class UpdateCyberEventLockdownResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsCyberEventLockdownEnabled
        // GraphQL -> isCyberEventLockdownEnabled: Boolean! (scalar)
        [JsonProperty("isCyberEventLockdownEnabled")]
        public System.Boolean? IsCyberEventLockdownEnabled { get; set; }

        //      C# -> CyberEventLockdownSupportCaseDetails? SupportCaseDetails
        // GraphQL -> supportCaseDetails: CyberEventLockdownSupportCaseDetails (type)
        [JsonProperty("supportCaseDetails")]
        public CyberEventLockdownSupportCaseDetails? SupportCaseDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateCyberEventLockdownResponse";
    }

    public UpdateCyberEventLockdownResponse Set(
        System.Boolean? IsCyberEventLockdownEnabled = null,
        CyberEventLockdownSupportCaseDetails? SupportCaseDetails = null
    ) 
    {
        if ( IsCyberEventLockdownEnabled != null ) {
            this.IsCyberEventLockdownEnabled = IsCyberEventLockdownEnabled;
        }
        if ( SupportCaseDetails != null ) {
            this.SupportCaseDetails = SupportCaseDetails;
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
        //      C# -> System.Boolean? IsCyberEventLockdownEnabled
        // GraphQL -> isCyberEventLockdownEnabled: Boolean! (scalar)
        if (this.IsCyberEventLockdownEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCyberEventLockdownEnabled\n" ;
            } else {
                s += ind + "isCyberEventLockdownEnabled\n" ;
            }
        }
        //      C# -> CyberEventLockdownSupportCaseDetails? SupportCaseDetails
        // GraphQL -> supportCaseDetails: CyberEventLockdownSupportCaseDetails (type)
        if (this.SupportCaseDetails != null) {
            var fspec = this.SupportCaseDetails.AsFieldSpec(conf.Child("supportCaseDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "supportCaseDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsCyberEventLockdownEnabled
        // GraphQL -> isCyberEventLockdownEnabled: Boolean! (scalar)
        if (ec.Includes("isCyberEventLockdownEnabled",true))
        {
            if(this.IsCyberEventLockdownEnabled == null) {

                this.IsCyberEventLockdownEnabled = true;

            } else {


            }
        }
        else if (this.IsCyberEventLockdownEnabled != null && ec.Excludes("isCyberEventLockdownEnabled",true))
        {
            this.IsCyberEventLockdownEnabled = null;
        }
        //      C# -> CyberEventLockdownSupportCaseDetails? SupportCaseDetails
        // GraphQL -> supportCaseDetails: CyberEventLockdownSupportCaseDetails (type)
        if (ec.Includes("supportCaseDetails",false))
        {
            if(this.SupportCaseDetails == null) {

                this.SupportCaseDetails = new CyberEventLockdownSupportCaseDetails();
                this.SupportCaseDetails.ApplyExploratoryFieldSpec(ec.NewChild("supportCaseDetails"));

            } else {

                this.SupportCaseDetails.ApplyExploratoryFieldSpec(ec.NewChild("supportCaseDetails"));

            }
        }
        else if (this.SupportCaseDetails != null && ec.Excludes("supportCaseDetails",false))
        {
            this.SupportCaseDetails = null;
        }
    }


    #endregion

    } // class UpdateCyberEventLockdownResponse
    
    #endregion

    public static class ListUpdateCyberEventLockdownResponseExtensions
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
            this List<UpdateCyberEventLockdownResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateCyberEventLockdownResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateCyberEventLockdownResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateCyberEventLockdownResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateCyberEventLockdownResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types