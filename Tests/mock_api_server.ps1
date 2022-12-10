function Start-MockApiServer
{
  python3 $PSScriptRoot/mock_api_server/mock_api_server.py &
  Start-Sleep -Seconds 1.5
}

function Close-MockApiServer
{
  curl -X POST http://localhost:8080/shutdown
}

function Update-MockApiServerCache
{
  param (
      [string]$Query,
      [string]$Reply
  )

  $replyHash = @{}
  (ConvertFrom-Json $Reply).psobject.properties | Foreach {$replyHash[$_.Name] = $_.Value}

  $payload = @{
    "POST /api/graphql" = @{
      $Query = @{
        response = @{
          data = $replyHash
        }
        status = 200
      }
    }
  }

  $payloadJson = ($payload | ConvertTo-Json -Depth 10)

  $params = @{
     Method = "Post"
     Uri = "http://localhost:8080/cache"
     Body = ${payloadJson}
     ContentType = "application/json"
  }

  Invoke-RestMethod @params
}
