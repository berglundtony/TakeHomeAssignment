using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TakeHomeAssignment.Data;

namespace TakeHomeAssignment.HttpClients
{
    public interface ITakeHomeClient
    {
     
        //Task<ReturnRateInformation> GetRates(String[] dates, string from, string to);
        Task<ReturnRateInformation> GetRate(String[] dates, string from, string to);
    }
}