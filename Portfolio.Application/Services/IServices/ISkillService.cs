﻿using Portfolio.Application.Models.DTOs;
using Portfolio.Domain.Enums;

namespace Portfolio.Application.Services.IServices
{
    public interface ISkillService
    {
        Task<IEnumerable<SkillDTO>> GetAllSkills();

        Task<SkillDTO> GetSkillById(string id);

        Task<IEnumerable<SkillDTO>> GetSkillsByType(SkillType type);
    }
}