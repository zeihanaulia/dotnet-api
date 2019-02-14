using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace dotnet-api.Localization
{
    public static class dotnet-apiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(dotnet-apiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(dotnet-apiLocalizationConfigurer).GetAssembly(),
                        "dotnet-api.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
