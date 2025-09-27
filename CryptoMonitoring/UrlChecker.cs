using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMonitoring
{
    public static class UrlChecker
    {
        public static async Task<bool> IsValidHttpUrlAsync(string name)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    DateTime todayUtc = DateTime.UtcNow.Date;
                    long startTime = new DateTimeOffset(todayUtc).ToUnixTimeMilliseconds();
                    var response = await client.GetAsync($"https://api.binance.com/api/v3/klines?symbol=" + name.ToUpper() + $"USDT&interval=1m&startTime={startTime}&limit=1000");

                    if (!response.IsSuccessStatusCode)
                    {
                        return false;
                    }
                    var content = await response.Content.ReadAsStringAsync();
                    return true;
                }
            }


            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<bool> IsValidWebSocketUrlAsync(string name)
        {
            try
            {
                using (var ws = new ClientWebSocket())
                {
                    var uri = new Uri("wss://stream.binance.com:9443/ws/"+ name.ToLower() +"usdt@trade");
                    await ws.ConnectAsync(uri, CancellationToken.None);

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
