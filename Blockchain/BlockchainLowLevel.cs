using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{
    //class what interacts with a blocks. Factory that pumps out block after block after block. Controller by BlockchainHighLevel.cs
    //static cuz servile utility class(рабский служебный класс)
    static internal class BlockchainLowLevel
    {
        const string GenesisBlockText = "GenesisBlock";
        public static Block CreateGenesisBlock()
        {
            //set it all to zero
            byte[] PreviousBlockHash = BitConverter.GetBytes(0);
            byte[] Blockhash = HashBLock(PreviousBlockHash, GenesisBlockText, 0);

            Block GenesisBlock = new Block(Blockhash, PreviousBlockHash, GenesisBlockText, 0);

            return GenesisBlock;
        }

        //return a new hash from prevBlockHash, Data, Nonce
        public static byte[] HashBLock(byte[] PreviousBlockHash, string BlockData, int Nonce)
        {
            string PreviousHashString = BitConverter.ToString(PreviousBlockHash);
            string NonceString = Nonce.ToString();
            string CompleteBlock = PreviousHashString + NonceString + BlockData;

            //can use sha256, for example sha1 is good, its fast
            byte[] NewBlockHash = SHA1.HashData(Encoding.ASCII.GetBytes(CompleteBlock));
            return NewBlockHash;
        }
    }
}
