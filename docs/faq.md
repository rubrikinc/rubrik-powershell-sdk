# RSC PowerShell SDK FAQ

## Query complexity errors

The API server responded to my query with an error like this:

```log
Error: Query reducing error: Query is too expensive. Actual Complexity (100003) >= Threshold Complexity (1001)
```

This means that the query you sent to the API server was too
complex. The API server has a limit on how complex a query can be
(rationale: to prevent denial of service attacks, and help
with rate limiting). The complexity of a query is calculated by
the number of fields requested, the number of nested objects,
and the number of items in lists.

### Resolution

- If it is a query you are running manually, try to reduce the
  number of fields (and nested fields) requested. If needed,
  break up the fields and run multiple queries.
- If you got that error without specifying fields explicitly
  (for example by running a `Invoke-RscXxx` cmdlet), please open
  an issue on GitHub with the full command you ran, and the
  full error message you got back.
