using System;
using System.Collections.Generic;

namespace i18n.Domain.Entities
{
    public static class PluralsDictionary
    {
        static readonly Dictionary<string, string> Plurals = new Dictionary<string, string>
        {
            {"ach", "nplurals=2; plural=(n > 1);"},
            {"af", "nplurals=2; plural=(n != 1);"},
            {"ak", "nplurals=2; plural=(n > 1);"},
            {"am", "nplurals=2; plural=(n > 1);"},
            {"an", "nplurals=2; plural=(n != 1);"},
            {"anp", "nplurals=2; plural=(n != 1);"},
            {"ar", "nplurals=6; plural=(n==0 ? 0 : n==1 ? 1 : n==2 ? 2 : n%100>=3 && n%100<=10 ? 3 : n%100>=11 ? 4 : 5);"},
            {"arn", "nplurals=2; plural=(n > 1);"},
            {"as", "nplurals=2; plural=(n != 1);"},
            {"ast", "nplurals=2; plural=(n != 1);"},
            {"ay", "nplurals=1; plural=0;"},
            {"az", "nplurals=2; plural=(n != 1);"},
            {"be", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"bg", "nplurals=2; plural=(n != 1);"},
            {"bn", "nplurals=2; plural=(n != 1);"},
            {"bo", "nplurals=1; plural=0;"},
            {"br", "nplurals=2; plural=(n > 1);"},
            {"brx", "nplurals=2; plural=(n != 1);"},
            {"bs", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"ca", "nplurals=2; plural=(n != 1);"},
            {"cgg", "nplurals=1; plural=0;"},
            {"cs", "nplurals=3; plural=(n==1) ? 0 : (n>=2 && n<=4) ? 1 : 2;"},
            {"csb", "nplurals=3; plural=(n==1) ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2;"},
            {"cy", "nplurals=4; plural=(n==1) ? 0 : (n==2) ? 1 : (n != 8 && n != 11) ? 2 : 3;"},
            {"da", "nplurals=2; plural=(n != 1);"},
            {"de", "nplurals=2; plural=(n != 1);"},
            {"doi", "nplurals=2; plural=(n != 1);"},
            {"dz", "nplurals=1; plural=0;"},
            {"el", "nplurals=2; plural=(n != 1);"},
            {"en", "nplurals=2; plural=(n != 1);"},
            {"eo", "nplurals=2; plural=(n != 1);"},
            {"es", "nplurals=2; plural=(n != 1);"},
            {"es_AR", "nplurals=2; plural=(n != 1);"},
            {"et", "nplurals=2; plural=(n != 1);"},
            {"eu", "nplurals=2; plural=(n != 1);"},
            {"fa", "nplurals=1; plural=0;"},
            {"ff", "nplurals=2; plural=(n != 1);"},
            {"fi", "nplurals=2; plural=(n != 1);"},
            {"fil", "nplurals=2; plural=(n > 1);"},
            {"fo", "nplurals=2; plural=(n != 1);"},
            {"fr", "nplurals=2; plural=(n > 1);"},
            {"fur", "nplurals=2; plural=(n != 1);"},
            {"fy", "nplurals=2; plural=(n != 1);"},
            {"ga", "nplurals=5; plural=(n==1) ? 0 : n==2 ? 1 : n<7 ? 2 : n<11 ? 3 : 4;"},
            {"gd", "nplurals=4; plural=(n==1 || n==11) ? 0 : (n==2 || n==12) ? 1 : (n > 2 && n < 20) ? 2 : 3;"},
            {"gl", "nplurals=2; plural=(n != 1);"},
            {"gu", "nplurals=2; plural=(n != 1);"},
            {"gun", "nplurals=2; plural=(n > 1);"},
            {"ha", "nplurals=2; plural=(n != 1);"},
            {"he", "nplurals=2; plural=(n != 1);"},
            {"hi", "nplurals=2; plural=(n != 1);"},
            {"hne", "nplurals=2; plural=(n != 1);"},
            {"hy", "nplurals=2; plural=(n != 1);"},
            {"hr", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"hu", "nplurals=2; plural=(n != 1);"},
            {"ia", "nplurals=2; plural=(n != 1);"},
            {"id", "nplurals=1; plural=0;"},
            {"is", "nplurals=2; plural=(n%10!=1 || n%100==11);"},
            {"it", "nplurals=2; plural=(n != 1);"},
            {"ja", "nplurals=1; plural=0;"},
            {"jbo", "nplurals=1; plural=0;"},
            {"jv", "nplurals=2; plural=(n != 0);"},
            {"ka", "nplurals=1; plural=0;"},
            {"kk", "nplurals=1; plural=0;"},
            {"kl", "nplurals=2; plural=(n != 1);"},
            {"km", "nplurals=1; plural=0;"},
            {"kn", "nplurals=2; plural=(n != 1);"},
            {"ko", "nplurals=1; plural=0;"},
            {"ku", "nplurals=2; plural=(n != 1);"},
            {"kw", "nplurals=4; plural=(n==1) ? 0 : (n==2) ? 1 : (n == 3) ? 2 : 3;"},
            {"ky", "nplurals=1; plural=0;"},
            {"lb", "nplurals=2; plural=(n != 1);"},
            {"ln", "nplurals=2; plural=(n > 1);"},
            {"lo", "nplurals=1; plural=0;"},
            {"lt", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n%10>=2 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"lv", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n != 0 ? 1 : 2);"},
            {"mai", "nplurals=2; plural=(n != 1);"},
            {"mfe", "nplurals=2; plural=(n > 1);"},
            {"mg", "nplurals=2; plural=(n > 1);"},
            {"mi", "nplurals=2; plural=(n > 1);"},
            {"mk", "nplurals=2; plural= n==1 || n%10==1 ? 0 : 1; Can’t be correct needs a 2 somewhere"},
            {"ml", "nplurals=2; plural=(n != 1);"},
            {"mn", "nplurals=2; plural=(n != 1);"},
            {"mni", "nplurals=2; plural=(n != 1);"},
            {"mnk", "nplurals=3; plural=(n==0 ? 0 : n==1 ? 1 : 2);"},
            {"mr", "nplurals=2; plural=(n != 1);"},
            {"ms", "nplurals=1; plural=0;"},
            {"mt", "nplurals=4; plural=(n==1 ? 0 : n==0 || ( n%100>1 && n%100<11) ? 1 : (n%100>10 && n%100<20 ) ? 2 : 3);"},
            {"my", "nplurals=1; plural=0;"},
            {"nah", "nplurals=2; plural=(n != 1);"},
            {"nap", "nplurals=2; plural=(n != 1);"},
            {"nb", "nplurals=2; plural=(n != 1);"},
            {"ne", "nplurals=2; plural=(n != 1);"},
            {"nl", "nplurals=2; plural=(n != 1);"},
            {"se", "nplurals=2; plural=(n != 1);"},
            {"nn", "nplurals=2; plural=(n != 1);"},
            {"no", "nplurals=2; plural=(n != 1);"},
            {"nso", "nplurals=2; plural=(n != 1);"},
            {"oc", "nplurals=2; plural=(n > 1);"},
            {"or", "nplurals=2; plural=(n != 1);"},
            {"ps", "nplurals=2; plural=(n != 1);"},
            {"pa", "nplurals=2; plural=(n != 1);"},
            {"pap", "nplurals=2; plural=(n != 1);"},
            {"pl", "nplurals=3; plural=(n==1 ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"pms", "nplurals=2; plural=(n != 1);"},
            {"pt", "nplurals=2; plural=(n != 1);"},
            {"pt_BR", "nplurals=2; plural=(n > 1);"},
            {"rm", "nplurals=2; plural=(n != 1);"},
            {"ro", "nplurals=3; plural=(n==1 ? 0 : (n==0 || (n%100 > 0 && n%100 < 20)) ? 1 : 2);"},
            {"ru", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"rw", "nplurals=2; plural=(n != 1);"},
            {"sah", "nplurals=1; plural=0;"},
            {"sat", "nplurals=2; plural=(n != 1);"},
            {"sco", "nplurals=2; plural=(n != 1);"},
            {"sd", "nplurals=2; plural=(n != 1);"},
            {"si", "nplurals=2; plural=(n != 1);"},
            {"sk", "nplurals=3; plural=(n==1) ? 0 : (n>=2 && n<=4) ? 1 : 2;"},
            {"sl", "nplurals=4; plural=(n%100==1 ? 1 : n%100==2 ? 2 : n%100==3 || n%100==4 ? 3 : 0);"},
            {"so", "nplurals=2; plural=(n != 1);"},
            {"son", "nplurals=2; plural=(n != 1);"},
            {"sq", "nplurals=2; plural=(n != 1);"},
            {"sr", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"su", "nplurals=1; plural=0;"},
            {"sw", "nplurals=2; plural=(n != 1);"},
            {"sv", "nplurals=2; plural=(n != 1);"},
            {"ta", "nplurals=2; plural=(n != 1);"},
            {"te", "nplurals=2; plural=(n != 1);"},
            {"tg", "nplurals=2; plural=(n > 1);"},
            {"ti", "nplurals=2; plural=(n > 1);"},
            {"th", "nplurals=1; plural=0;"},
            {"tk", "nplurals=2; plural=(n != 1);"},
            {"tr", "nplurals=2; plural=(n > 1);"},
            {"tt", "nplurals=1; plural=0;"},
            {"ug", "nplurals=1; plural=0;"},
            {"uk", "nplurals=3; plural=(n%10==1 && n%100!=11 ? 0 : n%10>=2 && n%10<=4 && (n%100<10 || n%100>=20) ? 1 : 2);"},
            {"ur", "nplurals=2; plural=(n != 1);"},
            {"uz", "nplurals=2; plural=(n > 1);"},
            {"vi", "nplurals=1; plural=0;"},
            {"wa", "nplurals=2; plural=(n > 1);"},
            {"wo", "nplurals=1; plural=0;"},
            {"yo", "nplurals=2; plural=(n != 1);"},
            {"zh", "nplurals=2; plural=(n > 1);"}
        };

        /// <summary>
        /// return plural header string for selected lang code
        /// reference http://docs.translatehouse.org/projects/localization-guide/en/latest/l10n/pluralforms.html?id=l10n/pluralforms
        /// </summary>
        /// <param name="langCode">ISO lan code (e.g. en, fr, de)</param>
        /// <returns>plural string (e.g. "nplurals=2; plural=(n != 1);")</returns>
        public static String Get(string langCode)
        {
            return Plurals[langCode];
        }

        public static int calcPluralIndex(string langCode, int n)
        {
            switch (langCode)
            {
                case "ach": return (n > 1) ? 1 : 0;
                case "af": return (n != 1) ? 1 : 0;
                case "ak": return (n > 1) ? 1 : 0;
                case "am": return (n > 1) ? 1 : 0;
                case "an": return (n != 1) ? 1 : 0;
                case "anp": return (n != 1) ? 1 : 0;
                case "ar": return (n == 0 ? 0 : n == 1 ? 1 : n == 2 ? 2 : n % 100 >= 3 && n % 100 <= 10 ? 3 : n % 100 >= 11 ? 4 : 5);
                case "arn": return (n > 1) ? 1 : 0;
                case "as": return (n != 1) ? 1 : 0;
                case "ast": return (n != 1) ? 1 : 0;
                case "ay": return 0;
                case "az": return (n != 1) ? 1 : 0;
                case "be": return (n % 10 == 1 && n % 100 != 11 ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "bg": return (n != 1) ? 1 : 0;
                case "bn": return (n != 1) ? 1 : 0;
                case "bo": return 0;
                case "br": return (n > 1) ? 1 : 0;
                case "brx": return (n != 1) ? 1 : 0;
                case "bs": return (n % 10 == 1 && n % 100 != 11 ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "ca": return (n != 1) ? 1 : 0;
                case "cgg": return 0;
                case "cs": return (n == 1) ? 0 : (n >= 2 && n <= 4) ? 1 : 2;
                case "csb": return (n == 1) ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2;
                case "cy": return (n == 1) ? 0 : (n == 2) ? 1 : (n != 8 && n != 11) ? 2 : 3;
                case "da": return (n != 1) ? 1 : 0;
                case "de": return (n != 1) ? 1 : 0;
                case "doi": return (n != 1) ? 1 : 0;
                case "dz": return 0;
                case "el": return (n != 1) ? 1 : 0;
                case "en": return (n != 1) ? 1 : 0;
                case "eo": return (n != 1) ? 1 : 0;
                case "es": return (n != 1) ? 1 : 0;
                case "es_AR": return (n != 1) ? 1 : 0;
                case "et": return (n != 1) ? 1 : 0;
                case "eu": return (n != 1) ? 1 : 0;
                case "fa": return 0;
                case "ff": return (n != 1) ? 1 : 0;
                case "fi": return (n != 1) ? 1 : 0;
                case "fil": return (n > 1) ? 1 : 0;
                case "fo": return (n != 1) ? 1 : 0;
                case "fr": return (n > 1) ? 1 : 0;
                case "fur": return (n != 1) ? 1 : 0;
                case "fy": return (n != 1) ? 1 : 0;
                case "ga": return (n == 1) ? 0 : n == 2 ? 1 : n < 7 ? 2 : n < 11 ? 3 : 4;
                case "gd": return (n == 1 || n == 11) ? 0 : (n == 2 || n == 12) ? 1 : (n > 2 && n < 20) ? 2 : 3;
                case "gl": return (n != 1) ? 1 : 0;
                case "gu": return (n != 1) ? 1 : 0;
                case "gun": return (n > 1) ? 1 : 0;
                case "ha": return (n != 1) ? 1 : 0;
                case "he": return (n != 1) ? 1 : 0;
                case "hi": return (n != 1) ? 1 : 0;
                case "hne": return (n != 1) ? 1 : 0;
                case "hy": return (n != 1) ? 1 : 0;
                case "hr": return (n % 10 == 1 && n % 100 != 11 ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "hu": return (n != 1) ? 1 : 0;
                case "ia": return (n != 1) ? 1 : 0;
                case "id": return 0;
                case "is": return (n % 10 != 1 || n % 100 == 11) ? 1 : 0;
                case "it": return (n != 1) ? 1 : 0;
                case "ja": return 0;
                case "jbo": return 0;
                case "jv": return (n != 0) ? 1 : 0;
                case "ka": return 0;
                case "kk": return 0;
                case "kl": return (n != 1) ? 1 : 0;
                case "km": return 0;
                case "kn": return (n != 1) ? 1 : 0;
                case "ko": return 0;
                case "ku": return (n != 1) ? 1 : 0;
                case "kw": return (n == 1) ? 0 : (n == 2) ? 1 : (n == 3) ? 2 : 3;
                case "ky": return 0;
                case "lb": return (n != 1) ? 1 : 0;
                case "ln": return (n > 1) ? 1 : 0;
                case "lo": return 0;
                case "lt": return (n % 10 == 1 && n % 100 != 11 ? 0 : n % 10 >= 2 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "lv": return (n % 10 == 1 && n % 100 != 11 ? 0 : n != 0 ? 1 : 2);
                case "mai": return (n != 1) ? 1 : 0;
                case "mfe": return (n > 1) ? 1 : 0;
                case "mg": return (n > 1) ? 1 : 0;
                case "mi": return (n > 1) ? 1 : 0;
                case "mk": return n == 1 || n % 10 == 1 ? 0 : 1; ///Can’t be correct needs a 2 somewhere
                case "ml": return (n != 1) ? 1 : 0;
                case "mn": return (n != 1) ? 1 : 0;
                case "mni": return (n != 1) ? 1 : 0;
                case "mnk": return (n == 0 ? 0 : n == 1 ? 1 : 2);
                case "mr": return (n != 1) ? 1 : 0;
                case "ms": return 0;
                case "mt": return (n == 1 ? 0 : n == 0 || (n % 100 > 1 && n % 100 < 11) ? 1 : (n % 100 > 10 && n % 100 < 20) ? 2 : 3);
                case "my": return 0;
                case "nah": return (n != 1) ? 1 : 0;
                case "nap": return (n != 1) ? 1 : 0;
                case "nb": return (n != 1) ? 1 : 0;
                case "ne": return (n != 1) ? 1 : 0;
                case "nl": return (n != 1) ? 1 : 0;
                case "se": return (n != 1) ? 1 : 0;
                case "nn": return (n != 1) ? 1 : 0;
                case "no": return (n != 1) ? 1 : 0;
                case "nso": return (n != 1) ? 1 : 0;
                case "oc": return (n > 1) ? 1 : 0;
                case "or": return (n != 1) ? 1 : 0;
                case "ps": return (n != 1) ? 1 : 0;
                case "pa": return (n != 1) ? 1 : 0;
                case "pap": return (n != 1) ? 1 : 0;
                case "pl": return (n == 1 ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "pms": return (n != 1) ? 1 : 0;
                case "pt": return (n != 1) ? 1 : 0;
                case "pt_BR": return (n > 1) ? 1 : 0;
                case "rm": return (n != 1) ? 1 : 0;
                case "ro": return (n == 1 ? 0 : (n == 0 || (n % 100 > 0 && n % 100 < 20)) ? 1 : 2);
                case "ru": return (n % 10 == 1 && n % 100 != 11 ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "rw": return (n != 1) ? 1 : 0;
                case "sah": return 0;
                case "sat": return (n != 1) ? 1 : 0;
                case "sco": return (n != 1) ? 1 : 0;
                case "sd": return (n != 1) ? 1 : 0;
                case "si": return (n != 1) ? 1 : 0;
                case "sk": return (n == 1) ? 0 : (n >= 2 && n <= 4) ? 1 : 2;
                case "sl": return (n % 100 == 1 ? 1 : n % 100 == 2 ? 2 : n % 100 == 3 || n % 100 == 4 ? 3 : 0);
                case "so": return (n != 1) ? 1 : 0;
                case "son": return (n != 1) ? 1 : 0;
                case "sq": return (n != 1) ? 1 : 0;
                case "sr": return (n % 10 == 1 && n % 100 != 11 ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "su": return 0;
                case "sw": return (n != 1) ? 1 : 0;
                case "sv": return (n != 1) ? 1 : 0;
                case "ta": return (n != 1) ? 1 : 0;
                case "te": return (n != 1) ? 1 : 0;
                case "tg": return (n > 1) ? 1 : 0;
                case "ti": return (n > 1) ? 1 : 0;
                case "th": return 0;
                case "tk": return (n != 1) ? 1 : 0;
                case "tr": return (n > 1) ? 1 : 0;
                case "tt": return 0;
                case "ug": return 0;
                case "uk": return (n % 10 == 1 && n % 100 != 11 ? 0 : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? 1 : 2);
                case "ur": return (n != 1) ? 1 : 0;
                case "uz": return (n > 1) ? 1 : 0;
                case "vi": return 0;
                case "wa": return (n > 1) ? 1 : 0;
                case "wo": return 0;
                case "yo": return (n != 1) ? 1 : 0;
                case "zh": return (n > 1) ? 1 : 0;

                default:
                    return 0;
            }
        }
    }
}
