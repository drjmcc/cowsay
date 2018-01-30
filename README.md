# Sample Containerized Cowsay API
This is a sample implementation of Cowsay in Dotnet Core 2. The app is containerized and comes with the manifests required for publishing that app in Kubernetes.


## Build and run the sample with Docker for Linux containers

You can build and run the sample in Docker using Linux containers using the following commands. The instructions assume that you are in the root of the repository.

```console
cd cowsay
docker build -t cowsay .
docker run -it --rm -p 8000:80 cowsay
```

After the application starts, visit `http://localhost:8000` in your web browser.

Note: The `-p` argument maps port 8000 on you local machine to port 80 in the container (the form of the port mapping is `host:container`). See the [Docker run reference](https://docs.docker.com/engine/reference/commandline/run/) for more information on commandline paramaters.


## Build and run the sample locally

You can build and run the sample locally with the [.NET Core 2.0 SDK](https://www.microsoft.com/net/download/core) using the following commands. The commands assume that you are in the root of the repository.

```console
cd cowsay
dotnet run
```

After the application starts, visit `http://localhost:8000/cow` in your web browser.

You can produce an application that is ready to deploy to production locally using the following command.

```console
dotnet publish -c release -o out
```

You can run the application on **Linux or macOS** using the following command.

```console
dotnet out/Cowsay.dll
```

## Docker Images used in this sample

The following Docker images are used in this sample

* [microsoft/aspnetcore-build:2.0](https://hub.docker.com/r/microsoft/aspnetcore-build)
* [microsoft/aspnetcore:2.0](https://hub.docker.com/r/microsoft/aspnetcore/)

