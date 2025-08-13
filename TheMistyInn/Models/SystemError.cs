﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMistyInn.Enums;

namespace TheMistyInn.Models
{
    public class SystemError<T>
    {
        public int Id { get; set; }
        public Guid? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public T? CreatedBy { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public ErrorType ErrorType { get; set; }

    }
}
