﻿namespace Cqrs.Common.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class GenericFetchStrategy<T> : IFetchStrategy<T>
    {
        private readonly IList<string> _properties = new List<string>();

        public IEnumerable<string> IncludePaths => _properties;

        public GenericFetchStrategy(Expression<Func<T, object>> path) 
        {
            _properties.Add(path.ToPropertyName());
        }
    }
}