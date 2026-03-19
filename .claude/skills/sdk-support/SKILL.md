---
name: sdk-support
description: Ask anything about the RSC PowerShell SDK. Pass a question as text, or a URL (Slack, GitHub issue, web page) and the question will be extracted from it.
---

# Ask — RSC PowerShell SDK Q&A

Answer any question about the Rubrik Security Cloud (RSC) PowerShell SDK,
grounded in the actual codebase.

## Input

The argument (`$ARGUMENTS`) is either:
- **Plain text**: a question (e.g., `/ask how do I filter clusters by name?`)
- **A URL**: a link to a Slack message, GitHub issue, or web page that contains
  the question (e.g., `/ask https://rubrik.enterprise.slack.com/archives/...`)

## Step 1: Extract the question

**If the argument looks like a URL** (starts with `http://` or `https://`):

- **Slack URL** (`slack.com/archives/`):
  Parse channel ID and timestamp from the URL path. The timestamp is the `p`
  segment: remove leading `p`, insert `.` before the last 6 digits
  (e.g., `p1710000000123456` → `1710000000.123456`).
  Fetch with `mcp__slack__get_thread_replies(channel, thread_ts)`.
  If no replies come back, use `mcp__slack__conversations_history` with
  `oldest`/`latest` set to the timestamp and `inclusive: true`.
  Resolve user IDs with `mcp__slack__resolve_user_ids`.

- **GitHub URL** (`github.com/.../issues/` or `github.com/.../discussions/`):
  Use `gh issue view` or `gh discussion view` via Bash, or use WebFetch.

- **Any other URL**: Use WebFetch to retrieve the page content.

**Anonymization**: When presenting the extracted question, NEVER include
people's names, user IDs, or handles. Refer to them as "the user" or
"someone asked". The output must be shareable and suitable for docs/FAQ
without identifying anyone.

Present a brief summary of the extracted question to the user before answering.

**If the argument is plain text**: use it directly as the question.

## Step 2: Research the codebase

Search the SDK codebase for relevant context. Be thorough — the quality of
the answer depends on accurate codebase knowledge. Look in:

- `Toolkit/Public/` — Toolkit cmdlet scripts (high-level wrappers)
- `Samples/` — sample scripts and usage examples
- `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Cmdlets/` — hand-written C# cmdlets
- `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/generated/` — auto-generated cmdlets
- `RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Public/` — core script functions
- `docs/`, `README.md`, `GETTING_STARTED.md`, `FAQ.md` — documentation
- `CHANGELOG.md` — recent changes and known fixes

Use Grep, Glob, or the Explore agent as needed. Verify that any cmdlet names,
parameter names, or type names you reference actually exist in the codebase.

## Step 3: Answer the question

Write a clear, helpful answer. Guidelines:

- **Be accurate**: Only reference cmdlets, parameters, and types that exist
  in the codebase. If you're not sure, say so.
- **Show code**: Include PowerShell examples when useful.
- **Be concise**: Answer the question directly, don't give a lecture.
- **Reference sources**: Mention relevant files (e.g., "see `Samples/Example.ps1`")
  so the user can explore further.
- **Be honest**: If something is a known limitation, bug, or unsupported, say so.

## Important

- **Anonymous**: NEVER include people's names, user IDs, or handles in any
  part of the output. The output must be safe to paste into public docs.
- Do NOT post or comment anywhere on behalf of the user.
- Do NOT fabricate cmdlet names or parameters.
- If the question involves authentication or connecting to RSC, check
  `Toolkit/Public/Connect-Rsc.ps1` and getting-started docs for accurate info.
- If the question mentions a specific error, search for that error string in
  the codebase.
