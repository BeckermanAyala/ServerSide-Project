using System;
using System.Collections.Generic;

namespace Dal.Do;

public partial class Subscriber
{
    public int SubscriberId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? City { get; set; } = null;

    public string SubscriptionType { get; set; } = null!;

    public DateTime DateOfSubscription { get; set; }

    public string Password { get; set; } = null!;
}
