﻿using Jambo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jambo.Domain.ServiceBus
{
    public interface IPublisher : IDisposable
    {
        Task Publish(DomainEvent domainEvent);
        Task Publish(IEnumerable<DomainEvent> domainEvents, Header header);
    }
}
