using System.Collections.Generic;

public class BannerAdSettingServiceImpl : IBannerAdSettingService
{
    private BannerAdSettingLocalRepository localRepository = new BannerAdSettingLocalRepository("banner_config");
    private BannerAdSettingDTOConvertor BannerAdSettingDTOConvertor = new BannerAdSettingDTOConvertor();

    public BannerAdSettingDTO Get(string id)
    {
        BannerAdSettingEntity entity = localRepository.FindById(id: id);
        BannerAdSettingDTO dto = BannerAdSettingDTOConvertor.From(entity);

        return dto;
    }

    public List<BannerAdSettingDTO> GetAll()
    {
        List<BannerAdSettingEntity> entities = localRepository.FindAll();
        return BannerAdSettingDTOConvertor.From(entities);
    }

    public void init()
    {
        localRepository.init();
    }

    public void lazyInit()
    {
        localRepository.lazyInit();
    }

    public void refresh()
    {
        localRepository.refresh();
    }
}
