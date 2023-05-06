using Domain.Enums;
using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Offer : BaseEntity
    {
        public ContactPerson ContactPerson { get; set; }
        public Organization Organization { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
        public ValueTypeOfOffer ValueType { get; set; }
        public DateTime ExpectedCloseDate { get; set; }
        public OfferVisibility Visibility { get; set; }
        public OfferStage OfferStage { get; set; }

    }
}
