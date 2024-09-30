using System.Text.Json;
using CA_InterfaceAdapter_Adapters;
using CA_InterfaceAdapter_Adapters.Dtos;

namespace CA_FrameworksDrivers_ExternalService;

public class PostService : IExternalService<PostServiceDTO>
{
  private readonly HttpClient _httpClient;
  private readonly JsonSerializerOptions _options;

  public PostService(HttpClient httpClient)
  {
    _httpClient = httpClient;
    _options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true
    };
  }

  public async Task<IEnumerable<PostServiceDTO>> GetContentAsync()
  {
    var response = await _httpClient.GetAsync(_httpClient.BaseAddress);
    response.EnsureSuccessStatusCode();
    using var responseStream = await response.Content.ReadAsStreamAsync();
    return await JsonSerializer.DeserializeAsync<IEnumerable<PostServiceDTO>>(responseStream, _options);
  }
}
