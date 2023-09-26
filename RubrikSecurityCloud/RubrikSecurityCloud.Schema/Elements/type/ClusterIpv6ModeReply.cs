// ClusterIpv6ModeReply.cs
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
    #region ClusterIpv6ModeReply
    public class ClusterIpv6ModeReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsIpv6Mode
        // GraphQL -> isIpv6Mode: Boolean! (scalar)
        [JsonProperty("isIpv6Mode")]
        public System.Boolean? IsIpv6Mode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterIpv6ModeReply";
    }

    public ClusterIpv6ModeReply Set(
        System.Boolean? IsIpv6Mode = null
    ) 
    {
        if ( IsIpv6Mode != null ) {
            this.IsIpv6Mode = IsIpv6Mode;
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
        //      C# -> System.Boolean? IsIpv6Mode
        // GraphQL -> isIpv6Mode: Boolean! (scalar)
        if (this.IsIpv6Mode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isIpv6Mode\n" ;
            } else {
                s += ind + "isIpv6Mode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsIpv6Mode
        // GraphQL -> isIpv6Mode: Boolean! (scalar)
        if (ec.Includes("isIpv6Mode",true))
        {
            if(this.IsIpv6Mode == null) {

                this.IsIpv6Mode = true;

            } else {


            }
        }
        else if (this.IsIpv6Mode != null && ec.Excludes("isIpv6Mode",true))
        {
            this.IsIpv6Mode = null;
        }
    }


    #endregion

    } // class ClusterIpv6ModeReply
    
    #endregion

    public static class ListClusterIpv6ModeReplyExtensions
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
            this List<ClusterIpv6ModeReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterIpv6ModeReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterIpv6ModeReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterIpv6ModeReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types