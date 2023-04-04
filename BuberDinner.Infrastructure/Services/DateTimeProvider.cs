using BuberDinner.Application.Common.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        DateTime IDateTimeProvider.UtcNow => throw new NotImplementedException();
    }
}
