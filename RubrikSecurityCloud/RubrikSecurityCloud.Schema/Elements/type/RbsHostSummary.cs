// RbsHostSummary.cs
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
    #region RbsHostSummary
    public class RbsHostSummary: BaseType
    {
        #region members

        //      C# -> HostRbsStatus? Status
        // GraphQL -> status: HostRbsStatus! (enum)
        [JsonProperty("status")]
        public HostRbsStatus? Status { get; set; }

        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        [JsonProperty("agentId")]
        public System.String? AgentId { get; set; }

        //      C# -> System.String? AgentVersion
        // GraphQL -> agentVersion: String (scalar)
        [JsonProperty("agentVersion")]
        public System.String? AgentVersion { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OsInfo
        // GraphQL -> osInfo: String (scalar)
        [JsonProperty("osInfo")]
        public System.String? OsInfo { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RbsHostSummary";
    }

    public RbsHostSummary Set(
        HostRbsStatus? Status = null,
        System.String? AgentId = null,
        System.String? AgentVersion = null,
        System.String? Name = null,
        System.String? OsInfo = null,
        System.String? OsType = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( AgentId != null ) {
            this.AgentId = AgentId;
        }
        if ( AgentVersion != null ) {
            this.AgentVersion = AgentVersion;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OsInfo != null ) {
            this.OsInfo = OsInfo;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
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
        //      C# -> HostRbsStatus? Status
        // GraphQL -> status: HostRbsStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (this.AgentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "agentId\n" ;
            } else {
                s += ind + "agentId\n" ;
            }
        }
        //      C# -> System.String? AgentVersion
        // GraphQL -> agentVersion: String (scalar)
        if (this.AgentVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "agentVersion\n" ;
            } else {
                s += ind + "agentVersion\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? OsInfo
        // GraphQL -> osInfo: String (scalar)
        if (this.OsInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osInfo\n" ;
            } else {
                s += ind + "osInfo\n" ;
            }
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String (scalar)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HostRbsStatus? Status
        // GraphQL -> status: HostRbsStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new HostRbsStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (ec.Includes("agentId",true))
        {
            if(this.AgentId == null) {

                this.AgentId = "FETCH";

            } else {


            }
        }
        else if (this.AgentId != null && ec.Excludes("agentId",true))
        {
            this.AgentId = null;
        }
        //      C# -> System.String? AgentVersion
        // GraphQL -> agentVersion: String (scalar)
        if (ec.Includes("agentVersion",true))
        {
            if(this.AgentVersion == null) {

                this.AgentVersion = "FETCH";

            } else {


            }
        }
        else if (this.AgentVersion != null && ec.Excludes("agentVersion",true))
        {
            this.AgentVersion = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? OsInfo
        // GraphQL -> osInfo: String (scalar)
        if (ec.Includes("osInfo",true))
        {
            if(this.OsInfo == null) {

                this.OsInfo = "FETCH";

            } else {


            }
        }
        else if (this.OsInfo != null && ec.Excludes("osInfo",true))
        {
            this.OsInfo = null;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String (scalar)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = "FETCH";

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
        }
    }


    #endregion

    } // class RbsHostSummary
    
    #endregion

    public static class ListRbsHostSummaryExtensions
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
            this List<RbsHostSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RbsHostSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RbsHostSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RbsHostSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RbsHostSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types