using Nancy.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.XSSF.Streaming.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TakeHomeAssignment.Data;

namespace TakeHomeAssignment.HttpClients
{
    public class TakeHomeClient : BaseClient, ITakeHomeClient
    {
        public TakeHomeClient(HttpClient httpClients) : base(httpClients, new Uri("https://api.exchangerate.host/"))
        {
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ReturnRateInformation> GetRate(string[] dates, string from, string to)
        {
            List<RatesAtDates> _currency_rate = new List<RatesAtDates>();
            List<Root> _result = new List<Root>();
            double maxRate, minRate, avarageRate;
            string maxdate, mindate;

            for (int i = 0; i < dates.Length; i++)
            {
                _result.Add(await GetAsync<Root>($"/convert?from={from}&to={to}&date={dates[i]}"));
            }
            CurrentRate(_currency_rate, _result);
            GetRates(_currency_rate, out maxRate, out minRate, out avarageRate);
            GetDates(_currency_rate, maxRate, minRate, out maxdate, out mindate);

            ReturnRateInformation rateresult = GetResult(maxRate, minRate, avarageRate, maxdate, mindate);

            return rateresult;
        }

        private static void CurrentRate(List<RatesAtDates> _currency_rate, List<Root> _result)
        {
            foreach (var res in _result)
            {
                var currentrate = res.info.rate;
                var date = res.date;
                var targetcurrency = res.query.to;
                _currency_rate.Add(new RatesAtDates { Date = date, Currency = targetcurrency, Rate = currentrate });
            }
        }

        private static void GetRates(List<RatesAtDates> _currency_rate, out double maxRate, out double minRate, out double avarageRate)
        {
            double[] dataX = _currency_rate.Select(c => c.Rate).ToArray();

            maxRate = dataX.Max();
            minRate = dataX.Min();
            double sumRate = 0;
            foreach (var rate in dataX)
            {
                sumRate += rate;
            }
            avarageRate = sumRate / dataX.Count();
        }

        private static void GetDates(List<RatesAtDates> _currency_rate, double maxRate, double minRate, out string maxdate, out string mindate)
        {
            maxdate = _currency_rate.Where(c => c.Rate == maxRate).Select(d => d.Date).FirstOrDefault();
            mindate = _currency_rate.Where(c => c.Rate == minRate).Select(d => d.Date).FirstOrDefault();
        }

        private static ReturnRateInformation GetResult(double maxRate, double minRate, double avarageRate, string maxdate, string mindate)
        {
            return new ReturnRateInformation
            {
                MinRateText = "A min rate of ",
                MinRate = minRate,
                OnMin = " on ",
                MinDate = mindate,
                MaxRateText = " A max rate of ",
                MaxRate = maxRate,
                OnMax = " on ",
                MaxDate = maxdate,
                AvarageRateText = "An avarage rate of ",
                AvarageRate = avarageRate
            };
        }
    }
}

