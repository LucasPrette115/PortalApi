using System;

namespace Portal.Domain.Specs;

public interface ISpec<in T> where T : class
{
    bool IsSatisfiedBy(T candidate); 
}
