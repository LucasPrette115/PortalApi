using System;
using System.ComponentModel;

namespace Portal.Domain.Validations;

public interface IValidate
{
    bool IsValid();
}
