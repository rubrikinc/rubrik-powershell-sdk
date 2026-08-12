// AirMcpGatewayConnectionData.cs
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
    #region AirMcpGatewayConnectionData
    public class AirMcpGatewayConnectionData: BaseType
    {
        #region members

        //      C# -> AirGatewayProvisioningState? Status
        // GraphQL -> status: AirGatewayProvisioningState! (enum)
        [JsonProperty("status")]
        public AirGatewayProvisioningState? Status { get; set; }

        //      C# -> System.String? EndpointUrl
        // GraphQL -> endpointUrl: String! (scalar)
        [JsonProperty("endpointUrl")]
        public System.String? EndpointUrl { get; set; }

        //      C# -> System.String? IdpName
        // GraphQL -> idpName: String! (scalar)
        [JsonProperty("idpName")]
        public System.String? IdpName { get; set; }

        //      C# -> System.String? IdpTenantId
        // GraphQL -> idpTenantId: UUID! (scalar)
        [JsonProperty("idpTenantId")]
        public System.String? IdpTenantId { get; set; }

        //      C# -> List<System.String>? McpServerIds
        // GraphQL -> mcpServerIds: [UUID!]! (scalar)
        [JsonProperty("mcpServerIds")]
        public List<System.String>? McpServerIds { get; set; }

        //      C# -> System.String? StatusError
        // GraphQL -> statusError: String! (scalar)
        [JsonProperty("statusError")]
        public System.String? StatusError { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AirMcpGatewayConnectionData";
    }

    public AirMcpGatewayConnectionData Set(
        AirGatewayProvisioningState? Status = null,
        System.String? EndpointUrl = null,
        System.String? IdpName = null,
        System.String? IdpTenantId = null,
        List<System.String>? McpServerIds = null,
        System.String? StatusError = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( EndpointUrl != null ) {
            this.EndpointUrl = EndpointUrl;
        }
        if ( IdpName != null ) {
            this.IdpName = IdpName;
        }
        if ( IdpTenantId != null ) {
            this.IdpTenantId = IdpTenantId;
        }
        if ( McpServerIds != null ) {
            this.McpServerIds = McpServerIds;
        }
        if ( StatusError != null ) {
            this.StatusError = StatusError;
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
        //      C# -> AirGatewayProvisioningState? Status
        // GraphQL -> status: AirGatewayProvisioningState! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? EndpointUrl
        // GraphQL -> endpointUrl: String! (scalar)
        if (this.EndpointUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endpointUrl\n" ;
            } else {
                s += ind + "endpointUrl\n" ;
            }
        }
        //      C# -> System.String? IdpName
        // GraphQL -> idpName: String! (scalar)
        if (this.IdpName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpName\n" ;
            } else {
                s += ind + "idpName\n" ;
            }
        }
        //      C# -> System.String? IdpTenantId
        // GraphQL -> idpTenantId: UUID! (scalar)
        if (this.IdpTenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpTenantId\n" ;
            } else {
                s += ind + "idpTenantId\n" ;
            }
        }
        //      C# -> List<System.String>? McpServerIds
        // GraphQL -> mcpServerIds: [UUID!]! (scalar)
        if (this.McpServerIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mcpServerIds\n" ;
            } else {
                s += ind + "mcpServerIds\n" ;
            }
        }
        //      C# -> System.String? StatusError
        // GraphQL -> statusError: String! (scalar)
        if (this.StatusError != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusError\n" ;
            } else {
                s += ind + "statusError\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AirGatewayProvisioningState? Status
        // GraphQL -> status: AirGatewayProvisioningState! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AirGatewayProvisioningState();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? EndpointUrl
        // GraphQL -> endpointUrl: String! (scalar)
        if (ec.Includes("endpointUrl",true))
        {
            if(this.EndpointUrl == null) {

                this.EndpointUrl = "FETCH";

            } else {


            }
        }
        else if (this.EndpointUrl != null && ec.Excludes("endpointUrl",true))
        {
            this.EndpointUrl = null;
        }
        //      C# -> System.String? IdpName
        // GraphQL -> idpName: String! (scalar)
        if (ec.Includes("idpName",true))
        {
            if(this.IdpName == null) {

                this.IdpName = "FETCH";

            } else {


            }
        }
        else if (this.IdpName != null && ec.Excludes("idpName",true))
        {
            this.IdpName = null;
        }
        //      C# -> System.String? IdpTenantId
        // GraphQL -> idpTenantId: UUID! (scalar)
        if (ec.Includes("idpTenantId",true))
        {
            if(this.IdpTenantId == null) {

                this.IdpTenantId = "FETCH";

            } else {


            }
        }
        else if (this.IdpTenantId != null && ec.Excludes("idpTenantId",true))
        {
            this.IdpTenantId = null;
        }
        //      C# -> List<System.String>? McpServerIds
        // GraphQL -> mcpServerIds: [UUID!]! (scalar)
        if (ec.Includes("mcpServerIds",true))
        {
            if(this.McpServerIds == null) {

                this.McpServerIds = new List<System.String>();

            } else {


            }
        }
        else if (this.McpServerIds != null && ec.Excludes("mcpServerIds",true))
        {
            this.McpServerIds = null;
        }
        //      C# -> System.String? StatusError
        // GraphQL -> statusError: String! (scalar)
        if (ec.Includes("statusError",true))
        {
            if(this.StatusError == null) {

                this.StatusError = "FETCH";

            } else {


            }
        }
        else if (this.StatusError != null && ec.Excludes("statusError",true))
        {
            this.StatusError = null;
        }
    }


    #endregion

    } // class AirMcpGatewayConnectionData
    
    #endregion

    public static class ListAirMcpGatewayConnectionDataExtensions
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
            this List<AirMcpGatewayConnectionData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AirMcpGatewayConnectionData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AirMcpGatewayConnectionData> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AirMcpGatewayConnectionData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AirMcpGatewayConnectionData> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types