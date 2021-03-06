﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Showroom.Domain.Entities
{
    public class ManagerProfile : UserProfile
    {
        public string Headline { get; set; }

        public string ShortPresentation { get; set; }

        public string Presentation { get; set; }

        public ICollection<ManagerCompetenceArea> ManagerCompetenceAreas { get; set; }

        public ICollection<ConsultantProfile> ConsultantProfiles { get; set; }

        public ICollection<ClientProfile> ClientProfiles { get; set; }

        public ICollection<ClientCase> ClientCases { get; set; }

        public ICollection<ConsultantRecommendation> Recommendations { get; set; }

        [NotMapped]
        public IEnumerable<CompetenceArea> CompetenceAreas2 => ManagerCompetenceAreas?.Select(x => x.CompetenceArea);
    }
}
