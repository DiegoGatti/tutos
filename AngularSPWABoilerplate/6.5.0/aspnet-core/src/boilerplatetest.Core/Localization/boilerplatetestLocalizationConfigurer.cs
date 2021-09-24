using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace boilerplatetest.Localization
{
    public static class boilerplatetestLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(boilerplatetestConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(boilerplatetestLocalizationConfigurer).GetAssembly(),
                        "boilerplatetest.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
