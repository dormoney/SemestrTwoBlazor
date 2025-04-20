using SemestrTwoBlazor.ApiRequests.Model;
using System.Text.Json;

namespace SemestrTwoBlazor.ApiRequests
{
    public class ApiRequestService
    {
        private readonly HttpClient _httpClient;

        public ApiRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserData>> GetAllUsers()
        {
            var url = "api/Admin/GetAllUsers";
            try
            {
                var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (string.IsNullOrEmpty(responseContent))
                {
                    return new List<UserData>();
                }

                var usersData = JsonSerializer.Deserialize<List<UserData>>(responseContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return usersData ?? new List<UserData>();
            }
            catch (Exception ex)
            {
                return new List<UserData>();
            }
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var url = "api/User/Register";

            try
            {
                var response = await _httpClient.PostAsJsonAsync(url, request);
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
