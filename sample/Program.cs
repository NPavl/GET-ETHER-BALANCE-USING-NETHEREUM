using System;
using System.Threading.Tasks;
using Nethereum.Web3;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAccountBalance().Wait();
            Console.ReadLine();
        }

        static async Task GetAccountBalance()
        {
            var web3 = new Web3("https://ropsten.infura.io/v3/4a95227010b5463cb0f56ecee2556266");
            var balance = await web3.Eth.GetBalance.SendRequestAsync("0xaF3f0ba2848093D6eEaF4109bfD9A9FbbBA1f470");

            Console.WriteLine($"Balance in Wei: {balance.Value}");

            var etherAmount = Web3.Convert.FromWei(balance.Value);
            Console.WriteLine($"Balance in Ether: {etherAmount}");
        }
    }
}
 