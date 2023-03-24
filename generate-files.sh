docker run --rm -v "${PWD}:/local" \
  openapitools/openapi-generator-cli generate \
  -g csharp-netcore \
  -i local/reference/vero.yaml \
  -o local \
  --additional-properties=packageName=Vero.Api.Codegen,targetFramework=net7.0,library=httpclient,packageGuid=80CB6CC0-F037-4E2B-B50F-4FEF820EE2DB \
  --global-property=apiTests=false,modelTests=false,modelDocs=false


docker run --rm -v "${PWD}:/local" \
  openapitools/openapi-generator-cli generate \
  -g aspnetcore \
  -i /local/reference/testbed.yaml \
  -o /local \
  --additional-properties=packageName=Testbed.Api.Codegen,aspnetCoreVersion=6.0,buildTarget=library,packageGuid=5056B1F1-C1F6-426F-B703-78D9E634D34D,operationIsAsync=true \
  --global-property=apiTests=false,modelTests=false,modelDocs=false
