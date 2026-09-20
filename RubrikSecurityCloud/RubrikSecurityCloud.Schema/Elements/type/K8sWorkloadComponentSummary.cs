// K8sWorkloadComponentSummary.cs
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
    #region K8sWorkloadComponentSummary
    public class K8sWorkloadComponentSummary: BaseType
    {
        #region members

        //      C# -> List<System.String>? ActiveNodes
        // GraphQL -> activeNodes: [String!]! (scalar)
        [JsonProperty("activeNodes")]
        public List<System.String>? ActiveNodes { get; set; }

        //      C# -> System.String? CpuLimit
        // GraphQL -> cpuLimit: String (scalar)
        [JsonProperty("cpuLimit")]
        public System.String? CpuLimit { get; set; }

        //      C# -> System.String? CpuRequest
        // GraphQL -> cpuRequest: String (scalar)
        [JsonProperty("cpuRequest")]
        public System.String? CpuRequest { get; set; }

        //      C# -> System.String? Image
        // GraphQL -> image: String (scalar)
        [JsonProperty("image")]
        public System.String? Image { get; set; }

        //      C# -> System.String? MemoryLimit
        // GraphQL -> memoryLimit: String (scalar)
        [JsonProperty("memoryLimit")]
        public System.String? MemoryLimit { get; set; }

        //      C# -> System.String? MemoryRequest
        // GraphQL -> memoryRequest: String (scalar)
        [JsonProperty("memoryRequest")]
        public System.String? MemoryRequest { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? Replicas
        // GraphQL -> replicas: Int! (scalar)
        [JsonProperty("replicas")]
        public System.Int32? Replicas { get; set; }

        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        [JsonProperty("scope")]
        public System.String? Scope { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sWorkloadComponentSummary";
    }

    public K8sWorkloadComponentSummary Set(
        List<System.String>? ActiveNodes = null,
        System.String? CpuLimit = null,
        System.String? CpuRequest = null,
        System.String? Image = null,
        System.String? MemoryLimit = null,
        System.String? MemoryRequest = null,
        System.String? Name = null,
        System.Int32? Replicas = null,
        System.String? Scope = null,
        System.String? Status = null,
        System.String? StatusMessage = null
    ) 
    {
        if ( ActiveNodes != null ) {
            this.ActiveNodes = ActiveNodes;
        }
        if ( CpuLimit != null ) {
            this.CpuLimit = CpuLimit;
        }
        if ( CpuRequest != null ) {
            this.CpuRequest = CpuRequest;
        }
        if ( Image != null ) {
            this.Image = Image;
        }
        if ( MemoryLimit != null ) {
            this.MemoryLimit = MemoryLimit;
        }
        if ( MemoryRequest != null ) {
            this.MemoryRequest = MemoryRequest;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Replicas != null ) {
            this.Replicas = Replicas;
        }
        if ( Scope != null ) {
            this.Scope = Scope;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
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
        //      C# -> List<System.String>? ActiveNodes
        // GraphQL -> activeNodes: [String!]! (scalar)
        if (this.ActiveNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeNodes\n" ;
            } else {
                s += ind + "activeNodes\n" ;
            }
        }
        //      C# -> System.String? CpuLimit
        // GraphQL -> cpuLimit: String (scalar)
        if (this.CpuLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cpuLimit\n" ;
            } else {
                s += ind + "cpuLimit\n" ;
            }
        }
        //      C# -> System.String? CpuRequest
        // GraphQL -> cpuRequest: String (scalar)
        if (this.CpuRequest != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cpuRequest\n" ;
            } else {
                s += ind + "cpuRequest\n" ;
            }
        }
        //      C# -> System.String? Image
        // GraphQL -> image: String (scalar)
        if (this.Image != null) {
            if (conf.Flat) {
                s += conf.Prefix + "image\n" ;
            } else {
                s += ind + "image\n" ;
            }
        }
        //      C# -> System.String? MemoryLimit
        // GraphQL -> memoryLimit: String (scalar)
        if (this.MemoryLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memoryLimit\n" ;
            } else {
                s += ind + "memoryLimit\n" ;
            }
        }
        //      C# -> System.String? MemoryRequest
        // GraphQL -> memoryRequest: String (scalar)
        if (this.MemoryRequest != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memoryRequest\n" ;
            } else {
                s += ind + "memoryRequest\n" ;
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
        //      C# -> System.Int32? Replicas
        // GraphQL -> replicas: Int! (scalar)
        if (this.Replicas != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicas\n" ;
            } else {
                s += ind + "replicas\n" ;
            }
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (this.Scope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scope\n" ;
            } else {
                s += ind + "scope\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (this.StatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessage\n" ;
            } else {
                s += ind + "statusMessage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? ActiveNodes
        // GraphQL -> activeNodes: [String!]! (scalar)
        if (ec.Includes("activeNodes",true))
        {
            if(this.ActiveNodes == null) {

                this.ActiveNodes = new List<System.String>();

            } else {


            }
        }
        else if (this.ActiveNodes != null && ec.Excludes("activeNodes",true))
        {
            this.ActiveNodes = null;
        }
        //      C# -> System.String? CpuLimit
        // GraphQL -> cpuLimit: String (scalar)
        if (ec.Includes("cpuLimit",true))
        {
            if(this.CpuLimit == null) {

                this.CpuLimit = "FETCH";

            } else {


            }
        }
        else if (this.CpuLimit != null && ec.Excludes("cpuLimit",true))
        {
            this.CpuLimit = null;
        }
        //      C# -> System.String? CpuRequest
        // GraphQL -> cpuRequest: String (scalar)
        if (ec.Includes("cpuRequest",true))
        {
            if(this.CpuRequest == null) {

                this.CpuRequest = "FETCH";

            } else {


            }
        }
        else if (this.CpuRequest != null && ec.Excludes("cpuRequest",true))
        {
            this.CpuRequest = null;
        }
        //      C# -> System.String? Image
        // GraphQL -> image: String (scalar)
        if (ec.Includes("image",true))
        {
            if(this.Image == null) {

                this.Image = "FETCH";

            } else {


            }
        }
        else if (this.Image != null && ec.Excludes("image",true))
        {
            this.Image = null;
        }
        //      C# -> System.String? MemoryLimit
        // GraphQL -> memoryLimit: String (scalar)
        if (ec.Includes("memoryLimit",true))
        {
            if(this.MemoryLimit == null) {

                this.MemoryLimit = "FETCH";

            } else {


            }
        }
        else if (this.MemoryLimit != null && ec.Excludes("memoryLimit",true))
        {
            this.MemoryLimit = null;
        }
        //      C# -> System.String? MemoryRequest
        // GraphQL -> memoryRequest: String (scalar)
        if (ec.Includes("memoryRequest",true))
        {
            if(this.MemoryRequest == null) {

                this.MemoryRequest = "FETCH";

            } else {


            }
        }
        else if (this.MemoryRequest != null && ec.Excludes("memoryRequest",true))
        {
            this.MemoryRequest = null;
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
        //      C# -> System.Int32? Replicas
        // GraphQL -> replicas: Int! (scalar)
        if (ec.Includes("replicas",true))
        {
            if(this.Replicas == null) {

                this.Replicas = Int32.MinValue;

            } else {


            }
        }
        else if (this.Replicas != null && ec.Excludes("replicas",true))
        {
            this.Replicas = null;
        }
        //      C# -> System.String? Scope
        // GraphQL -> scope: String! (scalar)
        if (ec.Includes("scope",true))
        {
            if(this.Scope == null) {

                this.Scope = "FETCH";

            } else {


            }
        }
        else if (this.Scope != null && ec.Excludes("scope",true))
        {
            this.Scope = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
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
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (ec.Includes("statusMessage",true))
        {
            if(this.StatusMessage == null) {

                this.StatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.StatusMessage != null && ec.Excludes("statusMessage",true))
        {
            this.StatusMessage = null;
        }
    }


    #endregion

    } // class K8sWorkloadComponentSummary
    
    #endregion

    public static class ListK8sWorkloadComponentSummaryExtensions
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
            this List<K8sWorkloadComponentSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sWorkloadComponentSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sWorkloadComponentSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sWorkloadComponentSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sWorkloadComponentSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types