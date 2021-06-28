using System.Collections.Generic;

public class BannerAdSettingDTOConvertor : IDataConvertor<BannerAdSettingEntity, BannerAdSettingDTO>
{
    public BannerAdSettingDTO From(BannerAdSettingEntity f)
    {
        BannerAdSettingDTO dto = new BannerAdSettingDTO();

        dto.Id = f.id;
        dto.Enable = f.enable == 1;
        dto.IsBottom = f.isBottom == 1;
        dto.ReloadIntervalSeconds = f.reloadIntervalSeconds;
        dto.Src = f.src;

        return dto;
    }

    public List<BannerAdSettingDTO> From(List<BannerAdSettingEntity> fs)
    {
        List<BannerAdSettingDTO> dtos = new List<BannerAdSettingDTO>();

        foreach (var item in fs)
        {
            dtos.Add(From(item));
        }

        return dtos;
    }
}
