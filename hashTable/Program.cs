public class myHashTable
{
    private Dictionary<byte, string> table;

    public myHashTable()
    {
        table = new Dictionary<byte, string>();
    }

    public byte Add(string word)
    {
        byte hash = CalculateMyHash(word);
        table[hash] = word;
        return hash;
    }

    public string Get(byte hash)
    {
        if (table.ContainsKey(hash))
        {
            return table[hash];
        }
        else
        {
            return "ERROR 404  Word not found";
        }
    }
    
    private byte CalculateMyHash(string word)
    {
        byte hash = 0;

        foreach (byte b in word)
        {
            hash += b; 
        }
        return hash;
    }
}

class Program
{
    static void Main()
    {
        myHashTable myhashTable = new myHashTable();

        byte hash1 = myhashTable.Add("apple");
        byte hash2 = myhashTable.Add("banana");
        byte hash3 = myhashTable.Add("cherry");

        Console.WriteLine($"Слово за хешем {hash1}: {myhashTable.Get(hash1)}");
        Console.WriteLine($"Слово за хешем {hash2}: {myhashTable.Get(hash2)}");
        Console.WriteLine($"Слово за хешем {hash3}: {myhashTable.Get(hash3)}");
    }
}
