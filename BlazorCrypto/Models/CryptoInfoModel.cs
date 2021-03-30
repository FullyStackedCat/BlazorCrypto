namespace BlazorCrypto.Models
{


    public class CryptoInfoModel
    {
        public CoinModel[] Coins { get; set; }
    }

    public class CoinModel
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
    }


}
