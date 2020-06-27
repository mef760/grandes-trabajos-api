using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GrandesTrabajos.Localization
{
    public static class GrandesTrabajosLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GrandesTrabajosConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GrandesTrabajosLocalizationConfigurer).GetAssembly(),
                        "GrandesTrabajos.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
