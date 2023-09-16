# cs-userilog-enhancer-shell

## Prerequisites
- none

## About project

## Set up
- Clone the repository
```shell
git clone https://github.com/5enthilbaliah/cs-userilog-enhancer-shell.git
```

## Set up nuget repository (Ubuntu)

### Set up mono
```shell
sudo apt install ca-certificates gnupg
sudo gpg --homedir /tmp --no-default-keyring --keyring /usr/share/keyrings/mono-official-archive-keyring.gpg --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb [signed-by=/usr/share/keyrings/mono-official-archive-keyring.gpg] https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt update
```

```shell
sudo apt install mono-devel

# Download the latest stable `nuget.exe` to `/usr/local/bin`
sudo curl -o /usr/local/bin/nuget.exe https://dist.nuget.org/win-x86-commandline/latest/nuget.exe

# Create as alias for nuget
alias nuget="mono /usr/local/bin/nuget.exe"
```

### Create local Nuget repository
- Create a folder at shells folder level named .private_nuget. Run the below command, replace the {version} with version in nuget pkg.
```shell
nuget add bin/Release/Serilog.Enhancers.{version}.nupkg -source ../../.private_nuget/
```

### Update the ubuntu nuget settings 
Nuget config will be found on one of the two below path
- ~/.nuget/NuGet/NuGet.config
- ~/.config/NuGet/NuGet.config

Update this config to include the private directory path we create
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
    <add key="local" value="/{path_to_shell_folder}/shells/.private_nuget" />
  </packageSources>
</configuration>
```

### Set up the Serilog settings
- Add json settings in appSettings
```
...
"Serilog": {
    "Using":  [ "Serilog.Sinks.Console", "Serilog.Enhancers" ],
    ...
    "WriteTo": [{
      "Name": "Console",
      "Args": {
        "outputTemplate": "[{Timestamp:HH:mm:ss} {Level:u3} {ApplicationName}] <x:{CorrelationId}> <m:{MachineName}> {Message:lj} <s:{SourceContext}> {NewLine}{Exception}"
      }
    }],
    "Enhancer": {
      "CorrelationKey": "x-correlation-id",
      "DefaultCorrelationId": "36f47eb8-fe7c-42d6-aeb0-32f683d27aa1",
      "CorrelationIdPropertyName": "CorrelationId"
    }
  }
...
```
- To read EnhancerSettings from appsettings inject IOptions<SerilogEnhancedSettings>, provide the correct path
```csharp
hostBuilder.Services.Configure<SerilogEnhancedSettings>(configuration.GetSection("Serilog:Enhancer"));
```
- Add HttpContextAccessor dependency
```csharp
hostBuilder.Services.AddHttpContextAccessor();
```
- Add Enhancer to LoggerConfiguration in the UseSerilog
```csharp
Log.Logger = new LoggerConfiguration()
            .CreateBootstrapLogger();
        
        hostBuilder.Host.UseSerilog((_, sp, lc) =>
        {
            lc.ReadFrom.Configuration(configuration)
                .AttachHttpEnricher(sp);
        });

        hostBuilder.Services.AddSerilogEnhancedLogger();
```