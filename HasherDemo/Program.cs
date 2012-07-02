using System;
using Hasher;

namespace HasherDemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string stringToHash = "helloWorld";
            string salt;
            var hasher = new StringHasher();

            var md5Hash = hasher.MD5ComputeHash(stringToHash);
            Console.WriteLine(md5Hash);
            Console.WriteLine(md5Hash.Length);
            Console.WriteLine(hasher.MD5VerifyHash(stringToHash, md5Hash));
            md5Hash = hasher.MD5SaltComputeHash(stringToHash, out salt);
            Console.WriteLine(md5Hash);
            Console.WriteLine(md5Hash.Length);
            Console.WriteLine(hasher.MD5SaltVerifyHash(stringToHash, md5Hash, salt));

            var sha256Hash = hasher.SHA256ComputeHash(stringToHash);
            Console.WriteLine(sha256Hash);
            Console.WriteLine(sha256Hash.Length);
            Console.WriteLine(hasher.SHA256VerifyHash(stringToHash, sha256Hash));
            sha256Hash = hasher.SHA256SaltComputeHash(stringToHash, out salt);
            Console.WriteLine(sha256Hash);
            Console.WriteLine(sha256Hash.Length);
            Console.WriteLine(hasher.SHA256SaltVerifyHash(stringToHash, sha256Hash, salt));

            var sha512Hash = hasher.SHA512ComputeHash(stringToHash);
            Console.WriteLine(sha512Hash);
            Console.WriteLine(sha512Hash.Length);
            Console.WriteLine(hasher.SHA512VerifyHash(stringToHash, sha512Hash));
            sha512Hash = hasher.SHA512SaltComputeHash(stringToHash, out salt);
            Console.WriteLine(sha512Hash);
            Console.WriteLine(sha512Hash.Length);
            Console.WriteLine(hasher.SHA512SaltVerifyHash(stringToHash, sha512Hash, salt));

            Console.ReadKey();
        }
    }
}
