curl \
    -X GET \
    --header "Content-Type: application/json" \
    --header "Authorization: Bearer $RSC_ACCESS_TOKEN" \
    --data "{\"query\": \"{currentUser{id}}\"}" \
    http://localhost:8080/api/graphql \
    | jq .
