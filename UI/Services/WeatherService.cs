using System;
using System.Net.Http;
using System.Net.Http.Json;
using DependencyTest.Shared;

namespace DependencyTest.UI.Services;

public class WeatherService
{
	private readonly HttpClient httpClient;

	public WeatherService(IHttpClientFactory factory)
	{
		httpClient = factory.CreateClient();
	}

	public async Task<IEnumerable<WeatherForecast>> GetWeather()
	{
		return await httpClient.GetFromJsonAsync<List<WeatherForecast>>("WeatherForecast");
	}
}

