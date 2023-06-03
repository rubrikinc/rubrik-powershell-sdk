function Test-MockApiServer {
  $uri = "http://localhost:8080/cache"
  try {
    $response = Invoke-WebRequest -Uri $uri -UseBasicParsing -Method Get -ErrorAction Stop
    return $response.StatusCode -eq 200
  }
  catch {
    return $false
  }
}

function Start-MockApiServer {
  if (Test-MockApiServer) {
    Write-Output "Server is already running"
  }
  else {
    python3 $PSScriptRoot/mock_api_server/mock_api_server.py &
    while (-not (Test-MockApiServer)) {
      Start-Sleep -Milliseconds 100
    }
    Write-Output "Server has started"
  }
}
function Close-MockApiServer {
  Invoke-WebRequest -Uri "http://localhost:8080/shutdown" -UseBasicParsing -Method Post -ErrorAction SilentlyContinue | Out-Null
}

function Update-MockApiServerCache {
  param (
    [string]$Query,
    [string]$Reply
  )

  $replyHash = @{}
  (ConvertFrom-Json $Reply).psobject.properties | ForEach-Object { $replyHash[$_.Name] = $_.Value }

  $payload = @{
    "POST /api/graphql" = @{
      $Query = @{
        response = @{
          data = $replyHash
        }
        status   = 200
      }
    }
  }

  $payloadJson = ($payload | ConvertTo-Json -Depth 10)

  $params = @{
    Method      = "Post"
    Uri         = "http://localhost:8080/cache"
    Body        = ${payloadJson}
    ContentType = "application/json"
  }

  Invoke-RestMethod @params
}
