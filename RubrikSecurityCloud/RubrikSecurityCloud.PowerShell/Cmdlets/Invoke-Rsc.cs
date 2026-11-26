using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Send a query to the RSC API.
    /// </summary>
    /// <description>
    /// There are 2 usages of this cmdlet:
    /// 1) -Query : Send a query object (obtained from a `New-RscQuery*` cmdlet); or
    /// 2) -GqlQuery : Send a text GraphQL query.
    /// </description>
    /// <example>
    /// Send a query object.
    /// <code>
    /// #
    /// # Create a query object
    /// $q = New-RscQueryGetVsphereVmList -Name "my-vm"
    /// 
    /// # Send it - by piping to Invoke-Rsc:
    /// $q | Invoke-Rsc
    /// # - Or  - by calling Invoke() on the query object
    /// $q.Invoke()
    /// 
    /// # The above 2 methods are equivalent.
    /// </code>
    /// </example>
    /// <example>
    /// Send a GraphQL query string.
    /// <code>
    /// #
    /// # Text GraphQL query string
    /// $gqlQuery = @'
    ///   mutation DeleteWebhookMutation($id: Int!) {
    ///     deleteWebhook(input: {id: $id})
    ///   }
    /// '@
    /// 
    /// # Invoke the query - as a parameter:
    /// Invoke-Rsc -GqlQuery $gqlQuery -Var @{id = 1}
    /// # - Or - by piping the query to Invoke-Rsc:
    /// $gqlQuery | Invoke-Rsc -Var @{id = 1}
    ///
    /// # The above 2 methods are equivalent.
    /// </code>
    /// </example>
    /// <example>
    /// Read the GraphQL query from a .gql file, and send it.
    /// <code>
    /// #
    /// # text GraphQL query file with variables in the header
    /// $gqlFile = "./Samples/queryClusterList.gql"
    /// $gqlQuery = Get-Content -Path $gqlFile -Raw
    /// 
    /// # Invoke the query - by piping to Invoke-Rsc:
    /// $gqlQuery | Invoke-Rsc
    /// # - Or - by giving it as a parameter:
    /// Invoke-Rsc -GqlQuery $gqlQuery
    /// 
    /// # The above 2 methods are equivalent.
    /// </code>
    /// </example>

    [Cmdlet(
        VerbsLifecycle.Invoke,
        "Rsc",
        DefaultParameterSetName = "Query")]
    public class Invoke_Rsc : RscBasePSCmdlet
    {
        /// <summary>
        /// The query object to send to the RSC API.
        /// </summary>
        [Parameter(
            ParameterSetName = "Query",
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true
        )]
        public object Query { get; set; }

        // Parameter Set "NativeGQL"
        // is used when the user writes their own GQL queries
        /// <summary>
        /// The text GraphQL query string to send to the RSC API.
        /// Variables can possibly be supplied in a header comment.
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeGQL",
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true
        )]
        [Alias("Gql")]
        public string GqlQuery { get; set; }

        /// <summary>
        /// The variables to supply to the GraphQL query.
        /// Only used when GqlQuery is set.
        /// </summary>
        [Parameter(
            ParameterSetName = "NativeGQL",
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true
        )]
        public Hashtable Var { get; set; }

        public Invoke_Rsc() : base(retrieveConnection: true)
        {
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch (ParameterSetName)
                {
                    case "Query":
                        ProcessRecord_Query();
                        break;
                    case "NativeGQL":
                        ProcessRecord_NativeGQL();
                        break;
                }
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        /// <summary>
        /// Send a query object (obtained from a `New-RscQuery*` cmdlet).
        /// </summary>
        internal void ProcessRecord_Query()
        {
            if (Query is PSObject pSObject)
            {
                Query = pSObject.BaseObject;
            }
            if (Query is string sQuery)
            {
                if (string.IsNullOrEmpty(sQuery))
                {
                    throw new ArgumentException("No GQL query provided");
                }
                
                // if the content of sQuery is an existing file, read it
                try {
                    var _asPathString = Path.GetFullPath(sQuery);
                    if (File.Exists(_asPathString))
                    {
                        sQuery = File.ReadAllText(_asPathString);
                    }
                } catch (Exception) {
                    // ignore
                }

                GqlQuery = sQuery;
                ProcessRecord_NativeGQL();
                return;
            }
            if (Query is RscQuery query)
            {
                // calling Invoke() on a RscQuery object ends up here

                query.Var.Finalize();
                // query.Var is case insensitive
                if (query.Var.ContainsKey("first"))
                {
                    FetchAndCollatePages(query);
                }
                else
                {
                    this.SendGqlRequest(query.GqlRequest());
                }
                return;
            }
            if (Query is RscGqlRequest gqlRequest)
            {
                this.SendGqlRequest(gqlRequest);
                return;
            }
            throw new ArgumentException($"Invalid query type {Query.GetType().Name}");
        }

        /// <summary>
        /// Send a raw GraphQL query to the RSC API.
        /// </summary>
        internal void ProcessRecord_NativeGQL()
        {
            var (inlineVars, query) = StringUtils.ParseGqlAndVarString(GqlQuery);
            if (!string.IsNullOrEmpty(inlineVars) && (
                Var == null || Var.Count == 0))
            {
                Var = JsonConvert.DeserializeObject<Hashtable>(inlineVars);
            }
            object reply = _rbkClient.InvokeRawQuery(
                query,
                Var,
                _logger,
                GetMetricTags()
            );
            WriteObject(reply);
        }

        internal static PageInfo ObjectPageInfo(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            PropertyInfo pageInfoProperty = obj.GetType().GetProperty("PageInfo");
            if (pageInfoProperty == null)
            {
                return null;
            }
            PageInfo pageInfo = (PageInfo)pageInfoProperty.GetValue(obj);
            return pageInfo;
        }

        internal static void CopyPageInfo(PageInfo source, object target)
        {
            if (source == null)
            {
                return;
            }
            if (target == null)
            {
                return;
            }
            PropertyInfo targetPageInfoProperty = target.GetType().GetProperty("PageInfo");
            if (targetPageInfoProperty == null)
            {
                return;
            }
            targetPageInfoProperty.SetValue(target, source);
        }

        internal static IList ObjectNodes(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            PropertyInfo nodesProperty = obj.GetType().GetProperty("Nodes");
            if (nodesProperty == null)
            {
                return null;
            }
            object nodes = nodesProperty.GetValue(obj);
            return (IList)nodes;
        }

        internal static int GetQueryVarFirst(RscQuery query)
        {
            if (
                query.Var.ContainsKey("first") &&
                query.Var["first"] != null &&
                query.Var["first"] is int)
            {
                int first = (int)query.Var["first"];
                if (first > 0)
                {
                    return first;
                }
            }
            return 0;
        }

        /// <summary>
        /// Collate pages of results.
        /// </summary>
        internal void FetchAndCollatePages(RscQuery query)
        {
            WriteObject(CollatePages(
                query,
                request => this.SendGqlRequest(request, false),
                _logger));
        }

        // Fetches every page of query with sendPage and returns them
        // collated into one connection object. The caller's query is
        // left as it was, and the result only has the fields it selected.
        internal static object CollatePages(
            RscQuery query,
            System.Func<RscGqlRequest, object> sendPage,
            IRscLogger logger)
        {
            // _FetchAndCollatePages() alters 'first' and 'after'.
            object callerFirst = query.Var["first"];
            bool hadAfter = query.Var.ContainsKey("after");
            object callerAfter = hadAfter ? query.Var["after"] : null;
            var unselectPageInfo = SelectPageInfoForPaging(query.Field);
            try
            {
                object collated = _FetchAndCollatePages(query, sendPage, logger);
                unselectPageInfo(collated);
                return collated;
            }
            finally
            {
                unselectPageInfo(query.Field);
                query.Var["first"] = callerFirst;
                if (hadAfter || query.Var.ContainsKey("after"))
                {
                    query.Var["after"] = callerAfter;
                }
            }
        }

        // Paging needs pageInfo.hasNextPage and pageInfo.endCursor.
        // Selects whichever of them the caller didn't, and returns an
        // action that unselects them again on a field or result object.
        // Does nothing when no nodes are selected (e.g. a count-only
        // query): such a query isn't paged, and selecting pageInfo
        // would make the server fetch a page for nothing.
        internal static System.Action<object> SelectPageInfoForPaging(object field)
        {
            System.Action<object> nothing = target => { };
            PropertyInfo prop = field?.GetType().GetProperty("PageInfo");
            if (prop == null || prop.PropertyType != typeof(PageInfo) || !prop.CanWrite)
            {
                return nothing;
            }
            IList nodes = ObjectNodes(field);
            if (nodes == null || nodes.Count == 0 || nodes.Cast<object>().All(
                n => n is IFieldSpec spec && string.IsNullOrWhiteSpace(spec.AsFieldSpec())))
            {
                return nothing;
            }
            var selected = (PageInfo)prop.GetValue(field);
            if (selected == null)
            {
                // Any non-null value selects the field.
                prop.SetValue(field, new PageInfo { HasNextPage = true, EndCursor = "" });
                return target =>
                {
                    target?.GetType().GetProperty("PageInfo")?.SetValue(target, null);
                };
            }
            bool addHasNextPage = selected.HasNextPage == null;
            bool addEndCursor = selected.EndCursor == null;
            if (addHasNextPage) selected.HasNextPage = true;
            if (addEndCursor) selected.EndCursor = "";
            return target =>
            {
                PageInfo pageInfo = ObjectPageInfo(target);
                if (pageInfo == null) return;
                if (addHasNextPage) pageInfo.HasNextPage = null;
                if (addEndCursor) pageInfo.EndCursor = null;
            };
        }

        internal static object _FetchAndCollatePages(
            RscQuery query,
            System.Func<RscGqlRequest, object> sendPage,
            IRscLogger logger)
        {
            PageInfo pageInfo;
            bool hasNextPage;
            int pageCount = 0;
            int first = GetQueryVarFirst(query);

            // Prep query for fetching first page
            if (Config.ConnectionMaxPageSize > 0)
            {
                if (first == 0 || first > Config.ConnectionMaxPageSize)
                {
                    query.Var["first"] = Config.ConnectionMaxPageSize;
                }
                else
                {
                    query.Var["first"] = first;
                }
            }
            else
            {
                if (first > 0)
                {
                    // Config.ConnectionMaxPageSize not set
                    // => use first from query
                    query.Var["first"] = first;
                }
                else
                {
                    // use API server default page size
                    query.Var["first"] = null;
                }
            }
            // query.Var["after"] :
            // typically, "after" is not set in the query
            // but if it is, we want to honor it. 

            // Object to collate results into
            object collated = null;

            do
            {
                // adjust page size if last one:
                if (first > 0 && collated != null)
                {
                    int collatedCount = ObjectNodes(collated).Count;
                    if (collatedCount + (int)query.Var["first"] > first)
                    {
                        query.Var["first"] = first - collatedCount;
                    }
                }

                // null 'first' means the server's default page size.
                if (query.Var["first"] is int pageSize && pageSize <= 0)
                {
                    break; // no more pages to fetch
                }

                // Fetch page
                logger?.Verbose($"Fetching page {pageCount + 1} with Var['first']={query.Var["first"]} and Var['after']={query.Var["after"]}");
                var page = sendPage(query.GqlRequest());
                pageCount++;
                pageInfo = ObjectPageInfo(page);
                logger?.Verbose($"Fetched page {pageCount}. HasNextPage: {pageInfo?.HasNextPage} EndCursor: {pageInfo?.EndCursor}");

                // If this is the first page, initialize the collated object
                if (collated == null)
                {
                    collated = page;
                    if (ObjectNodes(collated) == null)
                    {
                        // no nodes => we assume response is not paginated
                        break;
                    }
                }
                else
                {
                    var pageNodes = ObjectNodes(page);
                    if (pageNodes == null)
                    {
                        break;
                    }
                    // Append the results of this page to the collated object
                    foreach (var item in pageNodes)
                    {
                        ObjectNodes(collated).Add(item);
                    }
                    CopyPageInfo(pageInfo, collated);

                }

                if (pageInfo == null)
                {
                    break;
                }

                var collatedList = ObjectNodes(collated);
                if (first > 0 && collatedList.Count >= first)
                {
                    // truncate collated object to first items
                    while (collatedList.Count > first)
                    {
                        collatedList.RemoveAt(collatedList.Count - 1);
                    }
                    break;
                }

                hasNextPage = pageInfo.HasNextPage ?? false;
                if (hasNextPage)
                {
                    if (pageInfo.EndCursor == null)
                    {
                        // Without a cursor the next request would
                        // fetch this same page again.
                        logger?.Warning("Stopped paging: the response has no pageInfo.endCursor.");
                        break;
                    }
                    query.Var["after"] = pageInfo.EndCursor;
                }

            } while (hasNextPage);

            return collated;
        }
    }
}
