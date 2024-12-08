﻿using Data;

namespace Server.Services
{
    public interface ISinhVienServices
    {
        Task<List<SinhVien>> GetAll();
        Task<SinhVien> GetById(int id);
        Task Create(SinhVien sv);
        Task Update(SinhVien sv);
        Task Delete(int id);
    }
}
