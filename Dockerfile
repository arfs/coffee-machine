FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
EXPOSE 80
RUN apt-get update 
CMD ["/bin/bash"]
