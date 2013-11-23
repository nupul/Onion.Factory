﻿namespace Onion.Factory.Core.Domain
{
    using System;

    public class Layer
    {
        public Layer()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}