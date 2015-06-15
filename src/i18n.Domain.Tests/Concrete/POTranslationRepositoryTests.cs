using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using i18n.Domain.Concrete;
using i18n.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace i18n.Domain.Concrete.Tests
{
    [TestClass()]
    public class POTranslationRepositoryTests
    {
        [TestMethod()]
        [DeploymentItem("App.config")]
        public void SaveTranslationTest()
        {
            var msgid = "as you \ncan see";
            var msgstr = "as you \ncan see it";
            var msgref = "my.aspx.cs:1745";
            var msgcomment = "test case";
            var settings = new i18nSettings(new WebConfigSettingService("App.config"));
            settings.InitialLanguage = "en";
            settings.DirectoriesToScan = new[] { Directory.GetCurrentDirectory() };
            settings.LocaleDirectory = "locale";
            settings.AvailableLanguages = new[] { "en", "ru", "de" };
            var pot = new POTranslationRepository(settings);
            var items = new Dictionary<String, TemplateItem>();
            items.Add(msgid, new TemplateItem
            {
                MsgId = msgid,
                MsgKey = msgid,
                Comments = new List<String> { msgcomment },
                References = new List<String> { msgref }
            });
            pot.SaveTemplate(items);
            new TranslationMerger(pot).MergeAllTranslation(items);
            var translation = pot.GetTranslation(pot.GetAvailableLanguages().First().LanguageShortTag);
            var msg = translation.Items[msgid];
            Assert.AreEqual("", msg.Messages.First());

            msg.Messages = new[] { msgstr };
            pot.SaveTranslation(translation);
            translation = pot.GetTranslation(pot.GetAvailableLanguages().First().LanguageShortTag);
            msg = translation.Items[msgid];
            Assert.AreEqual(msgstr, msg.Messages.First());
        }

        [DeploymentItem("App.config")]
        [TestMethod()]
        public void SavePluralTranslationTest()
        {
            var msgid = "as you \ncan see me";
            var msgplural = "as you \ncan see us";
            var msgref = "my.aspx.cs:1745";
            var msgcomment = "test case";
            var msgstr1 = "as you \ncan see it 1";
            var msgstr2 = "as you \ncan see it 2";
            var settings = new i18nSettings(new WebConfigSettingService("App.config"));
            settings.InitialLanguage = "en";
            settings.DirectoriesToScan = new[] { Directory.GetCurrentDirectory() };
            settings.LocaleDirectory = "locale";
            settings.AvailableLanguages = new[] { "en", "ru", "de" };
            var pot = new POTranslationRepository(settings);
            var items = new Dictionary<String, TemplateItem>();
            items.Add(msgid, new TemplateItem
            {
                MsgId = msgid,
                MsgKey = msgid,
                MsgIdPlural = msgplural,
                Comments = new List<String> { msgcomment },
                References = new List<String> { msgref }
            });
            pot.SaveTemplate(items);
            new TranslationMerger(pot).MergeAllTranslation(items);
            var translation = pot.GetTranslation(pot.GetAvailableLanguages().First().LanguageShortTag);
            var msg = translation.Items[msgid];
            Assert.AreEqual("", msg.Messages.First());

            msg.Messages = new[] { msgstr1, msgstr2 };
            pot.SaveTranslation(translation);
            translation = pot.GetTranslation(pot.GetAvailableLanguages().First().LanguageShortTag);
            msg = translation.Items[msgid];
            Assert.AreEqual(msgstr1, msg.Messages.First());
            Assert.AreEqual(msgstr2, msg.Messages.Last());

            msgstr1 = msgstr1.Replace("\n","");
            msgstr2 = msgstr2.Replace("\n", "");
            msg.Messages = new[] { msgstr1, msgstr2 };
            pot.SaveTranslation(translation);
            translation = pot.GetTranslation(pot.GetAvailableLanguages().First().LanguageShortTag);
            msg = translation.Items[msgid];
            Assert.AreEqual(msgstr1, msg.Messages.First());
            Assert.AreEqual(msgstr2, msg.Messages.Last());
        }
    }
}
