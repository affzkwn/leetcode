using System.Numerics;

public static class DiffieHellman
{
    
    private static readonly Random Random = new();

    public static BigInteger PrivateKey(BigInteger primeP)
    {
        // Generate a random number between 2 and p-1 (i.e., 1 < key < p)
        byte[] bytes = new byte[primeP.ToByteArray().Length];
        BigInteger result;
        do
        {
            Random.NextBytes(bytes);
            result = new BigInteger(bytes);
            if (result < 0) result = -result;
        } while (result < 2 || result >= primeP);
        return result;
    }

    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey)
    {
        // Calculate g^privateKey mod p
        return BigInteger.ModPow(primeG, privateKey, primeP);
    }

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey)
    {
        // Calculate publicKey^privateKey mod p
        return BigInteger.ModPow(publicKey, privateKey, primeP);
    }
}