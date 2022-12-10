curl -s\
    -X GET \
    --header "Content-Type: application/json" \
    --header "Authorization: Bearer $RSC_ACCESS_TOKEN" \
    http://localhost:8080/cache \
    | jq .
