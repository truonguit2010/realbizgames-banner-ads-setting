using ChainPattern;

public class BannerAdSetting_Validator_Result : IAsynPieceResult
{
    public const string PUBLIC_KEY = "BannerAdSetting_Validator_Result";

    private bool _success;

    public BannerAdSetting_Validator_Result(bool success)
    {
        _success = success;
    }

    public bool Success { get => _success; set => _success = value; }

    public string GetKey()
    {
        return PUBLIC_KEY;
    }
}
