using BlueBank.Domain.Shared.Responses;
using System;

namespace BlueBank.Domain.Core.Responses
{
    class AddHistoryResponse : Response
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public double Value { get; private set; }
        public Client DestinyClient { get; set; }
        public Guid AccountId { get; set; }
    }
}
