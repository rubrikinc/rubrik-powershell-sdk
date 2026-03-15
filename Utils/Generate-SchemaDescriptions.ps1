<#
.SYNOPSIS
Parse GraphQL schema comments into a PowerShell hashtable data file.

.DESCRIPTION
Reads docs/graphql/schema-public.graphql and extracts # comment descriptions
above top-level declarations and root fields (Query/Mutation fields).
Writes Toolkit/Private/SchemaDescriptions.ps1 with a $Script:SchemaDescriptions
hashtable mapping "Kind:Name" to description strings.
#>
param(
    [string]$SchemaPath,
    [string]$OutputPath
)

$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $SchemaPath) {
    $SchemaPath = Join-Path $repoRoot "docs/graphql/schema-public.graphql"
}
if (-not $OutputPath) {
    $OutputPath = Join-Path $repoRoot "Toolkit/Private/SchemaDescriptions.ps1"
}

if (-not (Test-Path $SchemaPath)) {
    Write-Warning "Schema file not found: $SchemaPath"
    exit 1
}

Write-Host "Parsing schema descriptions from $SchemaPath ..."

$lines = [System.IO.File]::ReadAllLines($SchemaPath)
$descriptions = @{}
$implements = @{}  # Type -> list of interfaces
$fieldDescs = @{}  # "TypeName.fieldName" -> description
$rootFieldArgs = @{}  # "Query:fieldName" -> @("argName: ArgType - desc", ...)
$commentLines = @()
$inRootBlock = ""  # "Query" or "Mutation" when inside those blocks
$inTypeBlock = ""  # type/input/interface name when inside their bodies
$currentRootField = ""  # root field name when parsing its argument list
$currentArgs = @()      # accumulated arguments for current root field
$braceDepth = 0

# Map GraphQL keywords to description key prefixes
$kindMap = @{
    'type'      = 'Type'
    'enum'      = 'Enum'
    'input'     = 'Input'
    'interface' = 'Interface'
    'union'     = 'Union'
    'scalar'    = 'Scalar'
}

function TrimDescription([string[]]$lines) {
    # Join comment lines, take first sentence, truncate at 120 chars
    $text = ($lines -join ' ').Trim()
    if ($text.Length -eq 0) { return "" }
    # Take up to first period followed by space or end-of-string
    if ($text -match '^(.+?\.)\s') {
        $text = $Matches[1]
    } elseif ($text -match '^(.+?\.)$') {
        $text = $Matches[1]
    }
    if ($text.Length -gt 120) {
        $text = $text.Substring(0, 117) + "..."
    }
    return $text
}

for ($i = 0; $i -lt $lines.Count; $i++) {
    $line = $lines[$i]

    # Blank line: reset accumulated comments
    if ($line -match '^\s*$') {
        $commentLines = @()
        continue
    }

    # Comment line: accumulate
    if ($line -match '^\s*#\s?(.*)$') {
        $commentText = $Matches[1].Trim()
        if ($commentText.Length -gt 0) {
            $commentLines += $commentText
        }
        continue
    }

    # Non-comment, non-blank line
    $desc = TrimDescription $commentLines
    $commentLines = @()

    if ($inRootBlock -ne "") {
        # Inside type Query { ... } or type Mutation { ... }
        # Track brace depth
        $openCount = ($line.ToCharArray() | Where-Object { $_ -eq '{' }).Count
        $closeCount = ($line.ToCharArray() | Where-Object { $_ -eq '}' }).Count
        $braceDepth = $braceDepth + $openCount - $closeCount

        if ($braceDepth -le 0) {
            $inRootBlock = ""
            $currentRootField = ""
            $currentArgs = @()
            $braceDepth = 0
            continue
        }

        # Inside an argument list for a root field?
        if ($currentRootField -ne "") {
            # Check for closing ) — may also have a final arg on same line
            if ($line -match '\)') {
                if ($line -match '^\s+([a-zA-Z_]\w*)\s*:\s*([^)]+)\)') {
                    $argName = $Matches[1]
                    $argType = $Matches[2].Trim().TrimEnd(',', ' ')
                    $entry = "${argName}: ${argType}"
                    if ($desc.Length -gt 0) { $entry += " - $desc" }
                    $currentArgs += $entry
                }
                if ($currentArgs.Count -gt 0) {
                    $rootFieldArgs["${inRootBlock}:${currentRootField}"] = $currentArgs
                }
                $currentRootField = ""
                $currentArgs = @()
                continue
            }
            # Argument line: argName: Type
            if ($line -match '^\s+([a-zA-Z_]\w*)\s*:\s*(.+?)[,\s]*$') {
                $argName = $Matches[1]
                $argType = $Matches[2].Trim().TrimEnd(',', ' ')
                $entry = "${argName}: ${argType}"
                if ($desc.Length -gt 0) { $entry += " - $desc" }
                $currentArgs += $entry
            }
            continue
        }

        # Match a root field: indented fieldName( or fieldName:
        if ($line -match '^\s+([a-zA-Z_]\w*)\s*[\(:]') {
            $fieldName = $Matches[1]
            if ($desc.Length -gt 0) {
                $key = "${inRootBlock}:${fieldName}"
                $descriptions[$key] = $desc
            }
            # Has arguments? Enter arg-parsing mode
            if ($line -match '\(' -and $line -notmatch '\)') {
                $currentRootField = $fieldName
                $currentArgs = @()
            }
        }
        continue
    }

    # Inside a type/input/interface body: parse fields
    if ($inTypeBlock -ne "") {
        $openCount = ($line.ToCharArray() | Where-Object { $_ -eq '{' }).Count
        $closeCount = ($line.ToCharArray() | Where-Object { $_ -eq '}' }).Count
        $braceDepth = $braceDepth + $openCount - $closeCount

        if ($braceDepth -le 0) {
            $inTypeBlock = ""
            $braceDepth = 0
            continue
        }

        # Match a field: indented fieldName( or fieldName:
        if ($line -match '^\s+([a-zA-Z_]\w*)\s*[\(:]') {
            $fieldName = $Matches[1]
            if ($desc.Length -gt 0) {
                $fieldDescs["$inTypeBlock.$fieldName"] = $desc
            }
        }
        continue
    }

    # Top-level declaration: type Query { or type Mutation {
    if ($line -match '^type\s+(Query|Mutation)\s*\{') {
        $inRootBlock = $Matches[1]
        $braceDepth = 1
        continue
    }

    # Top-level declaration: type/enum/input/interface/union/scalar Name
    if ($line -match '^(type|enum|input|interface|union|scalar)\s+([A-Za-z_]\w*)') {
        $keyword = $Matches[1]
        $name = $Matches[2]
        $kind = $kindMap[$keyword]
        if ($kind -and $desc.Length -gt 0) {
            $key = "${kind}:${name}"
            $descriptions[$key] = $desc
        }
        # Parse "implements Iface1 , Iface2 , ..." clause
        if ($keyword -eq 'type' -and $line -match '\bimplements\s+(.+?)(\s*\{|$)') {
            $ifaceList = $Matches[1] -split '\s*,\s*' | ForEach-Object { $_.Trim() } | Where-Object { $_.Length -gt 0 }
            if ($ifaceList.Count -gt 0) {
                $implements[$name] = $ifaceList
            }
        }
        # For types, inputs, and interfaces: parse fields inside the body
        $hasBody = $keyword -eq 'type' -or $keyword -eq 'input' -or $keyword -eq 'interface'
        $openCount = ($line.ToCharArray() | Where-Object { $_ -eq '{' }).Count
        $closeCount = ($line.ToCharArray() | Where-Object { $_ -eq '}' }).Count
        if ($hasBody -and $openCount -gt $closeCount) {
            $inTypeBlock = $name
            $braceDepth = $openCount - $closeCount
        }
        continue
    }
}

Write-Host "  Found $($descriptions.Count) descriptions, $($implements.Count) implements clauses, $($fieldDescs.Count) field descriptions, $($rootFieldArgs.Count) root fields with arguments."

# Write output file
$sb = New-Object System.Text.StringBuilder
[void]$sb.AppendLine("# Auto-generated by Utils/Generate-SchemaDescriptions.ps1")
[void]$sb.AppendLine("# Do not edit manually.")
[void]$sb.AppendLine('$Script:SchemaDescriptions = @{')

foreach ($key in ($descriptions.Keys | Sort-Object)) {
    $val = $descriptions[$key] -replace "'", "''"
    [void]$sb.AppendLine("    '$key' = '$val'")
}

[void]$sb.AppendLine('}')
[void]$sb.AppendLine('$Script:SchemaImplements = @{')

foreach ($key in ($implements.Keys | Sort-Object)) {
    $vals = ($implements[$key] | ForEach-Object { "'$_'" }) -join ', '
    [void]$sb.AppendLine("    '$key' = @($vals)")
}

[void]$sb.AppendLine('}')
[void]$sb.AppendLine('$Script:SchemaFieldDescriptions = @{')

foreach ($key in ($fieldDescs.Keys | Sort-Object)) {
    $val = $fieldDescs[$key] -replace "'", "''"
    [void]$sb.AppendLine("    '$key' = '$val'")
}

[void]$sb.AppendLine('}')
[void]$sb.AppendLine('$Script:SchemaRootFieldArgs = @{')

foreach ($key in ($rootFieldArgs.Keys | Sort-Object)) {
    $vals = ($rootFieldArgs[$key] | ForEach-Object { "'" + ($_ -replace "'", "''") + "'" }) -join ', '
    [void]$sb.AppendLine("    '$key' = @($vals)")
}

[void]$sb.AppendLine('}')

$content = $sb.ToString()
[System.IO.File]::WriteAllText($OutputPath, $content)
Write-Host "  Wrote $OutputPath"
