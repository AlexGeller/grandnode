﻿using System.Collections.Generic;
using Grand.Framework.Mvc.Models;

namespace Grand.Web.Models.Common
{
    public partial class LanguageSelectorModel : BaseGrandModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public string CurrentLanguageId { get; set; }

        public bool UseImages { get; set; }
    }
}