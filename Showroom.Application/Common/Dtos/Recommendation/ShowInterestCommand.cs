﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Showroom.Application.Common.Dtos
{
    public class ShowInterestCommand
    {
        [Required]
        public Guid ConsultantId { get; set; }

        public Guid? ConsultantRecommendationId { get; set; }

        public string Message { get; set; }
    }
}
