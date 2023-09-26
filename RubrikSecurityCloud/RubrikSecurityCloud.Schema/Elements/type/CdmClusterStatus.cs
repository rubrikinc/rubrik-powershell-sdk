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
                    s += ind + "statusInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
            this List<CdmClusterStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmClusterStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmClusterStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmClusterStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types