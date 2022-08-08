
# TeslaX - C# Tesla API - based Multi-Platform Client

This is an unofficial .NET client implementation of the Tesla JSON API used by the Android and iOS apps. 
The API provides functionality to monitor and control the Tesla vehicles remotely.

TeslaX project contains very simple demo app that only make a try to get all your Teslas. :)



## Tesla API Lib Installation (into your own project)::


From Powershell
```ps1
Nuget-Install 'Tesla-API'
```

.NET CLI
```ps1
dotnet add package 'Tesla-API'
```

## Setup ::


#### Setup Dependency Injection

In the `Startup.cs` file, add the following to the `ConfigureServices` method to allow the TeslaAPI to be dependency injected.
```c#
services.AddScoped<ITeslaAPI, TeslaAPI>();
```

#### Making a Request

To make a request with the Tesla API, you'll need to create a `HttpClient` and set the `User-Agent` header to an identifier for your application.

#### Authenticating with Tesla

Follow the standard OAuth process [as documented by Tim Dorr](https://tesla-api.timdorr.com/api-basics/authentication) to get an access token. After getting an access token, add it to the `Authorization` header on the `HttpClient`, which is passed into data API calls.

You can use the [TeslaAuth](https://github.com/tomhollander/TeslaAuth/) package that provides a .net implementation to obtain a (refresh) token.

#### Example

```c#
public class TeslaService
{
	private readonly ITeslaAPI _teslaAPI;
	private readonly HttpClient _client = new HttpClient();

	/// <summary>
	/// Initializes a new instance of the <see cref="TeslaService"/> class.
	/// </summary>
	/// <param name="teslaClient">The TeslaAPI client.</param>
	public TeslaService(ITeslaAPI teslaAPI)
	{
	    _teslaAPI = teslaAPI;
	    _client.DefaultRequestHeaders.Add("User-Agent", "MyApplication");
	}

	/// <summary>
	/// Get all Vehicles in the user's account.
	/// </summary>
	/// <returns>Returns a list of all Vehicles.</returns>
	public async Task<List<Vehicle>> GetVehiclesAsync(string clientID, string clientSecret, string bearerToken)
	{
	    TeslaAccessToken accessToken = await _teslaAPI.GetAccesTokenAsync(_client, clientID, clientSecret, bearerToken);
	    _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken.AccessToken}");
	    return await _teslaAPI.GetAllVehiclesAsync(_client);
	}
}
```

## Referencies ::

![Tesla Owners API – How To](https://alexievarts.com/technology/tesla-owners-api-how-to/)
![at0dd's Tesla API](https://github.com/at0dd/tesla-api)
![Nuget Version](https://img.shields.io/nuget/v/tesla-api)
![Nuget Downloads](https://img.shields.io/nuget/dt/tesla-api)
![Tim Dorr API Documentation](https://tesla-api.timdorr.com/)
![API Documentation GitHub](https://github.com/timdorr/tesla-api)


## :

AS IS. No support. RnD only!

## :: ::

-- [m][e] 2022