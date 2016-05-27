FROM microsoft/dotnet:latest  


COPY . /root/app/

WORKDIR /root/app/

RUN dotnet restore
RUN dotnet build

CMD ["dotnet", "run"] 