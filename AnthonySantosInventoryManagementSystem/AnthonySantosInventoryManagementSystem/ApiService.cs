using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AnthonySantosInventoryManagementSystem
{
    public class ApiService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "http://localhost:5000";

        public static async Task<List<ApiPart>> GetPartsAsync()
        {
            try
            {
                string url = $"{BaseUrl}/api/parts?tenant_id=1";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResponse>(json);
                return result.parts;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to connect to RepairOS API: " + ex.Message);
            }
        }

        public static async Task<bool> UpdatePartAsync(int partId, string partName, double cost)
        {
            try
            {
                string url = $"{BaseUrl}/api/parts/{partId}";
                var data = new
                {
                    part_name = partName,
                    cost = cost
                };
                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update part: " + ex.Message);
            }
        }

        public static async Task<bool> AddPartAsync(string partName, double cost, string sku, string category, string description, string supplier)
        {
            try
            {
                string url = $"{BaseUrl}/api/parts";
                var data = new
                {
                    tenant_id = 1,
                    part_name = partName,
                    cost = cost,
                    sku = sku,
                    category = category,
                    description = description,
                    supplier = supplier
                };
                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add part: " + ex.Message);
            }
        }

        public static async Task<bool> DeletePartAsync(int partId)
        {
            try
            {
                string url = $"{BaseUrl}/api/parts/{partId}";
                HttpResponseMessage response = await client.DeleteAsync(url);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete part: " + ex.Message);
            }
        }
    }

    public class ApiPart
    {
        public int part_id { get; set; }
        public string part_name { get; set; }
        public double cost { get; set; }
        public string sku { get; set; }
        public string category { get; set; }
        public int quantity_on_hand { get; set; }
    }

    public class ApiResponse
    {
        public bool success { get; set; }
        public List<ApiPart> parts { get; set; }
    }
}