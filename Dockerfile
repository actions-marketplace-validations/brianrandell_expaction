FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# LABEL "com.github.actions.name"="ExpAction"
# LABEL "com.github.actions.description"="Test running .NET Core in a GitHub Action"

# LABEL "repository"="https://github.com/brianrandell/expaction"
# LABEL "homepage"="https://github.com/brianrandell/"
# LABEL "maintainer"="Brian Randell <brianr@mcwtech.com>"

COPY src/ .

ADD entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh

ENTRYPOINT ["/entrypoint.sh"]