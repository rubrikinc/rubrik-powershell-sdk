// TriggerExocomputeHealthCheckReply.cs
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
    #region TriggerExocomputeHealthCheckReply
    public class TriggerExocomputeHealthCheckReply: BaseType
    {
        #region members

        //      C# -> System.String? HealthCheckJobId
        // GraphQL -> healthCheckJobId: String! (scalar)
        [JsonProperty("healthCheckJobId")]
        public System.String? HealthCheckJobId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TriggerExocomputeHealthCheckReply";
    }

    public TriggerExocomputeHealthCheckReply Set(
        System.String? HealthCheckJobId = null
    ) 
    {
        if ( HealthCheckJobId != null ) {
            this.HealthCheckJobId = HealthCheckJobId;
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
        //      C# -> System.String? HealthCheckJobId
        // GraphQL -> healthCheckJobId: String! (scalar)
        if (this.HealthCheckJobId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "healthCheckJobId\n" ;
            } else {
                s += ind + "healthCheckJobId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HealthCheckJobId
        // GraphQL -> healthCheckJobId: String! (scalar)
        if (ec.Includes("healthCheckJobId",true))
        {
            if(this.HealthCheckJobId == null) {

                this.HealthCheckJobId = "FETCH";

            } else {


            }
        }
        else if (this.HealthCheckJobId != null && ec.Excludes("healthCheckJobId",true))
        {
            this.HealthCheckJobId = null;
        }
    }


    #endregion

    } // class TriggerExocomputeHealthCheckReply
    
    #endregion

    public static class ListTriggerExocomputeHealthCheckReplyExtensions
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
            this List<TriggerExocomputeHealthCheckReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<TriggerExocomputeHealthCheckReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TriggerExocomputeHealthCheckReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TriggerExocomputeHealthCheckReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TriggerExocomputeHealthCheckReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types