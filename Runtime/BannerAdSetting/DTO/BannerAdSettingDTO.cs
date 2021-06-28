
[System.Serializable]
public class BannerAdSettingDTO
{
    private string id;
    private bool enable;
    private bool isBottom;
    private int reloadIntervalSeconds;
    private string src;

    public string Id { get => id; set => id = value; }
    public bool Enable { get => enable; set => enable = value; }
    public bool IsBottom { get => isBottom; set => isBottom = value; }
    public int ReloadIntervalSeconds { get => reloadIntervalSeconds; set => reloadIntervalSeconds = value; }
    public string Src { get => src; set => src = value; }

    public override string ToString()
    {
        return string.Format("[BannerAdSettingDTO id:{0} enable:{1} isBottom:{2} reloadIntervalSeconds:{3} src:{4}]", id, enable, isBottom, reloadIntervalSeconds, src);
    }
}
