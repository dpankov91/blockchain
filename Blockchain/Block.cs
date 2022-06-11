using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{
    internal class Block
    {
        private byte[] _BlockHash;
        private byte[] _PreviousBlockHash;
        private string _Data;
        private int _nonce;

        //only get, cuz when we create a block we should never be able to change it
        public byte[] BlockHash  { get { return _BlockHash; } }

        public byte[] PreviousBlockHash { get { return _PreviousBlockHash; } }

       public string Data { get { return _Data; } }

        public int Nonce { get { return _nonce; } }

        // to get data into the block we use constructor
        public Block(byte[] blockHash, byte[] previousBlockHash, string data, int nonce = 0)
        {
            _BlockHash = blockHash;
            _PreviousBlockHash = previousBlockHash;
            _Data = data;
            _nonce = nonce;
        }
    }
}
