.PHONY: default build clean copy_static_files test e2e-test
OUTPUT = ./Output
default: build

# build: builds the SDK.
build: copy_static_files
	$(MAKE) -C RubrikSecurityCloud build

# copy_static_files: copies static files to the output directory.
copy_static_files:
	mkdir -p $(OUTPUT)
	cp -av ./Operations $(OUTPUT)

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
