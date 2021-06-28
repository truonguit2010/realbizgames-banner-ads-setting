using System.Collections.Generic;
using UnityEngine;
using ChainPattern;

public class BannerAdSetting_Validator : IAsynPieceExecutor
{
    const string TAG = "BannerAdSetting_Validator";

    private IBannerAdSettingService service;
    // ------------------------------------------------------
    public bool IsDone => _result != null;
    // ------------------------------------------------------
    public IAsynPieceResult Result => _result;
    private BannerAdSetting_Validator_Result _result;
    // ------------------------------------------------------
    public BannerAdSetting_Validator(IBannerAdSettingService service)
    {
        this.service = service;
    }

    public void Execute(IAsynChainResult data)
    {
        Debug.LogFormat("{0} - Execute", TAG);

        List<BannerAdSettingDTO> dtos = service.GetAll();

        // #if UNITY_EDITOR
        string msg = ToStringForList(dtos);
        Debug.LogFormat("{0} - {1}", TAG, msg);
        // #endif

        _result = new BannerAdSetting_Validator_Result(success: true);

        Debug.LogFormat("{0} - End", TAG);
    }

    public static string ToStringForList<T>(List<T> l)
    {
        string message = "Total: " + l.Count + "\n";
        foreach (T o in l)
        {
            message += o.ToString() + "\n";
        }
        return message;
    }
}