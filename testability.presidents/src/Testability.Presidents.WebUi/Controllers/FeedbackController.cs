using Testability.Presidents.Api.Interfaces;
using Testability.Presidents.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testability.Presidents.WebUI.Controllers
{
    public class FeedbackController : Controller
    {
        private ILogger _Logger;
        private IFeatureManager _FeatureManager;

        public FeedbackController(ILogger logger, IFeatureManager featureManager)
        {
            if (logger == null)
                throw new ArgumentNullException("logger", "logger is null.");
            if (featureManager == null)
                throw new ArgumentNullException("featureManager", "featureManager is null.");

            _Logger = logger;
            _FeatureManager = featureManager;
        }

        public JsonResult SubmitFeedback(string id)
        {
            if (_FeatureManager.CustomerSatisfaction == true)
            {
                _Logger.LogCustomerSatisfaction(id);
            }

            return Json(true);
        }
    }
}