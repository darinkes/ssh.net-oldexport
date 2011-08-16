using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Security
{
    /// <summary>
    /// Represents base class for AES based encryption.
    /// </summary>
    public class CipherBlowfish : Cipher
    {
        /// <summary>
        /// Gets algorithm name.
        /// </summary>
        public override string Name
        {
            get { return "blowfish-cbc"; }
        }

        /// <summary>
        /// Gets or sets the key size, in bits, of the secret key used by the cipher.
        /// </summary>
        /// <value>
        /// The key size, in bits.
        /// </value>
        public override int KeySize
        {
            get
            {
                return 16 * 8;
            }
        }

        /// <summary>
        /// Gets or sets the block size, in bits, of the cipher operation.
        /// </summary>
        /// <value>
        /// The block size, in bits.
        /// </value>
        public override int BlockSize
        {
            get
            {
                return 8;
            }
        }

        /// <summary>
        /// Creates the encryptor.
        /// </summary>
        /// <returns></returns>
        protected override ModeBase CreateEncryptor()
        {
            return new CbcMode(new BlowfishCipher(this.Key.Take(this.KeySize / 8).ToArray(), this.Vector.Take(this.BlockSize).ToArray()));
        }

        /// <summary>
        /// Creates the decryptor.
        /// </summary>
        /// <returns></returns>
        protected override ModeBase CreateDecryptor()
        {
            return new CbcMode(new BlowfishCipher(this.Key.Take(this.KeySize / 8).ToArray(), this.Vector.Take(this.BlockSize).ToArray()));
        }
    }
}
