// RemovedNodeDetail.cs
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
    #region RemovedNodeDetail
    public class RemovedNodeDetail: BaseType
    {
        #region members

        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String! (scalar)
        [JsonProperty("chassisId")]
        public System.String? ChassisId { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> System.String? Position
        // GraphQL -> position: String! (scalar)
        [JsonProperty("position")]
        public System.String? Position { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RemovedNodeDetail";
    }

    public RemovedNodeDetail Set(
        System.String? ChassisId = null,
        System.String? IpAddress = null,
        System.String? NodeName = null,
        System.String? Position = null
    ) 
    {
        if ( ChassisId != null ) {
            this.ChassisId = ChassisId;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( Position != null ) {
            this.Position = Position;
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
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String! (scalar)
        if (this.ChassisId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chassisId\n" ;
            } else {
                s += ind + "chassisId\n" ;
            }
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
            }
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        //      C# -> System.String? Position
        // GraphQL -> position: String! (scalar)
        if (this.Position != null) {
            if (conf.Flat) {
                s += conf.Prefix + "position\n" ;
            } else {
                s += ind + "position\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String! (scalar)
        if (ec.Includes("chassisId",true))
        {
            if(this.ChassisId == null) {

                this.ChassisId = "FETCH";

            } else {


            }
        }
        else if (this.ChassisId != null && ec.Excludes("chassisId",true))
        {
            this.ChassisId = null;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (ec.Includes("nodeName",true))
        {
            if(this.NodeName == null) {

                this.NodeName = "FETCH";

            } else {


            }
        }
        else if (this.NodeName != null && ec.Excludes("nodeName",true))
        {
            this.NodeName = null;
        }
        //      C# -> System.String? Position
        // GraphQL -> position: String! (scalar)
        if (ec.Includes("position",true))
        {
            if(this.Position == null) {

                this.Position = "FETCH";

            } else {


            }
        }
        else if (this.Position != null && ec.Excludes("position",true))
        {
            this.Position = null;
        }
    }


    #endregion

    } // class RemovedNodeDetail
    
    #endregion

    public static class ListRemovedNodeDetailExtensions
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
            this List<RemovedNodeDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RemovedNodeDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RemovedNodeDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RemovedNodeDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RemovedNodeDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types