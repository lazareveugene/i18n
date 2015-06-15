using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using i18n.Domain.Concrete;
using i18n.Domain.Entities;
using i18n.Helpers;

namespace i18n.PostBuild
{
    public static class JSTranslation
    {
        public static String GenerateJSTranslation(i18nSettings settings, Translation trans)
        {
            var sb = new StringBuilder();
            var jsonItems = new List<String>();
            var nplurals = 1;
            int.TryParse(PluralsDictionary.Get(trans.LanguageInformation.LanguageShortTag).Split(';')[0].Split('=')[1],
                out nplurals);
            foreach (var item in trans.Items)
            {
                if (!String.IsNullOrEmpty(item.Value.MsgIdPlural))
                {
                    var count = 0;
                    var plurals = (item.Value.Messages ?? new[] { "" }).Select(
                        s => String.Format("{0}:\"{1}\"", count++, (s ?? "").Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n")));
                    jsonItems.Add(String.Format("\"{0}\":{{{1}}}", item.Key.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n"), String.Join(",", plurals)));
                }
                else
                {
                    jsonItems.Add(String.Format("\"{0}\":\"{1}\"", item.Key.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n"),
                        (item.Value.Messages ?? new[] { "" }).First().Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n")));
                }
            }
            sb.AppendFormat(
                @"/**
 * i18n: JavaScript function
 * Project: 
 * Release: Working copy
 * Locale: {0}, {1}
 */
// First, checks if it isn't implemented yet.
if (!String.prototype.format) {{
  String.prototype.format = function() {{
    var args = arguments;
    return this.replace(/{{(\d+)}}/g, function(match, number) {{ 
      return typeof args[number] != 'undefined'
        ? args[number]
        : match
      ;
    }});
  }};
}}
var _ = function( pairs ){{
    
    // calc numeric index of a plural form
    function pluralIndex( n ){{
        return Number( {2} );
    }}

    function lookup(msgid1, msgid2, n) {{
        var value = pairs[msgid1];
        // singular if no multiplier
        if (null == n) {{
            n = 1;
        }}
        // plurals stored as objects, e.g. {{ 0: '' }}
        if (value instanceof Object) {{
            value = value[pluralIndex(n) || 0];
        }}
        return value || (1 === n ? msgid1 : msgid2) || msgid1 || '';
    }}

    function format(str, args) {{
        return str.replace(/%(\d+)/g, function (match, number) {{
            return typeof args[number] != 'undefined' ? args[number] : match;
        }});
    }}

    function parse(str, p1, p2, p3, offset, s) {{

        // Extract msgid from 1nd capture group.
        var splitMsgId = p1.split('{4}');
        var MsgId = splitMsgId[0];
        var MsgIdPlural = splitMsgId.length > 1 ? splitMsgId[1] : '';
        // Extract format items from 2rd capture group.
        var formatItems = (''+p2).split('{5}');
        // Extract comment from 3th capture group.
        var Comment = p3;
        return format(lookup(MsgId, MsgIdPlural, Number(formatItems[0])), formatItems);
    }}

    // expose public _() function
    return function (nuggetStr) {{
        return nuggetStr.replace(/{3}/, parse);
    }}
}}( {{ {6} }} )",
                trans.LanguageInformation.LanguageShortTag,
                trans.LanguageInformation.LanguageInEnglish,
                PluralsDictionary.Get(trans.LanguageInformation.LanguageShortTag).Split(';')[1].Replace("plural=","").Trim(),
                string.Format(@"{0}(.+?)(?:{1}([^\|\|\|].{4}?))?(?:{2}(.+?))?{3}",
                    EscapeString(settings.NuggetBeginToken),
                    EscapeString(settings.NuggetDelimiterToken),
                    EscapeString(settings.NuggetCommentToken),
                    EscapeString(settings.NuggetEndToken),
                    "+"),
                    EscapeString(settings.NuggetPluralToken),
                    EscapeString(settings.NuggetDelimiterToken),
                String.Join(",", jsonItems));
            return sb.ToString();
        }

        /// <summary>
        /// Modifies a string such that each character is prefixed by another character
        /// (defaults to backslash).
        /// </summary>
        private static string EscapeString(string str, char escapeChar = '\\')
        {
            StringBuilder str1 = new StringBuilder(str.Length * 2);
            foreach (var c in str)
            {
                str1.Append(escapeChar);
                str1.Append(c);
            }
            return str1.ToString();
        }
    }
}
