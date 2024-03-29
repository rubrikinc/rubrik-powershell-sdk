// GetWhitelistReply.cs
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
    #region GetWhitelistReply
    public class GetWhitelistReply: BaseType
    {
        #region members

        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        [JsonProperty("mode")]
        public WhitelistModeEnum? Mode { get; set; }

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> List<System.String>? IpCidrs
        // GraphQL -> ipCidrs: [String!]! (scalar)
        [JsonProperty("ipCidrs")]
        public List<System.String>? IpCidrs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetWhitelistReply";
    }

    public GetWhitelistReply Set(
        WhitelistModeEnum? Mode = null,
        System.Boolean? Enabled = null,
        List<System.String>? IpCidrs = null
    ) 
    {
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( IpCidrs != null ) {
            this.IpCidrs = IpCidrs;
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
        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        if (this.Mode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mode\n" ;
            } else {
                s += ind + "mode\n" ;
            }
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabled\n" ;
            } else {
                s += ind + "enabled\n" ;
            }
        }
        //      C# -> List<System.String>? IpCidrs
        // GraphQL -> ipCidrs: [String!]! (scalar)
        if (this.IpCidrs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipCidrs\n" ;
            } else {
                s += ind + "ipCidrs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        if (ec.Includes("mode",true))
        {
            if(this.Mode == null) {

                this.Mode = new WhitelistModeEnum();

            } else {


            }
        }
        else if (this.Mode != null && ec.Excludes("mode",true))
        {
            this.Mode = null;
        }
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (ec.Includes("enabled",true))
        {
            if(this.Enabled == null) {

                this.Enabled = true;

            } else {


            }
        }
        else if (this.Enabled != null && ec.Excludes("enabled",true))
        {
            this.Enabled = null;
        }
        //      C# -> List<System.String>? IpCidrs
        // GraphQL -> ipCidrs: [String!]! (scalar)
        if (ec.Includes("ipCidrs",true))
        {
            if(this.IpCidrs == null) {

                this.IpCidrs = new List<System.String>();

            } else {


            }
        }
        else if (this.IpCidrs != null && ec.Excludes("ipCidrs",true))
        {
            this.IpCidrs = null;
        }
    }


    #endregion

    } // class GetWhitelistReply
    
    #endregion

    public static class ListGetWhitelistReplyExtensions
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
            this List<GetWhitelistReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GetWhitelistReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetWhitelistReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetWhitelistReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetWhitelistReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types