// SapHanaHost.cs
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
    #region SapHanaHost
    public class SapHanaHost: BaseType
    {
        #region members

        //      C# -> SapHanaHostHostType? HostType
        // GraphQL -> hostType: SapHanaHostHostType (enum)
        [JsonProperty("hostType")]
        public SapHanaHostHostType? HostType { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        [JsonProperty("hostUuid")]
        public System.String? HostUuid { get; set; }

        //      C# -> System.String? SapHanaHostName
        // GraphQL -> sapHanaHostName: String (scalar)
        [JsonProperty("sapHanaHostName")]
        public System.String? SapHanaHostName { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaHost";
    }

    public SapHanaHost Set(
        SapHanaHostHostType? HostType = null,
        System.String? HostName = null,
        System.String? HostUuid = null,
        System.String? SapHanaHostName = null,
        System.String? Status = null
    ) 
    {
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostUuid != null ) {
            this.HostUuid = HostUuid;
        }
        if ( SapHanaHostName != null ) {
            this.SapHanaHostName = SapHanaHostName;
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SapHanaHostHostType? HostType
        // GraphQL -> hostType: SapHanaHostHostType (enum)
        if (this.HostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostType\n" ;
            } else {
                s += ind + "hostType\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (this.HostUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostUuid\n" ;
            } else {
                s += ind + "hostUuid\n" ;
            }
        }
        //      C# -> System.String? SapHanaHostName
        // GraphQL -> sapHanaHostName: String (scalar)
        if (this.SapHanaHostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sapHanaHostName\n" ;
            } else {
                s += ind + "sapHanaHostName\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SapHanaHostHostType? HostType
        // GraphQL -> hostType: SapHanaHostHostType (enum)
        if (ec.Includes("hostType",true))
        {
            if(this.HostType == null) {

                this.HostType = new SapHanaHostHostType();

            } else {


            }
        }
        else if (this.HostType != null && ec.Excludes("hostType",true))
        {
            this.HostType = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        if (ec.Includes("hostUuid",true))
        {
            if(this.HostUuid == null) {

                this.HostUuid = "FETCH";

            } else {


            }
        }
        else if (this.HostUuid != null && ec.Excludes("hostUuid",true))
        {
            this.HostUuid = null;
        }
        //      C# -> System.String? SapHanaHostName
        // GraphQL -> sapHanaHostName: String (scalar)
        if (ec.Includes("sapHanaHostName",true))
        {
            if(this.SapHanaHostName == null) {

                this.SapHanaHostName = "FETCH";

            } else {


            }
        }
        else if (this.SapHanaHostName != null && ec.Excludes("sapHanaHostName",true))
        {
            this.SapHanaHostName = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class SapHanaHost
    
    #endregion

    public static class ListSapHanaHostExtensions
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
            this List<SapHanaHost> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SapHanaHost> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaHost> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaHost());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaHost> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types