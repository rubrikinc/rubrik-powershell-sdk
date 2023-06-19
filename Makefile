.PHONY: default build clean test e2e-test

default: build

# build: builds the SDK.
build:
	$(MAKE) -C RubrikSecurityCloud build

# clean: removes all compiled files.
clean:
	rm -rf Tests/testResults.xml
	$(MAKE) -C RubrikSecurityCloud clean
	rm -rf docs/powershell docs/graphql/*.graphql
	if [ -d Tests/mock_api_server ]; then $(MAKE) -C Tests/mock_api_server clean ; fi

# test: run unit tests and mock tests.
test:
	$(MAKE) -C Tests test

# mock-test: run mock tests.
mock-test:
	$(MAKE) -C Tests mock-test

# e2e-test: run e2e tests.
e2e-test:
	$(MAKE) -C Tests e2e-test
