using RocDKST.Api.Enums;

namespace RocDKST.Api.Models;

public class Subscription
{
    public int Id { get; set; }
    public SubscriptionType SubscriptionType { get; set; }
    public ClassType SubscriptionClassType { get; set; }
}