// CdmClusterStatus.cs
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
    #region CdmClusterStatus
    public class CdmClusterStatus: BaseType
    {
        #region members

        //      C# -> CdmClusterStatusTypeEnum? Status
        // GraphQL -> status: CdmClusterStatusTypeEnum! (enum)
        [JsonProperty("status")]
        public CdmClusterStatusTypeEnum? Status { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> CdmClusterStatusInfo? StatusInfo
        // GraphQL -> statusInfo: CdmClusterStatusInfo (type)
        [JsonProperty("statusInfo")]
        public CdmClusterStatusInfo? StatusInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmClusterStatus";
    }

    public CdmClusterStatus Set(
        CdmClusterStatusTypeEnum? Status = null,
        System.String? Message = null,
        CdmClusterStatusInfo? StatusInfo = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( StatusInfo != null ) {
            this.StatusInfo = StatusInfo;
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
        //      C# -> CdmClusterStatusTypeEnum? Status
        // GraphQL -> status: CdmClusterStatusTypeEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> CdmClusterStatusInfo? StatusInfo
        // GraphQL -> statusInfo: CdmClusterStatusInfo (type)
        if (this.StatusInfo != null) {
            var fspec = this.StatusInfo.AsFieldSpec(conf.Child("statusInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "statusInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CdmClusterStatusTypeEnum? Status
        // GraphQL -> status: CdmClusterStatusTypeEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new CdmClusterStatusTypeEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> CdmClusterStatusInfo? StatusInfo
        // GraphQL -> statusInfo: CdmClusterStatusInfo (type)
        if (ec.Includes("statusInfo",false))
        {
            if(this.StatusInfo == null) {

                this.StatusInfo = new CdmClusterStatusInfo();
                this.StatusInfo.ApplyExploratoryFieldSpec(ec.NewChild("statusInfo"));

            } else {

                this.StatusInfo.ApplyExploratoryFieldSpec(ec.NewChild("statusInfo"));

            }
        }
        else if (this.StatusInfo != null && ec.Excludes("statusInfo",false))
        {
            this.StatusInfo = null;
        }
    }


    #endregion

    } // class CdmClusterStatus
    
    #endregion

    public static class ListCdmClusterStatusExtensions
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
            this List<CdmClusterStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmClusterStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmClusterStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmClusterStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmClusterStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types