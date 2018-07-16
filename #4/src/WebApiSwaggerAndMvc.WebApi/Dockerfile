FROM microsoft/aspnetcore-build AS build
LABEL maintainer = "g.mikele@gmail.com"
WORKDIR /code
COPY . .
RUN dotnet restore && dotnet publish --output /output

FROM microsoft/aspnetcore
LABEL maintainer = "g.mikele@gmail.com"
COPY --from=build /output /app
WORKDIR /app
EXPOSE 5000
ENTRYPOINT [ "dotnet" ]
CMD ["/app/WebApiSwaggerAndMvc.WebApi.dll"]
