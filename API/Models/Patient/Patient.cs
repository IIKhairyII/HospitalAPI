﻿using API.Models.Common;

namespace API.Models.Patient
{
    public class Patient : CommonInfo
    {
        public List<PatientHistory> History { get; set; }
    }
}
