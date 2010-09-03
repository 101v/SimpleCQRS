﻿using System;

namespace SimpleCqrs.Eventing
{
    public class DomainEvent
    {
        public Guid AggregateRootId { get; set; }
        public int Sequence { get; set; }
    }
}