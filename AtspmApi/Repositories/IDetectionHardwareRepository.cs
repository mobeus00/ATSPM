﻿using System.Collections.Generic;
using AtspmApi.Models;

namespace AtspmApi.Repositories
{
    public interface IDetectionHardwareRepository
    {
        List<DetectionHardware> GetAllDetectionHardwares();
        List<DetectionHardware> GetAllDetectionHardwaresNoBasic();
        DetectionHardware GetDetectionHardwareByID(int ID);
        void Update(DetectionHardware DetectionHardware);
        void Add(DetectionHardware DetectionHardware);
        void Remove(DetectionHardware DetectionHardware);
    }
}