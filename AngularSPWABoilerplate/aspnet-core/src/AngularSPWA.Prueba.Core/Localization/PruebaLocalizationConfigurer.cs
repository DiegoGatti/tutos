using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AngularSPWA.Prueba.Localization
{
    public static class PruebaLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PruebaConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PruebaLocalizationConfigurer).GetAssembly(),
                        "AngularSPWA.Prueba.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
