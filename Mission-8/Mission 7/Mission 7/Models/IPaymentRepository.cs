﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_7.Models
{
    public interface IPaymentRepository 
    {
        IQueryable<Payment> Payments { get; }

        void SavePayment(Payment payment);
    }
}
