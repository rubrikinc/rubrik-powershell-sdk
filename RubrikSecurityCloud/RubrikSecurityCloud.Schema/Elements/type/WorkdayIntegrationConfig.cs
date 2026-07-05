// WorkdayIntegrationConfig.cs
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
    #region WorkdayIntegrationConfig
    public class WorkdayIntegrationConfig: BaseType
    {
        #region members

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? TokenEndpoint
        // GraphQL -> tokenEndpoint: String! (scalar)
        [JsonProperty("tokenEndpoint")]
        public System.String? TokenEndpoint { get; set; }

        //      C# -> WorkdayStatus? Status
        // GraphQL -> status: WorkdayStatus (type)
        [JsonProperty("status")]
        public WorkdayStatus? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkdayIntegrationConfig";
    }

    public WorkdayIntegrationConfig Set(
        System.String? ClientId = null,
        System.String? TokenEndpoint = null,
        WorkdayStatus? Status = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( TokenEndpoint != null ) {
            this.TokenEndpoint = TokenEndpoint;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? TokenEndpoint
        // GraphQL -> tokenEndpoint: String! (scalar)
        if (this.TokenEndpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tokenEndpoint\n" ;
            } else {
                s += ind + "tokenEndpoint\n" ;
            }
        }
        //      C# -> WorkdayStatus? Status
        // GraphQL -> status: WorkdayStatus (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (ec.Includes("clientId",true))
        {
            if(this.ClientId == null) {

                this.ClientId = "FETCH";

            } else {


            }
        }
        else if (this.ClientId != null && ec.Excludes("clientId",true))
        {
            this.ClientId = null;
        }
        //      C# -> System.String? TokenEndpoint
        // GraphQL -> tokenEndpoint: String! (scalar)
        if (ec.Includes("tokenEndpoint",true))
        {
            if(this.TokenEndpoint == null) {

                this.TokenEndpoint = "FETCH";

            } else {


            }
        }
        else if (this.TokenEndpoint != null && ec.Excludes("tokenEndpoint",true))
        {
            this.TokenEndpoint = null;
        }
        //      C# -> WorkdayStatus? Status
        // GraphQL -> status: WorkdayStatus (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new WorkdayStatus();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class WorkdayIntegrationConfig
    
    #endregion

    public static class ListWorkdayIntegrationConfigExtensions
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
            this List<WorkdayIntegrationConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkdayIntegrationConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkdayIntegrationConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkdayIntegrationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkdayIntegrationConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types