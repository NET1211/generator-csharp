FROM mcr.microsoft.com/dotnet/core/sdk:2.2.104 as sdk

# Add dotnet (C#) generator source.
COPY . /usr/src/gapic-generator-csharp/

# Build generator native binary.
RUN cd /usr/src/gapic-generator-csharp/Google.Api.Generator; \
    dotnet publish -c Release --self-contained --runtime linux-x64; \
    chmod 0777 bin/Release/netcoreapp2.2/linux-x64/publish/Google.Api.Generator

# Build smaller runtime image.
# The generator executable just built is stand-alone, so dotnet is not required in the OS image.
FROM debian:stable-slim

# Add protoc and our common protos.
COPY --from=gcr.io/gapic-images/api-common-protos:0.1.0 /usr/local/bin/protoc /usr/local/bin/protoc
COPY --from=gcr.io/gapic-images/api-common-protos:0.1.0 /protos/ /protos/

# Add C# generator binaries.
COPY --from=sdk \
    /usr/src/gapic-generator-csharp/Google.Api.Generator/bin/Release/netcoreapp2.2/linux-x64/publish \
    /usr/src/gapic-generator-csharp/Google.Api.Generator/bin/Release/netcoreapp2.2/linux-x64/publish
# Add entrypoint script.
COPY --from=sdk \
    /usr/src/gapic-generator-csharp/docker-entrypoint.sh \
    /usr/src/gapic-generator-csharp/docker-entrypoint.sh

# Define the generator as an entry point.
ENTRYPOINT ["/usr/src/gapic-generator-csharp/docker-entrypoint.sh"]
