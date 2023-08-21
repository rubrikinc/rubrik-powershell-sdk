.PHONY: default build clean copy_static_files test e2e-test
OUTPUT = ./Output
default: build

# build: builds the SDK.
build:
	$(MAKE) -C RubrikSecurityCloud build

# clean: removes all compiled files.
clean:
	$(MAKE) -C Tests clean
	$(MAKE) -C RubrikSecurityCloud clean

# test: run unit tests and mock tests.
test:
	$(MAKE) -C Tests test

# mock-test: run mock tests.
mock-test:
	$(MAKE) -C Tests mock-test

# e2e-test: run e2e tests.
e2e-test:
	$(MAKE) -C Tests e2e-test
