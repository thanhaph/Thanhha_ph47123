using Data;

namespace Server.Services
{
    public class SinhVienServices : ISinhVienServices
    {
        private readonly HttpClient _httpClient;

        public SinhVienServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Create(SinhVien sv)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:7160/api/SinhVien", sv);
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync("https://localhost:7160/api/SinhVien/" + id);
        }

        public async Task<List<SinhVien>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<SinhVien>>("https://localhost:7160/api/SinhVien");
        }

        public async Task<SinhVien> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<SinhVien>("https://localhost:7160/api/SinhVien/" + id);
        }

        public async Task Update(SinhVien sv)
        {
            await _httpClient.PutAsJsonAsync("https://localhost:7160/api/SinhVien", sv);
        }
    }
}
