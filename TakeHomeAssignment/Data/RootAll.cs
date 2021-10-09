﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeHomeAssignment.Data
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Motd
    {
        public string msg { get; set; }
        public string url { get; set; }
    }

    public class Rates
    {
        public double USD { get; set; }
        public double JPY { get; set; }
        public double BGN { get; set; }
        public double CZK { get; set; }
        public double DKK { get; set; }
        public double GBP { get; set; }
        public double HUF { get; set; }
        public double PLN { get; set; }
        public double RON { get; set; }
        public double SEK { get; set; }
        public double CHF { get; set; }
        public double ISK { get; set; }
        public double NOK { get; set; }
        public double HRK { get; set; }
        public double RUB { get; set; }
        public double TRY { get; set; }
        public double AUD { get; set; }
        public double BRL { get; set; }
        public double CAD { get; set; }
        public double CNY { get; set; }
        public double HKD { get; set; }
        public double IDR { get; set; }
        public double ILS { get; set; }
        public double INR { get; set; }
        public double KRW { get; set; }
        public double MXN { get; set; }
        public double MYR { get; set; }
        public double NZD { get; set; }
        public double PHP { get; set; }
        public double SGD { get; set; }
        public double THB { get; set; }
        public double ZAR { get; set; }
        public int EUR { get; set; }
        public double AED { get; set; }
        public double AFN { get; set; }
        public double ALL { get; set; }
        public double ARS { get; set; }
        public double BAM { get; set; }
        public double BBD { get; set; }
        public double BDT { get; set; }
        public double BHD { get; set; }
        public double BIF { get; set; }
        public double BMD { get; set; }
        public double BND { get; set; }
        public double BOB { get; set; }
        public double BSD { get; set; }
        public double BWP { get; set; }
        public double BZD { get; set; }
        public double CLP { get; set; }
        public double COP { get; set; }
        public double CRC { get; set; }
        public double CUP { get; set; }
        public double CVE { get; set; }
        public double DJF { get; set; }
        public double DOP { get; set; }
        public double DZD { get; set; }
        public double EGP { get; set; }
        public double ETB { get; set; }
        public double FJD { get; set; }
        public double GHS { get; set; }
        public double GNF { get; set; }
        public double GTQ { get; set; }
        public double HNL { get; set; }
        public double HTG { get; set; }
        public double IQD { get; set; }
        public double JMD { get; set; }
        public double JOD { get; set; }
        public double KES { get; set; }
        public double KHR { get; set; }
        public double KWD { get; set; }
        public double KYD { get; set; }
        public double KZT { get; set; }
        public double LAK { get; set; }
        public double LBP { get; set; }
        public double LKR { get; set; }
        public double LSL { get; set; }
        public double LYD { get; set; }
        public double MAD { get; set; }
        public double MDL { get; set; }
        public double MGA { get; set; }
        public double MKD { get; set; }
        public double MMK { get; set; }
        public double MOP { get; set; }
        public double MUR { get; set; }
        public double MVR { get; set; }
        public double MWK { get; set; }
        public double NAD { get; set; }
        public double NGN { get; set; }
        public double NIO { get; set; }
        public double NPR { get; set; }
        public double OMR { get; set; }
        public double PAB { get; set; }
        public double PEN { get; set; }
        public double PGK { get; set; }
        public double PKR { get; set; }
        public double PYG { get; set; }
        public double QAR { get; set; }
        public double RSD { get; set; }
        public double RWF { get; set; }
        public double SAR { get; set; }
        public double SCR { get; set; }
        public double SOS { get; set; }
        public double SVC { get; set; }
        public double SZL { get; set; }
        public double TND { get; set; }
        public double TTD { get; set; }
        public double TWD { get; set; }
        public double TZS { get; set; }
        public double UAH { get; set; }
        public double UGX { get; set; }
        public double UYU { get; set; }
        public double UZS { get; set; }
        public double VND { get; set; }
        public double XAF { get; set; }
        public double XOF { get; set; }
        public double XPF { get; set; }
        public double ZMW { get; set; }
    }

    public class RootAll
    {
        public Motd motd { get; set; }
        public bool success { get; set; }
        public bool historical { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }

        public static implicit operator Task<object>(RootAll v)
        {
            throw new NotImplementedException();
        }
    }
}
