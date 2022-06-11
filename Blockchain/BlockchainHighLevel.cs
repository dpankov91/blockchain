using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{
    //Facade that will talk with lowlevel blockchain factory
    internal class BlockchainHighLevel
    {
        LinkedList<Block> _BlockChain;

        public LinkedList<Block> Blockchain { get { return _BlockChain; } }

        // Spin up a blockchain and add a genesis block as a first block
        public BlockchainHighLevel()
        {
            _BlockChain = new LinkedList<Block>();
            _BlockChain.AddLast(BlockchainLowLevel.CreateGenesisBlock());
        }

        public void AddBlock(string DataToAdd)
        {
            //Create a new block hash
            byte[] NewBlockHash = BlockchainLowLevel.HashBLock(_BlockChain.Last.Value.BlockHash, DataToAdd, 0);
            //Create a new block
            Block NewBlock = new Block(NewBlockHash, _BlockChain.Last.Value.BlockHash, DataToAdd);
            //Add it to chain
            _BlockChain.AddLast(NewBlock);
        }
    }
}
