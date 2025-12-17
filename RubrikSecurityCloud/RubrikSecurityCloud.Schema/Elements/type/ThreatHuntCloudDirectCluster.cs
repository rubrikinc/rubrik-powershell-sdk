// ThreatHuntCloudDirectCluster.cs
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
    #region ThreatHuntCloudDirectCluster
    public class ThreatHuntCloudDirectCluster: BaseType
    {
        #region members

        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum! (enum)
        [JsonProperty("productType")]
        public ClusterProductEnum? ProductType { get; set; }

        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        [JsonProperty("status")]
        public ClusterStatus? Status { get; set; }

        //      C# -> System.String? ConnectionStatus
        // GraphQL -> connectionStatus: String (scalar)
        [JsonProperty("connectionStatus")]
        public System.String? ConnectionStatus { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        [JsonProperty("lambdaConfig")]
        public GetLambdaConfigReply? LambdaConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntCloudDirectCluster";
    }

    public ThreatHuntCloudDirectCluster Set(
        ClusterProductEnum? ProductType = null,
        ClusterStatus? Status = null,
        System.String? ConnectionStatus = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? Version = null,
        GetLambdaConfigReply? LambdaConfig = null
    ) 
    {
        if ( ProductType != null ) {
            this.ProductType = ProductType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( LambdaConfig != null ) {
            this.LambdaConfig = LambdaConfig;
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
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum! (enum)
        if (this.ProductType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productType\n" ;
            } else {
                s += ind + "productType\n" ;
            }
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? ConnectionStatus
        // GraphQL -> connectionStatus: String (scalar)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (this.LambdaConfig != null) {
            var fspec = this.LambdaConfig.AsFieldSpec(conf.Child("lambdaConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lambdaConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum! (enum)
        if (ec.Includes("productType",true))
        {
            if(this.ProductType == null) {

                this.ProductType = new ClusterProductEnum();

            } else {


            }
        }
        else if (this.ProductType != null && ec.Excludes("productType",true))
        {
            this.ProductType = null;
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ClusterStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? ConnectionStatus
        // GraphQL -> connectionStatus: String (scalar)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = "FETCH";

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (ec.Includes("lambdaConfig",false))
        {
            if(this.LambdaConfig == null) {

                this.LambdaConfig = new GetLambdaConfigReply();
                this.LambdaConfig.ApplyExploratoryFieldSpec(ec.NewChild("lambdaConfig"));

            } else {

                this.LambdaConfig.ApplyExploratoryFieldSpec(ec.NewChild("lambdaConfig"));

            }
        }
        else if (this.LambdaConfig != null && ec.Excludes("lambdaConfig",false))
        {
            this.LambdaConfig = null;
        }
    }


    #endregion

    } // class ThreatHuntCloudDirectCluster
    
    #endregion

    public static class ListThreatHuntCloudDirectClusterExtensions
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
            this List<ThreatHuntCloudDirectCluster> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntCloudDirectCluster> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntCloudDirectCluster> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntCloudDirectCluster());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntCloudDirectCluster> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types