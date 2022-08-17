using Newtonsoft.Json;
using Queue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Service
{
    public class CallAPI
    {
        public static string Authenticate()
        {

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri("http://10.36.11.141:45/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new
                         MediaTypeWithQualityHeaderValue("application/json"));
                string username = "admin";
                string password = "Hmtd@1234";


                var values = new Dictionary<string, string>
                            {
                                { "username", username },
                                { "password", password }
                            };
                var content = new FormUrlEncodedContent(values);
                HttpResponseMessage response = client.PostAsync("api/Login/Authenticate",
               content).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
        public static List<DSBenhNhan> GetSoThuTuTrongNgayAll()
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token[1]);
            HttpResponseMessage response =  
                 client.GetAsync("api/OutpatientQueue/GetSoThuTuTrongNgayAll").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var lstBenhNhan = JsonConvert.DeserializeObject<List<DSBenhNhan>>(json);
            return lstBenhNhan;
        }

        public static List<DSBenhNhan> GetSoThuTuTrongNgay(string phongban_id)
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/GetSoThuTuTrongNgay?phongbans=" + phongban_id).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var lstBenhNhan = JsonConvert.DeserializeObject<List<DSBenhNhan>>(json);
            return lstBenhNhan;
        }

        public static List<DM_PhongBan> GetDMPhongBans()
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/GetDMPhongBans").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var lstPhongBan = JsonConvert.DeserializeObject<List<DM_PhongBan>>(json);
            return lstPhongBan;
        }

        public static string SoThuTu_DangXuLy(int id)
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/SoThuTu_DangXuLy?id=" + id).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var stt = JsonConvert.DeserializeObject<string>(json);
            return stt;
        }

        public static List<DSDangXuLi> GetSoThuTuTrongNgay_DangXuLy()
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/GetSoThuTuTrongNgay_DangXuLy").Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var lstDangXuLi = JsonConvert.DeserializeObject<List<DSDangXuLi>>(json);
            return lstDangXuLi;
        }

        public static string SoThuTu_Uutien(int id)
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/SoThuTu_Uutien?id=" + id).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var stt = JsonConvert.DeserializeObject<string>(json);
            return stt;
        }

        public static string SoThuTu_HuyXuLy(int id)
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/SoThuTu_HuyXuLy?id=" + id).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var stt = JsonConvert.DeserializeObject<string>(json);
            return stt;
        }

        public static string SoThuTu_Goi(int id)
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/SoThuTu_Goi?id=" + id).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var stt = JsonConvert.DeserializeObject<string>(json);
            return stt;
        }

        public static string SoThuTu_HuyGoi(int id)
        {
            string[] token = Authenticate().Split('\"');
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://10.36.11.141:45/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token[1]);
            HttpResponseMessage response =
                 client.GetAsync("api/OutpatientQueue/SoThuTu_HuyGoi?id=" + id).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var stt = JsonConvert.DeserializeObject<string>(json);
            return stt;
        }
    }
}
