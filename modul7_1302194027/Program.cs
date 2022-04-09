using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

class BankTransferConfig
{
    public string lang { get; set; }
    public transfer transfer { get; set; }
    public string methods { get; set; }
    public confirmation confirmation { get; set; }

    public static void ReadJson()
    {
        using (StreamReader r = new StreamReader("bank_transfer_config.json"))
        {
            string json = r.ReadToEnd();
            BankTransferConfig items = JsonConvert.DeserializeObject<BankTransferConfig>(json);

            Console.WriteLine("{0}", items.lang);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BankTransferConfig.ReadJson();
    }
}

public class transfer
{
    public string threshold { get; set;  }
    public string low_fee { get; set; }
    public string high_fee { get; set; }
}

public class confirmation
{
    public string yes { get; set; }
    public string ya{ get; set; }
}