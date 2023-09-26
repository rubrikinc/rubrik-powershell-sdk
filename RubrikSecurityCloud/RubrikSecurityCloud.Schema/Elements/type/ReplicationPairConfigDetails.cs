// ReplicationPairConfigDetails.cs
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
    #region ReplicationPairConfigDetails
    public class ReplicationPairConfigDetails: BaseType
    {
        #region members

        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        [JsonProperty("setupType")]
        public System.String? SetupType { get; set; }

        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        [JsonProperty("sourceGateway")]
        public GatewayInfo? SourceGateway { get; set; }

        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        [JsonProperty("targetGateway")]
        public GatewayInfo? TargetGateway { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationPairConfigDetails";
    }

    public ReplicationPairConfigDetails Set(
        System.String? SetupType = null,
        GatewayInfo? SourceGateway = null,
        GatewayInfo? TargetGateway = null
    ) 
    {
        if ( SetupType != null ) {
            this.SetupType = SetupType;
        }
        if ( SourceGateway != null ) {
            this.SourceGateway = SourceGateway;
        }
        if ( TargetGateway != null ) {
            this.TargetGateway = TargetGateway;
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
        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        if (this.SetupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "setupType\n" ;
            } else {
                s += ind + "setupType\n" ;
            }
        }
        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        if (this.SourceGateway != null) {
            var fspec = this.SourceGateway.AsFieldSpec(conf.Child("sourceGateway"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceGateway {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        if (this.TargetGateway != null) {
            var fspec = this.TargetGateway.AsFieldSpec(conf.Child("targetGateway"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetGateway {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SetupType
        // GraphQL -> setupType: String! (scalar)
        if (ec.Includes("setupType",true))
        {
            if(this.SetupType == null) {

                this.SetupType = "FETCH";

            } else {


            }
        }
        else if (this.SetupType != null && ec.Excludes("setupType",true))
        {
            this.SetupType = null;
        }
        //      C# -> GatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfo (type)
        if (ec.Includes("sourceGateway",false))
        {
            if(this.SourceGateway == null) {

                this.SourceGateway = new GatewayInfo();
                this.SourceGateway.ApplyExploratoryFieldSpec(ec.NewChild("sourceGateway"));

            } else {

                this.SourceGateway.ApplyExploratoryFieldSpec(ec.NewChild("sourceGateway"));

            }
        }
        else if (this.SourceGateway != null && ec.Excludes("sourceGateway",false))
        {
            this.SourceGateway = null;
        }
        //      C# -> GatewayInfo? TargetGateway
        // GraphQL -> targetGateway: GatewayInfo (type)
        if (ec.Includes("targetGateway",false))
        {
            if(this.TargetGateway == null) {

                this.TargetGateway = new GatewayInfo();
                this.TargetGateway.ApplyExploratoryFieldSpec(ec.NewChild("targetGateway"));

            } else {

                this.TargetGateway.ApplyExploratoryFieldSpec(ec.NewChild("targetGateway"));

            }
        }
        else if (this.TargetGateway != null && ec.Excludes("targetGateway",false))
        {
            this.TargetGateway = null;
        }
    }


    #endregion

    } // class ReplicationPairConfigDetails
    
    #endregion

    public static class ListReplicationPairConfigDetailsExtensions
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
            this List<ReplicationPairConfigDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationPairConfigDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationPairConfigDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationPairConfigDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types