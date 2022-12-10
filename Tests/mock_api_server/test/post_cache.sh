curl -s \
    -X POST \
    --header "Content-Type: application/json" \
    --header "Authorization: Bearer $RSC_ACCESS_TOKEN" \
    --data @./cache.json \
    http://localhost:8080/cache \
    | jq .
