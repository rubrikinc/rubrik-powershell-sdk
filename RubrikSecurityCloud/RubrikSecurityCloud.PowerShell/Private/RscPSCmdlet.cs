using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.PowerShell.Private
{
    public class GqlTypeName
    {
        [JsonProperty("__typename")]
        public string TypeName { get; set; }
    }


    public class RscPSCmdlet : RscGqlPSCmdlet
    {
        protected string GetSnappableTypeNameById(string id)
        {
            if (_rbkClient != null)
            {
                string query = @"
                        query HierarchyObjects($fids: [UUID!]!) {
                          hierarchyObjects(fids: $fids) {
                                id
                                __typename
                            }
                        }";

                OperationVariableSet variables = new OperationVariableSet
                {
                    Variables = new Dictionary<string, object>()
                    {
                        { "fids", (new List<string>{id}).ToArray() }
                    }
                };

                Task<List<GqlTypeName>> apiTask = _rbkClient.InvokeGenericCallAsync<List<GqlTypeName>>(query, variables);
                apiTask.Wait();
                List<GqlTypeName> response = apiTask.Result;

                if (response.Count > 0)
                {
                    return response[0].TypeName;
                }
                return null;
            }

            return null;
        }
    }
}

