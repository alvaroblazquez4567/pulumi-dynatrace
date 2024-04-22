1. Update go version to GO_VERSION=1.22.2 in dockerfile

1. make prepare NAME=dynatrace REPOSITORY=github.com/alvaroblazquez4567/pulumi-dynatrace ORG=alvaroblazquez4567

2. In provider/go.mod, add a reference to the upstream Terraform provider in the require section.

github.com/dynatrace-oss/terraform-provider-dynatrace v1.55.0

3. In provider/resources.go, ensure the reference in the import section uses the correct Go module path

github.com/dynatrace-oss/terraform-provider-dynatrace/provider

4. Download the dependencies:

cd provider && go mod tidy && cd -

4.1 push changes????

5. Create the schema by running the following command:
make tfgen

6. add resource mapping
6.1 add data source mapping
6.2 copy functions from old provider

7. make provider

8. cd sdk && go mod tidy && cd -

9. make lint_provider