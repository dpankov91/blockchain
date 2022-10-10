using System;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a blockchain and add some transactions
            BlockchainHighLevel BE = new BlockchainHighLevel();

            BE.AddBlock("Arnold pays for trip to USA 20BTC");
            BE.AddBlock("Bobby Green pays 10BTC for Spa Resort");
            BE.AddBlock("Diana pays 15BTC for Dog food");

            int itemNumber = 0;
            foreach (var item in BE.Blockchain)
            {

                Console.WriteLine("---------------------------");
                Console.WriteLine("Block Height: " + itemNumber);
                Console.WriteLine("Block Hash: " + BitConverter.ToString(item.BlockHash));
                Console.WriteLine("Previous Hash: " + BitConverter.ToString(item.PreviousBlockHash));
                Console.WriteLine("Transaction Data: " + item.Data);
                Console.WriteLine("---------------------------");
                Console.WriteLine("");
                itemNumber++;
            }
        }
    }
}
