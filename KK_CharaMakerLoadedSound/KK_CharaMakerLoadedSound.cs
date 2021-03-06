﻿using BepInEx;
using Illusion.Game;

namespace KK_CharaMakerLoadedSound
{
    /// <summary>
    /// When Chara Maker starts, wait a bit for lag to stop then play a sound
    /// </summary>
    [BepInPlugin(GUID, PluginName, Version)]
    public class KK_CharaMakerLoadedSound : BaseUnityPlugin
    {
        public const string GUID = "com.deathweasel.bepinex.charamakerloadedsound";
        public const string PluginName = "Character Maker Loaded Sound";
        public const string Version = "1.0";

        void Main() => KKAPI.Maker.MakerAPI.MakerFinishedLoading += (s, e) => Utils.Sound.Play(SystemSE.result_single);
    }
}
